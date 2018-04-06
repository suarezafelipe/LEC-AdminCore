using System;
using System.Collections.Generic;

namespace AdminCore.BusinessLogic.Products.Models
{
    public partial class ValorAtributo
    {
        public ValorAtributo()
        {
            ArticulosAtributosValores = new HashSet<ArticulosAtributosValores>();
        }

        public int Secuencia { get; set; }
        public int IdAtributo { get; set; }
        public string ValorCadena { get; set; }
        public decimal? ValorDecimal { get; set; }
        public int? ValorEntero { get; set; }
        public bool? ValorBool { get; set; }
        public string ValorBlob { get; set; }
        public DateTime? ValorFecha { get; set; }
        public int IdTipo { get; set; }
        public int? IdUnidVenta { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public DateTime? FechaActualizacion { get; set; }
        public bool EstadoRegistro { get; set; }
        public int IdValor { get; set; }

        public AtributosArticulos IdAtributoNavigation { get; set; }
        public TipoAtributos IdTipoNavigation { get; set; }
        public UnidadesVenta IdUnidVentaNavigation { get; set; }
        public ICollection<ArticulosAtributosValores> ArticulosAtributosValores { get; set; }
    }
}
