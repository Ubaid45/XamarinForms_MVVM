using System;
using System.Collections.Generic;
using MVVM.ViewModels;
using MvvmDemo;
using Xamarin.Forms;

namespace MVVM.Views
{
    public partial class PlaylistDetailPage : ContentPage
    {
        private PlaylistViewModel _playlist;

        public PlaylistDetailPage(PlaylistViewModel playlist)
        {
            _playlist = playlist;

            InitializeComponent();

            title.Text = _playlist.Title;
        }
    }
}
