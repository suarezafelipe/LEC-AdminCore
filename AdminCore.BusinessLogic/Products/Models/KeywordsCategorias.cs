using System;
using System.Collections.Generic;

namespace AdminCore.BusinessLogic.Products.Models
{
    public partial class KeywordsCategorias
    {
        public int CategoriasIdCategoria { get; set; }
        public int PalabrasClaveIdPalabra { get; set; }

        public Categorias CategoriasIdCategoriaNavigation { get; set; }
        public PalabrasClave PalabrasClaveIdPalabraNavigation { get; set; }
    }
}
