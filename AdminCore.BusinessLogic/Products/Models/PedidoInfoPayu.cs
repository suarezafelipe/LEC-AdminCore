using System;
using System.Collections.Generic;

namespace AdminCore.BusinessLogic.Products.Models
{
    public partial class PedidoInfoPayu
    {
        public int IdPedidoInfo { get; set; }
        public decimal? Riesgo { get; set; }
        public string PolResponseCode { get; set; }
        public string LapResponseCode { get; set; }
        public string CodigoReferencia { get; set; }
        public string ReferencePol { get; set; }
        public int? Cuotas { get; set; }
        public DateTime? FechaPago { get; set; }
        public string Moneda { get; set; }
        public string PseCodigoSeguimiento { get; set; }
        public string Descripción { get; set; }
        public string MensajeTransaccion { get; set; }
        public string CodigoAutorizacionVenta { get; set; }
        public int? PseId { get; set; }
        public string PseReference1 { get; set; }
        public string PseReference2 { get; set; }
        public string PseReference3 { get; set; }
        public string TransaccionId { get; set; }
        public string CodigoSeguimiento { get; set; }
        public decimal? TarifaAdministrativaTx { get; set; }
        public decimal? ImpuestoTx { get; set; }
        public decimal? ValorBaseTx { get; set; }
        public string PolTransactionState { get; set; }
        public string TelefonoUsuarioPago { get; set; }
        public bool EstadoRegistro { get; set; }
        public int IdPedido { get; set; }
        public decimal ValorPagado { get; set; }
        public decimal Iva { get; set; }

        public Pedidos IdPedidoNavigation { get; set; }
    }
}
