using System;
using System.Collections.Generic;

namespace AdminCore.BusinessLogic.Products.Models
{
    public partial class TipoAtributos
    {
        public TipoAtributos()
        {
            AtributosArticulos = new HashSet<AtributosArticulos>();
            ValorAtributo = new HashSet<ValorAtributo>();
        }

        public int IdTipo { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public DateTime? FechaActualizacion { get; set; }
        public bool EstadoRegistro { get; set; }

        public ICollection<AtributosArticulos> AtributosArticulos { get; set; }
        public ICollection<ValorAtributo> ValorAtributo { get; set; }
    }
}
