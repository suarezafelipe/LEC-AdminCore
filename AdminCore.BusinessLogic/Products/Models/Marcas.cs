using System;
using System.Collections.Generic;

namespace AdminCore.BusinessLogic.Products.Models
{
    public partial class Marcas
    {
        public Marcas()
        {
            MarcasProveedor = new HashSet<MarcasProveedor>();
            Productos = new HashSet<Productos>();
        }

        public int IdMarca { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public DateTime? FechaActualizacion { get; set; }
        public bool EstadoRegistro { get; set; }

        public ICollection<MarcasProveedor> MarcasProveedor { get; set; }
        public ICollection<Productos> Productos { get; set; }
    }
}
