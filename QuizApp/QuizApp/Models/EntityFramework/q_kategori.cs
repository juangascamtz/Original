//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QuizApp.Models.EntityFramework
{
    using System;
    using System.Collections.Generic;
    
    public partial class q_kategori
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public q_kategori()
        {
            this.q_soru = new HashSet<q_soru>();
        }
    
        public int kategoriId { get; set; }
        public string kategori { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<q_soru> q_soru { get; set; }
    }
}
