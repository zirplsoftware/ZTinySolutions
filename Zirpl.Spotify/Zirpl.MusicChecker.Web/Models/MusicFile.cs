using System.IO;

namespace Zirpl.MusicChecker.Web.Models
{
    public class MusicFile
    {
        public FileInfo FileInfo { get; set; }
        public Artist Artist { get; set; }
        public Album Album { get; set; }
        public Track Track { get; set; }
    }
}
