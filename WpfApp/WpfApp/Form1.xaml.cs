using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WpfApp
{
    public partial class Form1 : Window
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void convert_btn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double km = Convert.ToDouble(textBox_km.Text);

                    double mile = km / 1.609344;
                    double liga = km / 4.828032;
                    double lie = km / 4.44;
                    double fut = km / 0.3048;

                    string result = $"{km} киллометр равен:\n" +
                        $"{liga} лиг (лье)\n{mile} миль\n{lie} лье\n{fut} футов";

                    message.Content = result ;
            }
            catch
            {
                
            }
        }

        public void validate(object sender, TextCompositionEventArgs e)
        {
            e.Handled = new Regex("[^0-9]+").IsMatch(e.Text);
        }

        private void close_btn_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void minus_btn_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }

        private void Window_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                this.DragMove();
            }
        }
    }
}
