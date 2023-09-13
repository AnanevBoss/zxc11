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

namespace Practica_Test
{
    /// <summary>
    /// Логика взаимодействия для Avtorization.xaml
    /// </summary>
    public partial class Avtorization : Window
    {
        public Avtorization()
        {
            InitializeComponent();
        }

       

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Registration reg = new Registration();
            reg.Show();
            this.Close();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Test tests = new Test();
            tests.Show();
            this.Close();
        }
    }
}
