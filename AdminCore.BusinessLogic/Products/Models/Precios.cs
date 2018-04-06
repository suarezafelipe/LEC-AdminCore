using System;
using System.Collections.Generic;

namespace AdminCore.BusinessLogic.Products.Models
{
    public partial class Precios
    {
        public int IdPrecio { get; set; }
        public int IdArticulo { get; set; }
        public bool PorDefecto { get; set; }
        public decimal Monto { get; set; }
        public string Moneda { get; set; }
        public string TipoCliente1 { get; set; }
        public string TipoCliente2 { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public DateTime? FechaActualizacion { get; set; }
        public DateTime? FechaVencimiento { get; set; }
        public bool EstadoRegistro { get; set; }
        public int IdProducto { get; set; }
        public decimal? PrecioLinio { get; set; }

        public Articulos Id { get; set; }
    }
}
