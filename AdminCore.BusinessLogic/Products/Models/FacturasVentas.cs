using System;
using System.Collections.Generic;

namespace AdminCore.BusinessLogic.Products.Models
{
    public partial class FacturasVentas
    {
        public FacturasVentas()
        {
            ArticulosPorFacturaVenta = new HashSet<ArticulosPorFacturaVenta>();
            DetallesSalidaInventario = new HashSet<DetallesSalidaInventario>();
        }

        public int IdFacturaVenta { get; set; }
        public string EstadoPago { get; set; }
        public string Comentario { get; set; }
        public bool EsLegal { get; set; }
        public DateTime FechaVenta { get; set; }
        public decimal TotalIvaFactura { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public DateTime? FechaActualizacion { get; set; }
        public bool EstadoRegistro { get; set; }
        public int? IdPedido { get; set; }
        public int IdCliente { get; set; }
        public decimal ValorDescuento { get; set; }
        public int? IdFacturaGenerada { get; set; }
        public int? IdResolucion { get; set; }
        public string NombreArchivo { get; set; }
        public int? DiasAPagar { get; set; }
        public decimal? ValorEnvio { get; set; }
        public decimal ValorMarcado { get; set; }

        public Personas IdClienteNavigation { get; set; }
        public Pedidos IdPedidoNavigation { get; set; }
        public ICollection<ArticulosPorFacturaVenta> ArticulosPorFacturaVenta { get; set; }
        public ICollection<DetallesSalidaInventario> DetallesSalidaInventario { get; set; }
    }
}
