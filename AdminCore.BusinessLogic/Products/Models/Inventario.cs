using System;
using System.Collections.Generic;

namespace AdminCore.BusinessLogic.Products.Models
{
    public partial class Inventario
    {
        public int IdArticulo { get; set; }
        public int IdProducto { get; set; }
        public int CantidadDisponible { get; set; }
        public int? CantidadComprada { get; set; }
        public int? CantidadVendida { get; set; }
        public int? CantidadPerdida { get; set; }
        public int? CantidadRegalada { get; set; }
        public decimal? PrecioPromedioCompraSinIva { get; set; }
        public decimal? PrecioPromedioVentaSinIva { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public DateTime? FechaActualizacion { get; set; }
        public bool EstadoRegistro { get; set; }
        public int? CantidadAjustada { get; set; }
    }
}
