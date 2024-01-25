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
    /// <summary>
    /// Interaction logic for Form2.xaml
    /// </summary>
    public partial class Form2 : Window
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void convert_btn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double C = Convert.ToDouble(textBox_degrees.Text);
                    double Kelvin = C + 273.15;
                    double Farengeit = (C * 9 / 5) + 32;
                    double Reomeiru = C * 4 / 5;
                    double Rankinu = (C + 273.15) * 9 / 5;

                    message.Content = $"Kelvin: {Kelvin}" +
                        $"\nFahrenheit: {Farengeit}" +
                        $"\nReomeiru: {Reomeiru}" +
                        $"\nRankin: {Rankinu}";
            }
            catch
            {
                message.Content = "Invalid data";
            }
        }

        private void Window_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                this.DragMove();
            }
        }

        private void validate(object sender, TextCompositionEventArgs e)
        {
            e.Handled = !Regex.IsMatch(e.Text, @"^-?[0-9]*(\,[0-9]*)?$");
        }


        private void close_btn_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void minus_btn_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }

        private void textBox_degrees_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (textBox_degrees.Text.Length > 0)
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
