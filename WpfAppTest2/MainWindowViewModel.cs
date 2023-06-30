using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WpfAppTest2
{
    public class MainWindowViewModel:BaseViewModel
    {
        public ICommand HomeCommand { get; set; }
        public ICommand AboutCommand { get; set; }
        public ICommand GalleryCommand { get; set; }
        public BaseViewModel ActiveView { get; set; }
     
        public MainWindowViewModel()
        {
            HomeCommand = new RelayCommand(HomeCommandClick);
            AboutCommand = new RelayCommand(AboutCommandClick);
            GalleryCommand = new RelayCommand(GalleryCommandClick);
        }

        private void GalleryCommandClick(object obj)
        {
            ActiveView = new GalleryViewModel(this);
            OnPropertyChanged(nameof(ActiveView));
            ActiveViewChild = null;
            OnPropertyChanged(nameof(ActiveViewChild));
        }

        private void AboutCommandClick(object obj)
        {
            ActiveView = new AboutViewModel(this);
            OnPropertyChanged(nameof(ActiveView));
            ActiveViewChild = null;
            OnPropertyChanged(nameof(ActiveViewChild));
        }

        private void HomeCommandClick(object obj)
        {
            ActiveView = new HomeViewModel(this);
            OnPropertyChanged(nameof(ActiveView));
            ActiveViewChild = null;
            OnPropertyChanged(nameof(ActiveViewChild));

        }
        public void HomeOption1ViewClick(object obj)
        {
            ActiveViewChild = new HomeOption1ViewModel();
            OnPropertyChanged(nameof(ActiveViewChild));
        }
        public void HomeOption2ViewClick(object obj)
        {
            ActiveViewChild = new HomeOption2ViewModel();
            OnPropertyChanged(nameof(ActiveViewChild));
        }
        public void HomeOption3ViewClick(object obj)
        {
            ActiveViewChild = new HomeOption3ViewModel();
            OnPropertyChanged(nameof(ActiveViewChild));
        }

        internal void AboutOption1ViewClick(object obj)
        {
            ActiveViewChild = new AboutOption1ViewModel();
            OnPropertyChanged(nameof(ActiveViewChild));
        }

        internal void AboutOption2ViewClick(object obj)
        {
            ActiveViewChild = new AboutOption2ViewModel();
            OnPropertyChanged(nameof(ActiveViewChild));
        }

        internal void AboutOption3ViewClick(object obj)
        {
            ActiveViewChild = new AboutOption3ViewModel();
            OnPropertyChanged(nameof(ActiveViewChild));
        }

        internal void GalleryOption2ViewClick(object obj)
        {
            ActiveViewChild = new GalleryOption2ViewModel();
            OnPropertyChanged(nameof(ActiveViewChild));
        }

        internal void GalleryOption1ViewClick(object obj)
        {
            ActiveViewChild = new GalleryOption1ViewModel();
            OnPropertyChanged(nameof(ActiveViewChild));
        }

        internal void GalleryOption3ViewClick(object obj)
        {
            ActiveViewChild = new GalleryOption3ViewModel();
            OnPropertyChanged(nameof(ActiveViewChild));
        }
    }

    internal class AboutOption2ViewModel : BaseViewModel
    {
    }
}
