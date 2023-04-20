using LearnSchool.ADOApp;
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
    /// Interaction logic for ServiceListPage.xaml
    /// </summary>
    public partial class ServiceListPage : Page
    {
        public ServiceListPage()
        {
            InitializeComponent();
            lvService.ItemsSource = App.Connection.Service.ToList();
        }

        private void ButtonEditClick(object sender, RoutedEventArgs e)
        {
            var button = ((Button)sender).Tag;
            var service = App.Connection.Service.FirstOrDefault(x => x.ID == (int)button);
            NavigationService.Navigate(new EditPage(service));
        }
    }
}
