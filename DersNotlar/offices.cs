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
    
    public partial class offices
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public offices()
        {
            this.workStations = new HashSet<workStations>();
            this.personnels = new HashSet<personnels>();
            this.workStationReservations = new HashSet<workStationReservations>();
        }
    
        public int id { get; set; }
        public string title { get; set; }
        public int workplaceId { get; set; }
    
        public virtual workplaces workplaces { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<workStations> workStations { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<personnels> personnels { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<workStationReservations> workStationReservations { get; set; }
    }
}
