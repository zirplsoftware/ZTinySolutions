using System;
using System.Collections.Generic;

namespace Zirpl.MusicChecker.Web.Models
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
