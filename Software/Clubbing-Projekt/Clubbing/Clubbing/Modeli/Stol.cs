using Clubbing.Forme;
using Clubbing.Podaci;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clubbing.Modeli
{
    public class Stol
    {
        public int IDStol { get; set; }
        public string NazivLokacije { get; set; } // nema nekog posebnog pravila oko nazivanja lokacije
        // moze biti npr. ulaz lijevo, sank sredina, sank lijevo i slicno
        public int MaxMjesta { get; set; } // maksimalni broj mjesta koji može biti za stolom, npr 6
        public Stol(string nazivLokacijeStola, int maxMjesta)
        {
            NazivLokacije = nazivLokacijeStola;
            MaxMjesta = maxMjesta;
        }
        public int DodajStolUBazu()
        {
            using (Entities entities = new Entities())
            {
                Podaci.Stol noviStol = new Podaci.Stol()
                {
                    naziv_lokacije = this.NazivLokacije,
                    max_mjesta = this.MaxMjesta,
                    fk_dogadjaj = Dogadjaj.trenutniDogadjaj.IDDogadjaj
                };
                entities.Stols.Add(noviStol);
                entities.SaveChanges();
                return noviStol.id_stol;
            }
        }
        public bool Zauzeti(Dogadjaj dogadjaj)
        {
            foreach (Rezervacija rezervacija in dogadjaj.Rezervacije)
            {
                if (rezervacija.Stol.IDStol == this.IDStol && rezervacija.Status.Naziv != "Odbijeno") return true;
            }
            return false;
        }
        public override string ToString()
        {
            return this.NazivLokacije + " | max mjesta: " + this.MaxMjesta;
        }
    }
}
