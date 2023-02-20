using BrovkiTest.Actions;
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
using BrovkiTest.PageMain; // использование папки с страницами

namespace BrovkiTest
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            NavigationClass.Navigation = FrameNav; //Название класса> Название элемента в самом классе> название созданного фрейма на главном окне
            FrameNav.Navigate(new DefaultPage());
        }
    }
}
