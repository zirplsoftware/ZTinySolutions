using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Zirpl.MusicChecker;

namespace MusicCatalogger
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = new MyDataContext();
            //this.AlbumResults.Clear();
            //this.AlbumsListView.ItemsSource = this.AlbumResults;
        }

        public class MyDataContext
        {
            public MyDataContext()
            {
                this.AlbumResults = this.AlbumResults ?? new ObservableCollection<AlbumResult>();
            }
            public ObservableCollection<AlbumResult> AlbumResults { get; private set; }
        }

        public class AlbumResult : INotifyPropertyChanged
        {
            public AlbumResult()
            {
                this.SpotifyAlbums = new ObservableCollection<Zirpl.Spotify.MetadataApi.Album>();
            }

            private Album _album;

            public Album Album
            {
                get
                {
                    return _album;
                }
                set
                {
                    _album = value;
                    var propertyChanged = this.PropertyChanged;
                    if (propertyChanged != null)
                    {
                        propertyChanged(this, new PropertyChangedEventArgs("Album"));
                    }
                }
            }

            public ObservableCollection<Zirpl.Spotify.MetadataApi.Album> SpotifyAlbums { get; set; }

            public event PropertyChangedEventHandler PropertyChanged;
        }

        private void LoadMusicButton_Click(object sender, RoutedEventArgs e)
        {
            var startingPath = @"E:\temp\Music";
            var catalog = new MusicCatalog(startingPath);
            foreach (var album in catalog.Albums.OrderBy(o => o.Name))
            {
                if (catalog.Albums.Where(o => o.Name.ToLowerInvariant() == album.Name.ToLowerInvariant()).Count() == 1)
                {
                    var albumResult = new AlbumResult() { Album = album };
                    ((MyDataContext)this.DataContext).AlbumResults.Add(albumResult);

                    int i = 1;
                    foreach (var spotifyAlbum in new Zirpl.Spotify.MetadataApi.SpotifyMetadataApiClient().SearchAlbums(album.Name).Albums)
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
        }
        private void SpotifyLinkButton_Click(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
