using System;
using System.Collections.Generic;

namespace AdminCore.BusinessLogic.Products.Models
{
    public partial class CarritoCompra
    {
        public CarritoCompra()
        {
            ArticulosCarritoCompra = new HashSet<ArticulosCarritoCompra>();
        }

        public int IdCarrito { get; set; }
        public string IdUsuario { get; set; }
        public string IdLista { get; set; }
        public int? IdGenero { get; set; }
        public bool IsList { get; set; }
        public string NombreColegio { get; set; }
        public string CodigoDescuento { get; set; }
        public decimal ValorDescuento { get; set; }
        public string TipoDescuento { get; set; }
        public decimal MinimoDescuento { get; set; }
        public int? IdIndividuo { get; set; }
        public string NombreOficialColegio { get; set; }
        public string NombreCortoColegio { get; set; }
        public string UrlLogo { get; set; }
        public string UrlLogoMin { get; set; }
        public string Curso { get; set; }
        public string DireccionaColegio { get; set; }
        public string Alerta { get; set; }
        public int? FechaLista { get; set; }
        public int? IdListaReal { get; set; }
        public bool Autenticado { get; set; }
        public DateTime FechaExpiracion { get; set; }
        public int? IdCiudad { get; set; }
        public string RedisSesion { get; set; }
        public bool? TieneMarcado { get; set; }
        public string NombreMarcado { get; set; }

        public ICollection<ArticulosCarritoCompra> ArticulosCarritoCompra { get; set; }
    }
}
