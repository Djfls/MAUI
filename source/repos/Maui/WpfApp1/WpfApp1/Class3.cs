using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace WpfApp1
{
    internal class Class3
    {
        public Class3() {
            Button b = new Button();
            b.Content = "ここをクリック";
            b.Click += delegate { MessageBox.Show("クリックされました"); };

            Button b2 = new Button();
            b2.Content = new Button();
            b2.Click += delegate { MessageBox.Show("クリックされました"); };

        }

        public delegate void RoutedEventHandler(object sender ,RoutedEventArgs e);

    }
}
