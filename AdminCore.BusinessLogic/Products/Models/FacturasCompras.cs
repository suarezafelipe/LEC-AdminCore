using System;
using System.Collections.Generic;

namespace AdminCore.BusinessLogic.Products.Models
{
    public partial class FacturasCompras
    {
        public FacturasCompras()
        {
            ArticulosPorFacturaCompra = new HashSet<ArticulosPorFacturaCompra>();
            DetallesEntradaInventario = new HashSet<DetallesEntradaInventario>();
        }

        public int IdFacturaCompra { get; set; }
        public string EstadoPago { get; set; }
        public string Comentario { get; set; }
        public bool EsLegal { get; set; }
        public decimal TotalIvaFactura { get; set; }
        public DateTime FechaCompra { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public DateTime? FechaActualizacion { get; set; }
        public bool EstadoRegistro { get; set; }
        public int IdIndividuo { get; set; }
        public decimal ValorDescuento { get; set; }
        public decimal ValorIva { get; set; }
        public decimal ValorRetencionFuente { get; set; }
        public decimal? ValorTotalArreglo { get; set; }
        public decimal? ValorIvaArreglo { get; set; }
        public decimal? ValorRetencionFuenteArreglo { get; set; }

        public Proveedores IdIndividuoNavigation { get; set; }
        public ICollection<ArticulosPorFacturaCompra> ArticulosPorFacturaCompra { get; set; }
        public ICollection<DetallesEntradaInventario> DetallesEntradaInventario { get; set; }
    }
}
