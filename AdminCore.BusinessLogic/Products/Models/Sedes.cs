using System;
using System.Collections.Generic;

namespace AdminCore.BusinessLogic.Products.Models
{
    public partial class Sedes
    {
        public int IdSede { get; set; }
        public string TipoSede { get; set; }
        public string FuncionPrincipal { get; set; }
        public string FuncionAdicional1 { get; set; }
        public string FuncionAdicional2 { get; set; }
        public string FuncionAdicional3 { get; set; }
        public int IdUbicacion { get; set; }
        public int? IdIndividuo { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public DateTime? FechaActualizacion { get; set; }
        public bool EstadoRegistro { get; set; }

        public Individuos IdIndividuoNavigation { get; set; }
        public Ubicaciones IdUbicacionNavigation { get; set; }
    }
}
