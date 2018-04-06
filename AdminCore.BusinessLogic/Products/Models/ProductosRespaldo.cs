using System;
using System.Collections.Generic;

namespace AdminCore.BusinessLogic.Products.Models
{
    public partial class ProductosRespaldo
    {
        public int IdRespaldo { get; set; }
        public int IdArticulo { get; set; }
        public int IdArticuloRes { get; set; }
        public int IdProducto { get; set; }
        public int IdProductoRes { get; set; }
        public bool Genero { get; set; }
        public int? Prioridad { get; set; }
        public bool EstadoRegistro { get; set; }

        public Articulos Id { get; set; }
        public Articulos IdNavigation { get; set; }
    }
}
