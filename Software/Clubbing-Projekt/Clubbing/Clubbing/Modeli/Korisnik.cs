using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clubbing.Modeli
{
    public class Korisnik
    {
        public string Ime{ get; set; }
        public string Prezime{ get; set; }
        public string KorisnickoIme{ get; set; }
        public string Lozinka{ get; set; }
        public bool Admin { get; set; }
        public List<Rezervacija> Rezervacije{ get; set; } // lista svih sadašnjih i prethodnih rezervacija korisnika
        public List<Klub> PraceniKlubovi{ get; set; } // lista svih klubova koje korisnik prati (za koju želi dobivati obavijesti)
        
        public Korisnik(string ime, string prezime, string korisnickoIme, string lozinka, bool admin)
        {
            Ime = ime;
            Prezime = prezime;
            KorisnickoIme = korisnickoIme;
            Lozinka = lozinka;
            Admin = admin;
        }

        public List<Obavijest> DohvatiObavijesti()
        {
            // dohvaća iz baze sve obavijesti za određenog korisnika za daljnu upotrebu
            return new List<Obavijest>();
        }

    }
}
