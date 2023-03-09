using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Vereinsverwaltung
{
    /// <summary>
    /// Interaktionslogik für LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        public LoginWindow()
        {
            InitializeComponent();
        }
        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(Passwort.Password);
            Window mainWindow = new MainWindow();
            int mitgliegNr = Convert.ToInt32(MitgliedNr.Text);
            int check = Vereinsverwaltung.App.CheckLogin(mitgliegNr, Passwort.Password);
            if (check > 0 && check == mitgliegNr)
            {
                mainWindow.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("login nicht erfolgreich");
            }
            
        }

private void NumberValidationTextBox(object sender, TextCompositionEventArgs e)
    {
        Regex regex = new Regex("[^0-9]+");
        e.Handled = regex.IsMatch(e.Text);
    }

}
}
