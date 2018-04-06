using System;
using System.Collections.Generic;

namespace AdminCore.BusinessLogic.Products.Models
{
    public partial class AjustesInventario
    {
        public AjustesInventario()
        {
            DetallesAjusteInventario = new HashSet<DetallesAjusteInventario>();
        }

        public int IdAjusteInventario { get; set; }
        public DateTime Fecha { get; set; }
        public string Concepto { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public DateTime? FechaActualizacion { get; set; }
        public bool EstadoRegistro { get; set; }

        public ICollection<DetallesAjusteInventario> DetallesAjusteInventario { get; set; }
    }
}
