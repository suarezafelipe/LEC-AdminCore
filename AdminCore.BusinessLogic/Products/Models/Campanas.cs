using System;
using System.Collections.Generic;

namespace AdminCore.BusinessLogic.Products.Models
{
    public partial class Campanas
    {
        public Campanas()
        {
            Descuentos = new HashSet<Descuentos>();
        }

        public int IdCampana { get; set; }
        public string Tipo { get; set; }
        public string Descripcion { get; set; }
        public DateTime FechaInicioCampana { get; set; }
        public DateTime FechaFinCampama { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public DateTime? FechaActualizacion { get; set; }
        public bool EstadoRegistro { get; set; }

        public ICollection<Descuentos> Descuentos { get; set; }
    }
}
