//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MiniPIM
{
    using System;
    using System.Collections.Generic;
    
    public partial class RelacionProducto
    {
        public string producto_sku_principal { get; set; }
        public string nombre_relacion { get; set; }
        public string producto_sku_relacionado { get; set; }
    
        public virtual Producto Producto { get; set; }
        public virtual Producto Producto1 { get; set; }
        public virtual Relacion Relacion { get; set; }
    }
}
