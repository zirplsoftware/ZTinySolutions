using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Results;
using System.Web.Mvc;
using Zirpl.MusicChecker.Web.Models;

namespace Zirpl.MusicChecker.Web.Controllers
{
    public class SpotifyMusicApiController : ApiController
    {
        public JsonResult<List<Zirpl.Spotify.MetadataApi.Artist>>  ArtistSearch(String artist)
        {
            var artists = new Zirpl.Spotify.MetadataApi.SpotifyMetadataApiClient().SearchArtists(artist).Artists;
            return this.Json(artists);
        }
        public JsonResult<List<Zirpl.Spotify.MetadataApi.Album>> AlbumSearch(String album)
        {
            var albums = new Zirpl.Spotify.MetadataApi.SpotifyMetadataApiClient().SearchAlbums(album).Albums;
            return this.Json(albums);
        }
    }
}
