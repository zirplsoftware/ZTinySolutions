using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zirpl.MusicChecker
{
    public class Album
    {
        public Album()
        {
            this.Tracks = new List<Track>();
        }
        public String Name { get; set; }
        public Artist Artist { get; set; }
        public List<Track> Tracks { get; set; }
    }
}
