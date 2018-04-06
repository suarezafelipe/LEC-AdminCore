using System;
using System.Collections.Generic;

namespace AdminCore.BusinessLogic.Products.Models
{
    public partial class ArticulosPorLista
    {
        public int IdArticulo { get; set; }
        public int IdLista { get; set; }
        public int IdProducto { get; set; }
        public int Cantidad { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public DateTime? FechaActualizacion { get; set; }
        public bool EstadoRegistro { get; set; }
        public int? Secuencia { get; set; }
        public bool? Obligatorio { get; set; }
        public bool TieneMarcado { get; set; }

        public Articulos Id { get; set; }
        public ListasEscolares IdListaNavigation { get; set; }
    }
}
