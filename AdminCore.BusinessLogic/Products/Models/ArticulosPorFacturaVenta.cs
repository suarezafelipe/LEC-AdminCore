using System;
using System.Collections.Generic;

namespace AdminCore.BusinessLogic.Products.Models
{
    public partial class ArticulosPorFacturaVenta
    {
        public ArticulosPorFacturaVenta()
        {
            ArticulosPedidosFacturasVenta = new HashSet<ArticulosPedidosFacturasVenta>();
        }

        public int IdArticulo { get; set; }
        public int IdFacturaVenta { get; set; }
        public int IdProducto { get; set; }
        public int Cantidad { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public DateTime? FechaActualizacion { get; set; }
        public decimal? PrecioConIva { get; set; }
        public bool EstadoRegistro { get; set; }

        public Articulos Id { get; set; }
        public FacturasVentas IdFacturaVentaNavigation { get; set; }
        public ICollection<ArticulosPedidosFacturasVenta> ArticulosPedidosFacturasVenta { get; set; }
    }
}
