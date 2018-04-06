using System;
using System.Collections.Generic;

namespace AdminCore.BusinessLogic.Products.Models
{
    public partial class ArticulosAtributosValores
    {
        public int IdArticulo { get; set; }
        public int IdProducto { get; set; }
        public int IdAtributo { get; set; }
        public int IdValor { get; set; }
        public bool EstadoRegistro { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public DateTime? FechaActualizacion { get; set; }

        public Articulos Id { get; set; }
        public AtributosArticulos IdAtributoNavigation { get; set; }
        public ValorAtributo IdValorNavigation { get; set; }
    }
}
