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
        private string Strasse;
        private string Hausnummer;
        private string PLZ;
        private string Ort;
        private string Geburtsdatum;
        private int JobTyp;
        private string Land;
        private string Konto;
        private bool IsAdmin;
        private string ErstellDat;
        private string AblaufDat;
        private bool Sepa;
        private string Telefon;


        public Vereinsmitglied(int mitgliederNr, string nachname, string vorname, string mail, string strasse, string hausnummer, string pLZ, string ort, string geburtsdatum, int jobTyp, string land, string konto, bool isAdmin, string erstellDat, string ablaufDat, bool sepa, string telefon)
        {
            MitgliederNr = mitgliederNr;
            Nachname = nachname;
            Vorname = vorname;
            Mail = mail;
            Strasse = strasse;
            Hausnummer = hausnummer;
            PLZ = pLZ;
            Ort = ort;
            Geburtsdatum = geburtsdatum;
            JobTyp = jobTyp;
            Land = land;
            Konto = konto;
            IsAdmin = isAdmin;
            ErstellDat = erstellDat;
            AblaufDat = ablaufDat;
            Sepa = sepa;
            Telefon = telefon;
        }
    }
}
