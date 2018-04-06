using System;
using System.Collections.Generic;

namespace AdminCore.BusinessLogic.Products.Models
{
    public partial class SalidasInventario
    {
        public SalidasInventario()
        {
            DetallesSalidaInventario = new HashSet<DetallesSalidaInventario>();
        }

        public int IdSalidaInventario { get; set; }
        public DateTime Fecha { get; set; }
        public string Concepto { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public DateTime? FechaActualizacion { get; set; }
        public bool EstadoRegistro { get; set; }

        public ICollection<DetallesSalidaInventario> DetallesSalidaInventario { get; set; }
    }
}
