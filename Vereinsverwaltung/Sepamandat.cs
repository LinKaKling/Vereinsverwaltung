using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vereinsverwaltung
{
    public class Sepamandat
    {
        private int SepaNr { get; }
        private int MitgliederNr { get; }
        private string IBAN { get; }
        private string BIC { get; }
        private string BankInst { get; }
        private DateTime StartDate {get;}

    }
}
