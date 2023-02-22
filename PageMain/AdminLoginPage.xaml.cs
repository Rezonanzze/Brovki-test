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
using BrovkiTest.Actions;

namespace BrovkiTest.PageMain
{
    /// <summary>
    /// Логика взаимодействия для AdminLoginPage.xaml
    /// </summary>
    public partial class AdminLoginPage : Page
    {
        public AdminLoginPage()
        {
            InitializeComponent();
        }

        private void ButtonAdminSignIn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (AdminPasswordBox.Password == "0000")
                {
                    //Тест - Название уведовления - Тип кнопки - Изображение уведовления
                    MessageBox.Show("Введён верный пароль. Перенаправления на страницу администрации","Уведомление",MessageBoxButton.OK,MessageBoxImage.Information);

                    NavigationClass.Navigation.Navigate(new AdminPage());
                }

                else
                {
                    MessageBox.Show("Введён НЕ верный пароль. Попробуйте ещё раз", "Уведомление", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ButtonABack_Click(object sender, RoutedEventArgs e)
        {
            NavigationClass.Navigation.GoBack();
        }
    }
}
