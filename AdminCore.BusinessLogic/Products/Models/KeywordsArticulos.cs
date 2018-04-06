using System;
using System.Collections.Generic;

namespace AdminCore.BusinessLogic.Products.Models
{
    public partial class KeywordsArticulos
    {
        public int ArticulosIdArticulo { get; set; }
        public int ArticulosIdProducto { get; set; }
        public int PalabrasClaveIdPalabra { get; set; }

        public Articulos Articulos { get; set; }
        public PalabrasClave PalabrasClaveIdPalabraNavigation { get; set; }
    }
}
