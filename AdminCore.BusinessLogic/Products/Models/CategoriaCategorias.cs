using System;
using System.Collections.Generic;

namespace AdminCore.BusinessLogic.Products.Models
{
    public partial class CategoriaCategorias
    {
        public int IdCategoriaHijo { get; set; }
        public int IdCategoriaPadre { get; set; }

        public Categorias IdCategoriaHijoNavigation { get; set; }
        public Categorias IdCategoriaPadreNavigation { get; set; }
    }
}
