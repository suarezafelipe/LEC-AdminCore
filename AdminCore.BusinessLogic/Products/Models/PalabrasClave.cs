using System;
using System.Collections.Generic;

namespace AdminCore.BusinessLogic.Products.Models
{
    public partial class PalabrasClave
    {
        public PalabrasClave()
        {
            KeywordsArticulos = new HashSet<KeywordsArticulos>();
            KeywordsCategorias = new HashSet<KeywordsCategorias>();
            KeywordsProductos = new HashSet<KeywordsProductos>();
        }

        public int IdPalabra { get; set; }
        public string CodIsoIdioma { get; set; }
        public string Palabra { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public DateTime? FechaActualizacion { get; set; }
        public bool EstadoRegistro { get; set; }

        public ICollection<KeywordsArticulos> KeywordsArticulos { get; set; }
        public ICollection<KeywordsCategorias> KeywordsCategorias { get; set; }
        public ICollection<KeywordsProductos> KeywordsProductos { get; set; }
    }
}
