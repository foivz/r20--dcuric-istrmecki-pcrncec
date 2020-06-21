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
    public class Status
    {
        // status rezervacije
        public int IDStatus{ get; set; }
        public string Naziv { get; set; }

        public static List<Status> listaStatusa = new List<Status>();
        private Status(int id, string naziv)
        {
            IDStatus = id;
            Naziv = naziv;
        }
        public static void PopuniStatuse()
        {
            using (Entities entities = new Entities())
            {
                entities.StatusRezervacijes.Load();
                var statusi = (from status in entities.StatusRezervacijes
                               select status).ToList();
                foreach (var status in statusi)
                {
                    listaStatusa.Add(new Status(status.id_status, status.naziv));
                }
            }
        }
        public static int DohvatiIDStatusa(string nazivStatusa)
        {
            using(Entities entities = new Entities())
            {
                entities.StatusRezervacijes.Load();
                int idStatus = (from status in entities.StatusRezervacijes
                                where status.naziv == nazivStatusa
                                select status.id_status).First();
                return idStatus;
            }
        }
        public override string ToString()
        {
            return this.Naziv;
        }
    }
}
