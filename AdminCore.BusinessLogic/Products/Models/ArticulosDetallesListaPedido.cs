using System;
using System.Collections.Generic;

namespace AdminCore.BusinessLogic.Products.Models
{
    public partial class ArticulosDetallesListaPedido
    {
        public int IdDetallePedido { get; set; }
        public int IdArticulo { get; set; }
        public int IdProducto { get; set; }
        public int Cantidad { get; set; }
        public bool TieneMarcado { get; set; }
        public DateTime EstadoRegistro { get; set; }
        public DateTime FechaActualizacion { get; set; }
        public bool EstadoRegistro1 { get; set; }

        public Articulos Id { get; set; }
        public DetallesListaPedido IdDetallePedidoNavigation { get; set; }
    }
}
