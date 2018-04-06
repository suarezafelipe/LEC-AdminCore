using System;
using System.Collections.Generic;

namespace AdminCore.BusinessLogic.Products.Models
{
    public partial class CotizacionesListaEscolar
    {
        public int IdCotizacion { get; set; }
        public string NombreCotizador { get; set; }
        public string Email { get; set; }
        public string NombreColegio { get; set; }
        public string Curso { get; set; }
        public string Telefono { get; set; }
        public int? GeneroEstudiante { get; set; }
        public DateTime FechaSolicitud { get; set; }
        public DateTime? FechaRespuesta { get; set; }
        public bool Estado { get; set; }
        public int? IdListaEscolar { get; set; }
    }
}
