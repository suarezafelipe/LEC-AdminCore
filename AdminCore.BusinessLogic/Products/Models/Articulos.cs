using System;
using System.Collections.Generic;

namespace AdminCore.BusinessLogic.Products.Models
{
    public partial class Articulos
    {
        public Articulos()
        {
            ArticulosAtributosValores = new HashSet<ArticulosAtributosValores>();
            ArticulosDetallesListaPedido = new HashSet<ArticulosDetallesListaPedido>();
            ArticulosPorFacturaCompra = new HashSet<ArticulosPorFacturaCompra>();
            ArticulosPorFacturaVenta = new HashSet<ArticulosPorFacturaVenta>();
            ArticulosPorInstitucion = new HashSet<ArticulosPorInstitucion>();
            ArticulosPorLista = new HashSet<ArticulosPorLista>();
            ArticulosPorOrden = new HashSet<ArticulosPorOrden>();
            ArticulosPorPedido = new HashSet<ArticulosPorPedido>();
            ArticulosUnidadVentaId = new HashSet<ArticulosUnidadVenta>();
            ArticulosUnidadVentaIdNavigation = new HashSet<ArticulosUnidadVenta>();
            DetallesAjusteInventario = new HashSet<DetallesAjusteInventario>();
            DetallesEntradaInventario = new HashSet<DetallesEntradaInventario>();
            DetallesSalidaInventario = new HashSet<DetallesSalidaInventario>();
            KeywordsArticulos = new HashSet<KeywordsArticulos>();
            Precios = new HashSet<Precios>();
            ProductosRespaldoId = new HashSet<ProductosRespaldo>();
            ProductosRespaldoIdNavigation = new HashSet<ProductosRespaldo>();
        }

        public int IdArticulo { get; set; }
        public int IdProducto { get; set; }
        public string Nombre { get; set; }
        public string CodUnicoListaencasa { get; set; }
        public string CodUnicoFabricante { get; set; }
        public string UrlThumbnail { get; set; }
        public bool EnPromocion { get; set; }
        public DateTime? UltimaOrden { get; set; }
        public DateTime? FechaDisponible { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public DateTime? FechaActualizacion { get; set; }
        public bool EstadoRegistro { get; set; }
        public string LargeImgUrl { get; set; }
        public string MediumImgUrl { get; set; }
        public decimal? Iva { get; set; }
        public bool EsCuaderno { get; set; }
        public bool? TieneImagen { get; set; }
        public string NombreBuscador { get; set; }
        public bool? IvaExcluido { get; set; }

        public Productos IdProductoNavigation { get; set; }
        public ICollection<ArticulosAtributosValores> ArticulosAtributosValores { get; set; }
        public ICollection<ArticulosDetallesListaPedido> ArticulosDetallesListaPedido { get; set; }
        public ICollection<ArticulosPorFacturaCompra> ArticulosPorFacturaCompra { get; set; }
        public ICollection<ArticulosPorFacturaVenta> ArticulosPorFacturaVenta { get; set; }
        public ICollection<ArticulosPorInstitucion> ArticulosPorInstitucion { get; set; }
        public ICollection<ArticulosPorLista> ArticulosPorLista { get; set; }
        public ICollection<ArticulosPorOrden> ArticulosPorOrden { get; set; }
        public ICollection<ArticulosPorPedido> ArticulosPorPedido { get; set; }
        public ICollection<ArticulosUnidadVenta> ArticulosUnidadVentaId { get; set; }
        public ICollection<ArticulosUnidadVenta> ArticulosUnidadVentaIdNavigation { get; set; }
        public ICollection<DetallesAjusteInventario> DetallesAjusteInventario { get; set; }
        public ICollection<DetallesEntradaInventario> DetallesEntradaInventario { get; set; }
        public ICollection<DetallesSalidaInventario> DetallesSalidaInventario { get; set; }
        public ICollection<KeywordsArticulos> KeywordsArticulos { get; set; }
        public ICollection<Precios> Precios { get; set; }
        public ICollection<ProductosRespaldo> ProductosRespaldoId { get; set; }
        public ICollection<ProductosRespaldo> ProductosRespaldoIdNavigation { get; set; }
    }
}
