using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPKPatcher
{
    public class Asset
    {
        public int offset;
        public int size;
        public String vpk;
        public String name;

        public Asset(String _name, int _offset, int _size, String _vpk)
        {
            name = _name;
            offset = _offset;
            size = _size;
            vpk = _vpk;
        }
    }
}
