using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clubbing.Modeli
{
    public abstract class Lokacija
    {
        // ovo je apstraktna klasa jer postoji samo jedna jedina lokacija za klub
        // zbog toga je stavljeni statički atribut lokacija, a klasa postavljena na apstraktnu
        // na početku lokacija nema svoje vrijednosti, pa je bitno 'dodati' lokaciju, odnosno postaviti vrijednosti u njezin statički atribut
        // nakon toga je moguća izmjena lokacije na formi predviđenoj za tu akciju
        private string Grad { get; set; }
        private string Ulica { get; set; }
        private int PostanskiBroj { get; set; }
        public static Lokacija lokacija;
        public Lokacija()
        {

        }
        public void PostaviLokaciju(string grad, string ulica, int postanskiBroj)
        {
            lokacija.Grad = grad;
            lokacija.Ulica = ulica;
            lokacija.PostanskiBroj = postanskiBroj;
        }
        public void prikaziLokaciju()
        {
            // prikazuje lokaciju kluba na način da se u panelu prikaže karta i na njoj označi lokacija kluba
            // njezina svrha je da korisnik na jednostavan način može vidjeti gdje se nalazi pojedini klub 
        }
    }
}
