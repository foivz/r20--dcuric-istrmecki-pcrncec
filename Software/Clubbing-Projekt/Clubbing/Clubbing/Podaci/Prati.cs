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
    
    public partial class Prati
    {
        public int fk_klub { get; set; }
        public int fk_korisnik { get; set; }
        public System.DateTime datum { get; set; }
    
        public virtual Klub Klub { get; set; }
        public virtual Korisnik Korisnik { get; set; }
    }
}
