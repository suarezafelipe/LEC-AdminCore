using System;
using System.Collections.Generic;

namespace AdminCore.BusinessLogic.Products.Models
{
    public partial class AtributosArticulos
    {
        public AtributosArticulos()
        {
            ArticulosAtributosValores = new HashSet<ArticulosAtributosValores>();
            ValorAtributo = new HashSet<ValorAtributo>();
        }

        public int IdAtributo { get; set; }
        public int IdTipo { get; set; }
        public string Nombre { get; set; }
        public int Secuencia { get; set; }
        public string Descripcion { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public DateTime? FechaActualizacion { get; set; }
        public bool EstadoRegistro { get; set; }
        public int? IdUnidVenta { get; set; }

        public TipoAtributos IdTipoNavigation { get; set; }
        public UnidadesVenta IdUnidVentaNavigation { get; set; }
        public ICollection<ArticulosAtributosValores> ArticulosAtributosValores { get; set; }
        public ICollection<ValorAtributo> ValorAtributo { get; set; }
    }
}
