﻿using System;
using System.Collections.Generic;

namespace AdminCore.BusinessLogic.Products.Models
{
    public partial class ArticulosPrePedido
    {
        public int IdArticulo { get; set; }
        public int IdPrePedido { get; set; }
        public int IdProducto { get; set; }
        public int Cantidad { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public DateTime? FechaActualizacion { get; set; }
        public bool EstadoRegistro { get; set; }
        public decimal? PrecioConIva { get; set; }

        public PrePedidos IdPrePedidoNavigation { get; set; }
    }
}
