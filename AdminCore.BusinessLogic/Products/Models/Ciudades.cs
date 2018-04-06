using System;
using System.Collections.Generic;

namespace AdminCore.BusinessLogic.Products.Models
{
    public partial class Ciudades
    {
        public Ciudades()
        {
            CostoEnvio = new HashSet<CostoEnvio>();
            Ubicaciones = new HashSet<Ubicaciones>();
        }

        public int IdCiudad { get; set; }
        public string CodigoCiudad { get; set; }
        public string NombreCiudad { get; set; }
        public bool TieneCostoEnvio { get; set; }
        public decimal ValorEnvio { get; set; }
        public bool EstadoRegistro { get; set; }
        public DateTime FechaActualizacion { get; set; }
        public DateTime FechaCreacion { get; set; }
        public int IdRegion { get; set; }
        public decimal? ValorDescuentoEnvio { get; set; }

        public Regiones IdRegionNavigation { get; set; }
        public ICollection<CostoEnvio> CostoEnvio { get; set; }
        public ICollection<Ubicaciones> Ubicaciones { get; set; }
    }
}
