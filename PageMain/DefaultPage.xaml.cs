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
    /// Логика взаимодействия для DefaultPage.xaml
    /// </summary>
    public partial class DefaultPage : Page
    {
        public DefaultPage()
        {
            InitializeComponent();
        }

        private void ButtonLoginUser_Click(object sender, RoutedEventArgs e)
        {
            NavigationClass.Navigation.Navigate(new UserPage());
        }

        private void ButtonLoginAdmin_Click(object sender, RoutedEventArgs e)
        {
            NavigationClass.Navigation.Navigate(new AdminLoginPage());
        }
    }
}
