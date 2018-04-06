using System;
using System.Collections.Generic;

namespace AdminCore.BusinessLogic.Products.Models
{
    public partial class Instituciones
    {
        public Instituciones()
        {
            BeneficiosAliados = new HashSet<BeneficiosAliados>();
            Cursos = new HashSet<Cursos>();
            EstadisticasIcfes = new HashSet<EstadisticasIcfes>();
        }

        public int IdIndividuo { get; set; }
        public string TipoInstitucion { get; set; }
        public string TipoIdentificacion { get; set; }
        public string NumIdentificacion { get; set; }
        public string NombreOficial { get; set; }
        public string NombreCorto { get; set; }
        public string Calendario { get; set; }
        public bool Aliado { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public DateTime? FechaActualizacion { get; set; }
        public bool EstadoRegistro { get; set; }
        public int? IdDescuento { get; set; }
        public bool Publico { get; set; }
        public string UrlLogo { get; set; }
        public string UrlLogoMin { get; set; }
        public string PideLista { get; set; }
        public string NombreBuscador { get; set; }

        public Descuentos IdDescuentoNavigation { get; set; }
        public Individuos IdIndividuoNavigation { get; set; }
        public AtribsInstituciones AtribsInstituciones { get; set; }
        public ICollection<BeneficiosAliados> BeneficiosAliados { get; set; }
        public ICollection<Cursos> Cursos { get; set; }
        public ICollection<EstadisticasIcfes> EstadisticasIcfes { get; set; }
    }
}
