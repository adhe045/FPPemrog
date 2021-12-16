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
using System.Windows.Shapes;

namespace FPPemrog.View
{
    /// <summary>
    /// Interaction logic for LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        public LoginWindow()
        {
            InitializeComponent();
            WindowStartupLocation = WindowStartupLocation.CenterScreen;
            ResizeMode = ResizeMode.NoResize;
            txtEmail.Focus();
        }

        private void txtPassword_GotFocus(object sender, RoutedEventArgs e)
        {
            txtPassword.Password = "";
        }

       

        private void txtUsername_GotFocus(object sender, RoutedEventArgs e)
        {
            txtEmail.SelectionStart = 0;
            txtEmail.SelectionLength = txtEmail.Text.Length;
        }

        private void btnLogin_Click_1(object sender, RoutedEventArgs e)
        {
            //instance -> create object
            Controller.LoginController login = new Controller.LoginController(this);
            //response
            login.ValidasiLogin();
            if (login.pesan != "")
            {
                MessageBox.Show(login.pesan);
            }
        }
    }
}
