//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Proyecto_Final.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Asentamiento
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Asentamiento()
        {
            this.Empleado = new HashSet<Empleado>();
        }
    
        public int idAsentamiento { get; set; }
        public int id { get; set; }
        public string descripcion { get; set; }
        public string codigoPostal { get; set; }
        public int idTipoDeAsentamiento { get; set; }
        public int idMunicipio { get; set; }
        public Nullable<int> idZona { get; set; }
        public Nullable<bool> estatus { get; set; }
        public Nullable<int> idUsuarioCrea { get; set; }
        public Nullable<System.DateTime> fechaCrea { get; set; }
        public Nullable<int> idUsuarioModifica { get; set; }
        public Nullable<System.DateTime> fechaModifica { get; set; }
    
        public virtual Municipio Municipio { get; set; }
        public virtual TipoDeAsentamiento TipoDeAsentamiento { get; set; }
        public virtual Usuario Usuario { get; set; }
        public virtual Usuario Usuario1 { get; set; }
        public virtual Zona Zona { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Empleado> Empleado { get; set; }
    }
}
