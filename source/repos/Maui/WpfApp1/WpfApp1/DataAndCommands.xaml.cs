using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
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
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// DataAndCommands.xaml の相互作用ロジック
    /// </summary>
    public partial class DataAndCommands : Window
    {
        public DataAndCommands()
        {
            InitializeComponent();

            CommandBindings.Add(new CommandBinding(OpenCommand,delegate(object sender ,ExecutedRoutedEventArgs e) { Process.Start("notepad.exe", (string)e.Parameter); }));
            CommandBindings.Add(new CommandBinding(BlockedCommand, delegate (object sender, ExecutedRoutedEventArgs e) { MessageBox.Show((string)e.Parameter, "ブロックされました"); }));

            FileInfo[] fileList = new DirectoryInfo("C:\\").GetFiles("*.*");
            _files.ItemsSource = fileList;
        }

        public static readonly RoutedCommand OpenCommand = new RoutedCommand("Open",typeof(DataAndCommands));
        public static readonly RoutedCommand BlockedCommand = new RoutedCommand("Blocked", typeof(DataAndCommands));
    }

    public class FileToCommandConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            string ext = ((FileInfo)value).Extension.ToLowerInvariant();
            if (ext==".txt") 
            {
                return DataAndCommands.OpenCommand;
            }
            return DataAndCommands.BlockedCommand;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }

    public class ToLowerInvariantConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return ((string)value).ToLowerInvariant();
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return value;
        }
    }
}
