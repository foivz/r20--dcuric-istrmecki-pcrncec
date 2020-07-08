using System;
using System.Collections.Generic;
using System.Text;

namespace ClubbingClassLibrary
{
    public static class DogadjajLib
    {
        public static bool Nadolazeci(DateTime datumPocetka)
        {
            // na temelju datumaPocetka se određuje da li je neki objekt klase dogadjaj nadolazeci ili ne
            // uspoređuje se s trenutnim datumom i vremenom
            int rez = DateTime.Compare(DateTime.Now, datumPocetka);
            return rez < 0;
        }
        public static bool Zavrseni(DateTime datumZavrsetka)
        {
            // na temelju datumaZavrsetka se određuje da li je neki objekt klase dogadjaj vec završen ili ne
            // uspoređuje se s trenutnim datumom i vremenom
            int rez = DateTime.Compare(DateTime.Now, datumZavrsetka);
            return rez > 0;
        }
    }
}
