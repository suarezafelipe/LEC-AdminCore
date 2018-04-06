using System;
using System.Collections.Generic;

namespace AdminCore.BusinessLogic.Products.Models
{
    public partial class ClienteCarritoCompra
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string NumeroIdentificacion { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public int IdCiudad { get; set; }
        public string Ciudad { get; set; }
        public string Email { get; set; }
        public int IdIndividuo { get; set; }
        public string CodigoPedido { get; set; }
        public DateTime FechaCreacion { get; set; }
        public int IdUbicacion { get; set; }
    }
}
