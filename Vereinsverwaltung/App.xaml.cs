using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Data.SqlClient;

namespace Vereinsverwaltung
{
    /// <summary>
    /// Interaktionslogik für "App.xaml"
    /// </summary>
    public partial class App : Application
    {

        public static string GetConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["VW"].ConnectionString;
        }

        public static int CheckLogin(int aNutzer, string aPasswort)
        {
            
            return 1;
        }
        private void ApplicationStart(object sender, StartupEventArgs e)
        {
            Window login = new LoginWindow();
            login.Show();

            // Determine if login was successful

            //show your MainWindow
        }
        public void openMainWindow()
        {

        }
    }
}
