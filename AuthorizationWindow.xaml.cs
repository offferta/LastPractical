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
using System.Windows.Navigation;
using System.Windows.Shapes;
using LastPractical.Classes;
using LastPractical.Context;
using Microsoft.EntityFrameworkCore;

namespace LastPractical
{
    /// <summary>
    /// Interaction logic for AuthorizationWindow.xaml
    /// </summary>
    public partial class AuthorizationWindow : Window
    {
        private MyDbContext _context = new MyDbContext();
        
        
        
        public AuthorizationWindow()
        {
            InitializeComponent();
        }

        void GetUser()
        {
            var username = LoginTextBox.Text; 
            var password = PasswordTextBox.Password;
            
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Пожалуйста, введите имя пользователя и пароль.", "Authentication Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            if (username.Trim() != username || password.Trim() != password)
            {
                MessageBox.Show("Имя пользователя и пароль не должны содержать начальных или конечных пробелов.", "Authentication Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            try
            {
                var user = _context.Users.IgnoreAutoIncludes()
                    .FirstOrDefault(u =>
                        u.Login == username &&
                        u.Password == password);

                if (user == null)
                {
                    throw new Exception();
                }
                    
                App.User = user;
                if (user.RoleId == 1)
                {
                    new ApplicationFrameWindow().Show();
                    Close(); 
                }

                /*MessageBox.Show("Добро пожаловать, " + App.User.FirstName);*/
            }
            catch (Exception e)
            {
                MessageBox.Show("Ошибка подключения" + e.Message,"Authentication Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void AuthorizatiorButton_OnClick(object sender, RoutedEventArgs e)
        {
            GetUser();
        }
    }
}