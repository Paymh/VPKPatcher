using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.Threading;

namespace VPKPatcher
{
    public partial class Form1 : Form
    {
        public bool IsPaused = false;
        public bool IsCancelled = false;

        public Form1()
        {
            InitializeComponent();
            lblEditedError.Text = "";
            lblGameDirError.Text = "";
            cmbGame.SelectedIndex = 0;
        }

        private bool checkPathErrors()
        {
            bool errors = false;
            if (txtEdited.Text == "" && !Directory.Exists(txtEdited.Text))
            {
                lblEditedError.Text = "Error: Please enter a valid path.";
                errors = true;
            }
            else
            {
                lblEditedError.Text = "";
            }
            if (txtGameDir.Text == "" && !Directory.Exists(txtGameDir.Text))
            {
                lblGameDirError.Text = "Error: Please enter a valid path.";
                errors = true;
            }
            else
            {
                lblGameDirError.Text = "";
            }
            return errors;
        }

        private void btnPatch_Click(object sender, EventArgs e)
        {
            if (!checkPathErrors()) //No errors start patching
            {
                if (cmbGame.Text == "Team Fortress 2")
                {
                    if (chkTextures.Checked)
                    {
                        PatchFiles("tf2_textures_");
                    } else if(chkMisc.Checked)
                    {
                        PatchFiles("tf2_misc_");
                    }
                }
            }
        }

        private void PatchFiles(String vpkPrefix)
        {
            (new Thread(() => {
                TogglePanels();
                DateTime start = DateTime.Now;
                Output(txtGameDir.Text + vpkPrefix + "dir.vpk");
                List<Asset> assets = GetEncapsulatedAssets(txtGameDir.Text + vpkPrefix + "dir.vpk", vpkPrefix, ".vpk");
                String[] files = Directory.GetFiles(txtEdited.Text, "*.*", SearchOption.AllDirectories);

                Parallel.ForEach(files, (file, state) =>
                {
                    if (IsCancelled)
                    {
                        Output("Cancelled task.");
                        state.Stop();
                    }
                    while (IsPaused)
                    {
                        Thread.Sleep(1000);
                    }
                    Asset asset = null;
                    String fileName = (GetDirName(file) + Path.GetFileName(file)).Replace("\\", "/");
                    Output("Attempting to patch file: " + GetDirName(file) + Path.GetFileName(file));
                    if ((asset = assets.Find(f => f.name == fileName)) != null)
                    { //File exists in vpk
                        byte[] editedBytes = this.getBytes(file); //Read edited file into memory
                        if (editedBytes.Length > asset.size)
                        {
                            Output("Edited file must be smaller than Original file to prevent data corruption. Skipping!");
                            return;
                        }
                        if (editedBytes.Length < asset.size)
                        {
                            Array.Resize<byte>(ref editedBytes, asset.size); //Fill edited fill with 00 bytes to match original file size
                        }
                        Output("Patched file to: " + asset.vpk);
                        ReplaceData(txtGameDir.Text + asset.vpk, asset.offset, editedBytes);
                    }
                    else
                    {
                        Output("File does not exist in VPK!");
                    }
                });
                TimeSpan timeTaken = DateTime.Now.Subtract(start);
                Output("Time taken: " + timeTaken.ToString());
                //We've finished or cancelled
                IsPaused = false;
                IsCancelled = false;
                TogglePanels();
            })).Start();
        }
        private void TogglePanels()
        {
            this.Invoke(new Action(() => 
            {
                pnlSetup.Enabled = !pnlSetup.Enabled;
                pnlRunning.Enabled = !pnlRunning.Enabled;
                btnPatch.Enabled = !btnPatch.Enabled;
            }));
        }
        private string GetDirName(string path)
        {
            return path.Replace(this.txtEdited.Text, "").Replace(Path.GetFileName(path), "");
        }

        public byte[] getBytes(string path)
        {
            return File.ReadAllBytes(path);
        }

        public static void ReplaceData(string filename, long position, byte[] data)
        {
            int numTries = 0;
            while(true)
            {
                try
                {
                    using (Stream stream = (Stream)File.Open(filename, FileMode.Open))
                    {
                        stream.Position = position;
                        stream.Write(data, 0, data.Length);
                        return;
                    }
                } catch(Exception)
                {
                    if(numTries > 10)
                    {
                        return;
                    }
                    numTries++;
                } 
            }
           
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            IsCancelled = true;
            IsPaused = false;
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            if(IsPaused)
            {
                IsPaused = false;
                btnPause.Text = "Pause";
            } else
            {
                IsPaused = true;
                btnPause.Text = "Unpause";
            }
        }

        private void Output(String line)
        {
            txtOutput.Invoke(new Action(() => txtOutput.AppendText(DateTime.Now.ToString() + " - " + line + "\n")));
        }

        public static List<Asset> GetEncapsulatedAssets(String path, String VPKprefix, String VPKsuffix)
        {
            List<Asset> assets = new List<Asset>();
            // Start the child process.
            Process p = new Process();
            // Redirect the output stream of the child process.
            p.StartInfo.UseShellExecute = false;
            p.StartInfo.RedirectStandardOutput = true;
            p.StartInfo.FileName = @"C:\Program Files (x86)\Steam\steamapps\common\Team Fortress 2\bin\vpk.exe"; //Hardcoded for now can fix later
            p.StartInfo.Arguments = "L \"" + path + "\"";
            p.StartInfo.CreateNoWindow = true;
            p.Start();
            // Do not wait for the child process to exit before
            // reading to the end of its redirected stream.
            // p.WaitForExit();
            // Read the output stream first and then wait.
            string output = p.StandardOutput.ReadToEnd();
            p.WaitForExit();
            StringReader reader = new StringReader(output);
            while (reader.Peek() > -1)
            {
                try
                {
                    String line = reader.ReadLine().Replace("crc=", "").Replace("metadatasz=", "").Replace("fnumber=", "").Replace("ofs=", "").Replace("sz=", "");
                    String[] lineData = line.Split(' ');

                    int vpk = Int32.Parse(lineData[3]);
                    String vpkName;
                    if (vpk < 10)
                    {
                        vpkName = "00" + vpk;
                    }
                    else if (vpk < 100)
                    {
                        vpkName = "0" + vpk;
                    }
                    else
                    {
                        vpkName = vpk.ToString();
                    }

                    Asset ass = new Asset(lineData[0], Convert.ToInt32(lineData[4], 16), Int32.Parse(lineData[5]),VPKprefix + vpkName + VPKsuffix);
                    assets.Add(ass);
                } catch(Exception)
                {
                    //One one recorded case where this will happen is when a filename has a space in it..valves mistake on latest update
                    continue;
                }
               
            }
            return assets;
        }
    }
}
