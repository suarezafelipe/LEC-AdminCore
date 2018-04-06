using System;
using System.Collections.Generic;

namespace AdminCore.BusinessLogic.Products.Models
{
    public partial class Posts
    {
        public Posts()
        {
            ImagenesPost = new HashSet<ImagenesPost>();
            Parrafos = new HashSet<Parrafos>();
            Subtitulos = new HashSet<Subtitulos>();
        }

        public int IdPost { get; set; }
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public string Email { get; set; }
        public string UrlImagenPrincipal { get; set; }
        public string TipoPost { get; set; }
        public bool TieneImagen { get; set; }
        public string Resumen { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime FechaActualizacion { get; set; }
        public bool EstadoRegistro { get; set; }

        public ICollection<ImagenesPost> ImagenesPost { get; set; }
        public ICollection<Parrafos> Parrafos { get; set; }
        public ICollection<Subtitulos> Subtitulos { get; set; }
    }
}
