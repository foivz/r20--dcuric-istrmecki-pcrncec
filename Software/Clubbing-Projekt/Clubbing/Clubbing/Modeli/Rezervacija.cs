using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clubbing.Modeli
{
    public class Rezervacija
    {
        public int BrojLjudi { get; set; } // broj ljudi za jednu rezervaciju, npr 3
        public Stol Stol{ get; set; } // stol koji se rezervira, odabere se na formi
        public string Status { get; set; } // trenutni status rezervacije, može ju mijenjat jedino admin kluba
        // može biti Potvrđeno, Odbijeno i Na čekanju (čeka se da admin potvrdi ili odbije tu rezervaciju)
        public DateTime DatumRezervacije { get; set; }
        public Rezervacija(int brojLjudi, Stol stolZaRezervirati)
        {
            BrojLjudi = brojLjudi;
            Stol = stolZaRezervirati;
            Status = "Na čekanju"; // logično, na početku je status na čekanju tako dugo dok ga admin ne promijeni
            DatumRezervacije = DateTime.Now;
        }
        public void Potvrdi()
        {
            Status = "Potvrđeno";
        }
        public void Odbij()
        {
            Status = "Odbijeno";
        }
    }
}
