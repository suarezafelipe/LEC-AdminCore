using System;
using System.Collections.Generic;

namespace AdminCore.BusinessLogic.Products.Models
{
    public partial class TrazabilidadCompras
    {
        public int IdDetalleEntradaInventario { get; set; }
        public int IdDetalleOrdenCompra { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public DateTime? FechaActualizacion { get; set; }
        public bool EstadoRegistro { get; set; }

        public DetallesEntradaInventario IdDetalleEntradaInventarioNavigation { get; set; }
        public ArticulosPorOrden IdDetalleOrdenCompraNavigation { get; set; }
    }
}
