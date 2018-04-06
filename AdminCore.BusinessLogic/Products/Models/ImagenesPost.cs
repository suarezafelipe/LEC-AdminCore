using System;
using System.Collections.Generic;

namespace AdminCore.BusinessLogic.Products.Models
{
    public partial class ImagenesPost
    {
        public int IdPostImagen { get; set; }
        public string TipoImagen { get; set; }
        public string Url { get; set; }
        public int Secuencia { get; set; }
        public int? IdPost { get; set; }

        public Posts IdPostNavigation { get; set; }
    }
}
