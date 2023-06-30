using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WpfAppTest2
{
    public class GalleryViewModel:BaseViewModel
    {
        public ICommand GalleryOption1View { get; set; }
        public ICommand GalleryOption2View { get; set; }
        public ICommand GalleryOption3View { get; set; }
        private MainWindowViewModel mainWindowViewModel1 { get; set; }
        public GalleryViewModel(MainWindowViewModel mainWindowViewModel)
        {
            mainWindowViewModel1 = mainWindowViewModel;
            GalleryOption1View = new RelayCommand(mainWindowViewModel1.GalleryOption1ViewClick);
            GalleryOption2View = new RelayCommand(mainWindowViewModel1.GalleryOption2ViewClick);
            GalleryOption3View = new RelayCommand(mainWindowViewModel1.GalleryOption3ViewClick);
        }
    }
}
