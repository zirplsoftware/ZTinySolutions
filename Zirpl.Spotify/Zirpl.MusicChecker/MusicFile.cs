using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zirpl.MusicChecker
{
    public class MusicFile
    {
        public FileInfo FileInfo { get; set; }
        public Artist Artist { get; set; }
        public Album Album { get; set; }
        public Track Track { get; set; }
    }
}
