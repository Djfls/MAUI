using System;
using System.Collections.Generic;
using System.Globalization;
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
using System.Xml;
using static WpfApp2.UserControl4;

namespace WpfApp2
{
    /// <summary>
    /// UserControl4.xaml の相互作用ロジック
    /// </summary>
    public partial class UserControl4 : UserControl
    {
        public UserControl4()
        {
            Brush brush = new SolidColorBrush(Colors.YellowGreen);
            InitializeComponent();
            b.Background = brush;

            Binding binding = new Binding();
            binding.Source = t1;
            binding.Path = new PropertyPath("Text");
            cc1.SetBinding(ContentControl.ContentProperty, binding);
            DataContext = new User4ViewModel();
        }

        private void b3_Click(object sender, RoutedEventArgs e)
        {
            Brush brush = new SolidColorBrush(Colors.Blue);
            this.Resources["brush"] = brush;
            b.SetResourceReference(Button.BackgroundProperty, "brush");

            //this.FindResource("brush") = brush;
        }
    }

    public class User4ViewModel 
    {
        public Human MyHuman { get; set; } = new Human { Name ="Tanaka"};
    }

    public class Human
    {
        public string Name { get; set; }
    }

    public class HumanConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return ((Human)value).Name;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            Human h = new Human();
            h.Name = value.ToString();
            return h;
        }
    }

}
