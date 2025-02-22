//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace iCAREWebExperiment.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class iCAREUser
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public iCAREUser()
        {
            this.DocumentMetadata = new HashSet<DocumentMetadata>();
            this.DocumentMetadata1 = new HashSet<DocumentMetadata>();
        }
    
        public string ID { get; set; }
        public string userName { get; set; }
        public string name { get; set; }
        public string email { get; set; }
        public DateTime registrationDate { get; set; }
        public string roleID { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DocumentMetadata> DocumentMetadata { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DocumentMetadata> DocumentMetadata1 { get; set; }
        public virtual iCAREAdmin iCAREAdmin { get; set; }
        public virtual iCAREWorker iCAREWorker { get; set; }
        public virtual UserPassword UserPassword { get; set; }
        public virtual UserRole UserRole { get; set; }
    }
}
