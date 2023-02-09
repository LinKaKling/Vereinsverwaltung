using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vereinsverwaltung
{
    class Kontobewegung
    {
        private int BewegNr { get; }
        private int SepaNr { get; }
        private int MitgliedNr { get; }
        private string IBAN { get; }
        private int BIC { get; }
        private string Kontoinhaber { get; }
        private double Betrag { get; }
        private DateTime Ausfuehrdatum { get; }
        private string Verwendungszweck { get; }
    }
}
