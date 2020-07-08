using System.Linq;
using System.Text;

namespace ClubbingClassLibrary
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
    }
}
