using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clubbing.Modeli
{
    public class Dogadjaj
    {
        public string NazivDogadjaja { get; set; }
        public string Opis { get; set; }
        public DateTime DatumPocetka { get; set; }
        public DateTime DatumZavrsetka { get; set; }
        public int CijenaUlaznice { get; set; }
        public List<Image> SlikeDogadjaja{ get; set; }
        public List<Rezervacija> Rezervacije { get; set; }
        public int MaxRezervacija { get; set; }
        public List<Recenzija> RecenzijeDogadjaja { get; set; }
        public List<Stol> Stolovi { get; set; } // svi stolovi na nekom dogadjaju
        public List<Stol> TrenutniStolovi { get; set; } // trenutno rezervirani stolovi za neki dogadjaj

        public Dogadjaj(string nazivDogadjaja, string opis, DateTime datumPocetka, DateTime datumZavrsetka, int cijenaUlazince, int maxRezervacija)
        {
            NazivDogadjaja = nazivDogadjaja;
            Opis = opis;
            DatumPocetka = datumPocetka;
            DatumZavrsetka = DatumZavrsetka;
            CijenaUlaznice = cijenaUlazince;
            MaxRezervacija = maxRezervacija;
        }
        public double IzracunajTrajanje()
        {
            // izracunava se trajanje nekog dogadjaja u satima (npr 5.5h)
            return 1.0;
        }
        public bool Zavrsen()
        {
            // na temelju datumaZavrsetka se određuje da li je neki objekt klase dogadjaj vec završen
            // uspoređuje se s trenutnim datumom i vremenom
            return false;
        }
        public void DodajNovuSliku(string nazivDatoteke)
        {
            // ako postoji datoteka s nazivom zadanog u parametru (nazivDatoteke) i ako je to datoteka koja je slika (npr .jpg)
            // onda se ta slika dodaje u varijablu slikeDogadjaja objekta ove klase
        }
        private void UcitajSlike()
        {  
            // služi za učitavanje svih slika koje postoje u datoteci u varijablu slikeDogadjaja 
        }
        public bool Popunjeno()
        {
            // provjerava ako je neki dogadjaj (objekt klase Dogadjaj) popunjen
            // provjerava se da li je dosegnut maksimalan broj rezervacija ili pak maksimalni kapacitet kluba koji organizira taj dogadjaj
            return false;
        }
    }
}
