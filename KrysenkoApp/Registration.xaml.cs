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
    /// Логика взаимодействия для Registration2.xaml
    /// </summary>
    public partial class Registration2 : Window
    {
        public Registration2()
        {
            InitializeComponent();
        }
        private void Registration()
        {
            var user = Model.Connect.Ent.User.ToList().Where(i => i.Login == RegTB.Text && i.Password == RegPB.Password).FirstOrDefault();
            if (user != null)
            {
                MessageBox.Show("Авторизация прошла успешно");
            }
            else
            {
                MessageBox.Show("Попробуйте еще раз");
            }

        }
        private void BtnRegistr_Click(object sender, RoutedEventArgs e)
        {
            Registration();
        }
    }
}
