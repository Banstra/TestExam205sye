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

namespace AAAA.Pages
{
    /// <summary>
    /// Логика взаимодействия для Login.xaml
    /// </summary>
    public partial class Login : Page
    {
        public Login()
        {
            InitializeComponent();
            Classes.Connect.RulEntities = new Entities.OOORulEntities();

        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            password.Visibility = Visibility.Visible;
            Password.Visibility = Visibility.Collapsed;

        }

        private void CheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            password.Visibility = Visibility.Collapsed;
            Password.Visibility = Visibility.Visible;
            password.Text = Password.Password;
        }

        private void Enter_Click(object sender, RoutedEventArgs e)
        {
            var Datasobj = Classes.Connect.RulEntities.Datas.FirstOrDefault(X => X.Login == login.Text && X.Password == password.Text);
            if (Datasobj.Type == 1)
            {
                Classes.Manager.MainFrame.Navigate(new Pages.Admin());
            }
            if (login.Text == "manager" && Password.Password == "12345")
            {
                Classes.Manager.MainFrame.Navigate(new Pages.Manager());
            }
            if (Datasobj.Type == 2)
            {
                Classes.Manager.MainFrame.Navigate(new Pages.User());
            }

        }
    }
}
