//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WindowsFormsApp_FinalProject
{
    using System;
    using System.Collections.Generic;
    
    public partial class STOgrenci
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public STOgrenci()
        {
            this.STDersTakips = new HashSet<STDersTakip>();
        }
    
        public int Id { get; set; }
        public string AdSoyad { get; set; }
        public Nullable<System.DateTime> DogumTarih { get; set; }
        public Nullable<int> GirisTarih { get; set; }
        public int Bolum { get; set; }
        public string Gsm { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<STDersTakip> STDersTakips { get; set; }
    }
}