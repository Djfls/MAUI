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
    /// UserControl6.xaml の相互作用ロジック
    /// </summary>
    public partial class UserControl6 : UserControl
    {
        public UserControl6()
        {
            InitializeComponent();
            DataContext = new User6ViewModel();
        }
    }

    public class LocalNameTemplateSelector : DataTemplateSelector
    {
        public DataTemplate Book { get; set; }
        public DataTemplate CD { get; set; }
        public DataTemplate DVD { get; set; }

        public override DataTemplate SelectTemplate(object item,
                   DependencyObject container)
        {
            return Book;
        }
    }


    public class User6ViewModel
    {
        public Media Media { get; set; } = new Media();
        public Dvd MyDVD { get; set; } = new Dvd("愛という名の映画", new List<Actor> { new Actor("satou"), new Actor("yamada") });
        public Cd MyCD { get; set; } = new Cd("愛子と", "山田");
        public List<Book> MyBooks { get; set; } = new List<Book> { new Book("山田", "愛1"), new Book("佐藤", "愛2"), new Book("鈴木", "愛3") };
    }

    public class Media
    {
        public Dvd MyDVD { get; set; } = new Dvd("愛という名の映画", new List<Actor> { new Actor("satou"), new Actor("yamada") });
        public Cd MyCD { get; set; } = new Cd("愛子と", "山田");
        public List<Book> MyBooks { get; set; } = new List<Book> { new Book("山田", "愛1"), new Book("佐藤", "愛2"), new Book("鈴木", "愛3") };
    }
    public class Dvd
    {
        public Dvd(string title, List<Actor> actors)
        {
            Title = title;
            Actors = actors;
        }

        public string Title { get; set; }
        public List<Actor> Actors { get; set; }
    }

    public class Actor
    {
        public Actor(string name)
        {
            Name = name;
        }

        public string Name { get; set; }
    }

    public class Cd
    {
        public Cd(string title, string artist)
        {
            Title = title;
            Artist = artist;
        }

        public string Title { get; set; }
        public string Artist { get; set; }
    }

    public class Book
    {
        public Book(string title, string author)
        {
            Title = title;
            Author = author;
        }

        public string Title { get; set; }
        public string Author { get; set; }
    }

}