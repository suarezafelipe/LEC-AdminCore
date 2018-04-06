using System;
using System.Collections.Generic;

namespace AdminCore.BusinessLogic.Products.Models
{
    public partial class Individuos
    {
        public Individuos()
        {
            ArticulosPorInstitucion = new HashSet<ArticulosPorInstitucion>();
            Pedidos = new HashSet<Pedidos>();
            Sedes = new HashSet<Sedes>();
        }

        public int IdIndividuo { get; set; }
        public string CodTipoIndividuo { get; set; }
        public string Email { get; set; }
        public string Email2 { get; set; }
        public string Telefono { get; set; }
        public string Tel2 { get; set; }
        public string IdIdentity { get; set; }

        public Instituciones Instituciones { get; set; }
        public Personas Personas { get; set; }
        public Proveedores Proveedores { get; set; }
        public ICollection<ArticulosPorInstitucion> ArticulosPorInstitucion { get; set; }
        public ICollection<Pedidos> Pedidos { get; set; }
        public ICollection<Sedes> Sedes { get; set; }
    }
}
