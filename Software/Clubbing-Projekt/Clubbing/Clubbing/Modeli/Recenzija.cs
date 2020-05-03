using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clubbing.Modeli
{
    public class Recenzija
    {
        public int Ocjena { get; set; } // ocjena recenzije, može biti 1-5
        public string Opis { get; set; } // tekstualni dio recenzije
        public bool ZaKlub { get; set; } // true ako je općenita recenzija za klub, false ako je za konkretni događaj
        public Recenzija(int ocjena, string opis, bool zaKlub)
        {
            // recenzija je valjana samo ako je i njezina ocjena valjana, tj. između 1 i 5
            if (ocjena >= 1 && ocjena <= 5)
            {
                Ocjena = ocjena;
                Opis = opis;
                ZaKlub = zaKlub;
            }
        }
    }
}
