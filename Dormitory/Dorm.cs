//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Dormitory
{
    using System;
    using System.Collections.Generic;
    
    public partial class Dorm
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Dorm()
        {
            this.Blocks = new HashSet<Block>();
            this.DormPhones = new HashSet<DormPhone>();
            this.PublicPlaces = new HashSet<PublicPlace>();
        }
    
        public int DormNum { get; set; }
        public string DormName { get; set; }
        public int UniId { get; set; }
        public string DormAddress { get; set; }
        public string DormGender { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Block> Blocks { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DormPhone> DormPhones { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PublicPlace> PublicPlaces { get; set; }
        public virtual Uni Uni { get; set; }
    }
}
