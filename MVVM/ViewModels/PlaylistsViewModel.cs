using System;
using System.Collections.ObjectModel;
using MVVM.Views;
using MvvmDemo;

namespace MVVM.ViewModels
{
    public class PlaylistsViewModel : BaseViewModel
    {
        public ObservableCollection<PlaylistViewModel> Playlists { get; private set; } = new ObservableCollection<PlaylistViewModel>();

        private PlaylistViewModel _selectedPlaylist;

        private readonly IPageService _pageService;

        public PlaylistsViewModel(IPageService pageService)
        {
            this._pageService = pageService;
        }
        public PlaylistViewModel SelectedPlaylist
        {
            get { return _selectedPlaylist; }
            set { SetValue(ref _selectedPlaylist, value); }
        }

        public void AddPlaylist()
        {
            var newPlaylist = "Playlist " + (Playlists.Count + 1);

            Playlists.Add(new PlaylistViewModel { Title = newPlaylist });
        }

        public async void SelectPlaylist(PlaylistViewModel playlist)
        {

            if (playlist == null)
                return;

            playlist.IsFavorite = !playlist.IsFavorite;

            SelectedPlaylist = null;

            await _pageService.PushAsync (new PlaylistDetailPage(playlist));
        }
    }
}
