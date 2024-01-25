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
    /// Логика взаимодействия для Form3.xaml
    /// </summary>
    public partial class Form3 : Window
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void close_btn_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void minus_btn_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }

        public void validate(object sender, TextCompositionEventArgs e)
        {
            e.Handled = !Regex.IsMatch(e.Text, @"^[0-9]*(\,[0-9]*)?$");
        }

        private void Window_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                this.DragMove();
            }
        }

        private void textBox_liters_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (textBox_liters.Text.Length > 0)
            {
                convert_btn.IsEnabled = true;
            }
            else
            {
                convert_btn.IsEnabled = false;
            }
        }

        private void convert_btn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double liters = Convert.ToDouble(textBox_liters.Text);
                if (liters == 0)
                {
                    message.Content = "Enter a value greater than 0";
                }
                else
                {
                    double m = liters / 1000;
                    double barreli = liters / 163.65;
                    double busheli = liters / 36.36872;
                    double galon = liters / 4.55;

                    message.Content = $"Cubic meters: {m}\n" +
                        $"Barrel: {barreli}\n" +
                        $"Bushel: {busheli}\n" +
                        $"Halon: {galon}";
                }
            }
            catch
            {
                message.Content = "Invalid data";
            }
        }
    }
}
