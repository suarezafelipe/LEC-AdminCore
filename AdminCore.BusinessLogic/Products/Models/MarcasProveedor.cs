using System;
using System.Collections.Generic;

namespace AdminCore.BusinessLogic.Products.Models
{
    public partial class MarcasProveedor
    {
        public int MarcasIdMarca { get; set; }
        public int ProveedoresIdIndividuo { get; set; }

        public Marcas MarcasIdMarcaNavigation { get; set; }
        public Proveedores ProveedoresIdIndividuoNavigation { get; set; }
    }
}
