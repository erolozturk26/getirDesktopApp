//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Alışveriş_Uygulaması
{
    using System;
    using System.Collections.Generic;
    
    public partial class Kullanicilar
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Kullanicilar()
        {
            this.Kullanici_Kontrol = false;
        }
    
        public int KullaniciID { get; set; }
        public string Kullanici_Adi { get; set; }
        public string Sifre { get; set; }
        public string Mail_Adresi { get; set; }
        public Nullable<bool> Kullanici_Kontrol { get; set; }
    }
}
