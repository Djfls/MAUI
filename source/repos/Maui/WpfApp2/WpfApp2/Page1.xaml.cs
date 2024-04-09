using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
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

namespace WpfApp2
{
    /// <summary>
    /// Page1.xaml の相互作用ロジック
    /// </summary>
    public partial class Page1 : Page
    {
        public Page1()
        {
            InitializeComponent();
            ////TextBlock textBlock = new TextBlock();
            //Hyperlink link = new Hyperlink();
            //link.Click += Link_Click;
            //link.Inlines.Add("クリックしてページ2に移動");
            //_nameBox2.Inlines.Add(link);
            ////Content = textBlock;
            //WindowTitle = "ページ1";
        }
        
        //次のモデルに引数渡しする
        private void Link_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Page2(_nameBox.Text), UriKind.RelativeOrAbsolute);
        }

        public Page1(string s)
        {
            InitializeComponent();
            sample.Text = s;
        }

        //グローバル変数渡し
        private void Hyperlink_RequestNavigate(object sender, RequestNavigateEventArgs e)
        {
            Application.Current.Properties["_name"] = _nameBox.Text;
        }

        NavigationService _navigationService;

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            _navigationService = this.NavigationService;
            _navigationService.Navigating += _navigationService_Navigating ;
            _navigationService.Navigated += _navigationService_Navigated;
        }

        private void _navigationService_Navigated(object sender, NavigationEventArgs e)
        {
            _navigationService.Navigating -= _navigationService_Navigating;
            _navigationService.Navigated -= _navigationService_Navigated;
        }

        private void _navigationService_Navigating(object sender, NavigatingCancelEventArgs e)
        {
            if (_nameBox.Text.Length==0) 
            {
                e.Cancel = true;
            }
        }
    }
}
