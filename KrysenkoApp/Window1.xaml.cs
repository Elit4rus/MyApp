using KrysenkoApp.Model;
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

namespace KrysenkoApp
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }
        User regUser = new User();
        private void RegUser()
        {
            regUser.Login = regLoginTB.Text.ToString();
            regUser.Password = regPasswordTB.Text.ToString();
            if (Connect.Ent.User.Count(i => i.Login == regLoginTB.Text) > 0)
            {
                MessageBox.Show("Такой логин уже существует");
                return;
            }
            else if (regLoginTB.Text != null || regPasswordTB.Text != null)
            {
                MessageBox.Show("Пользователь добавлен");
                Connect.Ent.User.Add(regUser);
                Connect.Ent.SaveChanges();
            }
            else if (regLoginTB.Text == null || regPasswordTB.Text == null)
            {
                MessageBox.Show("Введите данные");
            }
            else 
            {
                MessageBox.Show("Попробуйте снова");
            }
        }
        private void regMainBtn_Click(object sender, RoutedEventArgs e)
        {
            RegUser();
        }
    }
}
