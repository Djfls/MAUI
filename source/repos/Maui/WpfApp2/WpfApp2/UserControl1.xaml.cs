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
    /// UserControl1.xaml の相互作用ロジック
    /// </summary>
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
            Button b = new Button();
            b.Content = "Hello";

            StackPanel stackPanel = new StackPanel();
            ContentPresenter contentPresenter= new ContentPresenter();
            contentPresenter.Content = 5;
            contentPresenter.Content = DateTime.Now;
            contentPresenter.Content = b;
            stackPanel.Children.Add(contentPresenter);

            ListBox listBox = new ListBox();
            listBox.Items.Add("Hello1");
            listBox.Items.Add("Hello2");
            listBox.Items.Add("Hello3");
            stackPanel.Children.Add(listBox);

            Content = stackPanel;


        }


    }
}
