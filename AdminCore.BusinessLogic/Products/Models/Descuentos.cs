using System;
using System.Collections.Generic;

namespace AdminCore.BusinessLogic.Products.Models
{
    public partial class Descuentos
    {
        public Descuentos()
        {
            BeneficiosAliados = new HashSet<BeneficiosAliados>();
            DescuentosUsados = new HashSet<DescuentosUsados>();
            Instituciones = new HashSet<Instituciones>();
            Pedidos = new HashSet<Pedidos>();
        }

        public int IdDescuento { get; set; }
        public string Codigo { get; set; }
        public decimal ValorDescuento { get; set; }
        public DateTime ValidoDesde { get; set; }
        public DateTime ValidoHasta { get; set; }
        public bool UsoUnico { get; set; }
        public decimal MinimoCompra { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public DateTime? FechaActualizacion { get; set; }
        public bool EstadoRegistro { get; set; }
        public int IdCampana { get; set; }

        public Campanas IdCampanaNavigation { get; set; }
        public ICollection<BeneficiosAliados> BeneficiosAliados { get; set; }
        public ICollection<DescuentosUsados> DescuentosUsados { get; set; }
        public ICollection<Instituciones> Instituciones { get; set; }
        public ICollection<Pedidos> Pedidos { get; set; }
    }
}
