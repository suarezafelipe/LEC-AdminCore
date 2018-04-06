using System;
using System.Collections.Generic;

namespace AdminCore.BusinessLogic.Products.Models
{
    public partial class Ubicaciones
    {
        public Ubicaciones()
        {
            Bodegas = new HashSet<Bodegas>();
            Pedidos = new HashSet<Pedidos>();
            Sedes = new HashSet<Sedes>();
            UbicPersonas = new HashSet<UbicPersonas>();
        }

        public int IdUbicacion { get; set; }
        public string Direccion { get; set; }
        public string ComplementoDireccion { get; set; }
        public string CodigoPostal { get; set; }
        public string Departamento { get; set; }
        public string Localidad { get; set; }
        public string Barrio { get; set; }
        public string CoordenadasGmaps { get; set; }
        public int? RiesgoZona { get; set; }
        public int? Estrato { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public DateTime? FechaActualizacion { get; set; }
        public bool EstadoRegistro { get; set; }
        public int IdCiudad { get; set; }

        public Ciudades IdCiudadNavigation { get; set; }
        public ICollection<Bodegas> Bodegas { get; set; }
        public ICollection<Pedidos> Pedidos { get; set; }
        public ICollection<Sedes> Sedes { get; set; }
        public ICollection<UbicPersonas> UbicPersonas { get; set; }
    }
}
