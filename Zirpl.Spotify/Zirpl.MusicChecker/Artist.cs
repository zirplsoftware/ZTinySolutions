using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zirpl.MusicChecker
{
    public class Artist
    {
        public Artist()
        {
            this.Albums = new List<Album>();
            this.Tracks = new List<Track>();
        }

        public String Name { get; set; }
        public List<Album> Albums { get; set; }
        public List<Track> Tracks { get; set; } 
    }
}
