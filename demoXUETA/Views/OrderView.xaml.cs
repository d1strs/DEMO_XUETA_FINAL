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
    /// Логика взаимодействия для OrderView.xaml
    /// </summary>
    public partial class OrderView : Window
    {
        Orders orderRed;
        Users user22;

        public OrderView(Orders order, Users user)
        {
            InitializeComponent();
            user22 = user;

            if (order != null) {
                orderRed = order;
                createNewOrd.Visibility = Visibility.Collapsed;
                editOrd.Visibility = Visibility.Visible;
                remOrd.Visibility = Visibility.Visible;

                dateCreate.Text = order.date_create.ToString();
                vid_Tex.SelectedIndex = order.vid_texnika_id -1;
                texnika_model.Text = order.model_texnika.ToString();
                problem_desc.Text = order.problem_description.ToString();
                surname.Text = order.surname.ToString();
                name.Text = order.name.ToString();
                midllename.Text = order.midllename.ToString();
                phone_numb.Text = order.phone_number.ToString();
                Status.SelectedIndex = order.status_id - 1;
            }
        }

        private void editOrd_Click(object sender, RoutedEventArgs e)
        {
            orderRed.date_create = dateCreate.Text;
            orderRed.vid_texnika_id = vid_Tex.SelectedIndex+1;
            orderRed.model_texnika = texnika_model.Text;
            orderRed.problem_description = problem_desc.Text;
            orderRed.surname = surname.Text;
            orderRed.name = name.Text;
            orderRed.midllename = midllename.Text;
            orderRed.phone_number = phone_numb.Text;
            orderRed.status_id = Status.SelectedIndex+1;

            DBconn.DB.SaveChanges();
            MainMenu mainMenu = new MainMenu(user22);
            mainMenu.Show(); 
            this.Close();
        }

        private void remOrd_Click(object sender, RoutedEventArgs e)
        {
            DBconn.DB.Orders.Remove(orderRed);
            DBconn.DB.SaveChanges();
            MainMenu mainMenu = new MainMenu(user22);
            mainMenu.Show();
            this.Close();
        }

        private void createNewOrd_Click(object sender, RoutedEventArgs e)
        {
            Orders orders = new Orders();

            orders.date_create = dateCreate.Text;
            orders.vid_texnika_id = vid_Tex.SelectedIndex + 1;
            orders.model_texnika = texnika_model.Text;
            orders.problem_description = problem_desc.Text;
            orders.surname = surname.Text;
            orders.name = name.Text;
            orders.midllename = midllename.Text;
            orders.phone_number = phone_numb.Text;
            orders.status_id = Status.SelectedIndex + 1;

            DBconn.DB.Orders.Add(orders);
            DBconn.DB.SaveChanges();
            MainMenu mainMenu = new MainMenu(user22);
            mainMenu.Show();
            this.Close();
        }
    }
}
