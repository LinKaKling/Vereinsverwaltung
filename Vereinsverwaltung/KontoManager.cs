using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vereinsverwaltung
{
    class KontoManager
    {
        private string IBAN { get; }
        private string BIC { get; }
        private string Kontoinhaber { get; }
        private double Kontostand { get; }

        public Kontobewegung Beitragseinzug(int aSepaNr)
        {
            Kontobewegung aKontobewegung = new Kontobewegung();

            return aKontobewegung;
        }

        public List<Kontobewegung> HoleKontobewegung (DateTime aVon, DateTime aBis)
        {
            List<Kontobewegung> aListe = new List<Kontobewegung>();

            return aListe;
        }
        
        public Kontobewegung Zahlungseingang (string aIBAN, string aBIC, int aMitgliedNr, double aBetrag, DateTime aAusfuhrungsdatum, string aVerwendungszweck)
        {
            Kontobewegung kontobewegung = new Kontobewegung();
            return
        }

    }
}
