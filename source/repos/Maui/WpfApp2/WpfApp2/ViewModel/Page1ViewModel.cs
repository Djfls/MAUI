using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using System.Windows.Navigation;

namespace WpfApp2.ViewModel
{
    internal class Page1ViewModel
    {
        public ICommand NavigateNextCommand { get; protected set; }

        public Page1ViewModel()
        {
            this.NavigateNextCommand = new RelayCommand( this.NavigateNext) ;
        }

        Action<object> NavigateNext = o => {
            var navigationWindow = (NavigationWindow)Application.Current.MainWindow;
            var uri = new Uri("Page2.xaml",UriKind.Relative);
            navigationWindow.Navigate(uri, o);
        };

        protected void NavigateNext_(object o) {
            var navigationWindow = (NavigationWindow)Application.Current.MainWindow;
            navigationWindow.Navigate(new Page2(),o);        
        }

    }
}
