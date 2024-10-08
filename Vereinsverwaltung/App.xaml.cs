﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Data.SqlClient;
using System.Data.SQLite;

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
            MessageBox.Show(aNutzer + aPasswort);
            using ( var connection = new SQLiteConnection(GetConnectionString()))
            {
                connection.Open();

                var command = connection.CreateCommand();
                command.CommandText =
                @"
                    SELECT Passwort
                    FROM Mitglied_Kenn
                    WHERE MitgliedId = $nutzer
                ";
                command.Parameters.AddWithValue("$nutzer", aNutzer);

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var passwort = reader.GetString(0);

                        MessageBox.Show(passwort);
                        if(passwort == aPasswort)
                        {
                            return aNutzer;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
            return -1;
        }
        private void ApplicationStart(object sender, StartupEventArgs e)
        {
            Window login = new LoginWindow();
            login.Show();

        }
        public void openMainWindow()
        {

        }
    }
}
