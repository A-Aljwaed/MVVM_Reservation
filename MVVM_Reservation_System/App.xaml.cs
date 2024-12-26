using MVVM_Reservation_System.Exceptions;
using MVVM_Reservation_System.Models;
using System.Configuration;
using System.Data;
using System.Linq.Expressions;
using System.Windows;
using MVVM_Reservation_System.viewModels;

namespace MVVM_Reservation_System
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            MainWindow = new MainWindow()
            {
                DataContext = new MainViewModel()
            };
            MainWindow.Show();

                base.OnStartup(e);
          
        }

    }

}
