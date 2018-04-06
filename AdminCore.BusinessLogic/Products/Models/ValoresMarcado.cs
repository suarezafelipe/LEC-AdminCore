using System;
using System.Collections.Generic;

namespace AdminCore.BusinessLogic.Products.Models
{
    public partial class ValoresMarcado
    {
        public int IdValorMarcado { get; set; }
        public decimal Precio { get; set; }
        public int Valor { get; set; }
        public DateTime? FechaActualizacion { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public bool EstadoRegistro { get; set; }
    }
}
