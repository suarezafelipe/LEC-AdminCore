using System;
using System.Collections.Generic;

namespace AdminCore.BusinessLogic.Products.Models
{
    public partial class Proveedores
    {
        public Proveedores()
        {
            FacturasCompras = new HashSet<FacturasCompras>();
            MarcasProveedor = new HashSet<MarcasProveedor>();
            OrdenCompra = new HashSet<OrdenCompra>();
        }

        public int IdIndividuo { get; set; }
        public string TipoIdentificacion { get; set; }
        public string NumIdentificacion { get; set; }
        public string TipoProveedor { get; set; }
        public string RazonSocial { get; set; }
        public bool? PagoTarjeta { get; set; }
        public bool? DanCredito { get; set; }
        public double? ValorCompraMin { get; set; }
        public string UrlSitioWeb { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public DateTime? FechaActualizacion { get; set; }
        public bool EstadoRegistro { get; set; }
        public int IdAcvtividadEconomica { get; set; }
        public string NombreComercial { get; set; }
        public int? Secuencia { get; set; }
        public bool? Autoretenedor { get; set; }

        public ActividadesEconomicas IdAcvtividadEconomicaNavigation { get; set; }
        public Individuos IdIndividuoNavigation { get; set; }
        public ICollection<FacturasCompras> FacturasCompras { get; set; }
        public ICollection<MarcasProveedor> MarcasProveedor { get; set; }
        public ICollection<OrdenCompra> OrdenCompra { get; set; }
    }
}
