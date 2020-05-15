using MVVM.ViewModels;

namespace MvvmDemo
{
    public class Playlist : BaseViewModel 
    {
        public string Title { get; set; }
        public bool IsFavorite { get; set; }
    }
}
