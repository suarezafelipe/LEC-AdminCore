using System;
using System.Collections.Generic;

namespace AdminCore.BusinessLogic.Products.Models
{
    public partial class DescripcionProducto
    {
        public string TipoDescripcion { get; set; }
        public int IdProducto { get; set; }
        public string CodIsoIdioma { get; set; }
        public string NombreProdTraducido { get; set; }
        public string DescCorta { get; set; }
        public string DescLarga { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public DateTime? FechaActualizacion { get; set; }
        public bool EstadoRegistro { get; set; }

        public Productos IdProductoNavigation { get; set; }
    }
}
