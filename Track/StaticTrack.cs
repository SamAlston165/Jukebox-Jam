using Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Track
{
    public class StaticTrack : ITrack
    {
        private string path;

        public string Artist => "";
        public string Title => "";
        public string Album => "";
        public string Genre => "";
        public string Year => "";

        public StaticTrack(string path)
        {
            this.path = path;
        }

        public override string ToString()
        {
            return path;
        }

        public string GetPath()
        {
            return path;
        }
    }
}
