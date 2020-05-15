using System;
using System.Collections.ObjectModel;
using MvvmDemo;

namespace MVVM.ViewModels
{
    public class PlaylistsViewModel
    {
        public ObservableCollection<Playlist> Playlists { get; private set; } = new ObservableCollection<Playlist>();
        public Playlist SelectedPlaylist { get; set; }

        public void AddPlaylist()
        {
            var newPlaylist = "Playlist " + (Playlists.Count + 1);

            Playlists.Add(new Playlist { Title = newPlaylist });
        }

        public void SelectPlaylist(Playlist playlist)
        {

            if (playlist == null)
                return;

            playlist.IsFavorite = !playlist.IsFavorite;

            SelectedPlaylist = null;

            //await Navigation.PushAsync (new PlaylistDetailPage(playlist));
        }
    }
}
