using System;
using System.Collections.Generic;

namespace AdminCore.BusinessLogic.Products.Models
{
    public partial class ArticulosCarritoCompra
    {
        public int IdArticulosCarrito { get; set; }
        public int IdArticulo { get; set; }
        public string Nombre { get; set; }
        public string CodigoLec { get; set; }
        public string UrlThumb { get; set; }
        public int IdProducto { get; set; }
        public int Cantidad { get; set; }
        public int FechaLista { get; set; }
        public decimal Precio { get; set; }
        public string IdLista { get; set; }
        public string Marca { get; set; }
        public string LargeImage { get; set; }
        public decimal? Iva { get; set; }
        public bool EsCuaderno { get; set; }
        public bool TieneImagen { get; set; }
        public bool Donacion { get; set; }
        public bool Disponible { get; set; }
        public string IdUsuario { get; set; }
        public int IdCarrito { get; set; }
        public int? IdArticuloBackup { get; set; }
        public int? Peso { get; set; }
        public int? ValorMarcado { get; set; }
        public bool TieneMarcado { get; set; }

        public CarritoCompra IdCarritoNavigation { get; set; }
    }
}
