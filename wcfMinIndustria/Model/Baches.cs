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
            this.InformeBache = new HashSet<InformeBache>();
            this.ReporteDano = new HashSet<ReporteDano>();
        }
    
        public int IdBache { get; set; }
        public string Calle { get; set; }
        public string Distrito { get; set; }
        public string Tamano { get; set; }
        public string Posicion { get; set; }
        public int Usuario { get; set; }
        public int Prioridad { get; set; }
    
        public virtual Usuarios Usuarios { get; set; }
        public virtual Prioridad Prioridad1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<InformeBache> InformeBache { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ReporteDano> ReporteDano { get; set; }
    }
}
