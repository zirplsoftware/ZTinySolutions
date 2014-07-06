using System;

namespace Zirpl.MusicChecker.Web.Models
{
    public class Track
    {
        public String Name { get; set; }
        public Album Album { get; set; }
        public Artist Artist { get; set; }
    }
}
