using System;
using System.Collections.Generic;

namespace AdminCore.BusinessLogic.Products.Models
{
    public partial class DescuentosUsados
    {
        public string IdIdentity { get; set; }
        public int IdDescuento { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public DateTime? FechaActualizacion { get; set; }
        public bool EstadoRegistro { get; set; }

        public Descuentos IdDescuentoNavigation { get; set; }
    }
}
