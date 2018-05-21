using AdminCore.BusinessLogic.Products.Models;
using AdminCore.Persistence.Mapping.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace AdminCore.Persistence.Mapping.SQLServerMap
{
    public class ToBeDeleted : IToBeDeleted
    {
        public virtual DbSet<KeywordsArticulos> KeywordsArticulos { get; set; }
        public virtual DbSet<KeywordsCategorias> KeywordsCategorias { get; set; }
        public virtual DbSet<KeywordsProductos> KeywordsProductos { get; set; }
        public virtual DbSet<PalabrasClave> PalabrasClave { get; set; }
        public virtual DbSet<EstadisticasIcfes> EstadisticasIcfes { get; set; }

        public ModelBuilder LecDbBuilder(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<EstadisticasIcfes>(entity =>
            {
                entity.HasKey(e => new { e.FechaPrueba, e.IdIndividuo });

                entity.ToTable("ESTADISTICAS_ICFES");

                entity.HasIndex(e => e.IdIndividuo)
                    .HasName("IX_ID_INDIVIDUO");

                entity.Property(e => e.FechaPrueba)
                    .HasColumnName("FECHA_PRUEBA")
                    .HasColumnType("datetime");

                entity.Property(e => e.IdIndividuo).HasColumnName("ID_INDIVIDUO");

                entity.Property(e => e.EstadoRegistro).HasColumnName("ESTADO_REGISTRO");

                entity.Property(e => e.EstudiantesIcfes).HasColumnName("ESTUDIANTES_ICFES");

                entity.Property(e => e.FechaCreacion)
                    .HasColumnName("FECHA_CREACION")
                    .HasColumnType("datetime");

                entity.Property(e => e.NivelIcfes)
                    .HasColumnName("NIVEL_ICFES")
                    .HasMaxLength(16);

                entity.Property(e => e.PuntajeInstitucion).HasColumnName("PUNTAJE_INSTITUCION");

                entity.Property(e => e.TotalEstudiantes).HasColumnName("TOTAL_ESTUDIANTES");

                entity.Property(e => e.UltimaModificacion)
                    .HasColumnName("ULTIMA_MODIFICACION")
                    .HasColumnType("datetime");

                entity.HasOne(d => d.IdIndividuoNavigation)
                    .WithMany(p => p.EstadisticasIcfes)
                    .HasForeignKey(d => d.IdIndividuo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.ESTADISTICAS_ICFES_dbo.INSTITUCIONES_ID_INDIVIDUO");
            });
            
            modelBuilder.Entity<KeywordsArticulos>(entity =>
            {
                entity.HasKey(e => new { e.ArticulosIdArticulo, e.ArticulosIdProducto, e.PalabrasClaveIdPalabra });

                entity.ToTable("KEYWORDS_ARTICULOS");

                entity.HasIndex(e => e.PalabrasClaveIdPalabra)
                    .HasName("IX_PALABRAS_CLAVE_ID_PALABRA");

                entity.HasIndex(e => new { e.ArticulosIdArticulo, e.ArticulosIdProducto })
                    .HasName("IX_ARTICULOS_ID_ARTICULO_ARTICULOS_ID_PRODUCTO");

                entity.Property(e => e.ArticulosIdArticulo).HasColumnName("ARTICULOS_ID_ARTICULO");

                entity.Property(e => e.ArticulosIdProducto).HasColumnName("ARTICULOS_ID_PRODUCTO");

                entity.Property(e => e.PalabrasClaveIdPalabra).HasColumnName("PALABRAS_CLAVE_ID_PALABRA");

                entity.HasOne(d => d.PalabrasClaveIdPalabraNavigation)
                    .WithMany(p => p.KeywordsArticulos)
                    .HasForeignKey(d => d.PalabrasClaveIdPalabra)
                    .HasConstraintName("FK_dbo.KEYWORDS_ARTICULOS_dbo.PALABRAS_CLAVE_PALABRAS_CLAVE_ID_PALABRA");

                entity.HasOne(d => d.Articulos)
                    .WithMany(p => p.KeywordsArticulos)
                    .HasForeignKey(d => new { d.ArticulosIdArticulo, d.ArticulosIdProducto })
                    .HasConstraintName("FK_dbo.KEYWORDS_ARTICULOS_dbo.ARTICULOS_ARTICULOS_ID_ARTICULO_ARTICULOS_ID_PRODUCTO");
            });

            modelBuilder.Entity<KeywordsCategorias>(entity =>
            {
                entity.HasKey(e => new { e.CategoriasIdCategoria, e.PalabrasClaveIdPalabra });

                entity.ToTable("KEYWORDS_CATEGORIAS");

                entity.HasIndex(e => e.CategoriasIdCategoria)
                    .HasName("IX_CATEGORIAS_ID_CATEGORIA");

                entity.HasIndex(e => e.PalabrasClaveIdPalabra)
                    .HasName("IX_PALABRAS_CLAVE_ID_PALABRA");

                entity.Property(e => e.CategoriasIdCategoria).HasColumnName("CATEGORIAS_ID_CATEGORIA");

                entity.Property(e => e.PalabrasClaveIdPalabra).HasColumnName("PALABRAS_CLAVE_ID_PALABRA");

                entity.HasOne(d => d.CategoriasIdCategoriaNavigation)
                    .WithMany(p => p.KeywordsCategorias)
                    .HasForeignKey(d => d.CategoriasIdCategoria)
                    .HasConstraintName("FK_dbo.KEYWORDS_CATEGORIAS_dbo.CATEGORIAS_CATEGORIAS_ID_CATEGORIA");

                entity.HasOne(d => d.PalabrasClaveIdPalabraNavigation)
                    .WithMany(p => p.KeywordsCategorias)
                    .HasForeignKey(d => d.PalabrasClaveIdPalabra)
                    .HasConstraintName("FK_dbo.KEYWORDS_CATEGORIAS_dbo.PALABRAS_CLAVE_PALABRAS_CLAVE_ID_PALABRA");
            });

            modelBuilder.Entity<KeywordsProductos>(entity =>
            {
                entity.HasKey(e => new { e.ProductosIdProducto, e.PalabrasClaveIdPalabra });

                entity.ToTable("KEYWORDS_PRODUCTOS");

                entity.HasIndex(e => e.PalabrasClaveIdPalabra)
                    .HasName("IX_PALABRAS_CLAVE_ID_PALABRA");

                entity.HasIndex(e => e.ProductosIdProducto)
                    .HasName("IX_PRODUCTOS_ID_PRODUCTO");

                entity.Property(e => e.ProductosIdProducto).HasColumnName("PRODUCTOS_ID_PRODUCTO");

                entity.Property(e => e.PalabrasClaveIdPalabra).HasColumnName("PALABRAS_CLAVE_ID_PALABRA");

                entity.HasOne(d => d.PalabrasClaveIdPalabraNavigation)
                    .WithMany(p => p.KeywordsProductos)
                    .HasForeignKey(d => d.PalabrasClaveIdPalabra)
                    .HasConstraintName("FK_dbo.KEYWORDS_PRODUCTOS_dbo.PALABRAS_CLAVE_PALABRAS_CLAVE_ID_PALABRA");

                entity.HasOne(d => d.ProductosIdProductoNavigation)
                    .WithMany(p => p.KeywordsProductos)
                    .HasForeignKey(d => d.ProductosIdProducto)
                    .HasConstraintName("FK_dbo.KEYWORDS_PRODUCTOS_dbo.PRODUCTOS_PRODUCTOS_ID_PRODUCTO");
            });

            return modelBuilder;
        }
    }
}
