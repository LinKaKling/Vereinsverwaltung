using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vereinsverwaltung
{
    public class Kontobewegung
    {
        private int BewegNr { get; set; }
        private int SepaNr { get; }
        private int MitgliedNr { get; }
        private string IBAN { get; }
        private int BIC { get; }
        private string Kontoinhaber { get; }
        private double Betrag { get; }
        private DateTime Ausfuehrdatum { get; }
        private string Verwendungszweck { get; }

       /* public Kontobewegung(int bewegNr, int sepaNr, int mitgliedNr, string iBAN, int bIC, string kontoinhaber, double betrag, DateTime ausfuehrdatum, string verwendungszweck)
        {
            BewegNr = bewegNr;
            SepaNr = sepaNr;
            MitgliedNr = mitgliedNr;
            IBAN = iBAN;
            BIC = bIC;
            Kontoinhaber = kontoinhaber;
            Betrag = betrag;
            Ausfuehrdatum = ausfuehrdatum;
            Verwendungszweck = verwendungszweck;
        }*/
    }
}
