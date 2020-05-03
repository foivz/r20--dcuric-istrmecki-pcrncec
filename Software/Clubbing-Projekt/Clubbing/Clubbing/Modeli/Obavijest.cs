using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clubbing.Modeli
{
    public class Obavijest
    {
        public string Opis { get; set; } // detaljni opis određene rezervacije, može biti bilo kakav tekst
        public DateTime DatumObavijesti { get; set; }

        public Obavijest(string opis)
        {
            Opis = opis;
            DatumObavijesti = DateTime.Now;
        }
    }
}
