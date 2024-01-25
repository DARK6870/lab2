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
                if (km == 0)
                {
                    message.Content = "Enter value more than 0";
                }
                else
                {
                    double mile = km / 1.609344;
                    double liga = km / 4.828032;
                    double lie = km / 4.44;
                    double fut = km / 0.3048;

                    string result = $"{km} kilometer is equal to:\n" +
                            $"{liga} leagues\n{mile} miles\n{lie} lie\n{fut} feet";

                    message.Content = result;
                }
            }
            catch
            {

            }
        }

        public void validate(object sender, TextCompositionEventArgs e)
        {
            e.Handled = !Regex.IsMatch(e.Text, @"^[0-9]*(\,[0-9]*)?$");

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

        private void textBox_km_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (textBox_km.Text.Length > 0)
            {
                convert_btn.IsEnabled = true;
            }
            else
            {
                convert_btn.IsEnabled = false;
            }
        }
    }
}
