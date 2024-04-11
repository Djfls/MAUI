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
using System.Xml;

namespace WpfApp2
{
    /// <summary>
    /// UserControl5.xaml の相互作用ロジック
    /// </summary>
    public partial class UserControl5 : UserControl
    {
        public UserControl5()
        {
            InitializeComponent();

            //XmlDocument doc = new XmlDocument();
            //doc.LoadXml(
            //    @"
            //    <Media xmlns="""">
            //        <Book Author=""山田"" Title=""愛は天国""/>
            //        <Book Author=""佐藤"" Title=""愛は地獄""/>
            //        <Book Author=""鈴木"" Title=""愛は生きる糧""/>
            //        <CD Artist=""山田"" Title=""愛子は歌う""/>
            //        <DVD Director=""山田"" Title=""愛という名の映画"">
            //            <Actor>佐藤</Actor>
            //            <Actor>鈴木</Actor>
            //        </DVD>
            //    </Media>"
            //    );

            //FrameworkElementFactory frameworkElementFactory = new FrameworkElementFactory(typeof(TextBlock));
            //Binding bind = new Binding();
            //bind.XPath = "@Title";
            //frameworkElementFactory.SetBinding(TextBlock.TextProperty, bind);

            //DataTemplate template = new DataTemplate();
            //template.DataType = typeof(XmlElement);
            //template.VisualTree = frameworkElementFactory;

            //XmlDataProvider xmlDataProvider = new XmlDataProvider();
            //xmlDataProvider.Document = doc;
            //bind = new Binding();
            //bind.Source = doc;
            //bind.XPath = "\\Media\\Book";
            //ListBox listBox = new ListBox();
            //listBox.ItemTemplate = template;
            //listBox.SetBinding(ListBox.ItemsSourceProperty, bind);
            //Content = listBox;

            //DataContext = xmlDataProvider;

        }
    }
}
