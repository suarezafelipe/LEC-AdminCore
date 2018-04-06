using System;
using System.Collections.Generic;

namespace AdminCore.BusinessLogic.Products.Models
{
    public partial class Valoraciones
    {
        public int IdIndividuo { get; set; }
        public int IdProducto { get; set; }
        public int Ranking { get; set; }
        public string Titulo { get; set; }
        public string Comentario { get; set; }
        public DateTime FechaComentario { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public DateTime? FechaActualizacion { get; set; }
        public bool EstadoRegistro { get; set; }

        public Personas IdIndividuoNavigation { get; set; }
        public Productos IdProductoNavigation { get; set; }
    }
}
