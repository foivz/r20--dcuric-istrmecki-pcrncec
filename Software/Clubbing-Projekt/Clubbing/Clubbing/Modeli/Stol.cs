using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clubbing.Modeli
{
    public class Stol
    {
        public string NazivLokacije { get; set; } // nema nekog posebnog pravila oko nazivanja lokacije
        // moze biti npr. ulaz lijevo, sank sredina, sank lijevo i slicno
        public int MaxMjesta { get; set; } // maksimalni broj mjesta koji može biti za stolom, npr 6
        public Stol(string nazivLokacijeStola, int maxMjesta)
        {
            if (ValidacijaStola())
            {
                NazivLokacije = nazivLokacijeStola;
                MaxMjesta = maxMjesta;
            }
        }
        private bool ValidacijaStola()
        {
            // metoda koja se koristi neposredno prije dodavanja novog stola (novog objekta klase) kako bi se eventualno zabranilo dodavanje novog stola
            // usporedba kapaciteta kluba/dogadjaja i maxMjesta
            // jedan stol = jedna rezervacija
            // usporedba maxRezervacija (klasa Dogadjaj) s trenutnim brojem stolova na nekom dogadjaju, tj. atributom TrenutniStolovi (count liste)
            return false;
        }
    }
}
