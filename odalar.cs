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
    
    public partial class odalar
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public odalar()
        {
            this.rezervasyon = new HashSet<rezervasyon>();
        }
    
        public int id { get; set; }
        public Nullable<int> oda_no { get; set; }
        public Nullable<bool> oda_durum { get; set; }
        public Nullable<int> kisi_sayisi { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<rezervasyon> rezervasyon { get; set; }
    }
}