using System;
using System.Collections.Generic;
using MvvmDemo;
using Xamarin.Forms;

namespace MVVM.Views
{
    public partial class PlaylistDetailPage : ContentPage
    {
        private Playlist _playlist;

        public PlaylistDetailPage(Playlist playlist)
        {
            _playlist = playlist;

            InitializeComponent();

            title.Text = _playlist.Title;
        }
    }
}
