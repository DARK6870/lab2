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
                double C = Convert.ToDouble(textBox_C);
            }
            catch
            {
            }
        }

        private void validate(object sender, TextCompositionEventArgs e)
        {
            e.Handled = new Regex("[^0-9]+").IsMatch(e.Text);
        }
    }
}
