using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using Id3;

namespace Zirpl.MusicChecker.Web.Models
{
    public class MusicCatalog
    {
        private static MusicCatalog instance = new Models.MusicCatalog(@"E:\temp\Music");

        public static MusicCatalog Instance
        {
            get { return instance; }
        }
        private MusicCatalog(String path)
        {
            this.StartingPath = path;
            this.Files = new List<MusicFile>();
            this.Albums = new List<Album>();
            this.Artists = new List<Artist>();
            this.Tracks = new List<Track>();
            this.ExtensionsEncountered = new List<string>();
            this.LoadMusic(this.StartingPath);
        }
        public String StartingPath { get; private set; }
        public List<MusicFile> Files { get; private set; }
        public List<Artist> Artists { get; private set; }
        public List<Album> Albums { get; private set; }
        public List<Track> Tracks { get; private set; }
        public List<String> ExtensionsEncountered { get; private set; }

        private void LoadMusic(String path)
        {
            foreach (var innerPath in Directory.EnumerateFileSystemEntries(path))
            {
                var isDirectory = (File.GetAttributes(innerPath) & FileAttributes.Directory) == FileAttributes.Directory;
                if (isDirectory)
                {
                    LoadMusic(innerPath);
                }
                else if (Path.GetExtension(innerPath).ToLowerInvariant() == ".mp3")
                {
                    using (var mp3 = new Mp3File(innerPath))
                    {
                        var fileInfo = new FileInfo(innerPath);
                        //var albumName = Directory.GetParent(innerPath).Name;
                        //var artistName = Directory.GetParent(Directory.GetParent(innerPath).FullName).Name;
                        //var trackName = fileInfo.Name;

                        var tag = mp3.GetTag(Id3TagFamily.FileStartTag);
                        var albumName = tag.Album.Value.Trim();
                        albumName = String.IsNullOrWhiteSpace(albumName) ? "[NO ALBUM]" : albumName;
                        var artistName = tag.Artists.Value.Trim();
                        artistName = String.IsNullOrWhiteSpace(artistName) ? "[NO ARTIST]" : artistName;
                        var trackName = tag.Title.Value.Trim();
                        trackName = String.IsNullOrWhiteSpace(trackName) ? "[NO TRACK]" : trackName;
                        //tag = mp3.GetTag(2, 2);
                        Console.WriteLine(tag.ToString());

                        var artist = (from o in this.Artists
                                      where o.Name.ToLowerInvariant() == artistName.ToLowerInvariant()
                                      select o).SingleOrDefault();
                        if (artist == null)
                        {
                            artist = new Artist() { Name = artistName };
                            this.Artists.Add(artist);
                            //var spotifyArtists = new Zirpl.Spotify.MetadataApi.SpotifyMetadataApiClient().SearchArtists(artistName);
                            //artist.SpotifyArtists.AddRange(spotifyArtists.Artists);
                        }
                        var album = (from o in artist.Albums
                                     where o.Name.ToLowerInvariant() == albumName.ToLowerInvariant()
                                     select o).SingleOrDefault();
                        if (album == null)
                        {
                            album = new Album() { Artist = artist, Name = albumName };
                            artist.Albums.Add(album);
                            this.Albums.Add(album);
                        }
                        var track = (from o in album.Tracks
                                     where o.Name.ToLowerInvariant() == trackName.ToLowerInvariant()
                                     select o).SingleOrDefault();
                        if (track == null)
                        {
                            track = new Track() { Album = album, Artist = artist, Name = trackName };
                            album.Tracks.Add(track);
                            artist.Tracks.Add(track);
                            this.Tracks.Add(track);
                        }
                        this.Files.Add(new MusicFile()
                        {
                            Album = album,
                            Artist = artist,
                            FileInfo = fileInfo,
                            Track = track
                        });
                    }
                }
                else
                {
                    if (!ExtensionsEncountered.Contains(Path.GetExtension(innerPath).ToLowerInvariant()))
                    {
                        ExtensionsEncountered.Add(Path.GetExtension(innerPath).ToLowerInvariant());
                    }
                }
                Console.WriteLine(innerPath);
            }
        }
    }
}
