//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace wcfMinIndustria.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Baches
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Baches()
        {
            this.ReporteDano = new HashSet<ReporteDano>();
        }
    
        public int IdBache { get; set; }
        public string Calle { get; set; }
        public string Distrito { get; set; }
        public string Tamano { get; set; }
        public string Posicion { get; set; }
        public string Usuario { get; set; }
        public string Prioridad { get; set; }
        public System.DateTime Fcreacion { get; set; }
        public string Estado { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ReporteDano> ReporteDano { get; set; }
    }
}
