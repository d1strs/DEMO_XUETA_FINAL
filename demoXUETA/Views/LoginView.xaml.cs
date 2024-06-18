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

namespace demoXUETA.Views
{
    /// <summary>
    /// Логика взаимодействия для LoginView.xaml
    /// </summary>
    public partial class LoginView : Window
    {
        public LoginView()
        {
            InitializeComponent();
            loginBox.Text = "kasoo";
            passBox.Password = "root";
        }

        private void loginButton_Click(object sender, RoutedEventArgs e)
        {
            var user = DBconn.DB.Users.Where(p => p.login == loginBox.Text && p.password == passBox.Password).FirstOrDefault();

            if (user != null)
            {
                MainMenu mainMenu = new MainMenu(user);
                mainMenu.Show();
                this.Close();
            }

            else MessageBox.Show("loh228");
        }
    }
}
