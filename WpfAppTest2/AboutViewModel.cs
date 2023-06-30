using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WpfAppTest2
{
    public class AboutViewModel:BaseViewModel
    {
        public ICommand AboutOption1View { get; set; }
        public ICommand AboutOption2View { get; set; }
        public ICommand AboutOption3View { get; set; }

        private MainWindowViewModel mainWindowViewModel1 { get; set; }
        public AboutViewModel(MainWindowViewModel mainWindowViewModel)
        {
            mainWindowViewModel1 = mainWindowViewModel;
            AboutOption1View = new RelayCommand(mainWindowViewModel1.AboutOption1ViewClick);
            AboutOption2View = new RelayCommand(mainWindowViewModel1.AboutOption2ViewClick);
            AboutOption3View = new RelayCommand(mainWindowViewModel1.AboutOption3ViewClick);
        }
    }
}
