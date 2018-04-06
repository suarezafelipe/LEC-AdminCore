using System;
using System.Collections.Generic;

namespace AdminCore.BusinessLogic.Products.Models
{
    public partial class AtribsInstituciones
    {
        public int IdIndividuo { get; set; }
        public DateTime? FechaMatricula { get; set; }
        public DateTime? InicioClases { get; set; }
        public DateTime? FinClases { get; set; }
        public bool? VendeTextos { get; set; }
        public bool? VendeUtiles { get; set; }
        public decimal? ValorMatricula { get; set; }
        public decimal? ValorPension1 { get; set; }
        public int? AnioPension { get; set; }
        public string UrlSitioWeb { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public DateTime? FechaActualizacion { get; set; }
        public bool EstadoRegistro { get; set; }
        public string NombreRector { get; set; }
        public string Jornada { get; set; }

        public Instituciones IdIndividuoNavigation { get; set; }
    }
}
