using System;
using System.Collections.Generic;

namespace AdminCore.BusinessLogic.Products.Models
{
    public partial class ActividadesEconomicas
    {
        public ActividadesEconomicas()
        {
            Proveedores = new HashSet<Proveedores>();
        }

        public int IdActividadEconomica { get; set; }
        public string CodigoActividad { get; set; }
        public string Nombre { get; set; }
        public decimal? Tarifa { get; set; }
        public string CuentaIca { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public DateTime? FechaActualizacion { get; set; }
        public bool EstadoRegistro { get; set; }

        public ICollection<Proveedores> Proveedores { get; set; }
    }
}
