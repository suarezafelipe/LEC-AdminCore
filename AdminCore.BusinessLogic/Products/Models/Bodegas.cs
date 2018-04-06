using System;
using System.Collections.Generic;

namespace AdminCore.BusinessLogic.Products.Models
{
    public partial class Bodegas
    {
        public Bodegas()
        {
            Estantes = new HashSet<Estantes>();
        }

        public int IdBodega { get; set; }
        public string NombreBodega { get; set; }
        public string Especificacion { get; set; }
        public int IdUbicacion { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public DateTime? FechaActualizacion { get; set; }
        public bool EstadoRegistro { get; set; }

        public Ubicaciones IdUbicacionNavigation { get; set; }
        public ICollection<Estantes> Estantes { get; set; }
    }
}
