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
    }
}
