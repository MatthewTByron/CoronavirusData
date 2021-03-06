using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using CoronavirusData.Services.API;
using CoronavirusData.ViewModels;

namespace CoronavirusData
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
           MainWindow mainWindow = new MainWindow()
           {
               DataContext = new MainViewModel()
           };

           mainWindow.Show();

            base.OnStartup(e);
        }
    }
}
