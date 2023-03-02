using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vereinsverwaltung
{
    public class Vereinsmitglied
    {
        private int MitgliederNr { get; }
        private string Nachname { get; }
        private string Vorname;
        private string Mail;
        private string Adresse;
        private int Geburtsjahr;
        private int JobTyp;
        private bool Sepa;
        private int Telefon;
        private string Land;


        public Vereinsmitglied(int mitgliederNr, string nachname, string vorname, string mail, string adresse, int geburtsjahr, int jobTyp, bool sepa, int telefon, string land)
        {
            MitgliederNr = mitgliederNr;
            Nachname = nachname;
            Vorname = vorname;
            Mail = mail;
            Adresse = adresse;
            Geburtsjahr = geburtsjahr;
            JobTyp = jobTyp;
            Sepa = sepa;
            Telefon = telefon;
            Land = land;

        }
    }
}
