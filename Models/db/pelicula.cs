//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProyectoDesarrWebU2.Models.db
{
    using System;
    using System.Collections.Generic;
    
    public partial class pelicula
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public pelicula()
        {
            this.detallefactura = new HashSet<detallefactura>();
        }
    
        public int idpel { get; set; }
        public string titulopel { get; set; }
        public Nullable<decimal> preciopel { get; set; }
        public string imgpel { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<detallefactura> detallefactura { get; set; }
    }
}