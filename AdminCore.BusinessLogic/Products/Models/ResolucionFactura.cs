using System;
using System.Collections.Generic;

namespace AdminCore.BusinessLogic.Products.Models
{
    public partial class ResolucionFactura
    {
        public int IdResolucion { get; set; }
        public string Codigo { get; set; }
        public int LimiteFacturas { get; set; }
        public DateTime FechaLimite { get; set; }
        public bool EstadoRegistro { get; set; }
        public DateTime FechaActualizacion { get; set; }
        public bool Notificacion { get; set; }
    }
}
