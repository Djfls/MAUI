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

namespace WpfApp2
{
    /// <summary>
    /// UserControl2.xaml の相互作用ロジック
    /// </summary>
    public partial class UserControl2 : UserControl
    {
        public UserControl2()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ControlTemplate controlTemplate = new ControlTemplate(typeof(Button));
            controlTemplate.VisualTree=new FrameworkElementFactory(typeof(Ellipse));
            controlTemplate.VisualTree.SetValue(Ellipse.FillProperty, Brushes.Blue);
            controlTemplate.VisualTree.SetValue(Ellipse.WidthProperty,75.0);
            controlTemplate.VisualTree.SetValue(Ellipse.HeightProperty, 23.0);

            ((Button)sender).Template = controlTemplate;

        }
    }
}
