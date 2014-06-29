using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Id3;

namespace Zirpl.MusicChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            var startingPath = @"E:\temp\Music";
            var catalog = new MusicCatalog(startingPath);

            //Console.WriteLine();
            //Console.WriteLine("Artists:");
            //foreach (var artist in catalog.Artists.OrderBy(o => o.Name))
            //{
            //    Console.WriteLine(artist.Name);
            //}
            //Console.WriteLine();
            //Console.WriteLine("Albums:");
            //foreach (var album in catalog.Albums.OrderBy(o => o.Name))
            //{
            //    if (catalog.Albums.Where(o => o.Name.ToLowerInvariant() == album.Name.ToLowerInvariant()).Count() == 1)
            //    {
            //        Console.WriteLine("{0} by {1}", album.Name, album.Artist.Name);
            //    }
            //}
            //Console.WriteLine();
            //Console.WriteLine("Tracks:");
            //foreach (var track in catalog.Tracks.OrderBy(o => o.Name))
            //{
            //    Console.WriteLine(track.Name);
            //}


            //Console.WriteLine();
            //Console.WriteLine("Spotify Results:");
            foreach (var album in catalog.Albums.OrderBy(o => o.Name))
            {
                if (catalog.Albums.Where(o => o.Name.ToLowerInvariant() == album.Name.ToLowerInvariant()).Count() == 1)
                {
                    Console.WriteLine();
                    Console.WriteLine("Looking up: \"{0}\" by \"{1}\"", album.Name, album.Artist.Name);

                    Console.WriteLine("Spotify album search results:");

                    int i = 1;
                    foreach (var spotifyAlbum in new Spotify.MetadataApi.SpotifyMetadataApiClient().SearchAlbums(album.Name).Albums)
                    {
                        if (spotifyAlbum.Name.ToLowerInvariant() == album.Name.ToLowerInvariant()
                            && spotifyAlbum.Artists.First().Name.ToLowerInvariant() == album.Artist.Name.ToLowerInvariant())
                        {
                            Console.WriteLine(spotifyAlbum.Href);
                            //Console.WriteLine("{0}: \"{1}\" by \"{2}\"", i, spotifyAlbum.Name, spotifyAlbum.Artist.Name);
                        }
                        i++;
                    }
                    Thread.Sleep(1000);
                }
            }



            Console.ReadKey();
        }

        
    }
}
