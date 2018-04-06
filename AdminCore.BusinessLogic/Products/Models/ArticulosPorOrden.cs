using System;
using System.Collections.Generic;

namespace AdminCore.BusinessLogic.Products.Models
{
    public partial class ArticulosPorOrden
    {
        public ArticulosPorOrden()
        {
            TrazabilidadCompras = new HashSet<TrazabilidadCompras>();
        }

        public int IdArticulo { get; set; }
        public int IdOrden { get; set; }
        public int IdProducto { get; set; }
        public int Cantidad { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public DateTime? FechaActualizacion { get; set; }
        public bool EstadoRegistro { get; set; }
        public int IdDetalleOrdenCompra { get; set; }
        public decimal? PrecioUltimaCompra { get; set; }
        public string LugarUltimaCompra { get; set; }

        public Articulos Id { get; set; }
        public OrdenCompra IdOrdenNavigation { get; set; }
        public ICollection<TrazabilidadCompras> TrazabilidadCompras { get; set; }
    }
}
