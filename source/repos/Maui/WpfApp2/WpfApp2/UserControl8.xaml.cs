using System;
using System.Collections.Generic;
using System.ComponentModel;
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
    /// UserControl8.xaml の相互作用ロジック
    /// </summary>
    public partial class UserControl8 : UserControl
    {
        public Person[] people { get; set; } = new Person[] {
            new Person(new Name("Chris","Anderson")),
            new Person(new Name("Don","Box")),
            new Person(new Name("Chris","Sells")),
            };

        public UserControl8()
        {
            InitializeComponent();

            StackPanel stackPanel =new StackPanel();

            //Person[] people = new Person[] {
            //new Person(new Name("Chris","Anderson")),
            //new Person(new Name("Don","Box")),
            //new Person(new Name("Chris","Sells")),
            //};

            ListBox listBox=new ListBox();
            listBox.IsSynchronizedWithCurrentItem = true;
            listBox.DisplayMemberPath = "Name1.V1";
            listBox.ItemsSource = people;

            TextBlock textBlock = new TextBlock();
            textBlock.FontSize = 24;
            Binding binding=new Binding();
            binding.Source = people;
            binding.Path = new PropertyPath("Name1.V1");
            textBlock.SetBinding(TextBlock.TextProperty,binding);

            WrapPanel wrapPanel = new WrapPanel();
            Button button = new Button();
            button.Content = "<";
            button.Click += Button_Click;
            wrapPanel.Children.Add(button);

            Button button1 = new Button();
            button1.Content = ">";
            button1.Click += Button1_Click;
            wrapPanel.Children.Add(button1);







            stackPanel.Children.Add(wrapPanel);
            stackPanel.Children.Add(listBox);
            stackPanel.Children.Add(textBlock);
            Content = stackPanel;
        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            ICollectionView collectionView = CollectionViewSource.GetDefaultView(people);
            collectionView.MoveCurrentToNext();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
           ICollectionView collectionView=CollectionViewSource.GetDefaultView(people);
            collectionView.MoveCurrentToPrevious();
        }
    }

    public class Name
    {
        public string V1 { get; set; }
        public string V2 { get; set; }

        public Name(string v1, string v2)
        {
            this.V1 = v1;
            this.V2 = v2;
        }
    }
}
