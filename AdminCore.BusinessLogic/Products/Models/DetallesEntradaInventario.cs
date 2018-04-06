using System;
using System.Collections.Generic;

namespace AdminCore.BusinessLogic.Products.Models
{
    public partial class DetallesEntradaInventario
    {
        public DetallesEntradaInventario()
        {
            ArticulosEntradosEstantes = new HashSet<ArticulosEntradosEstantes>();
            TrazabilidadCompras = new HashSet<TrazabilidadCompras>();
        }

        public int IdDetalleEntradaInventario { get; set; }
        public int Cantidad { get; set; }
        public decimal PrecioCompraSinIva { get; set; }
        public decimal PorcentajeIva { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public DateTime? FechaActualizacion { get; set; }
        public bool EstadoRegistro { get; set; }
        public int IdArticulo { get; set; }
        public int IdProducto { get; set; }
        public int IdFacturaCompra { get; set; }
        public int IdEntradaInventario { get; set; }
        public decimal? PrecioCompraSinIvaDescuento { get; set; }

        public Articulos Id { get; set; }
        public EntradasInventario IdEntradaInventarioNavigation { get; set; }
        public FacturasCompras IdFacturaCompraNavigation { get; set; }
        public ICollection<ArticulosEntradosEstantes> ArticulosEntradosEstantes { get; set; }
        public ICollection<TrazabilidadCompras> TrazabilidadCompras { get; set; }
    }
}
