using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using MVVM.ViewModels;
using Xamarin.Forms;

namespace MvvmDemo
{
    public class Playlist : BaseViewModel 
    {
        public string Title { get; set; }

        private bool _isFavorite; 
        public bool IsFavorite 
        {
            get { return _isFavorite; }
            set 
            {
                SetValue(ref _isFavorite, value);

                OnPropertyChanged (nameof(Color));
            }
        }

        public Color Color 
        {
            get { return IsFavorite ? Color.Pink : Color.Black; }
        }

        
    }
}
