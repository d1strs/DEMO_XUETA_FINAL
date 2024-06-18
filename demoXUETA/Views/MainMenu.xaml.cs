using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
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
    /// Логика взаимодействия для MainMenu.xaml
    /// </summary>
    public partial class MainMenu : Window
    {
        Orders orderRed;
        Users user22;

        public MainMenu(Users user)
        {
            InitializeComponent();
            user22 = user;
            User.Text = $"{user.surname} {user.name} {user.midllename}--> Роль {user.Post.name}";
            vivo.ItemsSource = DBconn.DB.Orders.ToList();
        }

        private void editBut_Click(object sender, RoutedEventArgs e)
        {
            var selectOrder = (Orders)(sender as Button).DataContext;
            OrderView orderView = new OrderView(selectOrder, user22);
            orderView.Show();
            this.Close();
        }

        private void CreateButn_Click(object sender, RoutedEventArgs e)
        {
            OrderView orderView = new OrderView(orderRed, user22);
            orderView.Show();
            this.Close();
        }
    }
}
