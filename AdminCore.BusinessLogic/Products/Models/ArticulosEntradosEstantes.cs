using System;
using System.Collections.Generic;

namespace AdminCore.BusinessLogic.Products.Models
{
    public partial class ArticulosEntradosEstantes
    {
        public int IdDetalleEntradaInventario { get; set; }
        public int IdEstante { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public DateTime? FechaActualizacion { get; set; }
        public bool EstadoRegistro { get; set; }

        public DetallesEntradaInventario IdDetalleEntradaInventarioNavigation { get; set; }
        public Estantes IdEstanteNavigation { get; set; }
    }
}
