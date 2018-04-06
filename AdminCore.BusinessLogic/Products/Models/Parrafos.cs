using System;
using System.Collections.Generic;

namespace AdminCore.BusinessLogic.Products.Models
{
    public partial class Parrafos
    {
        public Parrafos()
        {
            Quotes = new HashSet<Quotes>();
        }

        public int IdParrafo { get; set; }
        public string TipoParrafo { get; set; }
        public string Texto { get; set; }
        public int Secuencia { get; set; }
        public int IdPost { get; set; }
        public string Quote { get; set; }

        public Posts IdPostNavigation { get; set; }
        public ICollection<Quotes> Quotes { get; set; }
    }
}
