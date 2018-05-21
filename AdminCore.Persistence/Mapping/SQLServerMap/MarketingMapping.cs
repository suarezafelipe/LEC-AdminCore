using AdminCore.BusinessLogic.Products.Models;
using AdminCore.Persistence.Mapping.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace AdminCore.Persistence.Mapping.SQLServerMap
{
    public class MarketingMapping : IMarketingMapping
    {
        public virtual DbSet<Parrafos> Parrafos { get; set; }
        public virtual DbSet<Subtitulos> Subtitulos { get; set; }
        public virtual DbSet<Posts> Posts { get; set; }
        public virtual DbSet<ImagenesPost> ImagenesPost { get; set; }
        public virtual DbSet<Quotes> Quotes { get; set; }

        public ModelBuilder LecDbBuilder(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Parrafos>(entity =>
            {
                entity.HasKey(e => e.IdParrafo);

                entity.ToTable("PARRAFOS");

                entity.HasIndex(e => e.IdPost)
                    .HasName("IX_ID_POST");

                entity.Property(e => e.IdParrafo).HasColumnName("ID_PARRAFO");

                entity.Property(e => e.IdPost).HasColumnName("ID_POST");

                entity.Property(e => e.Quote)
                    .HasColumnName("QUOTE")
                    .HasMaxLength(2000);

                entity.Property(e => e.Secuencia).HasColumnName("SECUENCIA");

                entity.Property(e => e.Texto)
                    .HasColumnName("TEXTO")
                    .HasMaxLength(3000);

                entity.Property(e => e.TipoParrafo)
                    .HasColumnName("TIPO_PARRAFO")
                    .HasMaxLength(20);

                entity.HasOne(d => d.IdPostNavigation)
                    .WithMany(p => p.Parrafos)
                    .HasForeignKey(d => d.IdPost)
                    .HasConstraintName("FK_dbo.PARRAFOS_dbo.POSTS_ID_POST");
            });

            modelBuilder.Entity<Posts>(entity =>
            {
                entity.HasKey(e => e.IdPost);

                entity.ToTable("POSTS");

                entity.Property(e => e.IdPost).HasColumnName("ID_POST");

                entity.Property(e => e.Autor)
                    .HasColumnName("AUTOR")
                    .HasMaxLength(90);

                entity.Property(e => e.Email)
                    .HasColumnName("EMAIL")
                    .HasMaxLength(80);

                entity.Property(e => e.EstadoRegistro).HasColumnName("ESTADO_REGISTRO");

                entity.Property(e => e.FechaActualizacion)
                    .HasColumnName("FECHA_ACTUALIZACION")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("('1900-01-01T00:00:00.000')");

                entity.Property(e => e.FechaCreacion)
                    .HasColumnName("FECHA_CREACION")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("('1900-01-01T00:00:00.000')");

                entity.Property(e => e.Resumen)
                    .HasColumnName("RESUMEN")
                    .HasMaxLength(500);

                entity.Property(e => e.TieneImagen).HasColumnName("TIENE_IMAGEN");

                entity.Property(e => e.TipoPost)
                    .HasColumnName("TIPO_POST")
                    .HasMaxLength(20);

                entity.Property(e => e.Titulo)
                    .HasColumnName("TITULO")
                    .HasMaxLength(80);

                entity.Property(e => e.UrlImagenPrincipal)
                    .HasColumnName("URL_IMAGEN_PRINCIPAL")
                    .HasMaxLength(300);
            });

            modelBuilder.Entity<Subtitulos>(entity =>
            {
                entity.HasKey(e => e.IdSubtitulo);

                entity.ToTable("SUBTITULOS");

                entity.HasIndex(e => e.IdPost)
                    .HasName("IX_ID_POST");

                entity.Property(e => e.IdSubtitulo).HasColumnName("ID_SUBTITULO");

                entity.Property(e => e.IdPost).HasColumnName("ID_POST");

                entity.Property(e => e.Secuencia).HasColumnName("SECUENCIA");

                entity.Property(e => e.Texto)
                    .HasColumnName("TEXTO")
                    .HasMaxLength(300);

                entity.Property(e => e.TipoEstilo)
                    .HasColumnName("TIPO_ESTILO")
                    .HasMaxLength(30);

                entity.HasOne(d => d.IdPostNavigation)
                    .WithMany(p => p.Subtitulos)
                    .HasForeignKey(d => d.IdPost)
                    .HasConstraintName("FK_dbo.SUBTITULOS_dbo.POSTS_ID_POST");
            });

            modelBuilder.Entity<ImagenesPost>(entity =>
            {
                entity.HasKey(e => e.IdPostImagen);

                entity.ToTable("IMAGENES_POST");

                entity.HasIndex(e => e.IdPost)
                    .HasName("IX_ID_POST");

                entity.Property(e => e.IdPostImagen).HasColumnName("ID_POST_IMAGEN");

                entity.Property(e => e.IdPost).HasColumnName("ID_POST");

                entity.Property(e => e.Secuencia).HasColumnName("SECUENCIA");

                entity.Property(e => e.TipoImagen)
                    .HasColumnName("TIPO_IMAGEN")
                    .HasMaxLength(20);

                entity.Property(e => e.Url)
                    .HasColumnName("URL")
                    .HasMaxLength(300);

                entity.HasOne(d => d.IdPostNavigation)
                    .WithMany(p => p.ImagenesPost)
                    .HasForeignKey(d => d.IdPost)
                    .HasConstraintName("FK_dbo.IMAGENES_POST_dbo.POSTS_ID_POST");
            });

            modelBuilder.Entity<Quotes>(entity =>
            {
                entity.HasKey(e => e.IdQuote);

                entity.ToTable("QUOTES");

                entity.HasIndex(e => e.IdParrafo)
                    .HasName("IX_ID_PARRAFO");

                entity.Property(e => e.IdQuote).HasColumnName("ID_QUOTE");

                entity.Property(e => e.IdParrafo).HasColumnName("ID_PARRAFO");

                entity.Property(e => e.Secuencia).HasColumnName("SECUENCIA");

                entity.Property(e => e.Texto)
                    .HasColumnName("TEXTO")
                    .HasMaxLength(3000);

                entity.Property(e => e.TipoQuote)
                    .HasColumnName("TIPO_QUOTE")
                    .HasMaxLength(20);

                entity.HasOne(d => d.IdParrafoNavigation)
                    .WithMany(p => p.Quotes)
                    .HasForeignKey(d => d.IdParrafo)
                    .HasConstraintName("FK_dbo.QUOTES_dbo.PARRAFOS_ID_PARRAFO");
            });

            return modelBuilder;
        }



    }
}
