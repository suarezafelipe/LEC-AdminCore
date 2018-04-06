using System;
using System.Collections.Generic;

namespace AdminCore.BusinessLogic.Products.Models
{
    public partial class PayuResponseLog
    {
        public int IdPayuResponse { get; set; }
        public string Mensaje { get; set; }
        public string CodigoReferencia { get; set; }
        public string NombreUsuario { get; set; }
        public int IdUsuario { get; set; }
        public string Email { get; set; }
        public string Identificador { get; set; }
        public string LapTransactionState { get; set; }
        public int TransactionState { get; set; }
        public string PolTransactionState { get; set; }
        public string LapResponseCode { get; set; }
        public string PolResponseCode { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime FechaActualizacion { get; set; }
        public bool EstadoRegistro { get; set; }
        public bool Checked { get; set; }
        public string PolReference { get; set; }
        public string LapPaymentMethod { get; set; }
        public string LapPaymentMethodType { get; set; }
        public string OrigenError { get; set; }
        public decimal ValorPagado { get; set; }
        public decimal Iva { get; set; }
    }
}
