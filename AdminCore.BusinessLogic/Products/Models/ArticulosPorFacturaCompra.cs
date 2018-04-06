using System;
using System.Collections.Generic;

namespace AdminCore.BusinessLogic.Products.Models
{
    public partial class ArticulosPorFacturaCompra
    {
        public int IdArticulo { get; set; }
        public int IdFacturaCompra { get; set; }
        public int IdProducto { get; set; }
        public int Cantidad { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public DateTime? FechaActualizacion { get; set; }
        public decimal PrecioCompraSinIva { get; set; }
        public decimal PorcentajeIva { get; set; }
        public bool EstadoRegistro { get; set; }

        public Articulos Id { get; set; }
        public FacturasCompras IdFacturaCompraNavigation { get; set; }
    }
}
