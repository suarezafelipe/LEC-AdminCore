using System;
using System.Collections.Generic;

namespace AdminCore.BusinessLogic.Products.Models
{
    public partial class DetallesAjusteInventario
    {
        public int IdDetalleAjusteInventario { get; set; }
        public int Cantidad { get; set; }
        public decimal PrecioSinIva { get; set; }
        public decimal PorcentajeIva { get; set; }
        public string TipoAjuste { get; set; }
        public DateTime? TipoAjuste1 { get; set; }
        public DateTime? FechaActualizacion { get; set; }
        public bool EstadoRegistro { get; set; }
        public int IdArticulo { get; set; }
        public int IdProducto { get; set; }
        public int IdAjusteInventario { get; set; }

        public Articulos Id { get; set; }
        public AjustesInventario IdAjusteInventarioNavigation { get; set; }
    }
}
