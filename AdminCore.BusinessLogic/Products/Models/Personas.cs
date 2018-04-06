using System;
using System.Collections.Generic;

namespace AdminCore.BusinessLogic.Products.Models
{
    public partial class Personas
    {
        public Personas()
        {
            FacturasVentas = new HashSet<FacturasVentas>();
            UbicPersonas = new HashSet<UbicPersonas>();
            Valoraciones = new HashSet<Valoraciones>();
        }

        public int IdIndividuo { get; set; }
        public string TipoPersona { get; set; }
        public string TipoIdentificacion { get; set; }
        public string NumIdentificacion { get; set; }
        public string PrimerNombre { get; set; }
        public string SegundoNombre { get; set; }
        public string PrimerApellido { get; set; }
        public string SegundoApellido { get; set; }
        public int? NumHijos { get; set; }
        public DateTime? FechaNacimiento { get; set; }
        public string EstadoCivil { get; set; }
        public string Genero { get; set; }
        public string Ingresos { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public DateTime? FechaActualizacion { get; set; }
        public bool EstadoRegistro { get; set; }
        public bool? ClienteIdentity { get; set; }

        public Individuos IdIndividuoNavigation { get; set; }
        public ICollection<FacturasVentas> FacturasVentas { get; set; }
        public ICollection<UbicPersonas> UbicPersonas { get; set; }
        public ICollection<Valoraciones> Valoraciones { get; set; }
    }
}
