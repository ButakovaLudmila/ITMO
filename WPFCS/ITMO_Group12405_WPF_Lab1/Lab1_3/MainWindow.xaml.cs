using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
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

namespace ITMO_Group12405_WPF_Lab1.Lab1_3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            SetName.IsEnabled = false;
            RetName.IsEnabled = false;
        }

        private void SetName_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                System.IO.StreamWriter sw = new
               System.IO.StreamWriter("c:\\Users\\butakovalv\\Documents\\username.txt");
                sw.WriteLine(textBox1.Text);
                sw.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            RetName.IsEnabled = true;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                System.IO.StreamReader sr = new
               System.IO.StreamReader("c:\\Users\\butakovalv\\Documents\\username.txt");
                label1.Content = "Приветствую Вас, уважаемый " + sr.ReadToEnd();
                sr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void textBox1_TextChanged(object sender, TextChangedEventArgs e)
        {
            SetName.IsEnabled = true;
        }
    }

}
