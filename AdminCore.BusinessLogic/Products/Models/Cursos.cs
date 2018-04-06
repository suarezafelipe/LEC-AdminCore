using System;
using System.Collections.Generic;

namespace AdminCore.BusinessLogic.Products.Models
{
    public partial class Cursos
    {
        public Cursos()
        {
            ListasEscolares = new HashSet<ListasEscolares>();
        }

        public int IdCurso { get; set; }
        public string Nombre { get; set; }
        public int? Secuencia { get; set; }
        public string Nivel { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public DateTime? FechaActualizacion { get; set; }
        public bool EstadoRegistro { get; set; }
        public int IdIndividuo { get; set; }

        public Instituciones IdIndividuoNavigation { get; set; }
        public ICollection<ListasEscolares> ListasEscolares { get; set; }
    }
}
