using System;
using System.Collections.Generic;
using System.Diagnostics;
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
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window
    {
        public static readonly ICommand ExitCommand = new Exit();


        public MainWindow()
        {
            var a = new Class1();
            //var a2 = new Class2();
            InitializeComponent();

            this.PreviewMouseRightButtonDown += Window_PreviewMouseRightButtonDown;
            this.AddHandler(Button.ClickEvent, (RoutedEventHandler)delegate { MessageBox.Show("クリックされました"); });
            this.AddHandler(Exit.ExecuteEvent, (RoutedEventHandler)delegate (object sender, RoutedEventArgs e) { ExitExcuted(sender,  e); });
        }

        void ExitExcuted(object sender , RoutedEventArgs e) 
        {
            this.Close();
        }
        void CloseExcuted(object sender, ExecutedRoutedEventArgs e)
        {
            this.Close();
        }
        private void Window_PreviewMouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            e.Handled = true;
            Debug.WriteLine("Window_PreviewMouseRightButtonDown");
        }

        private void GroupBox_PreviewMouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            Debug.WriteLine("GroupBox_PreviewMouseRightButtonDown");
        }

        private void Button_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            Debug.WriteLine("Button_PreviewMouseDown");
        }

        private void Button_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            Debug.WriteLine("Button_MouseRightButtonDown");
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

    }

    public class Exit : ICommand
    {
        public static readonly RoutedEvent ExecuteEvent = EventManager.RegisterRoutedEvent
            ("Excuted",RoutingStrategy.Bubble,typeof(RoutedEventHandler),typeof(Exit));

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            RoutedEventArgs e = new RoutedEventArgs(Exit.ExecuteEvent,Keyboard.FocusedElement);
            if (e.Source!=null)
            {
                Keyboard.FocusedElement.RaiseEvent(e);
                Application.Current.Shutdown();

            }

        }
    }
    public static class SimpleButton
    {
        public static readonly ComponentResourceKey RingBrush = new ComponentResourceKey(typeof(SimpleButton), "RingBrush");
    }
}
