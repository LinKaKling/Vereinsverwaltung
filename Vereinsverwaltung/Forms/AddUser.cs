using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;
using System.Windows.Media;

namespace Vereinsverwaltung.Forms
{
    public partial class AddUser : Form
    {
        public AddUser()
        {
            InitializeComponent();
        }

        private void CloseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Code zum hinzufügen eines neuen Datensatzes für einen neuen User
            MessageBox.Show(this.maskedTextBox_Nachname.Text);
            var vereinsmitglied = new Vereinsmitglied(2, this.maskedTextBox_Nachname.Text, this.maskedTextBox_Vorname.Text, this.maskedTextBox_Email.Text, this.maskedTextBox_Strasse.Text, this.maskedTextBox_Hausnummer.Text, this.maskedTextBox_PLZ.Text, this.maskedTextBox_Ort.Text, this.DateTimePicker_UserGebDat.Value.ToString(), Convert.ToInt32(this.comboBox_ErwerbArt.SelectedValue), this.maskedTextBox_Land.Text, this.maskedTextBox_KontoNr.Text, this.isAdmin.Checked, System.DateTime.Now.ToString() , this.Austrittsdatum.Value.ToString(), false, this.maskedTextBox_Telefon.Text);
        }
    }
}
