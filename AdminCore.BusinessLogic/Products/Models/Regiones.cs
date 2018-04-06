using System;
using System.Collections.Generic;

namespace AdminCore.BusinessLogic.Products.Models
{
    public partial class Regiones
    {
        public Regiones()
        {
            Ciudades = new HashSet<Ciudades>();
        }

        public int IdRegion { get; set; }
        public string Nombre { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public DateTime? FechaActualizacion { get; set; }
        public bool EstadoRegistro { get; set; }
        public string CodigoPais { get; set; }

        public Paises CodigoPaisNavigation { get; set; }
        public ICollection<Ciudades> Ciudades { get; set; }
    }
}
