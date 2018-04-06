using System;
using System.Collections.Generic;

namespace AdminCore.BusinessLogic.Products.Models
{
    public partial class ArticulosPedidosFacturasVenta
    {
        public int IdCambio { get; set; }
        public int IdArticulo { get; set; }
        public int IdPedido { get; set; }
        public int IdProductoCambio { get; set; }
        public int IdProducto { get; set; }
        public int IdArticuloCambio { get; set; }
        public int IdFactura { get; set; }
        public bool EstadoRegistro { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public DateTime? FechaActualizacion { get; set; }

        public ArticulosPorPedido Id { get; set; }
        public ArticulosPorFacturaVenta IdNavigation { get; set; }
    }
}
