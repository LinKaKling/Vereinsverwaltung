
namespace Vereinsverwaltung.Forms
{
    partial class AddUser
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.addUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DateTimePicker_UserGebDat = new System.Windows.Forms.DateTimePicker();
            this.maskedTextBox_Land = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox_Ort = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox_PLZ = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox_Hausnummer = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox_Strasse = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox_Email = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox_Nachname = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox_Vorname = new System.Windows.Forms.MaskedTextBox();
            this.Label_UserLand = new System.Windows.Forms.Label();
            this.Label_UserIsAdmin = new System.Windows.Forms.Label();
            this.Label_UserAblaufDat = new System.Windows.Forms.Label();
            this.Label_UserKonto = new System.Windows.Forms.Label();
            this.Label_UserErwerbArt = new System.Windows.Forms.Label();
            this.Label_UserGebDat = new System.Windows.Forms.Label();
            this.Label_UserOrt = new System.Windows.Forms.Label();
            this.Label_UserPLZ = new System.Windows.Forms.Label();
            this.Label_UserHausnummer = new System.Windows.Forms.Label();
            this.Label_UserStrasse = new System.Windows.Forms.Label();
            this.Label_UserEMail = new System.Windows.Forms.Label();
            this.Label_UserNachname = new System.Windows.Forms.Label();
            this.Label_UserVorname = new System.Windows.Forms.Label();
            this.comboBox_ErwerbArt = new System.Windows.Forms.ComboBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.maskedTextBox_KontoNr = new System.Windows.Forms.MaskedTextBox();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addUserToolStripMenuItem,
            this.toolStripMenuItem1,
            this.closeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // addUserToolStripMenuItem
            // 
            this.addUserToolStripMenuItem.Name = "addUserToolStripMenuItem";
            this.addUserToolStripMenuItem.Size = new System.Drawing.Size(84, 24);
            this.addUserToolStripMenuItem.Text = "Add User";
            this.addUserToolStripMenuItem.Click += new System.EventHandler(this.addUserToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(27, 24);
            this.toolStripMenuItem1.Text = "|";
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(59, 24);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.CloseToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.maskedTextBox_KontoNr);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.comboBox_ErwerbArt);
            this.groupBox1.Controls.Add(this.DateTimePicker_UserGebDat);
            this.groupBox1.Controls.Add(this.maskedTextBox_Land);
            this.groupBox1.Controls.Add(this.maskedTextBox_Ort);
            this.groupBox1.Controls.Add(this.maskedTextBox_PLZ);
            this.groupBox1.Controls.Add(this.maskedTextBox_Hausnummer);
            this.groupBox1.Controls.Add(this.maskedTextBox_Strasse);
            this.groupBox1.Controls.Add(this.maskedTextBox_Email);
            this.groupBox1.Controls.Add(this.maskedTextBox_Nachname);
            this.groupBox1.Controls.Add(this.maskedTextBox_Vorname);
            this.groupBox1.Controls.Add(this.Label_UserLand);
            this.groupBox1.Controls.Add(this.Label_UserIsAdmin);
            this.groupBox1.Controls.Add(this.Label_UserAblaufDat);
            this.groupBox1.Controls.Add(this.Label_UserKonto);
            this.groupBox1.Controls.Add(this.Label_UserErwerbArt);
            this.groupBox1.Controls.Add(this.Label_UserGebDat);
            this.groupBox1.Controls.Add(this.Label_UserOrt);
            this.groupBox1.Controls.Add(this.Label_UserPLZ);
            this.groupBox1.Controls.Add(this.Label_UserHausnummer);
            this.groupBox1.Controls.Add(this.Label_UserStrasse);
            this.groupBox1.Controls.Add(this.Label_UserEMail);
            this.groupBox1.Controls.Add(this.Label_UserNachname);
            this.groupBox1.Controls.Add(this.Label_UserVorname);
            this.groupBox1.Location = new System.Drawing.Point(12, 49);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 309);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Adresse";
            // 
            // DateTimePicker_UserGebDat
            // 
            this.DateTimePicker_UserGebDat.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateTimePicker_UserGebDat.ImeMode = System.Windows.Forms.ImeMode.On;
            this.DateTimePicker_UserGebDat.Location = new System.Drawing.Point(111, 93);
            this.DateTimePicker_UserGebDat.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.DateTimePicker_UserGebDat.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.DateTimePicker_UserGebDat.Name = "DateTimePicker_UserGebDat";
            this.DateTimePicker_UserGebDat.Size = new System.Drawing.Size(100, 22);
            this.DateTimePicker_UserGebDat.TabIndex = 25;
            this.DateTimePicker_UserGebDat.Value = new System.DateTime(1975, 1, 1, 0, 0, 0, 0);
            // 
            // maskedTextBox_Land
            // 
            this.maskedTextBox_Land.Location = new System.Drawing.Point(111, 257);
            this.maskedTextBox_Land.Name = "maskedTextBox_Land";
            this.maskedTextBox_Land.Size = new System.Drawing.Size(100, 22);
            this.maskedTextBox_Land.TabIndex = 24;
            // 
            // maskedTextBox_Ort
            // 
            this.maskedTextBox_Ort.Location = new System.Drawing.Point(111, 230);
            this.maskedTextBox_Ort.Name = "maskedTextBox_Ort";
            this.maskedTextBox_Ort.Size = new System.Drawing.Size(100, 22);
            this.maskedTextBox_Ort.TabIndex = 23;
            // 
            // maskedTextBox_PLZ
            // 
            this.maskedTextBox_PLZ.Location = new System.Drawing.Point(111, 203);
            this.maskedTextBox_PLZ.Name = "maskedTextBox_PLZ";
            this.maskedTextBox_PLZ.Size = new System.Drawing.Size(100, 22);
            this.maskedTextBox_PLZ.TabIndex = 22;
            // 
            // maskedTextBox_Hausnummer
            // 
            this.maskedTextBox_Hausnummer.Location = new System.Drawing.Point(111, 175);
            this.maskedTextBox_Hausnummer.Name = "maskedTextBox_Hausnummer";
            this.maskedTextBox_Hausnummer.Size = new System.Drawing.Size(100, 22);
            this.maskedTextBox_Hausnummer.TabIndex = 21;
            // 
            // maskedTextBox_Strasse
            // 
            this.maskedTextBox_Strasse.Location = new System.Drawing.Point(111, 148);
            this.maskedTextBox_Strasse.Name = "maskedTextBox_Strasse";
            this.maskedTextBox_Strasse.Size = new System.Drawing.Size(100, 22);
            this.maskedTextBox_Strasse.TabIndex = 20;
            // 
            // maskedTextBox_Email
            // 
            this.maskedTextBox_Email.Location = new System.Drawing.Point(111, 121);
            this.maskedTextBox_Email.Name = "maskedTextBox_Email";
            this.maskedTextBox_Email.Size = new System.Drawing.Size(100, 22);
            this.maskedTextBox_Email.TabIndex = 19;
            // 
            // maskedTextBox_Nachname
            // 
            this.maskedTextBox_Nachname.Location = new System.Drawing.Point(111, 67);
            this.maskedTextBox_Nachname.Name = "maskedTextBox_Nachname";
            this.maskedTextBox_Nachname.Size = new System.Drawing.Size(100, 22);
            this.maskedTextBox_Nachname.TabIndex = 18;
            // 
            // maskedTextBox_Vorname
            // 
            this.maskedTextBox_Vorname.Location = new System.Drawing.Point(111, 40);
            this.maskedTextBox_Vorname.Name = "maskedTextBox_Vorname";
            this.maskedTextBox_Vorname.Size = new System.Drawing.Size(100, 22);
            this.maskedTextBox_Vorname.TabIndex = 17;
            this.maskedTextBox_Vorname.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePrompt;
            // 
            // Label_UserLand
            // 
            this.Label_UserLand.AutoSize = true;
            this.Label_UserLand.Location = new System.Drawing.Point(7, 262);
            this.Label_UserLand.Name = "Label_UserLand";
            this.Label_UserLand.Size = new System.Drawing.Size(45, 17);
            this.Label_UserLand.TabIndex = 16;
            this.Label_UserLand.Text = "Land*";
            // 
            // Label_UserIsAdmin
            // 
            this.Label_UserIsAdmin.AutoSize = true;
            this.Label_UserIsAdmin.Location = new System.Drawing.Point(245, 127);
            this.Label_UserIsAdmin.Name = "Label_UserIsAdmin";
            this.Label_UserIsAdmin.Size = new System.Drawing.Size(47, 17);
            this.Label_UserIsAdmin.TabIndex = 14;
            this.Label_UserIsAdmin.Text = "Admin";
            // 
            // Label_UserAblaufDat
            // 
            this.Label_UserAblaufDat.AutoSize = true;
            this.Label_UserAblaufDat.Location = new System.Drawing.Point(242, 100);
            this.Label_UserAblaufDat.Name = "Label_UserAblaufDat";
            this.Label_UserAblaufDat.Size = new System.Drawing.Size(98, 17);
            this.Label_UserAblaufDat.TabIndex = 13;
            this.Label_UserAblaufDat.Text = "Austrittsdatum";
            // 
            // Label_UserKonto
            // 
            this.Label_UserKonto.AutoSize = true;
            this.Label_UserKonto.Location = new System.Drawing.Point(242, 73);
            this.Label_UserKonto.Name = "Label_UserKonto";
            this.Label_UserKonto.Size = new System.Drawing.Size(44, 17);
            this.Label_UserKonto.TabIndex = 12;
            this.Label_UserKonto.Text = "IBAN*";
            // 
            // Label_UserErwerbArt
            // 
            this.Label_UserErwerbArt.AutoSize = true;
            this.Label_UserErwerbArt.Location = new System.Drawing.Point(245, 46);
            this.Label_UserErwerbArt.Name = "Label_UserErwerbArt";
            this.Label_UserErwerbArt.Size = new System.Drawing.Size(42, 17);
            this.Label_UserErwerbArt.TabIndex = 11;
            this.Label_UserErwerbArt.Text = "Beruf";
            // 
            // Label_UserGebDat
            // 
            this.Label_UserGebDat.AutoSize = true;
            this.Label_UserGebDat.Location = new System.Drawing.Point(7, 100);
            this.Label_UserGebDat.Name = "Label_UserGebDat";
            this.Label_UserGebDat.Size = new System.Drawing.Size(84, 17);
            this.Label_UserGebDat.TabIndex = 10;
            this.Label_UserGebDat.Text = "Geburtsdat*";
            // 
            // Label_UserOrt
            // 
            this.Label_UserOrt.AutoSize = true;
            this.Label_UserOrt.Location = new System.Drawing.Point(7, 235);
            this.Label_UserOrt.Name = "Label_UserOrt";
            this.Label_UserOrt.Size = new System.Drawing.Size(33, 17);
            this.Label_UserOrt.TabIndex = 9;
            this.Label_UserOrt.Text = "Ort*";
            // 
            // Label_UserPLZ
            // 
            this.Label_UserPLZ.AutoSize = true;
            this.Label_UserPLZ.Location = new System.Drawing.Point(7, 208);
            this.Label_UserPLZ.Name = "Label_UserPLZ";
            this.Label_UserPLZ.Size = new System.Drawing.Size(39, 17);
            this.Label_UserPLZ.TabIndex = 8;
            this.Label_UserPLZ.Text = "PLZ*";
            // 
            // Label_UserHausnummer
            // 
            this.Label_UserHausnummer.AutoSize = true;
            this.Label_UserHausnummer.Location = new System.Drawing.Point(7, 181);
            this.Label_UserHausnummer.Name = "Label_UserHausnummer";
            this.Label_UserHausnummer.Size = new System.Drawing.Size(97, 17);
            this.Label_UserHausnummer.TabIndex = 7;
            this.Label_UserHausnummer.Text = "Hausnummer*";
            // 
            // Label_UserStrasse
            // 
            this.Label_UserStrasse.AutoSize = true;
            this.Label_UserStrasse.Location = new System.Drawing.Point(7, 154);
            this.Label_UserStrasse.Name = "Label_UserStrasse";
            this.Label_UserStrasse.Size = new System.Drawing.Size(61, 17);
            this.Label_UserStrasse.TabIndex = 6;
            this.Label_UserStrasse.Text = "Strasse*";
            // 
            // Label_UserEMail
            // 
            this.Label_UserEMail.AutoSize = true;
            this.Label_UserEMail.Location = new System.Drawing.Point(7, 127);
            this.Label_UserEMail.Name = "Label_UserEMail";
            this.Label_UserEMail.Size = new System.Drawing.Size(52, 17);
            this.Label_UserEMail.TabIndex = 5;
            this.Label_UserEMail.Text = "E-Mail*";
            // 
            // Label_UserNachname
            // 
            this.Label_UserNachname.AutoSize = true;
            this.Label_UserNachname.Location = new System.Drawing.Point(7, 73);
            this.Label_UserNachname.Name = "Label_UserNachname";
            this.Label_UserNachname.Size = new System.Drawing.Size(76, 17);
            this.Label_UserNachname.TabIndex = 4;
            this.Label_UserNachname.Text = "Nachname";
            // 
            // Label_UserVorname
            // 
            this.Label_UserVorname.AutoSize = true;
            this.Label_UserVorname.Location = new System.Drawing.Point(7, 46);
            this.Label_UserVorname.Name = "Label_UserVorname";
            this.Label_UserVorname.Size = new System.Drawing.Size(70, 17);
            this.Label_UserVorname.TabIndex = 3;
            this.Label_UserVorname.Text = "Vorname*";
            // 
            // comboBox_ErwerbArt
            // 
            this.comboBox_ErwerbArt.FormattingEnabled = true;
            this.comboBox_ErwerbArt.Location = new System.Drawing.Point(366, 43);
            this.comboBox_ErwerbArt.Name = "comboBox_ErwerbArt";
            this.comboBox_ErwerbArt.Size = new System.Drawing.Size(121, 24);
            this.comboBox_ErwerbArt.TabIndex = 26;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(366, 127);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(18, 17);
            this.checkBox1.TabIndex = 27;
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(366, 94);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(121, 22);
            this.dateTimePicker1.TabIndex = 29;
            // 
            // maskedTextBox_KontoNr
            // 
            this.maskedTextBox_KontoNr.Location = new System.Drawing.Point(366, 70);
            this.maskedTextBox_KontoNr.Name = "maskedTextBox_KontoNr";
            this.maskedTextBox_KontoNr.Size = new System.Drawing.Size(121, 22);
            this.maskedTextBox_KontoNr.TabIndex = 30;
            // 
            // AddUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.groupBox1);
            this.Name = "AddUser";
            this.Text = "Neuer User";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem addUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label Label_UserStrasse;
        private System.Windows.Forms.Label Label_UserEMail;
        private System.Windows.Forms.Label Label_UserNachname;
        private System.Windows.Forms.Label Label_UserVorname;
        internal System.Windows.Forms.DateTimePicker DateTimePicker_UserGebDat;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_Land;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_Ort;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_PLZ;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_Hausnummer;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_Strasse;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_Email;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_Nachname;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_Vorname;
        private System.Windows.Forms.Label Label_UserLand;
        private System.Windows.Forms.Label Label_UserIsAdmin;
        private System.Windows.Forms.Label Label_UserAblaufDat;
        private System.Windows.Forms.Label Label_UserKonto;
        private System.Windows.Forms.Label Label_UserErwerbArt;
        private System.Windows.Forms.Label Label_UserGebDat;
        private System.Windows.Forms.Label Label_UserOrt;
        private System.Windows.Forms.Label Label_UserPLZ;
        private System.Windows.Forms.Label Label_UserHausnummer;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.ComboBox comboBox_ErwerbArt;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_KontoNr;
    }
}