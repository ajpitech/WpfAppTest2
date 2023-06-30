using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WpfAppTest2
{
    public class HomeViewModel:BaseViewModel
    {
        public ICommand HomeOption1View { get; set; }
        public ICommand HomeOption2View { get; set; }
        public ICommand HomeOption3View { get; set; }
        
        private MainWindowViewModel mainWindowViewModel1 { get; set; }
        public HomeViewModel(MainWindowViewModel mainWindowViewModel)
        {
            mainWindowViewModel1 = mainWindowViewModel;
            HomeOption1View = new RelayCommand(mainWindowViewModel1.HomeOption1ViewClick); 
            HomeOption2View = new RelayCommand(mainWindowViewModel1.HomeOption2ViewClick); 
            HomeOption3View = new RelayCommand(mainWindowViewModel1.HomeOption3ViewClick); 
        }

        
    }
}
