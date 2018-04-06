using System;
using System.Collections.Generic;

namespace AdminCore.BusinessLogic.Products.Models
{
    public partial class Productos
    {
        public Productos()
        {
            Articulos = new HashSet<Articulos>();
            CategoriaProd = new HashSet<CategoriaProd>();
            DescripcionProducto = new HashSet<DescripcionProducto>();
            KeywordsProductos = new HashSet<KeywordsProductos>();
            Valoraciones = new HashSet<Valoraciones>();
            VersionProducto = new HashSet<VersionProducto>();
        }

        public int IdProducto { get; set; }
        public string Nombre { get; set; }
        public int? NumeroUnidVenta { get; set; }
        public bool PorMayor { get; set; }
        public DateTime? FechaVencimiento { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public DateTime? FechaActualizacion { get; set; }
        public bool EstadoRegistro { get; set; }
        public int IdMarca { get; set; }
        public int? Prioridad { get; set; }
        public int? Secuencia { get; set; }
        public string SmallImgUrl { get; set; }
        public string MediumImgUrl { get; set; }
        public string LargeImgUrl { get; set; }
        public int? IdCategoriaContabilidad { get; set; }
        public string NombreBuscador { get; set; }
        public bool? TieneImagen { get; set; }
        public bool Disponible { get; set; }
        public int? Peso { get; set; }
        public int? IdUnidadVenta { get; set; }
        public int? ValorMarcado { get; set; }

        public CategoriasContabilidad IdCategoriaContabilidadNavigation { get; set; }
        public Marcas IdMarcaNavigation { get; set; }
        public ICollection<Articulos> Articulos { get; set; }
        public ICollection<CategoriaProd> CategoriaProd { get; set; }
        public ICollection<DescripcionProducto> DescripcionProducto { get; set; }
        public ICollection<KeywordsProductos> KeywordsProductos { get; set; }
        public ICollection<Valoraciones> Valoraciones { get; set; }
        public ICollection<VersionProducto> VersionProducto { get; set; }
    }
}
