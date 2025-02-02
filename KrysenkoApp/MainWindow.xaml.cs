﻿using System;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace KrysenkoApp
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void OpenRegistr()
        { 
            Registration2 registration2 = new Registration2();
            registration2.Show();
            this.Close();
        }
        private void OpenSignIn()
        {
            SignIn signIn = new SignIn();
            signIn.Show();
            this.Close();
        }
        private void Btn_Registr(object sender, RoutedEventArgs e)
        {
            OpenRegistr();
        }

        private void Btn_SignIn(object sender, RoutedEventArgs e)
        {
            OpenSignIn();
        }
    }
}
