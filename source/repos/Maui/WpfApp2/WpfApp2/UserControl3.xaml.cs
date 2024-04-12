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
    /// UserControl3.xaml の相互作用ロジック
    /// </summary>
    public partial class UserControl3 : UserControl
    {
        public UserControl3()
        {
            InitializeComponent();

            //ListBox listBox=new ListBox();
            //listBox.Items.Add("a");
            //listBox.Items.Add("b");
            //Content = listBox;

            this.DataContext = new UserViewModel(new string[] { "item1", "item2" });//こちらが表示される

        }

    }

    public class UserViewModel
    {
        public UserViewModel(string[] strings)
        {
            Strings = strings;
        }
        public string S { get; set; } = "初期値";
        public string[] Strings { get; set; } = new string[] { "ss", "sss", "sss" };

        public List<Person> People { get; set; } 
            = new List<Person>{ 
                new Person("山田",true) ,
                new Person("田中",true) ,
                new Person("宮田",true) ,
            };

        //public Person[] People { get; set; }
        //    = new Person[]{
        //        new Person("山田",true) ,
        //        new Person("田中",true) ,
        //        new Person("宮田",true) ,
        //    };

    }

    public class Person
    {

        public Name Name1 { get; set; }
        public string Name { get; set; }
        public bool CanCode { get; set; }
        public Person(string name, bool canCode)
        {
            Name = name;
            CanCode = canCode;
        }

        public Person(Name name)
        {
            this.Name1 = name;
        }
    }

    public class MyView : ViewBase
    {
        public double Angle { get; set; }
        protected override void PrepareItem(ListViewItem item)
        {
            item.LayoutTransform = new RotateTransform();
            base.PrepareItem(item);
        }
    }
}
