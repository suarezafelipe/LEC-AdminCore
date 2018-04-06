using System;
using System.Collections.Generic;

namespace AdminCore.BusinessLogic.Products.Models
{
    public partial class PrePedidos
    {
        public PrePedidos()
        {
            ArticulosPorInstitucionPrePedido = new HashSet<ArticulosPorInstitucionPrePedido>();
            ArticulosPrePedido = new HashSet<ArticulosPrePedido>();
        }

        public int IdPrePedido { get; set; }
        public string NumFactura { get; set; }
        public string Nombre { get; set; }
        public string NumIdentificacion { get; set; }
        public string Direccion { get; set; }
        public string Ciudad { get; set; }
        public string CodigoPais { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
        public bool Checked { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public DateTime? FechaActualizacion { get; set; }
        public bool EstadoRegistro { get; set; }
        public int? IdPersona { get; set; }
        public int? IdUbicacion { get; set; }
        public string CodigoDescuento { get; set; }
        public decimal? ValorDescuento { get; set; }
        public string TipoDescuento { get; set; }
        public decimal? CostoEnvio { get; set; }
        public decimal? Total { get; set; }
        public decimal? CostoMarcado { get; set; }
        public string NombreMarcado { get; set; }

        public ICollection<ArticulosPorInstitucionPrePedido> ArticulosPorInstitucionPrePedido { get; set; }
        public ICollection<ArticulosPrePedido> ArticulosPrePedido { get; set; }
    }
}
