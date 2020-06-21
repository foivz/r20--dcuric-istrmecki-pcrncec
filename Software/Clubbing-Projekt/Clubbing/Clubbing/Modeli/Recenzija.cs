using Clubbing.Forme;
using Clubbing.Podaci;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clubbing.Modeli
{
    public class Recenzija
    {
        public int IDRecenzija { get; set; }
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

        public int DodajRecenzijuKlubUBazu()
        {
            using(Entities entities = new Entities())
            {
                Podaci.Recenzija recenzija = new Podaci.Recenzija()
                {
                    fk_klub = Klub.trenutniKlub.IDKlub,
                    ocjena = this.Ocjena,
                    opis = this.Opis
                };
                entities.Recenzijas.Add(recenzija);
                entities.SaveChanges();
                return recenzija.id_recenzija;
            }
        }

        public int DodajRecenzijuDogadjajUBazu()
        {
            using (Entities entities = new Entities())
            {
                Podaci.Recenzija recenzija = new Podaci.Recenzija()
                {
                    fk_dogadjaj = Dogadjaj.trenutniDogadjaj.IDDogadjaj,
                    ocjena = this.Ocjena,
                    opis = this.Opis
                };
                entities.Recenzijas.Add(recenzija);
                entities.SaveChanges();
                return recenzija.id_recenzija;
            }
        }
    }
}
