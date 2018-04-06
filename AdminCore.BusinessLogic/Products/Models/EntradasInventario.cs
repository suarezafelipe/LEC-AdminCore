using System;
using System.Collections.Generic;

namespace AdminCore.BusinessLogic.Products.Models
{
    public partial class EntradasInventario
    {
        public EntradasInventario()
        {
            DetallesEntradaInventario = new HashSet<DetallesEntradaInventario>();
        }

        public int IdEntradaInventario { get; set; }
        public DateTime Fecha { get; set; }
        public string Concepto { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public DateTime? FechaActualizacion { get; set; }
        public bool EstadoRegistro { get; set; }

        public ICollection<DetallesEntradaInventario> DetallesEntradaInventario { get; set; }
    }
}
