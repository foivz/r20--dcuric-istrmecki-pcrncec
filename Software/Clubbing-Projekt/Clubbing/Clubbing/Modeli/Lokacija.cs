using Clubbing.Podaci;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clubbing.Modeli
{
    public class Lokacija
    {
        public int IDLokacija { get; set; }
        public string Grad { get; set; }
        public string Ulica { get; set; }
        public int PostanskiBroj { get; set; }
        public Lokacija(string grad, string ulica, int postanskiBroj)
        {
            Grad = grad;
            Ulica = ulica;
            PostanskiBroj = postanskiBroj;
        }
        public string DohvatiGMUpit()
        {
            StringBuilder returnMe = new StringBuilder();
            returnMe.Append("http://maps.google.com/maps?q=");
            returnMe.Append(this.Ulica + "+");
            returnMe.Append(this.PostanskiBroj + "+");
            returnMe.Append(this.Grad);
            //returnMe.Append("&output = embed");
            return returnMe.ToString();
        }
        public int DodajLokacijuUBazu()
        {
            using(Entities entities = new Entities())
            {
                Podaci.Lokacija lokacija = new Podaci.Lokacija()
                {
                  grad = this.Grad,
                  postanski_broj = this.PostanskiBroj,
                  ulica = this.Ulica,
                };
                entities.Lokacijas.Add(lokacija);

                entities.Klubs.Load();
                var klub = (from k in entities.Klubs
                            where k.id_klub == Klub.trenutniKlub.IDKlub
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
                                where l.id_lokacija == this.IDLokacija
                                select l).First();
                lokacija.grad = this.Grad;
                lokacija.postanski_broj = this.PostanskiBroj;
                lokacija.ulica = this.Ulica;
                entities.SaveChanges();
            }
        }
    }
}
