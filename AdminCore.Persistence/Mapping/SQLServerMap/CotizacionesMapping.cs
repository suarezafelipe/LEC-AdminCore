using AdminCore.BusinessLogic.Products.Models;
using AdminCore.Persistence.Mapping.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace AdminCore.Persistence.Mapping.SQLServerMap
{
    public class CotizacionesMapping : ICotizacionesMapping
    {
        protected virtual DbSet<ArticulosPorLista> ArticulosPorLista { get; set; }
        protected virtual DbSet<AtribsInstituciones> AtributosInstituciones { get; set; }
        protected virtual DbSet<CotizacionesListaEscolar> CotizacionesListasEscolares { get; set; }
        protected virtual DbSet<Cursos> Cursos { get; set; }
        protected virtual DbSet<HistoricoListas> HistoricoListas { get; set; }
        protected virtual DbSet<Instituciones> Instituciones { get; set; }
        protected virtual DbSet<ListasEscolares> ListasEscolares { get; set; }
        protected virtual DbSet<Sedes> Sedes { get; set; }
        
        public ModelBuilder LecDbBuilder(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ArticulosPorLista>(entity =>
            {
                entity.HasKey(e => new { e.IdArticulo, e.IdLista, e.IdProducto });

                entity.ToTable("ARTICULOS_POR_LISTA");

                entity.HasIndex(e => e.IdLista)
                    .HasName("IX_ID_LISTA");

                entity.HasIndex(e => new { e.IdArticulo, e.IdProducto })
                    .HasName("IX_ID_ARTICULO_ID_PRODUCTO");

                entity.Property(e => e.IdArticulo).HasColumnName("ID_ARTICULO");

                entity.Property(e => e.IdLista).HasColumnName("ID_LISTA");

                entity.Property(e => e.IdProducto).HasColumnName("ID_PRODUCTO");

                entity.Property(e => e.Cantidad).HasColumnName("CANTIDAD");

                entity.Property(e => e.EstadoRegistro).HasColumnName("ESTADO_REGISTRO");

                entity.Property(e => e.FechaActualizacion)
                    .HasColumnName("FECHA_ACTUALIZACION")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaCreacion)
                    .HasColumnName("FECHA_CREACION")
                    .HasColumnType("datetime");

                entity.Property(e => e.Obligatorio).HasColumnName("OBLIGATORIO");

                entity.Property(e => e.Secuencia).HasColumnName("SECUENCIA");

                entity.Property(e => e.TieneMarcado).HasColumnName("TIENE_MARCADO");

                entity.HasOne(d => d.IdListaNavigation)
                    .WithMany(p => p.ArticulosPorLista)
                    .HasForeignKey(d => d.IdLista)
                    .HasConstraintName("FK_dbo.ARTICULOS_POR_LISTA_dbo.LISTAS_ESCOLARES_ID_LISTA");

                entity.HasOne(d => d.Id)
                    .WithMany(p => p.ArticulosPorLista)
                    .HasForeignKey(d => new { d.IdArticulo, d.IdProducto })
                    .HasConstraintName("FK_dbo.ARTICULOS_POR_LISTA_dbo.ARTICULOS_ID_ARTICULO_ID_PRODUCTO");
            });

            modelBuilder.Entity<AtribsInstituciones>(entity =>
            {
                entity.HasKey(e => e.IdIndividuo);

                entity.ToTable("ATRIBS_INSTITUCIONES");

                entity.HasIndex(e => e.IdIndividuo)
                    .HasName("IX_ID_INDIVIDUO");

                entity.Property(e => e.IdIndividuo)
                    .HasColumnName("ID_INDIVIDUO")
                    .ValueGeneratedNever();

                entity.Property(e => e.AnioPension).HasColumnName("ANIO_PENSION");

                entity.Property(e => e.EstadoRegistro).HasColumnName("ESTADO_REGISTRO");

                entity.Property(e => e.FechaActualizacion)
                    .HasColumnName("FECHA_ACTUALIZACION")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaCreacion)
                    .HasColumnName("FECHA_CREACION")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaMatricula)
                    .HasColumnName("FECHA_MATRICULA")
                    .HasColumnType("datetime");

                entity.Property(e => e.FinClases)
                    .HasColumnName("FIN_CLASES")
                    .HasColumnType("datetime");

                entity.Property(e => e.InicioClases)
                    .HasColumnName("INICIO_CLASES")
                    .HasColumnType("datetime");

                entity.Property(e => e.Jornada)
                    .HasColumnName("JORNADA")
                    .HasMaxLength(30);

                entity.Property(e => e.NombreRector)
                    .HasColumnName("NOMBRE_RECTOR")
                    .HasMaxLength(100);

                entity.Property(e => e.UrlSitioWeb)
                    .HasColumnName("URL_SITIO_WEB")
                    .HasMaxLength(300);

                entity.Property(e => e.ValorMatricula).HasColumnName("VALOR_MATRICULA");

                entity.Property(e => e.ValorPension1).HasColumnName("VALOR_PENSION_1");

                entity.Property(e => e.VendeTextos).HasColumnName("VENDE_TEXTOS");

                entity.Property(e => e.VendeUtiles).HasColumnName("VENDE_UTILES");

                entity.HasOne(d => d.IdIndividuoNavigation)
                    .WithOne(p => p.AtribsInstituciones)
                    .HasForeignKey<AtribsInstituciones>(d => d.IdIndividuo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.ATRIBS_INSTITUCIONES_dbo.INSTITUCIONES_ID_INDIVIDUO");
            });

            modelBuilder.Entity<CotizacionesListaEscolar>(entity =>
            {
                entity.HasKey(e => e.IdCotizacion);

                entity.ToTable("COTIZACIONES_LISTA_ESCOLAR");

                entity.Property(e => e.IdCotizacion).HasColumnName("ID_COTIZACION");

                entity.Property(e => e.Curso)
                    .IsRequired()
                    .HasColumnName("CURSO")
                    .HasMaxLength(20);

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasColumnName("EMAIL")
                    .HasMaxLength(64);

                entity.Property(e => e.Estado).HasColumnName("ESTADO");

                entity.Property(e => e.FechaRespuesta)
                    .HasColumnName("FECHA_RESPUESTA")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaSolicitud)
                    .HasColumnName("FECHA_SOLICITUD")
                    .HasColumnType("datetime");

                entity.Property(e => e.GeneroEstudiante).HasColumnName("GENERO_ESTUDIANTE");

                entity.Property(e => e.IdListaEscolar).HasColumnName("ID_LISTA_ESCOLAR");

                entity.Property(e => e.NombreColegio)
                    .IsRequired()
                    .HasColumnName("NOMBRE_COLEGIO")
                    .HasMaxLength(120);

                entity.Property(e => e.NombreCotizador)
                    .IsRequired()
                    .HasColumnName("NOMBRE_COTIZADOR")
                    .HasMaxLength(100);

                entity.Property(e => e.Telefono)
                    .HasColumnName("TELEFONO")
                    .HasMaxLength(15);
            });

            modelBuilder.Entity<Cursos>(entity =>
            {
                entity.HasKey(e => e.IdCurso);

                entity.ToTable("CURSOS");

                entity.HasIndex(e => e.IdIndividuo)
                    .HasName("IX_ID_INDIVIDUO");

                entity.Property(e => e.IdCurso).HasColumnName("ID_CURSO");

                entity.Property(e => e.EstadoRegistro).HasColumnName("ESTADO_REGISTRO");

                entity.Property(e => e.FechaActualizacion)
                    .HasColumnName("FECHA_ACTUALIZACION")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaCreacion)
                    .HasColumnName("FECHA_CREACION")
                    .HasColumnType("datetime");

                entity.Property(e => e.IdIndividuo).HasColumnName("ID_INDIVIDUO");

                entity.Property(e => e.Nivel)
                    .HasColumnName("NIVEL")
                    .HasMaxLength(15);

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("NOMBRE")
                    .HasMaxLength(45);

                entity.Property(e => e.Secuencia).HasColumnName("SECUENCIA");

                entity.HasOne(d => d.IdIndividuoNavigation)
                    .WithMany(p => p.Cursos)
                    .HasForeignKey(d => d.IdIndividuo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.CURSOS_dbo.INSTITUCIONES_ID_INDIVIDUO");
            });

            modelBuilder.Entity<HistoricoListas>(entity =>
            {
                entity.HasKey(e => new { e.FechaCambio, e.IdLista });

                entity.ToTable("HISTORICO_LISTAS");

                entity.HasIndex(e => e.IdLista)
                    .HasName("IX_ID_LISTA");

                entity.Property(e => e.FechaCambio)
                    .HasColumnName("FECHA_CAMBIO")
                    .HasColumnType("datetime");

                entity.Property(e => e.IdLista).HasColumnName("ID_LISTA");

                entity.Property(e => e.EstadoRegistro).HasColumnName("ESTADO_REGISTRO");

                entity.Property(e => e.FechaActualizacion)
                    .HasColumnName("FECHA_ACTUALIZACION")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaCreacion)
                    .HasColumnName("FECHA_CREACION")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaEstProxCambio)
                    .HasColumnName("FECHA_EST_PROX_CAMBIO")
                    .HasColumnType("datetime");

                entity.Property(e => e.RegistroCambios)
                    .HasColumnName("REGISTRO_CAMBIOS")
                    .HasMaxLength(900);

                entity.HasOne(d => d.IdListaNavigation)
                    .WithMany(p => p.HistoricoListas)
                    .HasForeignKey(d => d.IdLista)
                    .HasConstraintName("FK_dbo.HISTORICO_LISTAS_dbo.LISTAS_ESCOLARES_ID_LISTA");
            });

            modelBuilder.Entity<Instituciones>(entity =>
            {
                entity.HasKey(e => e.IdIndividuo);

                entity.ToTable("INSTITUCIONES");

                entity.HasIndex(e => e.IdDescuento)
                    .HasName("IX_ID_DESCUENTO");

                entity.HasIndex(e => e.IdIndividuo)
                    .HasName("IX_ID_INDIVIDUO");

                entity.Property(e => e.IdIndividuo)
                    .HasColumnName("ID_INDIVIDUO")
                    .ValueGeneratedNever();

                entity.Property(e => e.Aliado).HasColumnName("ALIADO");

                entity.Property(e => e.Calendario)
                    .HasColumnName("CALENDARIO")
                    .HasMaxLength(1);

                entity.Property(e => e.EstadoRegistro).HasColumnName("ESTADO_REGISTRO");

                entity.Property(e => e.FechaActualizacion)
                    .HasColumnName("FECHA_ACTUALIZACION")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaCreacion)
                    .HasColumnName("FECHA_CREACION")
                    .HasColumnType("datetime");

                entity.Property(e => e.IdDescuento).HasColumnName("ID_DESCUENTO");

                entity.Property(e => e.NombreBuscador)
                    .HasColumnName("NOMBRE_BUSCADOR")
                    .HasMaxLength(200);

                entity.Property(e => e.NombreCorto)
                    .HasColumnName("NOMBRE_CORTO")
                    .HasMaxLength(45);

                entity.Property(e => e.NombreOficial)
                    .HasColumnName("NOMBRE_OFICIAL")
                    .HasMaxLength(80);

                entity.Property(e => e.NumIdentificacion)
                    .HasColumnName("NUM_IDENTIFICACION")
                    .HasMaxLength(16);

                entity.Property(e => e.PideLista)
                    .IsRequired()
                    .HasColumnName("PIDE_LISTA")
                    .HasMaxLength(2);

                entity.Property(e => e.Publico).HasColumnName("PUBLICO");

                entity.Property(e => e.TipoIdentificacion)
                    .HasColumnName("TIPO_IDENTIFICACION")
                    .HasMaxLength(3);

                entity.Property(e => e.TipoInstitucion)
                    .IsRequired()
                    .HasColumnName("TIPO_INSTITUCION")
                    .HasMaxLength(16);

                entity.Property(e => e.UrlLogo)
                    .HasColumnName("URL_LOGO")
                    .HasMaxLength(300);

                entity.Property(e => e.UrlLogoMin)
                    .HasColumnName("URL_LOGO_MIN")
                    .HasMaxLength(300);

                entity.HasOne(d => d.IdDescuentoNavigation)
                    .WithMany(p => p.Instituciones)
                    .HasForeignKey(d => d.IdDescuento)
                    .HasConstraintName("FK_dbo.INSTITUCIONES_dbo.DESCUENTOS_ID_DESCUENTO");

                entity.HasOne(d => d.IdIndividuoNavigation)
                    .WithOne(p => p.Instituciones)
                    .HasForeignKey<Instituciones>(d => d.IdIndividuo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.INSTITUCIONES_dbo.INDIVIDUOS_ID_INDIVIDUO");
            });

            modelBuilder.Entity<ListasEscolares>(entity =>
            {
                entity.HasKey(e => e.IdLista);

                entity.ToTable("LISTAS_ESCOLARES");

                entity.HasIndex(e => e.IdCurso)
                    .HasName("IX_ID_CURSO");

                entity.Property(e => e.IdLista).HasColumnName("ID_LISTA");

                entity.Property(e => e.Alerta)
                    .HasColumnName("ALERTA")
                    .HasMaxLength(600);

                entity.Property(e => e.AnoLista).HasColumnName("ANO_LISTA");

                entity.Property(e => e.CodUnicoListaencasa)
                    .HasColumnName("COD_UNICO_LISTAENCASA")
                    .HasMaxLength(64);

                entity.Property(e => e.EstadoRegistro).HasColumnName("ESTADO_REGISTRO");

                entity.Property(e => e.FechaActualizacion)
                    .HasColumnName("FECHA_ACTUALIZACION")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaCreacion)
                    .HasColumnName("FECHA_CREACION")
                    .HasColumnType("datetime");

                entity.Property(e => e.IdCurso).HasColumnName("ID_CURSO");

                entity.Property(e => e.Origen)
                    .HasColumnName("ORIGEN")
                    .HasMaxLength(32);

                entity.HasOne(d => d.IdCursoNavigation)
                    .WithMany(p => p.ListasEscolares)
                    .HasForeignKey(d => d.IdCurso)
                    .HasConstraintName("FK_dbo.LISTAS_ESCOLARES_dbo.CURSOS_ID_CURSO");
            });

            modelBuilder.Entity<Sedes>(entity =>
            {
                entity.HasKey(e => e.IdSede);

                entity.ToTable("SEDES");

                entity.HasIndex(e => e.IdIndividuo)
                    .HasName("IX_ID_INDIVIDUO");

                entity.HasIndex(e => e.IdUbicacion)
                    .HasName("IX_ID_UBICACION");

                entity.Property(e => e.IdSede).HasColumnName("ID_SEDE");

                entity.Property(e => e.EstadoRegistro).HasColumnName("ESTADO_REGISTRO");

                entity.Property(e => e.FechaActualizacion)
                    .HasColumnName("FECHA_ACTUALIZACION")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaCreacion)
                    .HasColumnName("FECHA_CREACION")
                    .HasColumnType("datetime");

                entity.Property(e => e.FuncionAdicional1)
                    .HasColumnName("FUNCION_ADICIONAL_1")
                    .HasMaxLength(16);

                entity.Property(e => e.FuncionAdicional2)
                    .HasColumnName("FUNCION_ADICIONAL_2")
                    .HasMaxLength(16);

                entity.Property(e => e.FuncionAdicional3)
                    .HasColumnName("FUNCION_ADICIONAL_3")
                    .HasMaxLength(16);

                entity.Property(e => e.FuncionPrincipal)
                    .HasColumnName("FUNCION_PRINCIPAL")
                    .HasMaxLength(16);

                entity.Property(e => e.IdIndividuo).HasColumnName("ID_INDIVIDUO");

                entity.Property(e => e.IdUbicacion).HasColumnName("ID_UBICACION");

                entity.Property(e => e.TipoSede)
                    .HasColumnName("TIPO_SEDE")
                    .HasMaxLength(16);

                entity.HasOne(d => d.IdIndividuoNavigation)
                    .WithMany(p => p.Sedes)
                    .HasForeignKey(d => d.IdIndividuo)
                    .HasConstraintName("FK_dbo.SEDES_dbo.INDIVIDUOS_ID_INDIVIDUO");

                entity.HasOne(d => d.IdUbicacionNavigation)
                    .WithMany(p => p.Sedes)
                    .HasForeignKey(d => d.IdUbicacion)
                    .HasConstraintName("FK_dbo.SEDES_dbo.UBICACIONES_ID_UBICACION");
            });
            
            return modelBuilder;
        }
    }
}
