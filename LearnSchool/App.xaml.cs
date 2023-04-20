using LearnSchool.ADOApp;
using System.Windows;

namespace LearnSchool
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static DemoExamBaseEntities Connection = new DemoExamBaseEntities();
    }
}
