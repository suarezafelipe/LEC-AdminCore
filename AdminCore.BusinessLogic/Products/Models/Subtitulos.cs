using System;
using System.Collections.Generic;

namespace AdminCore.BusinessLogic.Products.Models
{
    public partial class Subtitulos
    {
        public int IdSubtitulo { get; set; }
        public string TipoEstilo { get; set; }
        public string Texto { get; set; }
        public int Secuencia { get; set; }
        public int? IdPost { get; set; }

        public Posts IdPostNavigation { get; set; }
    }
}
