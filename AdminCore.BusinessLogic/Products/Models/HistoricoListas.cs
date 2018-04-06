using System;
using System.Collections.Generic;

namespace AdminCore.BusinessLogic.Products.Models
{
    public partial class HistoricoListas
    {
        public DateTime FechaCambio { get; set; }
        public int IdLista { get; set; }
        public DateTime? FechaEstProxCambio { get; set; }
        public string RegistroCambios { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public DateTime? FechaActualizacion { get; set; }
        public bool EstadoRegistro { get; set; }

        public ListasEscolares IdListaNavigation { get; set; }
    }
}
