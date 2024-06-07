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

namespace KrysenkoApp
{
    /// <summary>
    /// Логика взаимодействия для SignIn.xaml
    /// </summary>
    public partial class SignIn : Window
    {
        public SignIn()
        {
            InitializeComponent();
        }
        private void Signin()
        {
            var user = Model.Connect.Ent.User.ToList().Where(i => i.Login == LoginTB.Text && i.Password == LoginPB.Password).FirstOrDefault();
            if (user != null)
            {
                MessageBox.Show("Авторизация прошла успешно");
            }
            else
            {
                MessageBox.Show("Попробуйте еще раз");
            }

        }
        private void BtnLogin_Click(object sender, RoutedEventArgs e)
        {
            Signin();
        }
    }
}
