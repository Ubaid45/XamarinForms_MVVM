using System.Collections.ObjectModel;
using MVVM.ViewModels;
using Xamarin.Forms;

namespace MvvmDemo
{
    public partial class PlaylistsPage : ContentPage
    {
        private ObservableCollection<Playlist> _playlists = new ObservableCollection<Playlist> ();

        public PlaylistsPage ()
        {
            BindingContext = new PlaylistsViewModel();

            InitializeComponent ();
        }

        protected override void OnAppearing ()
        {
            base.OnAppearing ();
        }

        void OnAddPlaylist (object sender, System.EventArgs e)
        {
            (BindingContext as PlaylistsViewModel).AddPlaylist();
        }

        void OnPlaylistSelected (object sender, Xamarin.Forms.SelectedItemChangedEventArgs e)
        {
            (BindingContext as PlaylistsViewModel).SelectPlaylist(e.SelectedItem as Playlist);
        }
    }
}
