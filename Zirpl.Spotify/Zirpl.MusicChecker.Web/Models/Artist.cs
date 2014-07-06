using System;
using System.Collections.Generic;

namespace Zirpl.MusicChecker.Web.Models
{
    public class Artist
    {
        public Artist()
        {
            this.Albums = new List<Album>();
            this.Tracks = new List<Track>();
            //this.SpotifyArtists = new List<Spotify.MetadataApi.Artist>();
        }

        public String Name { get; set; }
        public List<Album> Albums { get; set; }
        public List<Track> Tracks { get; set; }
        //public List<Zirpl.Spotify.MetadataApi.Artist> SpotifyArtists { get; private set; } 
    }
}
