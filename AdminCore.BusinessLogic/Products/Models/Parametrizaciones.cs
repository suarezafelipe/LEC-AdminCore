using System;
using System.Collections.Generic;

namespace AdminCore.BusinessLogic.Products.Models
{
    public partial class Parametrizaciones
    {
        public int IdParametro { get; set; }
        public string TipoParametro { get; set; }
        public string Descripcion { get; set; }
        public int? ParametroEntero { get; set; }
        public string ParametroString { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public DateTime? FechaActualizacion { get; set; }
        public bool EstadoRegistro { get; set; }
    }
}
