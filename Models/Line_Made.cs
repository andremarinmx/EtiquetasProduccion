//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EtiquetasProduccion.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Line_Made
    {
        public int Id { get; set; }
        public string OrderNumber { get; set; }
        public Nullable<double> Height { get; set; }
        public Nullable<double> Width { get; set; }
        public Nullable<int> Line_ { get; set; }
        public Nullable<int> Pcs_Order { get; set; }
        public Nullable<int> Pcs_Box { get; set; }
        public Nullable<int> Status_ { get; set; }
    }
}
