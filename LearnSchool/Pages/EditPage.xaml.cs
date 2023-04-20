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
    /// Interaction logic for EditPage.xaml
    /// </summary>
    public partial class EditPage : Page
    {
        private Service _currentService;
        public EditPage(Service service)
        {
            _currentService = service;
            InitializeComponent();
            FillServiceData();
        }

        private void btnBackClick(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void FillServiceData() 
        {
            tbTitle.Text = _currentService.Title;
            tbCost.Text = _currentService.Cost.ToString();
            tbDuration.Text = _currentService.DurationInSeconds.ToString();
            tbDescription.Text = _currentService.Description;
            tbDiscount.Text = _currentService.Discount.ToString();
        }
    }
}
