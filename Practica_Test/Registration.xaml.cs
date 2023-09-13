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
    /// Логика взаимодействия для Registration.xaml
    /// </summary>
    public partial class Registration : Window
    {
        public Registration()
        {
            InitializeComponent();
        }



        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Avtorization avtr = new Avtorization();
            avtr.Show();
            this.Close();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            


            string login = TextBoxLogin.Text.Trim();
            string pass = PassBox.Password.Trim();
            string pass2 = PassBox2.Password.Trim();
            string email = TextBoxEmail.Text.Trim().ToLower();

            if (login.Length < 5)
            {
                TextBoxLogin.ToolTip = "Это поле заполненно не корректно";
                TextBoxLogin.Background = Brushes.IndianRed;
            }
            else if (pass.Length < 5)
            {
                PassBox.ToolTip = "Это поле заполненно не корректно";
                PassBox.Background = Brushes.IndianRed;
            }
            else if (pass != pass2)
            {
                PassBox.ToolTip = "Это поле заполненно не корректно";
                PassBox2.Background = Brushes.IndianRed;
            }



            else
            {
                TextBoxLogin.ToolTip = "";
                TextBoxLogin.Background = Brushes.Transparent;
                PassBox.ToolTip = "";
                PassBox.Background = Brushes.Transparent;
                PassBox2.ToolTip = "";
                PassBox2.Background = Brushes.Transparent;


                MessageBox.Show("Вы успешно зарегестрировались");
                if (email.Length > 5 || !email.Contains("@") || !email.Contains("."))
                {
                    TextBoxEmail.ToolTip = "Это поле заполненно не корректно";
                    

                }

                else
                {
                    TextBoxEmail.ToolTip = "";
                    TextBoxEmail.Background = Brushes.Transparent;

                }

            }
        }
    }
}
