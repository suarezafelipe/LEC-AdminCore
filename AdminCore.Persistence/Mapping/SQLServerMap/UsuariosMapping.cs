using AdminCore.BusinessLogic.Products.Models;
using AdminCore.Persistence.Mapping.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace AdminCore.Persistence.Mapping.SQLServerMap
{
    public class UsuariosMapping : IUsuariosMapping
    {
        protected virtual DbSet<AspNetRoles> AspNetRoles { get; set; }
        protected virtual DbSet<AspNetUserClaims> AspNetUserClaims { get; set; }
        protected virtual DbSet<AspNetUserLogins> AspNetUserLogins { get; set; }
        protected virtual DbSet<AspNetUserRoles> AspNetUserRoles { get; set; }
        protected virtual DbSet<AspNetUsers> AspNetUsers { get; set; }
        protected virtual DbSet<BeneficiariosValidos> BeneficiariosValidos { get; set; }
        protected virtual DbSet<Campanas> Campanas { get; set; }
        protected virtual DbSet<Ciudades> Ciudades { get; set; }
        protected virtual DbSet<Descuentos> Descuentos { get; set; }
        protected virtual DbSet<DescuentosUsados> DescuentosUsados { get; set; }
        protected virtual DbSet<Individuos> Individuos { get; set; }
        protected virtual DbSet<Paises> Paises { get; set; }
        protected virtual DbSet<Personas> Personas { get; set; }
        protected virtual DbSet<Regiones> Regiones { get; set; }
        protected virtual DbSet<Ubicaciones> Ubicaciones { get; set; }
        protected virtual DbSet<UbicPersonas> UbicacionesPersonas { get; set; }

        public ModelBuilder LecDbBuilder(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AspNetRoles>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasMaxLength(128)
                    .ValueGeneratedNever();

                entity.Property(e => e.Name).IsRequired();
            });

            modelBuilder.Entity<AspNetUserClaims>(entity =>
            {
                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserClaims)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_dbo.AspNetUserClaims_dbo.AspNetUsers_User_Id");
            });

            modelBuilder.Entity<AspNetUserLogins>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.LoginProvider, e.ProviderKey });

                entity.Property(e => e.UserId).HasMaxLength(128);

                entity.Property(e => e.LoginProvider).HasMaxLength(128);

                entity.Property(e => e.ProviderKey).HasMaxLength(128);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserLogins)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_dbo.AspNetUserLogins_dbo.AspNetUsers_UserId");
            });

            modelBuilder.Entity<AspNetUserRoles>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.RoleId });

                entity.Property(e => e.UserId).HasMaxLength(128);

                entity.Property(e => e.RoleId).HasMaxLength(128);

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.AspNetUserRoles)
                    .HasForeignKey(d => d.RoleId)
                    .HasConstraintName("FK_dbo.AspNetUserRoles_dbo.AspNetRoles_RoleId");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserRoles)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_dbo.AspNetUserRoles_dbo.AspNetUsers_UserId");
            });

            modelBuilder.Entity<AspNetUsers>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasMaxLength(128)
                    .ValueGeneratedNever();

                entity.Property(e => e.ConfirmationToken).HasMaxLength(128);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.LastPasswordFailureDate).HasColumnType("datetime");

                entity.Property(e => e.PasswordChangedDate).HasColumnType("datetime");

                entity.Property(e => e.PasswordFailuresSinceLastSuccess).HasDefaultValueSql("((0))");

                entity.Property(e => e.PasswordVerificationToken).HasMaxLength(128);

                entity.Property(e => e.PasswordVerificationTokenExpirationDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<BeneficiariosValidos>(entity =>
            {
                entity.HasKey(e => e.IdBeneficiario);

                entity.ToTable("BENEFICIARIOS_VALIDOS");

                entity.HasIndex(e => e.IdBeneficio)
                    .HasName("IX_ID_BENEFICIO");

                entity.Property(e => e.IdBeneficiario).HasColumnName("ID_BENEFICIARIO");

                entity.Property(e => e.CorreoIdentificacion)
                    .HasColumnName("CORREO_IDENTIFICACION")
                    .HasMaxLength(60);

                entity.Property(e => e.EstaActivo).HasColumnName("ESTA_ACTIVO");

                entity.Property(e => e.EstadoRegistro).HasColumnName("ESTADO_REGISTRO");

                entity.Property(e => e.FechaActualizacion)
                    .HasColumnName("FECHA_ACTUALIZACION")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaCreacion)
                    .HasColumnName("FECHA_CREACION")
                    .HasColumnType("datetime");

                entity.Property(e => e.IdBeneficio).HasColumnName("ID_BENEFICIO");

                entity.Property(e => e.NumeroIdentificacion)
                    .HasColumnName("NUMERO_IDENTIFICACION")
                    .HasMaxLength(40);

                entity.HasOne(d => d.IdBeneficioNavigation)
                    .WithMany(p => p.BeneficiariosValidos)
                    .HasForeignKey(d => d.IdBeneficio)
                    .HasConstraintName("FK_dbo.BENEFICIARIOS_VALIDOS_dbo.BENEFICIOS_ALIADOS_ID_BENEFICIO");
            });

            modelBuilder.Entity<BeneficiosAliados>(entity =>
            {
                entity.HasKey(e => e.IdBeneficio);

                entity.ToTable("BENEFICIOS_ALIADOS");

                entity.HasIndex(e => e.IdCodigoDescuento)
                    .HasName("IX_ID_CODIGO_DESCUENTO");

                entity.HasIndex(e => e.IdIndividuo)
                    .HasName("IX_ID_INDIVIDUO");

                entity.Property(e => e.IdBeneficio).HasColumnName("ID_BENEFICIO");

                entity.Property(e => e.EsCostoEnvioGratis).HasColumnName("ES_COSTO_ENVIO_GRATIS");

                entity.Property(e => e.EsCostoMarcadoGratis).HasColumnName("ES_COSTO_MARCADO_GRATIS");

                entity.Property(e => e.EstadoRegistro).HasColumnName("ESTADO_REGISTRO");

                entity.Property(e => e.FechaActualizacion)
                    .HasColumnName("FECHA_ACTUALIZACION")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaCreacion)
                    .HasColumnName("FECHA_CREACION")
                    .HasColumnType("datetime");

                entity.Property(e => e.IdCodigoDescuento).HasColumnName("ID_CODIGO_DESCUENTO");

                entity.Property(e => e.IdIndividuo).HasColumnName("ID_INDIVIDUO");

                entity.HasOne(d => d.IdCodigoDescuentoNavigation)
                    .WithMany(p => p.BeneficiosAliados)
                    .HasForeignKey(d => d.IdCodigoDescuento)
                    .HasConstraintName("FK_dbo.BENEFICIOS_ALIADOS_dbo.DESCUENTOS_ID_CODIGO_DESCUENTO");

                entity.HasOne(d => d.IdIndividuoNavigation)
                    .WithMany(p => p.BeneficiosAliados)
                    .HasForeignKey(d => d.IdIndividuo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.BENEFICIOS_ALIADOS_dbo.INSTITUCIONES_ID_INDIVIDUO");
            });
            
            modelBuilder.Entity<Campanas>(entity =>
            {
                entity.HasKey(e => e.IdCampana);

                entity.ToTable("CAMPANAS");

                entity.Property(e => e.IdCampana).HasColumnName("ID_CAMPANA");

                entity.Property(e => e.Descripcion)
                    .HasColumnName("DESCRIPCION")
                    .HasMaxLength(300);

                entity.Property(e => e.EstadoRegistro).HasColumnName("ESTADO_REGISTRO");

                entity.Property(e => e.FechaActualizacion)
                    .HasColumnName("FECHA_ACTUALIZACION")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaCreacion)
                    .HasColumnName("FECHA_CREACION")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaFinCampama)
                    .HasColumnName("FECHA_FIN_CAMPAMA")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaInicioCampana)
                    .HasColumnName("FECHA_INICIO_CAMPANA")
                    .HasColumnType("datetime");

                entity.Property(e => e.Tipo)
                    .IsRequired()
                    .HasColumnName("TIPO")
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<Ciudades>(entity =>
            {
                entity.HasKey(e => e.IdCiudad);

                entity.ToTable("CIUDADES");

                entity.HasIndex(e => e.IdRegion)
                    .HasName("IX_ID_REGION");

                entity.Property(e => e.IdCiudad).HasColumnName("ID_CIUDAD");

                entity.Property(e => e.CodigoCiudad)
                    .HasColumnName("CODIGO_CIUDAD")
                    .HasColumnType("nchar(5)");

                entity.Property(e => e.EstadoRegistro).HasColumnName("ESTADO_REGISTRO");

                entity.Property(e => e.FechaActualizacion)
                    .HasColumnName("FECHA_ACTUALIZACION")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaCreacion)
                    .HasColumnName("FECHA_CREACION")
                    .HasColumnType("datetime");

                entity.Property(e => e.IdRegion).HasColumnName("ID_REGION");

                entity.Property(e => e.NombreCiudad)
                    .HasColumnName("NOMBRE_CIUDAD")
                    .HasMaxLength(50);

                entity.Property(e => e.TieneCostoEnvio).HasColumnName("TIENE_COSTO_ENVIO");

                entity.Property(e => e.ValorDescuentoEnvio).HasColumnName("VALOR_DESCUENTO_ENVIO");

                entity.Property(e => e.ValorEnvio).HasColumnName("VALOR_ENVIO");

                entity.HasOne(d => d.IdRegionNavigation)
                    .WithMany(p => p.Ciudades)
                    .HasForeignKey(d => d.IdRegion)
                    .HasConstraintName("FK_dbo.CIUDADES_dbo.REGIONES_ID_REGION");
            });

            modelBuilder.Entity<Descuentos>(entity =>
            {
                entity.HasKey(e => e.IdDescuento);

                entity.ToTable("DESCUENTOS");

                entity.HasIndex(e => e.IdCampana)
                    .HasName("IX_ID_CAMPANA");

                entity.Property(e => e.IdDescuento).HasColumnName("ID_DESCUENTO");

                entity.Property(e => e.Codigo)
                    .HasColumnName("CODIGO")
                    .HasMaxLength(45);

                entity.Property(e => e.EstadoRegistro).HasColumnName("ESTADO_REGISTRO");

                entity.Property(e => e.FechaActualizacion)
                    .HasColumnName("FECHA_ACTUALIZACION")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaCreacion)
                    .HasColumnName("FECHA_CREACION")
                    .HasColumnType("datetime");

                entity.Property(e => e.IdCampana)
                    .HasColumnName("ID_CAMPANA")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.MinimoCompra)
                    .HasColumnName("MINIMO_COMPRA")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.UsoUnico).HasColumnName("USO_UNICO");

                entity.Property(e => e.ValidoDesde)
                    .HasColumnName("VALIDO_DESDE")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("('1900-01-01T00:00:00.000')");

                entity.Property(e => e.ValidoHasta)
                    .HasColumnName("VALIDO_HASTA")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("('1900-01-01T00:00:00.000')");

                entity.Property(e => e.ValorDescuento)
                    .HasColumnName("VALOR_DESCUENTO")
                    .HasDefaultValueSql("((0))");

                entity.HasOne(d => d.IdCampanaNavigation)
                    .WithMany(p => p.Descuentos)
                    .HasForeignKey(d => d.IdCampana)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.DESCUENTOS_dbo.CAMPANAS_ID_CAMPANA");
            });

            modelBuilder.Entity<DescuentosUsados>(entity =>
            {
                entity.HasKey(e => new { e.IdIdentity, e.IdDescuento });

                entity.ToTable("DESCUENTOS_USADOS");

                entity.HasIndex(e => e.IdDescuento)
                    .HasName("IX_ID_DESCUENTO");

                entity.Property(e => e.IdIdentity)
                    .HasColumnName("ID_IDENTITY")
                    .HasMaxLength(128);

                entity.Property(e => e.IdDescuento).HasColumnName("ID_DESCUENTO");

                entity.Property(e => e.EstadoRegistro).HasColumnName("ESTADO_REGISTRO");

                entity.Property(e => e.FechaActualizacion)
                    .HasColumnName("FECHA_ACTUALIZACION")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaCreacion)
                    .HasColumnName("FECHA_CREACION")
                    .HasColumnType("datetime");

                entity.HasOne(d => d.IdDescuentoNavigation)
                    .WithMany(p => p.DescuentosUsados)
                    .HasForeignKey(d => d.IdDescuento)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.DESCUENTOS_USADOS_dbo.DESCUENTOS_ID_DESCUENTO");
            });

            modelBuilder.Entity<Individuos>(entity =>
            {
                entity.HasKey(e => e.IdIndividuo);

                entity.ToTable("INDIVIDUOS");

                entity.Property(e => e.IdIndividuo).HasColumnName("ID_INDIVIDUO");

                entity.Property(e => e.CodTipoIndividuo)
                    .IsRequired()
                    .HasColumnName("COD_TIPO_INDIVIDUO")
                    .HasMaxLength(30);

                entity.Property(e => e.Email)
                    .HasColumnName("EMAIL")
                    .HasMaxLength(254);

                entity.Property(e => e.Email2)
                    .HasColumnName("EMAIL2")
                    .HasMaxLength(254);

                entity.Property(e => e.IdIdentity)
                    .HasColumnName("ID_IDENTITY")
                    .HasMaxLength(128);

                entity.Property(e => e.Tel2)
                    .HasColumnName("TEL2")
                    .HasMaxLength(30);

                entity.Property(e => e.Telefono)
                    .HasColumnName("TELEFONO")
                    .HasMaxLength(30);
            });

            modelBuilder.Entity<Paises>(entity =>
            {
                entity.HasKey(e => e.CodigoPais);

                entity.ToTable("PAISES");

                entity.Property(e => e.CodigoPais)
                    .HasColumnName("CODIGO_PAIS")
                    .HasColumnType("nchar(2)")
                    .ValueGeneratedNever();

                entity.Property(e => e.EstadoRegistro).HasColumnName("ESTADO_REGISTRO");

                entity.Property(e => e.FechaActualizacion)
                    .HasColumnName("FECHA_ACTUALIZACION")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaCreacion)
                    .HasColumnName("FECHA_CREACION")
                    .HasColumnType("datetime");

                entity.Property(e => e.Idioma)
                    .HasColumnName("IDIOMA")
                    .HasMaxLength(16);

                entity.Property(e => e.Moneda)
                    .HasColumnName("MONEDA")
                    .HasMaxLength(3);

                entity.Property(e => e.NombrePais)
                    .HasColumnName("NOMBRE_PAIS")
                    .HasMaxLength(40);
            });

            modelBuilder.Entity<Personas>(entity =>
            {
                entity.HasKey(e => e.IdIndividuo);

                entity.ToTable("PERSONAS");

                entity.HasIndex(e => e.IdIndividuo)
                    .HasName("IX_ID_INDIVIDUO");

                entity.Property(e => e.IdIndividuo)
                    .HasColumnName("ID_INDIVIDUO")
                    .ValueGeneratedNever();

                entity.Property(e => e.ClienteIdentity).HasColumnName("CLIENTE_IDENTITY");

                entity.Property(e => e.EstadoCivil)
                    .HasColumnName("ESTADO_CIVIL")
                    .HasMaxLength(16);

                entity.Property(e => e.EstadoRegistro).HasColumnName("ESTADO_REGISTRO");

                entity.Property(e => e.FechaActualizacion)
                    .HasColumnName("FECHA_ACTUALIZACION")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaCreacion)
                    .HasColumnName("FECHA_CREACION")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaNacimiento)
                    .HasColumnName("FECHA_NACIMIENTO")
                    .HasColumnType("datetime");

                entity.Property(e => e.Genero)
                    .HasColumnName("GENERO")
                    .HasMaxLength(1);

                entity.Property(e => e.Ingresos)
                    .HasColumnName("INGRESOS")
                    .HasMaxLength(20);

                entity.Property(e => e.NumHijos).HasColumnName("NUM_HIJOS");

                entity.Property(e => e.NumIdentificacion)
                    .HasColumnName("NUM_IDENTIFICACION")
                    .HasMaxLength(15);

                entity.Property(e => e.PrimerApellido)
                    .HasColumnName("PRIMER_APELLIDO")
                    .HasMaxLength(32);

                entity.Property(e => e.PrimerNombre)
                    .HasColumnName("PRIMER_NOMBRE")
                    .HasMaxLength(120);

                entity.Property(e => e.SegundoApellido)
                    .HasColumnName("SEGUNDO_APELLIDO")
                    .HasMaxLength(32);

                entity.Property(e => e.SegundoNombre)
                    .HasColumnName("SEGUNDO_NOMBRE")
                    .HasMaxLength(32);

                entity.Property(e => e.TipoIdentificacion)
                    .HasColumnName("TIPO_IDENTIFICACION")
                    .HasMaxLength(3);

                entity.Property(e => e.TipoPersona)
                    .HasColumnName("TIPO_PERSONA")
                    .HasMaxLength(20);

                entity.HasOne(d => d.IdIndividuoNavigation)
                    .WithOne(p => p.Personas)
                    .HasForeignKey<Personas>(d => d.IdIndividuo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.PERSONAS_dbo.INDIVIDUOS_ID_INDIVIDUO");
            });

            modelBuilder.Entity<Regiones>(entity =>
            {
                entity.HasKey(e => e.IdRegion);

                entity.ToTable("REGIONES");

                entity.HasIndex(e => e.CodigoPais)
                    .HasName("IX_CODIGO_PAIS");

                entity.Property(e => e.IdRegion).HasColumnName("ID_REGION");

                entity.Property(e => e.CodigoPais)
                    .IsRequired()
                    .HasColumnName("CODIGO_PAIS")
                    .HasColumnType("nchar(2)");

                entity.Property(e => e.EstadoRegistro).HasColumnName("ESTADO_REGISTRO");

                entity.Property(e => e.FechaActualizacion)
                    .HasColumnName("FECHA_ACTUALIZACION")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaCreacion)
                    .HasColumnName("FECHA_CREACION")
                    .HasColumnType("datetime");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("NOMBRE")
                    .HasMaxLength(100);

                entity.HasOne(d => d.CodigoPaisNavigation)
                    .WithMany(p => p.Regiones)
                    .HasForeignKey(d => d.CodigoPais)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.REGIONES_dbo.PAISES_CODIGO_PAIS");
            });

            modelBuilder.Entity<Ubicaciones>(entity =>
            {
                entity.HasKey(e => e.IdUbicacion);

                entity.ToTable("UBICACIONES");

                entity.HasIndex(e => e.IdCiudad)
                    .HasName("IX_ID_CIUDAD");

                entity.Property(e => e.IdUbicacion).HasColumnName("ID_UBICACION");

                entity.Property(e => e.Barrio)
                    .HasColumnName("BARRIO")
                    .HasMaxLength(32);

                entity.Property(e => e.CodigoPostal)
                    .HasColumnName("CODIGO_POSTAL")
                    .HasMaxLength(16);

                entity.Property(e => e.ComplementoDireccion)
                    .HasColumnName("COMPLEMENTO_DIRECCION")
                    .HasMaxLength(32);

                entity.Property(e => e.CoordenadasGmaps).HasColumnName("COORDENADAS_GMAPS");

                entity.Property(e => e.Departamento)
                    .HasColumnName("DEPARTAMENTO")
                    .HasMaxLength(32);

                entity.Property(e => e.Direccion)
                    .IsRequired()
                    .HasColumnName("DIRECCION")
                    .HasMaxLength(120);

                entity.Property(e => e.EstadoRegistro).HasColumnName("ESTADO_REGISTRO");

                entity.Property(e => e.Estrato).HasColumnName("ESTRATO");

                entity.Property(e => e.FechaActualizacion)
                    .HasColumnName("FECHA_ACTUALIZACION")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaCreacion)
                    .HasColumnName("FECHA_CREACION")
                    .HasColumnType("datetime");

                entity.Property(e => e.IdCiudad).HasColumnName("ID_CIUDAD");

                entity.Property(e => e.Localidad)
                    .HasColumnName("LOCALIDAD")
                    .HasMaxLength(32);

                entity.Property(e => e.RiesgoZona).HasColumnName("RIESGO_ZONA");

                entity.HasOne(d => d.IdCiudadNavigation)
                    .WithMany(p => p.Ubicaciones)
                    .HasForeignKey(d => d.IdCiudad)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.UBICACIONES_dbo.CIUDADES_ID_CIUDAD");
            });

            modelBuilder.Entity<UbicPersonas>(entity =>
            {
                entity.HasKey(e => new { e.UbicacionesIdUbicacion, e.PersonasIdIndividuo });

                entity.ToTable("UBIC_PERSONAS");

                entity.HasIndex(e => e.PersonasIdIndividuo)
                    .HasName("IX_PERSONAS_ID_INDIVIDUO");

                entity.HasIndex(e => e.UbicacionesIdUbicacion)
                    .HasName("IX_UBICACIONES_ID_UBICACION");

                entity.Property(e => e.UbicacionesIdUbicacion).HasColumnName("UBICACIONES_ID_UBICACION");

                entity.Property(e => e.PersonasIdIndividuo).HasColumnName("PERSONAS_ID_INDIVIDUO");

                entity.HasOne(d => d.PersonasIdIndividuoNavigation)
                    .WithMany(p => p.UbicPersonas)
                    .HasForeignKey(d => d.PersonasIdIndividuo)
                    .HasConstraintName("FK_dbo.UBIC_PERSONAS_dbo.PERSONAS_PERSONAS_ID_INDIVIDUO");

                entity.HasOne(d => d.UbicacionesIdUbicacionNavigation)
                    .WithMany(p => p.UbicPersonas)
                    .HasForeignKey(d => d.UbicacionesIdUbicacion)
                    .HasConstraintName("FK_dbo.UBIC_PERSONAS_dbo.UBICACIONES_UBICACIONES_ID_UBICACION");
            });

            return modelBuilder;
        }
    }
}
