using System;
using System.Collections.Generic;

namespace AdminCore.BusinessLogic.Products.Models
{
    public partial class DetallesListaPedido
    {
        public DetallesListaPedido()
        {
            ArticulosDetallesListaPedido = new HashSet<ArticulosDetallesListaPedido>();
        }

        public int IdDetalleListaPedido { get; set; }
        public int IdPedido { get; set; }
        public int? IdLista { get; set; }
        public bool TieneMarcado { get; set; }
        public string NombreMarcado { get; set; }
        public DateTime EstadoRegistro { get; set; }
        public DateTime FechaActualizacion { get; set; }
        public bool EstadoRegistro1 { get; set; }

        public ListasEscolares IdListaNavigation { get; set; }
        public Pedidos IdPedidoNavigation { get; set; }
        public ICollection<ArticulosDetallesListaPedido> ArticulosDetallesListaPedido { get; set; }
    }
}
