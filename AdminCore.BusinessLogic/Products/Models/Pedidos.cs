using System;
using System.Collections.Generic;

namespace AdminCore.BusinessLogic.Products.Models
{
    public partial class Pedidos
    {
        public Pedidos()
        {
            ArticulosPorInstitucion = new HashSet<ArticulosPorInstitucion>();
            ArticulosPorPedido = new HashSet<ArticulosPorPedido>();
            DetallesListaPedido = new HashSet<DetallesListaPedido>();
            FacturasVentas = new HashSet<FacturasVentas>();
            PedidoInfoPayu = new HashSet<PedidoInfoPayu>();
        }

        public int IdPedido { get; set; }
        public DateTime FechaPedido { get; set; }
        public string EstadoDePedido { get; set; }
        public string EstadoDePago { get; set; }
        public string TipoPago { get; set; }
        public string MedioPago { get; set; }
        public decimal? Total { get; set; }
        public string NumFactura { get; set; }
        public string Comentario { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public DateTime? FechaActualizacion { get; set; }
        public bool EstadoRegistro { get; set; }
        public int? IdDescuento { get; set; }
        public int IdIndividuo { get; set; }
        public int IdUbicacion { get; set; }
        public string NombreEstudiante { get; set; }
        public string Curso { get; set; }
        public DateTime? FechaClienteCe { get; set; }
        public int? IdOrdenCompra { get; set; }
        public decimal? CostoEnvio { get; set; }
        public decimal? CostoMarcado { get; set; }
        public string NombreMarcado { get; set; }

        public Descuentos IdDescuentoNavigation { get; set; }
        public Individuos IdIndividuoNavigation { get; set; }
        public OrdenCompra IdOrdenCompraNavigation { get; set; }
        public Ubicaciones IdUbicacionNavigation { get; set; }
        public ICollection<ArticulosPorInstitucion> ArticulosPorInstitucion { get; set; }
        public ICollection<ArticulosPorPedido> ArticulosPorPedido { get; set; }
        public ICollection<DetallesListaPedido> DetallesListaPedido { get; set; }
        public ICollection<FacturasVentas> FacturasVentas { get; set; }
        public ICollection<PedidoInfoPayu> PedidoInfoPayu { get; set; }
    }
}
