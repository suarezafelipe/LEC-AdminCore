using System;
using System.Collections.Generic;

namespace AdminCore.BusinessLogic.Products.Models
{
    public partial class DetallesSalidaInventario
    {
        public int IdDetalleSalidaInventario { get; set; }
        public int Cantidad { get; set; }
        public decimal PrecioVentaSinIva { get; set; }
        public decimal PorcentajeIva { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public DateTime? FechaActualizacion { get; set; }
        public bool EstadoRegistro { get; set; }
        public int IdArticulo { get; set; }
        public int IdProducto { get; set; }
        public int IdFacturaVenta { get; set; }
        public int IdSalidaInventario { get; set; }

        public Articulos Id { get; set; }
        public FacturasVentas IdFacturaVentaNavigation { get; set; }
        public SalidasInventario IdSalidaInventarioNavigation { get; set; }
    }
}
