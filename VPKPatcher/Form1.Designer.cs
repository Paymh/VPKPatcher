namespace VPKPatcher
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtGameDir = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Files = new System.Windows.Forms.Label();
            this.txtEdited = new System.Windows.Forms.TextBox();
            this.chkRecursive = new System.Windows.Forms.CheckBox();
            this.btnPatch = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblGameDirError = new System.Windows.Forms.Label();
            this.lblEditedError = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbGame = new System.Windows.Forms.ComboBox();
            this.lblGameError = new System.Windows.Forms.Label();
            this.chkTextures = new System.Windows.Forms.CheckBox();
            this.chkMisc = new System.Windows.Forms.CheckBox();
            this.chkSounds = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.pnlSetup = new System.Windows.Forms.Panel();
            this.pnlRunning = new System.Windows.Forms.Panel();
            this.btnPause = new System.Windows.Forms.Button();
            this.pnlSetup.SuspendLayout();
            this.pnlRunning.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtGameDir
            // 
            this.txtGameDir.Location = new System.Drawing.Point(113, 92);
            this.txtGameDir.Name = "txtGameDir";
            this.txtGameDir.Size = new System.Drawing.Size(389, 20);
            this.txtGameDir.TabIndex = 0;
            this.txtGameDir.Text = "C:\\Program Files (x86)\\Steam\\steamapps\\common\\Team Fortress 2\\tf\\";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "VPK Dir:";
            // 
            // Files
            // 
            this.Files.AutoSize = true;
            this.Files.Location = new System.Drawing.Point(15, 140);
            this.Files.Name = "Files";
            this.Files.Size = new System.Drawing.Size(59, 13);
            this.Files.TabIndex = 3;
            this.Files.Text = "Edited File:";
            // 
            // txtEdited
            // 
            this.txtEdited.Location = new System.Drawing.Point(113, 137);
            this.txtEdited.Name = "txtEdited";
            this.txtEdited.Size = new System.Drawing.Size(389, 20);
            this.txtEdited.TabIndex = 2;
            // 
            // chkRecursive
            // 
            this.chkRecursive.AutoSize = true;
            this.chkRecursive.Location = new System.Drawing.Point(428, 164);
            this.chkRecursive.Name = "chkRecursive";
            this.chkRecursive.Size = new System.Drawing.Size(74, 17);
            this.chkRecursive.TabIndex = 6;
            this.chkRecursive.Text = "Recursive";
            this.chkRecursive.UseVisualStyleBackColor = true;
            // 
            // btnPatch
            // 
            this.btnPatch.Location = new System.Drawing.Point(63, 199);
            this.btnPatch.Name = "btnPatch";
            this.btnPatch.Size = new System.Drawing.Size(75, 23);
            this.btnPatch.TabIndex = 7;
            this.btnPatch.Text = "Patch";
            this.btnPatch.UseVisualStyleBackColor = true;
            this.btnPatch.Click += new System.EventHandler(this.btnPatch_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(8, 9);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblGameDirError
            // 
            this.lblGameDirError.AutoSize = true;
            this.lblGameDirError.Location = new System.Drawing.Point(345, 115);
            this.lblGameDirError.Name = "lblGameDirError";
            this.lblGameDirError.Size = new System.Drawing.Size(35, 13);
            this.lblGameDirError.TabIndex = 9;
            this.lblGameDirError.Text = "label4";
            // 
            // lblEditedError
            // 
            this.lblEditedError.AutoSize = true;
            this.lblEditedError.Location = new System.Drawing.Point(345, 160);
            this.lblEditedError.Name = "lblEditedError";
            this.lblEditedError.Size = new System.Drawing.Size(35, 13);
            this.lblEditedError.TabIndex = 11;
            this.lblEditedError.Text = "label6";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Game:";
            // 
            // cmbGame
            // 
            this.cmbGame.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGame.FormattingEnabled = true;
            this.cmbGame.Items.AddRange(new object[] {
            "Team Fortress 2",
            "Counter-Strike: Source (Not Implemented)"});
            this.cmbGame.Location = new System.Drawing.Point(113, 18);
            this.cmbGame.Name = "cmbGame";
            this.cmbGame.Size = new System.Drawing.Size(389, 21);
            this.cmbGame.TabIndex = 17;
            // 
            // lblGameError
            // 
            this.lblGameError.AutoSize = true;
            this.lblGameError.Location = new System.Drawing.Point(345, 42);
            this.lblGameError.Name = "lblGameError";
            this.lblGameError.Size = new System.Drawing.Size(35, 13);
            this.lblGameError.TabIndex = 18;
            this.lblGameError.Text = "label4";
            // 
            // chkTextures
            // 
            this.chkTextures.AutoSize = true;
            this.chkTextures.Checked = true;
            this.chkTextures.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkTextures.Location = new System.Drawing.Point(115, 59);
            this.chkTextures.Name = "chkTextures";
            this.chkTextures.Size = new System.Drawing.Size(67, 17);
            this.chkTextures.TabIndex = 19;
            this.chkTextures.Text = "Textures";
            this.chkTextures.UseVisualStyleBackColor = true;
            // 
            // chkMisc
            // 
            this.chkMisc.AutoSize = true;
            this.chkMisc.Location = new System.Drawing.Point(256, 59);
            this.chkMisc.Name = "chkMisc";
            this.chkMisc.Size = new System.Drawing.Size(48, 17);
            this.chkMisc.TabIndex = 21;
            this.chkMisc.Text = "Misc";
            this.chkMisc.UseVisualStyleBackColor = true;
            // 
            // chkSounds
            // 
            this.chkSounds.AutoSize = true;
            this.chkSounds.Location = new System.Drawing.Point(188, 59);
            this.chkSounds.Name = "chkSounds";
            this.chkSounds.Size = new System.Drawing.Size(62, 17);
            this.chkSounds.TabIndex = 23;
            this.chkSounds.Text = "Sounds";
            this.chkSounds.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "VPKs to search:";
            // 
            // txtOutput
            // 
            this.txtOutput.Location = new System.Drawing.Point(12, 272);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ReadOnly = true;
            this.txtOutput.Size = new System.Drawing.Size(512, 251);
            this.txtOutput.TabIndex = 25;
            // 
            // pnlSetup
            // 
            this.pnlSetup.Controls.Add(this.label5);
            this.pnlSetup.Controls.Add(this.chkSounds);
            this.pnlSetup.Controls.Add(this.chkMisc);
            this.pnlSetup.Controls.Add(this.chkTextures);
            this.pnlSetup.Controls.Add(this.chkRecursive);
            this.pnlSetup.Controls.Add(this.lblGameError);
            this.pnlSetup.Controls.Add(this.cmbGame);
            this.pnlSetup.Controls.Add(this.label4);
            this.pnlSetup.Controls.Add(this.lblEditedError);
            this.pnlSetup.Controls.Add(this.lblGameDirError);
            this.pnlSetup.Controls.Add(this.Files);
            this.pnlSetup.Controls.Add(this.txtEdited);
            this.pnlSetup.Controls.Add(this.label1);
            this.pnlSetup.Controls.Add(this.txtGameDir);
            this.pnlSetup.Location = new System.Drawing.Point(12, 5);
            this.pnlSetup.Name = "pnlSetup";
            this.pnlSetup.Size = new System.Drawing.Size(512, 182);
            this.pnlSetup.TabIndex = 26;
            // 
            // pnlRunning
            // 
            this.pnlRunning.Controls.Add(this.btnPause);
            this.pnlRunning.Controls.Add(this.btnCancel);
            this.pnlRunning.Enabled = false;
            this.pnlRunning.Location = new System.Drawing.Point(144, 190);
            this.pnlRunning.Name = "pnlRunning";
            this.pnlRunning.Size = new System.Drawing.Size(193, 37);
            this.pnlRunning.TabIndex = 27;
            // 
            // btnPause
            // 
            this.btnPause.Location = new System.Drawing.Point(94, 9);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(75, 23);
            this.btnPause.TabIndex = 9;
            this.btnPause.Text = "Pause";
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 551);
            this.Controls.Add(this.pnlRunning);
            this.Controls.Add(this.btnPatch);
            this.Controls.Add(this.pnlSetup);
            this.Controls.Add(this.txtOutput);
            this.Name = "Form1";
            this.Text = "Main";
            this.pnlSetup.ResumeLayout(false);
            this.pnlSetup.PerformLayout();
            this.pnlRunning.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtGameDir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Files;
        private System.Windows.Forms.TextBox txtEdited;
        private System.Windows.Forms.CheckBox chkRecursive;
        private System.Windows.Forms.Button btnPatch;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblGameDirError;
        private System.Windows.Forms.Label lblEditedError;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbGame;
        private System.Windows.Forms.Label lblGameError;
        private System.Windows.Forms.CheckBox chkTextures;
        private System.Windows.Forms.CheckBox chkMisc;
        private System.Windows.Forms.CheckBox chkSounds;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.Panel pnlSetup;
        private System.Windows.Forms.Panel pnlRunning;
        private System.Windows.Forms.Button btnPause;
    }
}

