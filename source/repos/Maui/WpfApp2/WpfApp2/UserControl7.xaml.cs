using System;
using System.Collections.Generic;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp2
{
    /// <summary>
    /// UserControl7.xaml の相互作用ロジック
    /// </summary>
    public partial class UserControl7 : UserControl
    {
        public UserControl7()
        {
            InitializeComponent();
            DataContext = new DirectoryInfo[] { new DirectoryInfo("C:\\Users\\Mutsuko\\Desktop\\oota") };
        }
    }

    public class GetFileSystemInfosConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            try
            {
                if (value is DirectoryInfo)
                {
                    return ((DirectoryInfo)value).GetFileSystemInfos();
                }
            }
            catch (Exception)
            {
                throw;
            }
            return null;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
