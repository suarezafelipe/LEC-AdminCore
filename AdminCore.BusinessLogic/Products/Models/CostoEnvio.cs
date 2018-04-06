using System;
using System.Collections.Generic;

namespace AdminCore.BusinessLogic.Products.Models
{
    public partial class CostoEnvio
    {
        public int IdCostoEnvio { get; set; }
        public decimal Precio { get; set; }
        public int Peso { get; set; }
        public DateTime? FechaActualizacion { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public bool EstadoRegistro { get; set; }
        public int IdCiudad { get; set; }

        public Ciudades IdCiudadNavigation { get; set; }
    }
}
