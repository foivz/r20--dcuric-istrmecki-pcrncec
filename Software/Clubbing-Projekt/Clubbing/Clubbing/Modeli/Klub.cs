using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clubbing.Modeli
{
    public class Klub
    {
        public string ImeKluba { get; set; }
        public int MaxKapacitet { get; set; }
        public Lokacija Kokacija { get; set; }
        public List<Image> SlikeKluba{ get; set; }
        public List<Dogadjaj> Dogadjaji{ get; set; }
        public static BindingList<Klub> SviKlubovi{ get; set; }
        public static Klub KlubAdmina{ get; set; }
        public List<Recenzija> Recenzije{ get; set; }

        public Klub(string imeKluba, int maxKapacitet)
        {
            ImeKluba = imeKluba;
            MaxKapacitet = maxKapacitet;
        }

        private void DodajNovuSliku(string nazivDatoteke)
        {
            // dodaje novu sliku u listu slikeKluba uz pomoc koje se u galeriji prikazuju slike
        }
        private void UcitajSlike()
        {
            // ucitava slike u listu slikeKluba
        }
        private int IzracunajProsjekOcjena()
        {
            // vraca prosjek svih ocjena u listi recenzije
            return 0;
        }
    }
}
