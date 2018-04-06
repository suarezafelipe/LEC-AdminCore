using System;
using System.Collections.Generic;

namespace AdminCore.BusinessLogic.Products.Models
{
    public partial class Paises
    {
        public Paises()
        {
            Regiones = new HashSet<Regiones>();
        }

        public string CodigoPais { get; set; }
        public string NombrePais { get; set; }
        public string Moneda { get; set; }
        public string Idioma { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public DateTime? FechaActualizacion { get; set; }
        public bool EstadoRegistro { get; set; }

        public ICollection<Regiones> Regiones { get; set; }
    }
}
