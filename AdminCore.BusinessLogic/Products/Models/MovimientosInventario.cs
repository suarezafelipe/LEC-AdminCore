using System;
using System.Collections.Generic;

namespace AdminCore.BusinessLogic.Products.Models
{
    public partial class MovimientosInventario
    {
        public int IdMovimiento { get; set; }
        public int IdArticulo { get; set; }
        public int IdProducto { get; set; }
        public int? IdDetallePadre { get; set; }
        public int IdDetalleHijo { get; set; }
        public int Cantidad { get; set; }
        public decimal ValorMovimientoSinIva { get; set; }
        public int TipoMovimiento { get; set; }
        public decimal? PorcentajeIva { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public DateTime? FechaActualizacion { get; set; }
        public bool EstadoRegistro { get; set; }
    }
}
