//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HotelAutomation
{
    using System;
    using System.Collections.Generic;
    
    public partial class kullanici
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public kullanici()
        {
            this.islemler = new HashSet<islemler>();
            this.rezervasyon = new HashSet<rezervasyon>();
        }
    
        public int kullanici_id { get; set; }
        public string kullanici_adi { get; set; }
        public string sifre { get; set; }
        public Nullable<int> yetki_id { get; set; }
        public Nullable<System.DateTime> olusturmaTarihi { get; set; }
        public Nullable<System.DateTime> guncellemeTarihi { get; set; }
        public Nullable<System.DateTime> silmeTarihi { get; set; }
        public Nullable<bool> aktifMi { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<islemler> islemler { get; set; }
        public virtual yetki_turu yetki_turu { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<rezervasyon> rezervasyon { get; set; }
    }
}
