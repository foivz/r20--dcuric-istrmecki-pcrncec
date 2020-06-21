using Clubbing.Podaci;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Validation;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clubbing.Modeli
{
    public class Obavijest
    {
        public int IDObavijest { get; set; }
        public string Opis { get; set; }
        public DateTime DatumObavijesti { get; set; }
        public Obavijest(string opis, DateTime datum)
        {
            Opis = opis;
            DatumObavijesti = datum;
        }
        public static List<Obavijest> DohvatiObavijestiKorisnika(Korisnik korisnik)
        {
            using(Entities entities = new Entities())
            {
                entities.Pratis.Load();
                entities.Obavijests.Load();

                var obavijestiKlubova = (from obavijestBaza in entities.Obavijests
                                         join p in entities.Pratis on obavijestBaza.fk_klub equals p.fk_klub
                                         where DateTime.Compare(p.datum, obavijestBaza.datum_obavijesti) < 0
                                         && obavijestBaza.vrsta == 1 && p.fk_korisnik == korisnik.IDKorisnik
                                         select obavijestBaza).ToList();
                if (obavijestiKlubova.Count > 0)
                {
                    List<Obavijest> listaObavijesti = new List<Obavijest>();
                    foreach (var obavijest in obavijestiKlubova)
                    {
                        listaObavijesti.Add(new Obavijest(obavijest.opis, obavijest.datum_obavijesti));
                    }
                    return listaObavijesti;
                }
                else
                {
                    return null;
                }
            }
        }
        public static List<Obavijest> DohvatiObavijestiAdmina(Korisnik korisnik)
        {
            using(Entities entities = new Entities())
            {
                entities.Obavijests.Load();
                Klub klubAdmina = korisnik.DohvatiKlubAdmina();
                var obavijestiAdmina = (from obavijestBaza in entities.Obavijests
                                        where obavijestBaza.fk_klub == klubAdmina.IDKlub
                                        && obavijestBaza.vrsta == 0
                                        select obavijestBaza).ToList();
                if (obavijestiAdmina.Count > 0)
                {
                    List<Obavijest> listaObavijesti = new List<Obavijest>();
                    foreach (var obavijest in obavijestiAdmina)
                    {
                        listaObavijesti.Add(new Obavijest(obavijest.opis, obavijest.datum_obavijesti));
                    }
                    return listaObavijesti;
                }
                else
                {
                    return null;
                }
            }
        }
        public int DodajObavijestUBazu(bool admin)
        {
            using(Entities entities = new Entities())
            {
                entities.Obavijests.Load();
                int fkKlub;
                if (admin)
                {
                    fkKlub = Korisnik.PrijavljeniKorisnik.DohvatiKlubAdmina().IDKlub;
                }
                else
                {
                    fkKlub = Klub.trenutniKlub.IDKlub;
                }
                Podaci.Obavijest novaObavijest = new Podaci.Obavijest()
                {
                    opis = this.Opis,
                    datum_obavijesti = this.DatumObavijesti,
                    fk_klub = fkKlub,
                    vrsta = (byte)(admin ? 1 : 0)
                };
                entities.Obavijests.Add(novaObavijest);
                entities.SaveChanges();
                return novaObavijest.id_obavijest;
            }
        }
    }
}
