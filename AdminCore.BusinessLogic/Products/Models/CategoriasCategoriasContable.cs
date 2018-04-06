using System;
using System.Collections.Generic;

namespace AdminCore.BusinessLogic.Products.Models
{
    public partial class CategoriasCategoriasContable
    {
        public int IdCategoria { get; set; }
        public int IdCategoriaContable { get; set; }
        public bool EstadoRegistro { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public DateTime? FechaActualizacion { get; set; }

        public CategoriasContabilidad IdCategoriaContableNavigation { get; set; }
        public Categorias IdCategoriaNavigation { get; set; }
    }
}
