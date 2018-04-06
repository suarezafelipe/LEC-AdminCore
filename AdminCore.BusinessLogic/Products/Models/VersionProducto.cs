using System;
using System.Collections.Generic;

namespace AdminCore.BusinessLogic.Products.Models
{
    public partial class VersionProducto
    {
        public int IdVersion { get; set; }
        public int IdProducto { get; set; }
        public string Nombre { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public DateTime? FechaActualizacion { get; set; }
        public bool EstadoRegistro { get; set; }

        public Productos IdProductoNavigation { get; set; }
    }
}
