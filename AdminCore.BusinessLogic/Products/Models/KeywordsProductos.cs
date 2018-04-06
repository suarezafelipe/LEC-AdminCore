using System;
using System.Collections.Generic;

namespace AdminCore.BusinessLogic.Products.Models
{
    public partial class KeywordsProductos
    {
        public int ProductosIdProducto { get; set; }
        public int PalabrasClaveIdPalabra { get; set; }

        public PalabrasClave PalabrasClaveIdPalabraNavigation { get; set; }
        public Productos ProductosIdProductoNavigation { get; set; }
    }
}
