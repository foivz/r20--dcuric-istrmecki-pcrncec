using Clubbing.Podaci;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Clubbing.Modeli
{
    public class Rezervacija
    {
        public int IDRezervacija { get; set; }
        public int BrojLjudi { get; set; } // broj ljudi za jednu rezervaciju, npr 3
        public Stol Stol{ get; set; } // stol koji se rezervira, odabere se na formi
        public Status Status { get; set; } // trenutni status rezervacije, može ju mijenjat jedino admin kluba
        // može biti Potvrđeno, Odbijeno i Na čekanju (čeka se da admin potvrdi ili odbije tu rezervaciju)
        public DateTime DatumRezervacije { get; set; }
        public Rezervacija(int brojLjudi, Stol stolZaRezervirati, DateTime dateTime, int fkStatus)
        {
            BrojLjudi = brojLjudi;
            Stol = stolZaRezervirati;
            DatumRezervacije = dateTime;
            // ako je parametar fkStatus = 0 onda to znači da se radi nova rezervacija koja ne postoji u bazi i njezin status je na čekanju
            // u suprotnom, postojeca rezervacija se dohvaca iz baze i more se znati njezin FK kako bi se mogao postaviti odgovarajući status
            // nikad se ne kreira novi status, već se samo na početku učitavaju postojeći statusi (3) iz baze i postavljaju u statičku listu, a atribut Status ove klase je samo referenca na neki od njih
            if (fkStatus == 0)
            {
                Status = Status.listaStatusa.Where(x => x.Naziv == "Na čekanju").FirstOrDefault(); // logično, na početku je status na čekanju tako dugo dok ga admin ne promijeni
            }
            else
            {
                Status = Status.listaStatusa.Where(x => x.IDStatus == fkStatus).FirstOrDefault();
            }
        }
        public void Potvrdi()
        {
            Status = Status.listaStatusa.Where(x => x.Naziv == "Potvrđeno").FirstOrDefault();
            using(Entities entities = new Entities())
            {
                entities.Rezervacijas.Load();
                var fkStatusRezervacije= (from rez in entities.Rezervacijas
                                   where rez.id_rezervacija == this.IDRezervacija
                                   select rez).First();
                fkStatusRezervacije.fk_status = Status.DohvatiIDStatusa("Potvrđeno");
                entities.SaveChanges();
            }
        }
        public void Odbij()
        {
            Status = Status.listaStatusa.Where(x => x.Naziv == "Odbijeno").FirstOrDefault();
            using (Entities entities = new Entities())
            {
                entities.Rezervacijas.Load();
                var fkStatusRezervacije = (from rez in entities.Rezervacijas
                                           where rez.id_rezervacija == this.IDRezervacija
                                           select rez).First();
                fkStatusRezervacije.fk_status = Status.DohvatiIDStatusa("Odbijeno");
                entities.SaveChanges();
            }
        }
        public string DohvatiImeKorisnika()
        {
            using(Entities entities = new Entities())
            {
                entities.Korisniks.Load();
                var korisnik = (from kor in entities.Korisniks
                                where kor.Rezervacijas.Select(x=>x.id_rezervacija).Contains(this.IDRezervacija)
                                select kor).First();
                return korisnik.ime + " " + korisnik.prezime;
            }
        }
        public string DohvatiImeDogađaja()
        {
            foreach (var klub in Klub.SviKlubovi)
            {
                foreach (Dogadjaj dogadjaj in klub.Dogadjaji)
                {
                    if (dogadjaj.Rezervacije.Contains(this))
                    {
                        return dogadjaj.NazivDogadjaja;
                    }
                }
            }
            return "";
        }
        public int DodajRezervacijuUBazu()
        {
            using (Entities entities = new Entities())
            {
                Podaci.Rezervacija rezervacija = new Podaci.Rezervacija()
                {
                    broj_ljudi = this.BrojLjudi,
                    datum_rezervacije = this.DatumRezervacije,
                    fk_korisnik = Korisnik.PrijavljeniKorisnik.IDKorisnik,
                    fk_status = this.Status.IDStatus,
                    fk_stol = this.Stol.IDStol
                };
                entities.Rezervacijas.Add(rezervacija);
                entities.SaveChanges();
                return rezervacija.id_rezervacija;
            }
        }
    }
}
