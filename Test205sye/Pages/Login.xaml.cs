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

namespace Test205sye.Pages
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

        private void Check(object sender, RoutedEventArgs e)
        {
            
                Password1.Visibility = Visibility.Collapsed;
                Password.Visibility = Visibility.Visible;
                Password.Text = Password1.Password;
            

            
               
            
        }

        private void Uncheck(object sender, RoutedEventArgs e)
        {
            Password1.Visibility = Visibility.Visible;
            Password.Visibility = Visibility.Collapsed;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var userObj = Classes.Connect.RulEntities.Datas.FirstOrDefault(x =>
                 x.Login == login.Text && x.Password == Password1.Password);
            if (userObj == null)
            {
                MessageBox.Show("Такого пользователя нет!", "Ошибка при авторизации",
                    MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                MessageBox.Show("Здравствуйте " + userObj.Login, "Уведомление",
                   MessageBoxButton.OK, MessageBoxImage.Information);
                switch (userObj.Type)
                {
                    case 1:
                        Classes.Manager.MainFrame.Navigate(new Admin());
                        break;
                    case 2:
                        Classes.Manager.MainFrame.Navigate(new Manager());
                        break;
                    case 3:
                        Classes.Manager.MainFrame.Navigate(new User());
                        break;
                    default:
                        MessageBox.Show("Данные не обнаружены!", "Уведомление",
                MessageBoxButton.OK, MessageBoxImage.Warning);
                        break;
                }
            }
        }
    }
}
