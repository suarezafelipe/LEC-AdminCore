using System;
using System.Collections.Generic;

namespace AdminCore.BusinessLogic.Products.Models
{
    public partial class Categorias
    {
        public Categorias()
        {
            CategoriaCategoriasIdCategoriaHijoNavigation = new HashSet<CategoriaCategorias>();
            CategoriaCategoriasIdCategoriaPadreNavigation = new HashSet<CategoriaCategorias>();
            CategoriaProd = new HashSet<CategoriaProd>();
            CategoriasCategoriasContable = new HashSet<CategoriasCategoriasContable>();
            KeywordsCategorias = new HashSet<KeywordsCategorias>();
        }

        public int IdCategoria { get; set; }
        public string Nombre { get; set; }
        public string NombreCorto { get; set; }
        public string DescripcionCorta { get; set; }
        public string DescripcionLarga { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public DateTime? FechaActualizacion { get; set; }
        public bool EstadoRegistro { get; set; }

        public ICollection<CategoriaCategorias> CategoriaCategoriasIdCategoriaHijoNavigation { get; set; }
        public ICollection<CategoriaCategorias> CategoriaCategoriasIdCategoriaPadreNavigation { get; set; }
        public ICollection<CategoriaProd> CategoriaProd { get; set; }
        public ICollection<CategoriasCategoriasContable> CategoriasCategoriasContable { get; set; }
        public ICollection<KeywordsCategorias> KeywordsCategorias { get; set; }
    }
}
