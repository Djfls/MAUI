using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Xml.Linq;

namespace WpfApp2
{
    /// <summary>
    /// Page2.xaml の相互作用ロジック
    /// </summary>
    public partial class Page2 : Page
    {
        private string text;

        public Page2()
        {
            InitializeComponent();
        }

        public Page2(string text)
        {
           Name = text;
        }
        NavigationService _navigationService;

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            //グローバル変数渡し
            //_name.Content = Application.Current.Properties["_name"];

            _name.Content = Name ?? "";

           _navigationService = this.NavigationService;
            _navigationService.Navigated += _navigationService_Navigated; ;

        }

        private void _navigationService_Navigated(object sender, NavigationEventArgs e)
        {
            _navigationService.Navigated -= _navigationService_Navigated;
            _navigationService.RemoveBackEntry();
        }

        public string Name { private get; set; }
    }
}
