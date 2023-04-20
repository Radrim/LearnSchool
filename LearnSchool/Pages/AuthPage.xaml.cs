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

namespace LearnSchool.Pages
{
    /// <summary>
    /// Interaction logic for AuthPage.xaml
    /// </summary>
    public partial class AuthPage : Page
    {
        public AuthPage()
        {
            InitializeComponent();
        }

        private void btnSignClick(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new ServiceListPage());
        }

        private void btnCodeSignClick(object sender, RoutedEventArgs e)
        {
            if (tbCode.Text != " ") 
            {
                if (tbCode.Text == "0000")
                {
                    NavigationService.Navigate(new ServiceListPage());
                }
                else MessageBox.Show("Введён неверный код.", "Оповещение", MessageBoxButton.OKCancel, MessageBoxImage.Warning);
            }
            else MessageBox.Show("Некорректный ввод данных", "Ошибка", MessageBoxButton.OKCancel, MessageBoxImage.Error);
        }
    }
}
