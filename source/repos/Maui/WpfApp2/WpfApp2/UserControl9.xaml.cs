using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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
    /// UserControl9.xaml の相互作用ロジック
    /// </summary>
    public partial class UserControl9 : UserControl
    {
        public Person[] people { get; set; } = new Person[] {
            new Person(new Name("Chris","Anderson")),
            new Person(new Name("Don","Box")),
            new Person(new Name("Chris","Sells")),
            };


        public UserControl9()
        {
            InitializeComponent();

            ICollectionView collectionView = new ListCollectionView(people);
            collectionView.Filter = delegate (object item) { return ((Person)item).Name1.V1 != "Don"; };

            StackPanel stackPanel = new StackPanel();
            
            ListBox listBox = new ListBox();
            listBox.DisplayMemberPath = "Name1.V1";
            listBox.ItemsSource = people;

            ListBox listBox1 = new ListBox();
            listBox1.DisplayMemberPath = "Name1.V1";
            listBox1.ItemsSource = collectionView;


            stackPanel.Children.Add(new TextBlock(new Run("変更なし")));
            stackPanel.Children.Add(listBox);
            stackPanel.Children.Add(new TextBlock(new Run("変更済み")));
            stackPanel.Children.Add(listBox1);

            Content = stackPanel;
        }
    }
}
