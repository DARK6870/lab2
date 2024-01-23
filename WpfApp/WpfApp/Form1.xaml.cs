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
using System.Windows.Shapes;

namespace WpfApp
{
    /// <summary>
    /// Interaction logic for Form1.xaml
    /// </summary>
    public partial class Form1 : Window
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void ShowError(string msg)
        {
            message.Foreground = Brushes.Red;
            message.Content = msg;
        }


        private void convert_btn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double km = Convert.ToDouble(textBox_km.Text);
                
                if(km <= 0)
                {
                    ShowError("Km should be more or equal to 0");
                }
                else
                {
                    double mile = km / 1.609344;
                    double liga = km / 4.828032;
                    double lie = km / 4.44;
                    double fut = km / 0.3048;

                    string result = $"{km} киллометр равен:\n" +
                        $"{liga} лиг (лье)\n{mile} миль\n{lie} лье\n{fut} футов";

                    message.Foreground = Brushes.Black;
                    message.Content = result ;
                }
            }
            catch
            {
                ShowError("Invalid data");
            }
        }
    }
}
