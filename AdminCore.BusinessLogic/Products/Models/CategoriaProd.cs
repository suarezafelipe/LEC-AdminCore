using System;
using System.Collections.Generic;

namespace AdminCore.BusinessLogic.Products.Models
{
    public partial class CategoriaProd
    {
        public int CategoriasIdCategoria { get; set; }
        public int ProductosIdProducto { get; set; }

        public Categorias CategoriasIdCategoriaNavigation { get; set; }
        public Productos ProductosIdProductoNavigation { get; set; }
    }
}
