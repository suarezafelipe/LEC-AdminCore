using System;
using System.Collections.Generic;

namespace AdminCore.BusinessLogic.Products.Models
{
    public partial class ArticulosCarritoCompraPrepedido
    {
        public int IdArticulosCarrito { get; set; }
        public int IdArticulo { get; set; }
        public int? IdArticuloBackup { get; set; }
        public int IdProducto { get; set; }
        public int Cantidad { get; set; }
        public decimal Precio { get; set; }
        public decimal? Iva { get; set; }
        public bool Donacion { get; set; }
        public int IdCarrito { get; set; }
        public int? Peso { get; set; }
        public int? ValorMarcado { get; set; }
        public bool TieneMarcado { get; set; }
        public string Nombre { get; set; }

        public CarritoCompraPrepedido IdCarritoNavigation { get; set; }
    }
}
