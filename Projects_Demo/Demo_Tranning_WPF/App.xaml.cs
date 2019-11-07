using Prism.Ioc;
using Demo_Tranning_WPF.Views;
using System.Windows;
using Newtonsoft.Json;
using System.IO;
using System.Configuration;

namespace Demo_Tranning_WPF
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App
    {
        protected override Window CreateShell()
        {
            getConectionString();
            return Container.Resolve<MainWindow>();

        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {

        }

        public void getConectionString()
        {
            var connectionString = ConfigurationManager.ConnectionStrings["QuanLyTTContext"].ConnectionString;
        }

    }
}
