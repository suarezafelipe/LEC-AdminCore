using System;
using System.Collections.Generic;

namespace AdminCore.BusinessLogic.Products.Models
{
    public partial class UnidadesVenta
    {
        public UnidadesVenta()
        {
            AtributosArticulos = new HashSet<AtributosArticulos>();
            ValorAtributo = new HashSet<ValorAtributo>();
        }

        public int IdUnidVenta { get; set; }
        public string Nombre { get; set; }
        public string Simbolo { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public DateTime? FechaActualizacion { get; set; }
        public bool EstadoRegistro { get; set; }

        public ICollection<AtributosArticulos> AtributosArticulos { get; set; }
        public ICollection<ValorAtributo> ValorAtributo { get; set; }
    }
}
