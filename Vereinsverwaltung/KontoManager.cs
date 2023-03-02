using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vereinsverwaltung
{
    internal class KontoManager
    {
        private string IBAN { get; }
        private string BIC { get; }
        private string Kontoinhaber { get; }
        private double Kontostand { get; }

       /* public Kontobewegung Beitragseinzug(int aSepaNr) //Übergabe von SEPA an Schnittstele
        {

            Kontobewegung kontobewegung = new Kontobewegung();


            return kontobewegung;
        }
       */
        public List<Kontobewegung> HoleKontobewegung (DateTime aVon, DateTime aBis)
        {
            List<Kontobewegung> aListe = new List<Kontobewegung>();


            return aListe;
        }
        /*
        public Kontobewegung Zahlungseingang (string aIBAN, string aBIC, int aMitgliedNr, double aBetrag, DateTime aAusfuhrungsdatum, string aVerwendungszweck)
        {
            Kontobewegung aKontobewegung = new Kontobewegung();
            
            return aKontobewegung;
        }
        */
    }
}
