using System;
using System.Collections.Generic;

namespace AdminCore.BusinessLogic.Products.Models
{
    public partial class Quotes
    {
        public int IdQuote { get; set; }
        public string TipoQuote { get; set; }
        public string Texto { get; set; }
        public int Secuencia { get; set; }
        public int? IdParrafo { get; set; }

        public Parrafos IdParrafoNavigation { get; set; }
    }
}
