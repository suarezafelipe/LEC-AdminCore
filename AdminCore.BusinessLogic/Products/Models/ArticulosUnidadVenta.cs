using System;
using System.Collections.Generic;

namespace AdminCore.BusinessLogic.Products.Models
{
    public partial class ArticulosUnidadVenta
    {
        public int IdUnidadVenta { get; set; }
        public int IdProducto { get; set; }
        public int IdArticulo { get; set; }
        public int IdProductoBase { get; set; }
        public int IdArticuloBase { get; set; }
        public int Cantidad { get; set; }

        public Articulos Id { get; set; }
        public Articulos IdNavigation { get; set; }
    }
}
