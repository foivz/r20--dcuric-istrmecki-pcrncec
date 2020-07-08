using Clubbing.Podaci;
using ClubbingClassLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clubbing.Modeli
{
    public class Dogadjaj
    {
        public int IDDogadjaj { get; set; }
        public string NazivDogadjaja { get; set; }
        public string Opis { get; set; }
        public DateTime DatumPocetka { get; set; }
        public DateTime DatumZavrsetka { get; set; }
        public int CijenaUlaznice { get; set; }

        public List<Image> SlikeDogadjaja = new List<Image>();

        public List<Rezervacija> Rezervacije = new List<Rezervacija>();
        public int MaxRezervacija { get; set; }

        public List<Recenzija> RecenzijeDogadjaja = new List<Recenzija>();

        public List<Stol> Stolovi = new List<Stol>(); // svi stolovi na nekom dogadjaju
       
        public static Dogadjaj trenutniDogadjaj; // trenutno odabrani dogadjaj na formi

        public Dogadjaj(string nazivDogadjaja, string opis, DateTime datumPocetka, DateTime datumZavrsetka, int cijenaUlazince, int maxRezervacija)
        {
            NazivDogadjaja = nazivDogadjaja;
            Opis = opis;
            DatumPocetka = datumPocetka;
            DatumZavrsetka = datumZavrsetka;
            CijenaUlaznice = cijenaUlazince;
            MaxRezervacija = maxRezervacija;
        }
        public List<Stol> DohvatiSlobodneStolove()
        {
            var slobodniStolovi = this.Stolovi.Where(x => x.Zauzeti(this) == false);
            if (slobodniStolovi != null)
            {
                return this.Stolovi.Where(x => x.Zauzeti(this) == false).ToList();
            }
            else
            {
                return null;
            }
        }
        public void DodajSlikuUBazu(Image slika)
        {
            MemoryStream ms = new MemoryStream();
            slika.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
            using(Entities entities = new Entities())
            {
                Slika novaSlika = new Slika()
                {
                    slika1 = ms.ToArray(),
                    fk_dogadjaj = this.IDDogadjaj
                };
                entities.Slikas.Add(novaSlika);
                entities.SaveChanges();
            }
        }
        public void PostaviSlike()
        {
         using (Entities entities = new Entities())
            {
                /* entities.Slikas.Load();
                 var listaSlikaDogadjaja = (from sl in entities.Slikas
                                                 where sl.fk_dogadjaj == this.IDDogadjaj
                                                 select sl.slika1).ToList();
                 foreach (var slika in listaSlikaDogadjaja)
                 {
                     MemoryStream ms = new MemoryStream(slika);
                     this.SlikeDogadjaja.Add(Image.FromStream(ms));
                 }*/
            }
        }
        public void PostaviRecenzije()
        {
            using (Entities entities = new Entities())
            {
                entities.Recenzijas.Load();
                var listaRecenzijaZaDogadjaj = (from rec in entities.Recenzijas
                                          where rec.fk_dogadjaj == this.IDDogadjaj
                                          select rec).ToList();
                foreach (Podaci.Recenzija recenzijaBaza in listaRecenzijaZaDogadjaj)
                {
                    Recenzija recenzija = new Recenzija(recenzijaBaza.ocjena, recenzijaBaza.opis, false);
                    recenzija.IDRecenzija = recenzijaBaza.id_recenzija;
                    this.RecenzijeDogadjaja.Add(recenzija);
                }
            }
        }
        public void PostaviStolove()
        {
            using (Entities entities = new Entities())
            {
                entities.Stols.Load();
                var listaStolova = (from s in entities.Stols
                                    where s.fk_dogadjaj == this.IDDogadjaj
                                    select s).ToList();
                foreach (Podaci.Stol stolBaza in listaStolova)
                {
                    Stol stol = new Stol(stolBaza.naziv_lokacije, stolBaza.max_mjesta);
                    stol.IDStol = stolBaza.id_stol;
                    this.Stolovi.Add(stol);
                }
            }
        }
        public void PostaviRezervacije()
        {
            Status.PopuniStatuse(); // mora se popuniti statička lista 'listaStatusa' iz baze kako bi se kasnije status rezervacije referencirao na neki element te liste
            using (Entities entities = new Entities())
            {
                entities.Rezervacijas.Load();
                var listaRezervacija = (from rez in entities.Rezervacijas
                                        where rez.Stol.fk_dogadjaj == this.IDDogadjaj
                                        select rez).ToList();
                foreach (Podaci.Rezervacija rezervacijaBaza in listaRezervacija)
                {
                    Stol stol = this.Stolovi.Where(x => x.IDStol == rezervacijaBaza.fk_stol).FirstOrDefault();
                    Rezervacija rezervacija = new Rezervacija(rezervacijaBaza.broj_ljudi, stol, rezervacijaBaza.datum_rezervacije, rezervacijaBaza.fk_status);
                    rezervacija.IDRezervacija = rezervacijaBaza.id_rezervacija;
                    this.Rezervacije.Add(rezervacija);
                }
            }
        }
        public static BindingList<Dogadjaj> DohvatiDogadjajeZaRezervaciju()
        {
            // dohvaca sve dogadjaje koji se mogu rezervirati (nadolazeci i ima slobodnih stolova)
            BindingList<Dogadjaj> dogadjaji = new BindingList<Dogadjaj>();
            foreach (Klub klub in Klub.SviKlubovi)
            {
                foreach (Dogadjaj dogadjaj in klub.Dogadjaji)
                {
                    if (DogadjajLib.Nadolazeci(dogadjaj.DatumPocetka) && dogadjaj.Rezervacije.Count != dogadjaj.Stolovi.Count)
                    {
                        dogadjaji.Add(dogadjaj);
                    }
                }
            }
            return dogadjaji;
        }
        public int DodajDogadjajUBazu()
        {
            using (Entities entities = new Entities())
            {
                Podaci.Dogadjaj dogadjaj = new Podaci.Dogadjaj()
                {
                    naziv = this.NazivDogadjaja,
                    opis = this.Opis,
                    datum_pocetka = this.DatumPocetka,
                    datum_zavrsetka = this.DatumZavrsetka,
                    cijena_ulaznice = this.CijenaUlaznice,
                    max_rezervacija = this.MaxRezervacija,
                    fk_klub = Korisnik.PrijavljeniKorisnik.DohvatiKlubAdmina().IDKlub
                };
                entities.Dogadjajs.Add(dogadjaj);
                entities.SaveChanges();
                return dogadjaj.id_dogadjaj;
            }
        }
        public void ObrisiDogadjajIzBaze()
        {
            using (Entities entities = new Entities())
            {
                entities.Dogadjajs.Load();
                var obrisaniDogadjaj = (from dogadjaj in entities.Dogadjajs
                                        where dogadjaj.id_dogadjaj == this.IDDogadjaj
                                        select dogadjaj).First();
                entities.Dogadjajs.Remove(obrisaniDogadjaj);
                entities.SaveChanges();
            }
        }
        public void AzurirajDogadjajUBazi()
        {
            using (Entities entities = new Entities())
            {
                entities.Dogadjajs.Load();
                var azuriraniDogadjaj = (from dogadjaj in entities.Dogadjajs
                                        where dogadjaj.id_dogadjaj == this.IDDogadjaj
                                        select dogadjaj).First();

                azuriraniDogadjaj.naziv = this.NazivDogadjaja;
                azuriraniDogadjaj.opis = this.Opis;
                azuriraniDogadjaj.cijena_ulaznice = this.CijenaUlaznice;
                azuriraniDogadjaj.max_rezervacija = this.MaxRezervacija;
                azuriraniDogadjaj.datum_pocetka = this.DatumPocetka;
                azuriraniDogadjaj.datum_zavrsetka = this.DatumZavrsetka;
                entities.SaveChanges();
            }
        }
    }
}
