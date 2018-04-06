using System;
using System.Collections.Generic;

namespace AdminCore.BusinessLogic.Products.Models
{
    public partial class EstadisticasIcfes
    {
        public DateTime FechaPrueba { get; set; }
        public int IdIndividuo { get; set; }
        public decimal? PuntajeInstitucion { get; set; }
        public string NivelIcfes { get; set; }
        public int? EstudiantesIcfes { get; set; }
        public int? TotalEstudiantes { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public DateTime? UltimaModificacion { get; set; }
        public bool EstadoRegistro { get; set; }

        public Instituciones IdIndividuoNavigation { get; set; }
    }
}
