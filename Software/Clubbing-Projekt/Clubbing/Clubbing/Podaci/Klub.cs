//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Clubbing.Podaci
{
    using System;
    using System.Collections.Generic;
    
    public partial class Klub
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Klub()
        {
            this.Dogadjajs = new HashSet<Dogadjaj>();
            this.Obavijests = new HashSet<Obavijest>();
            this.Pratis = new HashSet<Prati>();
            this.Recenzijas = new HashSet<Recenzija>();
        }
    
        public int id_klub { get; set; }
        public string naziv { get; set; }
        public int max_kapacitet { get; set; }
        public byte[] logo { get; set; }
        public int fk_zanr { get; set; }
        public Nullable<int> fk_lokacija { get; set; }
        public int fk_admin { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Dogadjaj> Dogadjajs { get; set; }
        public virtual Korisnik Korisnik { get; set; }
        public virtual Lokacija Lokacija { get; set; }
        public virtual Zanr Zanr { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Obavijest> Obavijests { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Prati> Pratis { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Recenzija> Recenzijas { get; set; }
    }
}