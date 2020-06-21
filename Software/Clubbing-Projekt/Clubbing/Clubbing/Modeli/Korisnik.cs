using Clubbing.Podaci;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clubbing.Modeli
{
    public class Korisnik
    {
        public int IDKorisnik { get; set; }
        public string Ime{ get; set; }
        public string Prezime{ get; set; }
        public string KorisnickoIme{ get; set; }
        public string Lozinka{ get; set; }
        public bool Admin { get; set; }
        public List<Rezervacija> Rezervacije = new List<Rezervacija>(); // lista svih sadašnjih i prethodnih rezervacija korisnika

        public List<Klub> PraceniKlubovi = new List<Klub>(); // lista svih klubova koje korisnik prati (za koju želi dobivati obavijesti)
        
        public static Korisnik PrijavljeniKorisnik;

        public Korisnik(int id, string ime, string prezime, string korisnickoIme, string lozinka, bool admin)
        {
            IDKorisnik = id;
            Ime = ime;
            Prezime = prezime;
            KorisnickoIme = korisnickoIme;
            Lozinka = lozinka;
            Admin = admin;
        }
        public bool ZapratiKlub()
        {
            using (Entities entities = new Entities())
            {
                entities.Pratis.Load();

                var listaPrati = (from prati in entities.Pratis
                                 where prati.fk_klub == Klub.trenutniKlub.IDKlub && prati.fk_korisnik == this.IDKorisnik
                                 select prati).ToList();
                if(listaPrati.Count>0)
                {
                    return false;
                }
                else
                {
                    Prati novoPracenje = new Prati()
                    {
                        fk_klub = Klub.trenutniKlub.IDKlub,
                        fk_korisnik = this.IDKorisnik,
                        datum = DateTime.Now
                    };
                    entities.Pratis.Add(novoPracenje);
                    entities.SaveChanges();
                    return true;
                }
            }
        }
        public Klub DohvatiKlubAdmina()
        {
            if (this.Admin)
            { 
                return Klub.SviKlubovi.Where(klub => klub.AdminKluba.IDKorisnik == this.IDKorisnik).FirstOrDefault();
            }
            else
            {
                return null;
            }
        }
        public void PopuniPraceneKlubove()
        {
            using(Entities entities = new Entities())
            {
                entities.Pratis.Load();
                var mojiPraceniKlubovi = (from prati in entities.Pratis
                                          where prati.fk_korisnik==this.IDKorisnik
                                          select prati.fk_klub).ToList();
                foreach (Klub klub in Klub.SviKlubovi)
                {
                    if (mojiPraceniKlubovi.Contains(klub.IDKlub))
                    {
                        PraceniKlubovi.Add(klub);
                    }
                }
            }
        }
        public void PopuniRezervacije()
        {
            using (Entities entities = new Entities())
            {
                entities.Rezervacijas.Load();
                var mojeRezervacije = (from r in entities.Rezervacijas
                                   where r.fk_korisnik == PrijavljeniKorisnik.IDKorisnik
                                   select r.id_rezervacija).ToList();
                foreach (Klub klub in Klub.SviKlubovi)
                {
                    foreach (Dogadjaj dogadjaj in klub.Dogadjaji)
                    {
                        foreach (Rezervacija rezervacija in dogadjaj.Rezervacije)
                        {
                            if (mojeRezervacije.Contains(rezervacija.IDRezervacija))
                            {
                                Rezervacije.Add(rezervacija);
                            }
                        }
                    }
                }
            }
        }
        public BindingList<Dogadjaj> DohvatiKlijentoveDogadjaje()
        {
            using (Entities entities = new Entities())
            {
                entities.Stols.Load();
                var mojiDogadjaji = (from stol in entities.Stols
                                    where stol.Rezervacijas.Select(x=>x.fk_korisnik).FirstOrDefault() == IDKorisnik
                                    select stol.Dogadjaj.id_dogadjaj).ToList();
                if (mojiDogadjaji.Count > 0)
                {
                    List<BindingList<Dogadjaj>> listaDogadjaja = Klub.SviKlubovi.Select(x => x.Dogadjaji).ToList();
                    BindingList<Dogadjaj> returnMe = new BindingList<Dogadjaj>();
                    foreach (var itemList in listaDogadjaja)
                    {
                        foreach (var dogadjaj in itemList)
                        {
                            if (mojiDogadjaji.Contains(dogadjaj.IDDogadjaj))
                            {
                                returnMe.Add(dogadjaj);
                            }
                        }
                    }
                    return returnMe;
                }
                else return null;
            }
        }
        public bool ValidacijaAutorizacijeKlub()
        {
            int trenutniKlubID = Klub.trenutniKlub.IDKlub;
            Klub klubAdmina = this.DohvatiKlubAdmina();
            if (klubAdmina != null)
            {
                return klubAdmina.IDKlub == trenutniKlubID;
            }
            else return false;
        }
        public bool ValidacijaAutorizacijeDogadjaj()
        {
            int trenutniDogadjajID = Dogadjaj.trenutniDogadjaj.IDDogadjaj;
            Klub klubAdmina = this.DohvatiKlubAdmina();
            if (klubAdmina != null)
            {
                return klubAdmina.Dogadjaji.Select(x=>x.IDDogadjaj).Contains(trenutniDogadjajID);
            }
            else return false;
        }
        public override string ToString()
        {
            return this.Ime + " " + this.Prezime;
        }
        
    }
}
