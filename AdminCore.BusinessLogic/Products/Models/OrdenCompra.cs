using System;
using System.Collections.Generic;

namespace AdminCore.BusinessLogic.Products.Models
{
    public partial class OrdenCompra
    {
        public OrdenCompra()
        {
            ArticulosPorOrden = new HashSet<ArticulosPorOrden>();
            Pedidos = new HashSet<Pedidos>();
        }

        public int IdOrden { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public DateTime? FechaActualizacion { get; set; }
        public bool EstadoRegistro { get; set; }
        public int? ProveedorIdIndividuo { get; set; }
        public DateTime FechaPedido { get; set; }
        public DateTime? FechaLimite { get; set; }
        public string ObservacionesGenerales { get; set; }

        public Proveedores ProveedorIdIndividuoNavigation { get; set; }
        public ICollection<ArticulosPorOrden> ArticulosPorOrden { get; set; }
        public ICollection<Pedidos> Pedidos { get; set; }
    }
}
