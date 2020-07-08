using Clubbing.Podaci;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using ClubbingClassLibrary;

namespace Clubbing.Modeli
{
    public class Klub
    {
        public int IDKlub { get; set; }
        public string ImeKluba { get; set; }
        public int MaxKapacitet { get; set; }
        public Image Logo { get; set; }
        public int FKZanr { get; set; }
        public ClubbingClassLibrary.Lokacija Lokacija { get; set; }
        public Korisnik AdminKluba { get; set; }

        public BindingList<Dogadjaj> Dogadjaji = new BindingList<Dogadjaj>();
        public List<Recenzija> Recenzije = new List<Recenzija>();
        public static BindingList<Klub> SviKlubovi = new BindingList<Klub>();
        public static Klub trenutniKlub;

        public Klub(string imeKluba, int maxKapacitet, Image logo, int fkZanr, Korisnik admin)
        {
            ImeKluba = imeKluba;
            MaxKapacitet = maxKapacitet;
            Logo = logo;
            FKZanr = fkZanr;
            AdminKluba = admin;
        }
        private void PostaviDogadjaje()
            // uzima dogadjaje iz baze za određeni klub i onda te događaje dodaje u listu događaja za taj klub
            // na isti način radi i PostaviRecenzije(), samo što tamo umjesto događaja dodaje recenzije za određeni klub
        {
            using(Entities entities = new Entities())
            {
                var listaDogadjajaBaza = (from k in entities.Klubs
                                        where k.id_klub==this.IDKlub
                                        select k.Dogadjajs).FirstOrDefault();
                foreach(Podaci.Dogadjaj dogadjajBaza in listaDogadjajaBaza)
                {
                    int id = dogadjajBaza.id_dogadjaj;
                    string naziv = dogadjajBaza.naziv;
                    string opis = dogadjajBaza.opis;
                    DateTime datumPocetka = dogadjajBaza.datum_pocetka;
                    DateTime datumZavrsetka = dogadjajBaza.datum_zavrsetka;
                    int cijenaUlaznice = dogadjajBaza.cijena_ulaznice;
                    int maxRezervacija = dogadjajBaza.max_rezervacija;
                    Dogadjaj dogadjaj = new Dogadjaj(naziv, opis, datumPocetka, datumZavrsetka, cijenaUlaznice, maxRezervacija);
                    dogadjaj.IDDogadjaj = id;
                    dogadjaj.PostaviSlike();
                    dogadjaj.PostaviRecenzije();
                    dogadjaj.PostaviStolove();
                    dogadjaj.PostaviRezervacije();
                    this.Dogadjaji.Add(dogadjaj);
                }
            }
        }
        private void PostaviRecenzije()
        {
            using (Entities entities = new Entities())
            {
                entities.Klubs.Load();
                var listaRecenzijaBaza = (from k in entities.Klubs
                                          where k.id_klub == this.IDKlub
                                          select k.Recenzijas).FirstOrDefault();
                foreach (Podaci.Recenzija recenzijaBaza in listaRecenzijaBaza)
                {
                    int ocjena = recenzijaBaza.ocjena;
                    string opis = recenzijaBaza.opis;
                    Recenzija recenzija = new Recenzija(ocjena, opis , true);
                    recenzija.IDRecenzija = recenzijaBaza.id_recenzija;
                    this.Recenzije.Add(recenzija);
                }
            }
        }
        private void PostaviLokaciju()
        {
            using (Entities entities = new Entities())
            {
                entities.Klubs.Load();
                var lokacijaBaza = (from l in entities.Klubs
                                where l.id_klub == this.IDKlub
                                select l.Lokacija).FirstOrDefault();
                if (lokacijaBaza != null)
                {
                    this.Lokacija = new ClubbingClassLibrary.Lokacija(lokacijaBaza.grad, lokacijaBaza.ulica, lokacijaBaza.postanski_broj);
                    this.Lokacija.IDLokacija = lokacijaBaza.id_lokacija;
                }
                else
                {
                    this.Lokacija = null;
                }
            }
        }
        public int IzracunajProsjekOcjena()
        {
            // vraca prosjek svih ocjena neke recenzije
            if (this.Recenzije.Count == 0)
            {
                return 0;
            }
            else
            {
                double prosjek = this.Recenzije.Average(x => x.Ocjena);
                double zaokruzenoVise = Math.Ceiling(prosjek);
                if(zaokruzenoVise - prosjek <= 0.5)
                {
                    return (int)zaokruzenoVise;
                }
                else
                {
                    return (int)zaokruzenoVise - 1;
                }
            }
        }
        public static void PostaviSveKlubove()
        {
            // Dohvaća sve potrebne podatke iz baze i postavlja te podatke i odgovajuće atribute
            // Uključuje i dohvaćanje podataka ostalih klasa (npr. događaji, status, recenzije...)
            SviKlubovi.Clear();
            using(Entities entities = new Entities())
            {
                entities.Klubs.Load();
                var klubovi = (from klub in entities.Klubs
                              select klub).ToList();
                foreach (var klub in klubovi)
                {

                    int idKlub = klub.id_klub;
                    string imeKluba = klub.naziv;
                    int maxKapacitet = klub.max_kapacitet;
                    int fkZanr = klub.fk_zanr;
                    MemoryStream ms = new MemoryStream(klub.logo);
                    Image logo = Image.FromStream(ms);
                    Korisnik admin = DohvatiAdmina(klub.Korisnik);
                    Klub noviKlub = new Klub(imeKluba, maxKapacitet, logo, fkZanr, admin);
                    noviKlub.IDKlub = idKlub;
                    noviKlub.PostaviDogadjaje();
                    noviKlub.PostaviRecenzije();
                    noviKlub.PostaviLokaciju();
                    SviKlubovi.Add(noviKlub);
                }
            }
        }

        private static Korisnik DohvatiAdmina(Podaci.Korisnik adminBaza)
        {
            // vraca novog korisnika koji je admin
            return new Korisnik(adminBaza.id_korisnik, adminBaza.ime, adminBaza.prezime, adminBaza.korisnicko_ime, adminBaza.lozinka, true);
        }
        public void ObrisiKlubIzBaze()
        {
            using (Entities entities = new Entities())
            {
                entities.Klubs.Load();
                var obrisaniKlub = (from klub in entities.Klubs
                                    where klub.id_klub == this.IDKlub
                                    select klub).First();
                entities.Klubs.Remove(obrisaniKlub);
                entities.SaveChanges();
            }
        }
        public int DodajKlubUBazu(Image logo)
        {
            MemoryStream ms = new MemoryStream();
            logo.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
            using (Entities entities = new Entities())
            {
                Podaci.Klub noviKlubBaza = new Podaci.Klub()
                {
                    naziv = this.ImeKluba,
                    max_kapacitet = this.MaxKapacitet,
                    logo = ms.ToArray(),
                    fk_zanr = this.FKZanr,
                    fk_admin = Korisnik.PrijavljeniKorisnik.IDKorisnik
                };
                entities.Klubs.Add(noviKlubBaza);
                entities.SaveChanges();
                return noviKlubBaza.id_klub;
            }
        }
        public int DodajLokacijuUBazu(string grad, string ulica, int postanskiBroj)
        {
            using (Entities entities = new Entities())
            {
                Podaci.Lokacija lokacija = new Podaci.Lokacija()
                {
                    grad = grad,
                    postanski_broj = postanskiBroj,
                    ulica = ulica,
                };
                entities.Lokacijas.Add(lokacija);

                entities.Klubs.Load();
                var klub = (from k in entities.Klubs
                            where k.id_klub == this.IDKlub
                            select k).First();
                klub.fk_lokacija = lokacija.id_lokacija;
                entities.SaveChanges();
                return lokacija.id_lokacija;
            }
        }
        public void AzurirajLokacijuUBazi()
        {
            using (Entities entities = new Entities())
            {
                entities.Lokacijas.Load();
                var lokacija = (from l in entities.Lokacijas
                                where l.id_lokacija == this.Lokacija.IDLokacija
                                select l).First();
                lokacija.grad = this.Lokacija.Grad;
                lokacija.postanski_broj = this.Lokacija.PostanskiBroj;
                lokacija.ulica = this.Lokacija.Ulica;
                entities.SaveChanges();
            }
        }
    }
}
