using System;
using System.Collections.Generic;

namespace AdminCore.BusinessLogic.Products.Models
{
    public partial class CarritoCompraPrepedido
    {
        public CarritoCompraPrepedido()
        {
            ArticulosCarritoCompraPrepedido = new HashSet<ArticulosCarritoCompraPrepedido>();
        }

        public int IdCarrito { get; set; }
        public string IdSesion { get; set; }
        public int? IdGenero { get; set; }
        public bool EsLista { get; set; }
        public string CodigoDescuento { get; set; }
        public decimal ValorDescuento { get; set; }
        public string TipoDescuento { get; set; }
        public decimal MinimoDescuento { get; set; }
        public string Alerta { get; set; }
        public int FechaLista { get; set; }
        public int? IdListaReal { get; set; }
        public bool? TieneMarcado { get; set; }
        public string NombreMarcado { get; set; }
        public int? IdInformacionUsuario { get; set; }
        public int? IdColegio { get; set; }
        public string NombreCortoColegio { get; set; }
        public string Curso { get; set; }
        public decimal CostoEnvio { get; set; }
        public decimal CostoMarcado { get; set; }

        public ICollection<ArticulosCarritoCompraPrepedido> ArticulosCarritoCompraPrepedido { get; set; }
    }
}
