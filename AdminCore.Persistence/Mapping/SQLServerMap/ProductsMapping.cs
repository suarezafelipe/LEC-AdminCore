using AdminCore.BusinessLogic.Products.Models;
using AdminCore.Persistence.Mapping.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace AdminCore.Persistence.Mapping.SQLServerMap
{
    public class ProductsMapping : IProductsMapping
    {
        public virtual DbSet<ActividadesEconomicas> ActividadesEconomicas { get; set; }
        public virtual DbSet<Articulos> Articulos { get; set; }
        public virtual DbSet<ArticulosAtributosValores> ArticulosAtributosValores { get; set; }
        public virtual DbSet<ArticulosUnidadVenta> ArticulosUnidadVenta { get; set; }
        public virtual DbSet<AtributosArticulos> AtributosArticulos { get; set; }
        public virtual DbSet<CategoriaCategorias> CategoriaCategorias { get; set; }
        public virtual DbSet<CategoriaProd> CategoriaProd { get; set; }
        public virtual DbSet<Categorias> Categorias { get; set; }
        public virtual DbSet<CategoriasCategoriasContable> CategoriasCategoriasContable { get; set; }
        public virtual DbSet<CategoriasContabilidad> CategoriasContabilidad { get; set; }
        public virtual DbSet<DescripcionProducto> DescripcionProducto { get; set; }
        public virtual DbSet<Marcas> Marcas { get; set; }
        public virtual DbSet<Parametrizaciones> Parametrizaciones { get; set; }
        public virtual DbSet<Precios> Precios { get; set; }
        public virtual DbSet<Productos> Productos { get; set; }
        public virtual DbSet<ProductosRespaldo> ProductosRespaldo { get; set; }
        public virtual DbSet<Proveedores> Proveedores { get; set; }
        public virtual DbSet<TipoAtributos> TipoAtributos { get; set; }
        public virtual DbSet<UnidadesVenta> UnidadesVenta { get; set; }
        public virtual DbSet<Valoraciones> Valoraciones { get; set; }
        public virtual DbSet<ValorAtributo> ValorAtributo { get; set; }
        public virtual DbSet<ValoresMarcado> ValoresMarcado { get; set; }
        public virtual DbSet<VersionProducto> VersionProducto { get; set; }

        public ModelBuilder LecDbBuilder(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ActividadesEconomicas>(entity =>
            {
                entity.HasKey(e => e.IdActividadEconomica);

                entity.ToTable("ACTIVIDADES_ECONOMICAS");

                entity.Property(e => e.IdActividadEconomica).HasColumnName("ID_ACTIVIDAD_ECONOMICA");

                entity.Property(e => e.CodigoActividad)
                    .IsRequired()
                    .HasColumnName("CODIGO_ACTIVIDAD")
                    .HasMaxLength(20);

                entity.Property(e => e.CuentaIca)
                    .HasColumnName("CUENTA_ICA")
                    .HasMaxLength(30);

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
                    .HasMaxLength(80);

                entity.Property(e => e.Tarifa).HasColumnName("TARIFA");
            });

            modelBuilder.Entity<Articulos>(entity =>
            {
                entity.HasKey(e => new { e.IdArticulo, e.IdProducto });

                entity.ToTable("ARTICULOS");

                entity.HasIndex(e => e.IdProducto)
                    .HasName("IX_ID_PRODUCTO");

                entity.Property(e => e.IdArticulo)
                    .HasColumnName("ID_ARTICULO")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.IdProducto).HasColumnName("ID_PRODUCTO");

                entity.Property(e => e.CodUnicoFabricante)
                    .HasColumnName("COD_UNICO_FABRICANTE")
                    .HasMaxLength(64);

                entity.Property(e => e.CodUnicoListaencasa)
                    .HasColumnName("COD_UNICO_LISTAENCASA")
                    .HasMaxLength(64);

                entity.Property(e => e.EnPromocion).HasColumnName("EN_PROMOCION");

                entity.Property(e => e.EsCuaderno).HasColumnName("ES_CUADERNO");

                entity.Property(e => e.EstadoRegistro).HasColumnName("ESTADO_REGISTRO");

                entity.Property(e => e.FechaActualizacion)
                    .HasColumnName("FECHA_ACTUALIZACION")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaCreacion)
                    .HasColumnName("FECHA_CREACION")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaDisponible)
                    .HasColumnName("FECHA_DISPONIBLE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Iva)
                    .HasColumnName("IVA")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.IvaExcluido)
                    .HasColumnName("IVA_EXCLUIDO")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.LargeImgUrl)
                    .HasColumnName("LARGE_IMG_URL")
                    .HasMaxLength(600);

                entity.Property(e => e.MediumImgUrl)
                    .HasColumnName("MEDIUM_IMG_URL")
                    .HasMaxLength(600);

                entity.Property(e => e.Nombre)
                    .HasColumnName("NOMBRE")
                    .HasMaxLength(80);

                entity.Property(e => e.NombreBuscador)
                    .HasColumnName("NOMBRE_BUSCADOR")
                    .HasMaxLength(200);

                entity.Property(e => e.TieneImagen).HasColumnName("TIENE_IMAGEN");

                entity.Property(e => e.UltimaOrden)
                    .HasColumnName("ULTIMA_ORDEN")
                    .HasColumnType("datetime");

                entity.Property(e => e.UrlThumbnail)
                    .HasColumnName("URL_THUMBNAIL")
                    .HasMaxLength(600);

                entity.HasOne(d => d.IdProductoNavigation)
                    .WithMany(p => p.Articulos)
                    .HasForeignKey(d => d.IdProducto)
                    .HasConstraintName("FK_dbo.ARTICULOS_dbo.PRODUCTOS_ID_PRODUCTO");
            });

            modelBuilder.Entity<ArticulosAtributosValores>(entity =>
            {
                entity.HasKey(e => new { e.IdArticulo, e.IdProducto, e.IdAtributo, e.IdValor });

                entity.ToTable("ARTICULOS_ATRIBUTOS_VALORES");

                entity.HasIndex(e => e.IdAtributo)
                    .HasName("IX_ID_ATRIBUTO");

                entity.HasIndex(e => e.IdValor)
                    .HasName("IX_ID_VALOR");

                entity.HasIndex(e => new { e.IdArticulo, e.IdProducto })
                    .HasName("IX_ID_ARTICULO_ID_PRODUCTO");

                entity.Property(e => e.IdArticulo).HasColumnName("ID_ARTICULO");

                entity.Property(e => e.IdProducto).HasColumnName("ID_PRODUCTO");

                entity.Property(e => e.IdAtributo).HasColumnName("ID_ATRIBUTO");

                entity.Property(e => e.IdValor).HasColumnName("ID_VALOR");

                entity.Property(e => e.EstadoRegistro).HasColumnName("ESTADO_REGISTRO");

                entity.Property(e => e.FechaActualizacion)
                    .HasColumnName("FECHA_ACTUALIZACION")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaCreacion)
                    .HasColumnName("FECHA_CREACION")
                    .HasColumnType("datetime");

                entity.HasOne(d => d.IdAtributoNavigation)
                    .WithMany(p => p.ArticulosAtributosValores)
                    .HasForeignKey(d => d.IdAtributo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.ARTICULOS_ATRIBUTOS_VALORES_dbo.ATRIBUTOS_ARTICULOS_ID_ATRIBUTO");

                entity.HasOne(d => d.IdValorNavigation)
                    .WithMany(p => p.ArticulosAtributosValores)
                    .HasForeignKey(d => d.IdValor)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.ARTICULOS_ATRIBUTOS_VALORES_dbo.VALOR_ATRIBUTO_ID_VALOR");

                entity.HasOne(d => d.Id)
                    .WithMany(p => p.ArticulosAtributosValores)
                    .HasForeignKey(d => new { d.IdArticulo, d.IdProducto })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.ARTICULOS_ATRIBUTOS_VALORES_dbo.ARTICULOS_ID_ARTICULO_ID_PRODUCTO");
            });
            
            modelBuilder.Entity<ArticulosUnidadVenta>(entity =>
            {
                entity.HasKey(e => e.IdUnidadVenta);

                entity.ToTable("ARTICULOS_UNIDAD_VENTA");

                entity.HasIndex(e => new { e.IdArticulo, e.IdProducto })
                    .HasName("IX_ID_ARTICULO_ID_PRODUCTO");

                entity.HasIndex(e => new { e.IdArticuloBase, e.IdProductoBase })
                    .HasName("IX_ID_ARTICULO_BASE_ID_PRODUCTO_BASE");

                entity.Property(e => e.IdUnidadVenta)
                    .HasColumnName("ID_UNIDAD_VENTA")
                    .ValueGeneratedNever();

                entity.Property(e => e.Cantidad).HasColumnName("CANTIDAD");

                entity.Property(e => e.IdArticulo)
                    .HasColumnName("ID_ARTICULO")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.IdArticuloBase).HasColumnName("ID_ARTICULO_BASE");

                entity.Property(e => e.IdProducto).HasColumnName("ID_PRODUCTO");

                entity.Property(e => e.IdProductoBase).HasColumnName("ID_PRODUCTO_BASE");

                entity.HasOne(d => d.Id)
                    .WithMany(p => p.ArticulosUnidadVentaId)
                    .HasForeignKey(d => new { d.IdArticulo, d.IdProducto })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.ARTICULOS_UNIDAD_VENTA_dbo.ARTICULOS_ID_ARTICULO_ID_PRODUCTO");

                entity.HasOne(d => d.IdNavigation)
                    .WithMany(p => p.ArticulosUnidadVentaIdNavigation)
                    .HasForeignKey(d => new { d.IdArticuloBase, d.IdProductoBase })
                    .HasConstraintName("FK_dbo.ARTICULOS_UNIDAD_VENTA_dbo.ARTICULOS_ID_ARTICULO_BASE_ID_PRODUCTO_BASE");
            });

            modelBuilder.Entity<AtributosArticulos>(entity =>
            {
                entity.HasKey(e => e.IdAtributo);

                entity.ToTable("ATRIBUTOS_ARTICULOS");

                entity.HasIndex(e => e.IdTipo)
                    .HasName("IX_ID_TIPO");

                entity.HasIndex(e => e.IdUnidVenta)
                    .HasName("IX_ID_UNID_VENTA");

                entity.Property(e => e.IdAtributo).HasColumnName("ID_ATRIBUTO");

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

                entity.Property(e => e.IdTipo).HasColumnName("ID_TIPO");

                entity.Property(e => e.IdUnidVenta).HasColumnName("ID_UNID_VENTA");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("NOMBRE")
                    .HasMaxLength(45);

                entity.Property(e => e.Secuencia).HasColumnName("SECUENCIA");

                entity.HasOne(d => d.IdTipoNavigation)
                    .WithMany(p => p.AtributosArticulos)
                    .HasForeignKey(d => d.IdTipo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.ATRIBUTOS_ARTICULOS_dbo.TIPO_ATRIBUTOS_ID_TIPO");

                entity.HasOne(d => d.IdUnidVentaNavigation)
                    .WithMany(p => p.AtributosArticulos)
                    .HasForeignKey(d => d.IdUnidVenta)
                    .HasConstraintName("FK_dbo.ATRIBUTOS_ARTICULOS_dbo.UNIDADES_VENTA_ID_UNID_VENTA");
            });
            
            modelBuilder.Entity<CategoriaCategorias>(entity =>
            {
                entity.HasKey(e => new { e.IdCategoriaHijo, e.IdCategoriaPadre });

                entity.ToTable("CATEGORIA_CATEGORIAS");

                entity.HasIndex(e => e.IdCategoriaHijo)
                    .HasName("IX_ID_CATEGORIA_HIJO");

                entity.HasIndex(e => e.IdCategoriaPadre)
                    .HasName("IX_ID_CATEGORIA_PADRE");

                entity.Property(e => e.IdCategoriaHijo).HasColumnName("ID_CATEGORIA_HIJO");

                entity.Property(e => e.IdCategoriaPadre).HasColumnName("ID_CATEGORIA_PADRE");

                entity.HasOne(d => d.IdCategoriaHijoNavigation)
                    .WithMany(p => p.CategoriaCategoriasIdCategoriaHijoNavigation)
                    .HasForeignKey(d => d.IdCategoriaHijo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.CATEGORIA_CATEGORIAS_dbo.CATEGORIAS_ID_CATEGORIA_HIJO");

                entity.HasOne(d => d.IdCategoriaPadreNavigation)
                    .WithMany(p => p.CategoriaCategoriasIdCategoriaPadreNavigation)
                    .HasForeignKey(d => d.IdCategoriaPadre)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.CATEGORIA_CATEGORIAS_dbo.CATEGORIAS_ID_CATEGORIA_PADRE");
            });

            modelBuilder.Entity<CategoriaProd>(entity =>
            {
                entity.HasKey(e => new { e.CategoriasIdCategoria, e.ProductosIdProducto });

                entity.ToTable("CATEGORIA_PROD");

                entity.HasIndex(e => e.CategoriasIdCategoria)
                    .HasName("IX_CATEGORIAS_ID_CATEGORIA");

                entity.HasIndex(e => e.ProductosIdProducto)
                    .HasName("IX_PRODUCTOS_ID_PRODUCTO");

                entity.Property(e => e.CategoriasIdCategoria).HasColumnName("CATEGORIAS_ID_CATEGORIA");

                entity.Property(e => e.ProductosIdProducto).HasColumnName("PRODUCTOS_ID_PRODUCTO");

                entity.HasOne(d => d.CategoriasIdCategoriaNavigation)
                    .WithMany(p => p.CategoriaProd)
                    .HasForeignKey(d => d.CategoriasIdCategoria)
                    .HasConstraintName("FK_dbo.CATEGORIA_PROD_dbo.CATEGORIAS_CATEGORIAS_ID_CATEGORIA");

                entity.HasOne(d => d.ProductosIdProductoNavigation)
                    .WithMany(p => p.CategoriaProd)
                    .HasForeignKey(d => d.ProductosIdProducto)
                    .HasConstraintName("FK_dbo.CATEGORIA_PROD_dbo.PRODUCTOS_PRODUCTOS_ID_PRODUCTO");
            });

            modelBuilder.Entity<Categorias>(entity =>
            {
                entity.HasKey(e => e.IdCategoria);

                entity.ToTable("CATEGORIAS");

                entity.Property(e => e.IdCategoria).HasColumnName("ID_CATEGORIA");

                entity.Property(e => e.DescripcionCorta)
                    .HasColumnName("DESCRIPCION_CORTA")
                    .HasMaxLength(300);

                entity.Property(e => e.DescripcionLarga).HasColumnName("DESCRIPCION_LARGA");

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
                    .HasMaxLength(45);

                entity.Property(e => e.NombreCorto)
                    .HasColumnName("NOMBRE_CORTO")
                    .HasMaxLength(30);
            });

            modelBuilder.Entity<CategoriasCategoriasContable>(entity =>
            {
                entity.HasKey(e => new { e.IdCategoria, e.IdCategoriaContable });

                entity.ToTable("CATEGORIAS_CATEGORIAS_CONTABLE");

                entity.HasIndex(e => e.IdCategoria)
                    .HasName("IX_ID_CATEGORIA");

                entity.HasIndex(e => e.IdCategoriaContable)
                    .HasName("IX_ID_CATEGORIA_CONTABLE");

                entity.Property(e => e.IdCategoria).HasColumnName("ID_CATEGORIA");

                entity.Property(e => e.IdCategoriaContable).HasColumnName("ID_CATEGORIA_CONTABLE");

                entity.Property(e => e.EstadoRegistro).HasColumnName("ESTADO_REGISTRO");

                entity.Property(e => e.FechaActualizacion)
                    .HasColumnName("FECHA_ACTUALIZACION")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaCreacion)
                    .HasColumnName("FECHA_CREACION")
                    .HasColumnType("datetime");

                entity.HasOne(d => d.IdCategoriaNavigation)
                    .WithMany(p => p.CategoriasCategoriasContable)
                    .HasForeignKey(d => d.IdCategoria)
                    .HasConstraintName("FK_dbo.CATEGORIAS_CATEGORIAS_CONTABLE_dbo.CATEGORIAS_ID_CATEGORIA");

                entity.HasOne(d => d.IdCategoriaContableNavigation)
                    .WithMany(p => p.CategoriasCategoriasContable)
                    .HasForeignKey(d => d.IdCategoriaContable)
                    .HasConstraintName("FK_dbo.CATEGORIAS_CATEGORIAS_CONTABLE_dbo.CATEGORIAS_CONTABILIDAD_ID_CATEGORIA_CONTABLE");
            });

            modelBuilder.Entity<CategoriasContabilidad>(entity =>
            {
                entity.HasKey(e => e.IdCategoria);

                entity.ToTable("CATEGORIAS_CONTABILIDAD");

                entity.Property(e => e.IdCategoria).HasColumnName("ID_CATEGORIA");

                entity.Property(e => e.CuentaContable).HasColumnName("CUENTA_CONTABLE");

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

                entity.Property(e => e.TipoIva)
                    .HasColumnName("TIPO_IVA")
                    .HasMaxLength(15);
            });

            modelBuilder.Entity<DescripcionProducto>(entity =>
            {
                entity.HasKey(e => new { e.TipoDescripcion, e.IdProducto });

                entity.ToTable("DESCRIPCION_PRODUCTO");

                entity.HasIndex(e => e.IdProducto)
                    .HasName("IX_ID_PRODUCTO");

                entity.Property(e => e.TipoDescripcion)
                    .HasColumnName("TIPO_DESCRIPCION")
                    .HasMaxLength(32);

                entity.Property(e => e.IdProducto).HasColumnName("ID_PRODUCTO");

                entity.Property(e => e.CodIsoIdioma)
                    .IsRequired()
                    .HasColumnName("COD_ISO_IDIOMA")
                    .HasMaxLength(2);

                entity.Property(e => e.DescCorta)
                    .HasColumnName("DESC_CORTA")
                    .HasMaxLength(300);

                entity.Property(e => e.DescLarga)
                    .HasColumnName("DESC_LARGA")
                    .HasMaxLength(4000);

                entity.Property(e => e.EstadoRegistro).HasColumnName("ESTADO_REGISTRO");

                entity.Property(e => e.FechaActualizacion)
                    .HasColumnName("FECHA_ACTUALIZACION")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaCreacion)
                    .HasColumnName("FECHA_CREACION")
                    .HasColumnType("datetime");

                entity.Property(e => e.NombreProdTraducido)
                    .HasColumnName("NOMBRE_PROD_TRADUCIDO")
                    .HasMaxLength(45);

                entity.HasOne(d => d.IdProductoNavigation)
                    .WithMany(p => p.DescripcionProducto)
                    .HasForeignKey(d => d.IdProducto)
                    .HasConstraintName("FK_dbo.DESCRIPCION_PRODUCTO_dbo.PRODUCTOS_ID_PRODUCTO");
            });
            
            modelBuilder.Entity<Marcas>(entity =>
            {
                entity.HasKey(e => e.IdMarca);

                entity.ToTable("MARCAS");

                entity.Property(e => e.IdMarca).HasColumnName("ID_MARCA");

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

                entity.Property(e => e.Nombre)
                    .HasColumnName("NOMBRE")
                    .HasMaxLength(45);
            });

            modelBuilder.Entity<MigrationHistory>(entity =>
            {
                entity.HasKey(e => new { e.MigrationId, e.ContextKey });

                entity.ToTable("__MigrationHistory");

                entity.Property(e => e.MigrationId).HasMaxLength(150);

                entity.Property(e => e.ContextKey).HasMaxLength(300);

                entity.Property(e => e.Model).IsRequired();

                entity.Property(e => e.ProductVersion)
                    .IsRequired()
                    .HasMaxLength(32);
            });

            modelBuilder.Entity<PalabrasClave>(entity =>
            {
                entity.HasKey(e => e.IdPalabra);

                entity.ToTable("PALABRAS_CLAVE");

                entity.Property(e => e.IdPalabra).HasColumnName("ID_PALABRA");

                entity.Property(e => e.CodIsoIdioma)
                    .IsRequired()
                    .HasColumnName("COD_ISO_IDIOMA")
                    .HasMaxLength(2);

                entity.Property(e => e.EstadoRegistro).HasColumnName("ESTADO_REGISTRO");

                entity.Property(e => e.FechaActualizacion)
                    .HasColumnName("FECHA_ACTUALIZACION")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaCreacion)
                    .HasColumnName("FECHA_CREACION")
                    .HasColumnType("datetime");

                entity.Property(e => e.Palabra)
                    .HasColumnName("PALABRA")
                    .HasMaxLength(45);
            });

            modelBuilder.Entity<Parametrizaciones>(entity =>
            {
                entity.HasKey(e => e.IdParametro);

                entity.ToTable("PARAMETRIZACIONES");

                entity.Property(e => e.IdParametro).HasColumnName("ID_PARAMETRO");

                entity.Property(e => e.Descripcion)
                    .HasColumnName("DESCRIPCION")
                    .HasMaxLength(900);

                entity.Property(e => e.EstadoRegistro).HasColumnName("ESTADO_REGISTRO");

                entity.Property(e => e.FechaActualizacion)
                    .HasColumnName("FECHA_ACTUALIZACION")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaCreacion)
                    .HasColumnName("FECHA_CREACION")
                    .HasColumnType("datetime");

                entity.Property(e => e.ParametroEntero).HasColumnName("PARAMETRO_ENTERO");

                entity.Property(e => e.ParametroString)
                    .HasColumnName("PARAMETRO_STRING")
                    .HasMaxLength(300);

                entity.Property(e => e.TipoParametro)
                    .IsRequired()
                    .HasColumnName("TIPO_PARAMETRO")
                    .HasMaxLength(30);
            });
            
            modelBuilder.Entity<Precios>(entity =>
            {
                entity.HasKey(e => e.IdPrecio);

                entity.ToTable("PRECIOS");

                entity.HasIndex(e => new { e.IdArticulo, e.IdProducto })
                    .HasName("IX_ID_ARTICULO_ID_PRODUCTO");

                entity.Property(e => e.IdPrecio).HasColumnName("ID_PRECIO");

                entity.Property(e => e.EstadoRegistro).HasColumnName("ESTADO_REGISTRO");

                entity.Property(e => e.FechaActualizacion)
                    .HasColumnName("FECHA_ACTUALIZACION")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaCreacion)
                    .HasColumnName("FECHA_CREACION")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaVencimiento)
                    .HasColumnName("FECHA_VENCIMIENTO")
                    .HasColumnType("datetime");

                entity.Property(e => e.IdArticulo).HasColumnName("ID_ARTICULO");

                entity.Property(e => e.IdProducto).HasColumnName("ID_PRODUCTO");

                entity.Property(e => e.Moneda)
                    .IsRequired()
                    .HasColumnName("MONEDA")
                    .HasMaxLength(3);

                entity.Property(e => e.Monto).HasColumnName("MONTO");

                entity.Property(e => e.PorDefecto).HasColumnName("POR_DEFECTO");

                entity.Property(e => e.PrecioLinio).HasColumnName("PRECIO_LINIO");

                entity.Property(e => e.TipoCliente1)
                    .HasColumnName("TIPO_CLIENTE1")
                    .HasMaxLength(32);

                entity.Property(e => e.TipoCliente2)
                    .HasColumnName("TIPO_CLIENTE2")
                    .HasMaxLength(32);

                entity.HasOne(d => d.Id)
                    .WithMany(p => p.Precios)
                    .HasForeignKey(d => new { d.IdArticulo, d.IdProducto })
                    .HasConstraintName("FK_dbo.PRECIOS_dbo.ARTICULOS_ID_ARTICULO_ID_PRODUCTO");
            });

            modelBuilder.Entity<Productos>(entity =>
            {
                entity.HasKey(e => e.IdProducto);

                entity.ToTable("PRODUCTOS");

                entity.HasIndex(e => e.IdCategoriaContabilidad)
                    .HasName("IX_ID_CATEGORIA_CONTABILIDAD");

                entity.HasIndex(e => e.IdMarca)
                    .HasName("IX_ID_MARCA");

                entity.Property(e => e.IdProducto).HasColumnName("ID_PRODUCTO");

                entity.Property(e => e.Disponible).HasColumnName("DISPONIBLE");

                entity.Property(e => e.EstadoRegistro).HasColumnName("ESTADO_REGISTRO");

                entity.Property(e => e.FechaActualizacion)
                    .HasColumnName("FECHA_ACTUALIZACION")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaCreacion)
                    .HasColumnName("FECHA_CREACION")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaVencimiento)
                    .HasColumnName("FECHA_VENCIMIENTO")
                    .HasColumnType("datetime");

                entity.Property(e => e.IdCategoriaContabilidad).HasColumnName("ID_CATEGORIA_CONTABILIDAD");

                entity.Property(e => e.IdMarca).HasColumnName("ID_MARCA");

                entity.Property(e => e.LargeImgUrl)
                    .HasColumnName("LARGE_IMG_URL")
                    .HasMaxLength(600);

                entity.Property(e => e.MediumImgUrl)
                    .HasColumnName("MEDIUM_IMG_URL")
                    .HasMaxLength(600);

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("NOMBRE")
                    .HasMaxLength(45);

                entity.Property(e => e.NombreBuscador)
                    .HasColumnName("NOMBRE_BUSCADOR")
                    .HasMaxLength(200);

                entity.Property(e => e.NumeroUnidVenta).HasColumnName("NUMERO_UNID_VENTA");

                entity.Property(e => e.Peso).HasColumnName("PESO");

                entity.Property(e => e.PorMayor).HasColumnName("POR_MAYOR");

                entity.Property(e => e.Prioridad).HasColumnName("PRIORIDAD");

                entity.Property(e => e.Secuencia).HasColumnName("SECUENCIA");

                entity.Property(e => e.SmallImgUrl)
                    .HasColumnName("SMALL_IMG_URL")
                    .HasMaxLength(600);

                entity.Property(e => e.TieneImagen).HasColumnName("TIENE_IMAGEN");

                entity.Property(e => e.ValorMarcado).HasColumnName("VALOR_MARCADO");

                entity.HasOne(d => d.IdCategoriaContabilidadNavigation)
                    .WithMany(p => p.Productos)
                    .HasForeignKey(d => d.IdCategoriaContabilidad)
                    .HasConstraintName("FK_dbo.PRODUCTOS_dbo.CATEGORIAS_CONTABILIDAD_ID_CATEGORIA_CONTABILIDAD");

                entity.HasOne(d => d.IdMarcaNavigation)
                    .WithMany(p => p.Productos)
                    .HasForeignKey(d => d.IdMarca)
                    .HasConstraintName("FK_dbo.PRODUCTOS_dbo.MARCAS_ID_MARCA");
            });

            modelBuilder.Entity<ProductosRespaldo>(entity =>
            {
                entity.HasKey(e => e.IdRespaldo);

                entity.ToTable("PRODUCTOS_RESPALDO");

                entity.HasIndex(e => new { e.IdArticulo, e.IdProducto })
                    .HasName("IX_ID_ARTICULO_ID_PRODUCTO");

                entity.HasIndex(e => new { e.IdArticuloRes, e.IdProductoRes })
                    .HasName("IX_ID_ARTICULO_RES_ID_PRODUCTO_RES");

                entity.Property(e => e.IdRespaldo).HasColumnName("ID_RESPALDO");

                entity.Property(e => e.EstadoRegistro).HasColumnName("ESTADO_REGISTRO");

                entity.Property(e => e.Genero).HasColumnName("GENERO");

                entity.Property(e => e.IdArticulo).HasColumnName("ID_ARTICULO");

                entity.Property(e => e.IdArticuloRes).HasColumnName("ID_ARTICULO_RES");

                entity.Property(e => e.IdProducto).HasColumnName("ID_PRODUCTO");

                entity.Property(e => e.IdProductoRes).HasColumnName("ID_PRODUCTO_RES");

                entity.Property(e => e.Prioridad).HasColumnName("PRIORIDAD");

                entity.HasOne(d => d.Id)
                    .WithMany(p => p.ProductosRespaldoId)
                    .HasForeignKey(d => new { d.IdArticulo, d.IdProducto })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.PRODUCTOS_RESPALDO_dbo.ARTICULOS_ID_ARTICULO_ID_PRODUCTO");

                entity.HasOne(d => d.IdNavigation)
                    .WithMany(p => p.ProductosRespaldoIdNavigation)
                    .HasForeignKey(d => new { d.IdArticuloRes, d.IdProductoRes })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.PRODUCTOS_RESPALDO_dbo.ARTICULOS_ID_ARTICULO_RES_ID_PRODUCTO_RES");
            });

            modelBuilder.Entity<Proveedores>(entity =>
            {
                entity.HasKey(e => e.IdIndividuo);

                entity.ToTable("PROVEEDORES");

                entity.HasIndex(e => e.IdAcvtividadEconomica)
                    .HasName("IX_ID_ACVTIVIDAD_ECONOMICA");

                entity.HasIndex(e => e.IdIndividuo)
                    .HasName("IX_ID_INDIVIDUO");

                entity.Property(e => e.IdIndividuo)
                    .HasColumnName("ID_INDIVIDUO")
                    .ValueGeneratedNever();

                entity.Property(e => e.Autoretenedor).HasColumnName("AUTORETENEDOR");

                entity.Property(e => e.DanCredito).HasColumnName("DAN_CREDITO");

                entity.Property(e => e.EstadoRegistro).HasColumnName("ESTADO_REGISTRO");

                entity.Property(e => e.FechaActualizacion)
                    .HasColumnName("FECHA_ACTUALIZACION")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaCreacion)
                    .HasColumnName("FECHA_CREACION")
                    .HasColumnType("datetime");

                entity.Property(e => e.IdAcvtividadEconomica)
                    .HasColumnName("ID_ACVTIVIDAD_ECONOMICA")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.NombreComercial).HasColumnName("NOMBRE_COMERCIAL");

                entity.Property(e => e.NumIdentificacion)
                    .HasColumnName("NUM_IDENTIFICACION")
                    .HasMaxLength(16);

                entity.Property(e => e.PagoTarjeta).HasColumnName("PAGO_TARJETA");

                entity.Property(e => e.RazonSocial)
                    .HasColumnName("RAZON_SOCIAL")
                    .HasMaxLength(64);

                entity.Property(e => e.Secuencia).HasColumnName("SECUENCIA");

                entity.Property(e => e.TipoIdentificacion)
                    .HasColumnName("TIPO_IDENTIFICACION")
                    .HasMaxLength(3);

                entity.Property(e => e.TipoProveedor)
                    .HasColumnName("TIPO_PROVEEDOR")
                    .HasMaxLength(32);

                entity.Property(e => e.UrlSitioWeb)
                    .HasColumnName("URL_SITIO_WEB")
                    .HasMaxLength(300);

                entity.Property(e => e.ValorCompraMin).HasColumnName("VALOR_COMPRA_MIN");

                entity.HasOne(d => d.IdAcvtividadEconomicaNavigation)
                    .WithMany(p => p.Proveedores)
                    .HasForeignKey(d => d.IdAcvtividadEconomica)
                    .HasConstraintName("FK_dbo.PROVEEDORES_dbo.ACTIVIDADES_ECONOMICAS_ID_ACVTIVIDAD_ECONOMICA");

                entity.HasOne(d => d.IdIndividuoNavigation)
                    .WithOne(p => p.Proveedores)
                    .HasForeignKey<Proveedores>(d => d.IdIndividuo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.PROVEEDORES_dbo.INDIVIDUOS_ID_INDIVIDUO");
            });

            modelBuilder.Entity<TipoAtributos>(entity =>
            {
                entity.HasKey(e => e.IdTipo);

                entity.ToTable("TIPO_ATRIBUTOS");

                entity.Property(e => e.IdTipo).HasColumnName("ID_TIPO");

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

                entity.Property(e => e.Nombre)
                    .HasColumnName("NOMBRE")
                    .HasMaxLength(45);
            });

            modelBuilder.Entity<UnidadesVenta>(entity =>
            {
                entity.HasKey(e => e.IdUnidVenta);

                entity.ToTable("UNIDADES_VENTA");

                entity.Property(e => e.IdUnidVenta).HasColumnName("ID_UNID_VENTA");

                entity.Property(e => e.EstadoRegistro).HasColumnName("ESTADO_REGISTRO");

                entity.Property(e => e.FechaActualizacion)
                    .HasColumnName("FECHA_ACTUALIZACION")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaCreacion)
                    .HasColumnName("FECHA_CREACION")
                    .HasColumnType("datetime");

                entity.Property(e => e.Nombre)
                    .HasColumnName("NOMBRE")
                    .HasMaxLength(45);

                entity.Property(e => e.Simbolo)
                    .HasColumnName("SIMBOLO")
                    .HasMaxLength(3);
            });

            modelBuilder.Entity<Valoraciones>(entity =>
            {
                entity.HasKey(e => new { e.IdIndividuo, e.IdProducto });

                entity.ToTable("VALORACIONES");

                entity.HasIndex(e => e.IdIndividuo)
                    .HasName("IX_ID_INDIVIDUO");

                entity.HasIndex(e => e.IdProducto)
                    .HasName("IX_ID_PRODUCTO");

                entity.Property(e => e.IdIndividuo).HasColumnName("ID_INDIVIDUO");

                entity.Property(e => e.IdProducto).HasColumnName("ID_PRODUCTO");

                entity.Property(e => e.Comentario)
                    .HasColumnName("COMENTARIO")
                    .HasMaxLength(1000);

                entity.Property(e => e.EstadoRegistro).HasColumnName("ESTADO_REGISTRO");

                entity.Property(e => e.FechaActualizacion)
                    .HasColumnName("FECHA_ACTUALIZACION")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaComentario)
                    .HasColumnName("FECHA_COMENTARIO")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaCreacion)
                    .HasColumnName("FECHA_CREACION")
                    .HasColumnType("datetime");

                entity.Property(e => e.Ranking).HasColumnName("RANKING");

                entity.Property(e => e.Titulo)
                    .HasColumnName("TITULO")
                    .HasMaxLength(60);

                entity.HasOne(d => d.IdIndividuoNavigation)
                    .WithMany(p => p.Valoraciones)
                    .HasForeignKey(d => d.IdIndividuo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.VALORACIONES_dbo.PERSONAS_ID_INDIVIDUO");

                entity.HasOne(d => d.IdProductoNavigation)
                    .WithMany(p => p.Valoraciones)
                    .HasForeignKey(d => d.IdProducto)
                    .HasConstraintName("FK_dbo.VALORACIONES_dbo.PRODUCTOS_ID_PRODUCTO");
            });

            modelBuilder.Entity<ValorAtributo>(entity =>
            {
                entity.HasKey(e => e.IdValor);

                entity.ToTable("VALOR_ATRIBUTO");

                entity.HasIndex(e => e.IdAtributo)
                    .HasName("IX_ID_ATRIBUTO");

                entity.HasIndex(e => e.IdTipo)
                    .HasName("IX_ID_TIPO");

                entity.HasIndex(e => e.IdUnidVenta)
                    .HasName("IX_ID_UNID_VENTA");

                entity.Property(e => e.IdValor).HasColumnName("ID_VALOR");

                entity.Property(e => e.EstadoRegistro).HasColumnName("ESTADO_REGISTRO");

                entity.Property(e => e.FechaActualizacion)
                    .HasColumnName("FECHA_ACTUALIZACION")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaCreacion)
                    .HasColumnName("FECHA_CREACION")
                    .HasColumnType("datetime");

                entity.Property(e => e.IdAtributo).HasColumnName("ID_ATRIBUTO");

                entity.Property(e => e.IdTipo).HasColumnName("ID_TIPO");

                entity.Property(e => e.IdUnidVenta).HasColumnName("ID_UNID_VENTA");

                entity.Property(e => e.Secuencia).HasColumnName("SECUENCIA");

                entity.Property(e => e.ValorBlob).HasColumnName("VALOR_BLOB");

                entity.Property(e => e.ValorCadena)
                    .HasColumnName("VALOR_CADENA")
                    .HasMaxLength(45);

                entity.Property(e => e.ValorDecimal).HasColumnName("VALOR_DECIMAL");

                entity.Property(e => e.ValorEntero).HasColumnName("VALOR_ENTERO");

                entity.Property(e => e.ValorFecha)
                    .HasColumnName("VALOR_FECHA")
                    .HasColumnType("datetime");

                entity.HasOne(d => d.IdAtributoNavigation)
                    .WithMany(p => p.ValorAtributo)
                    .HasForeignKey(d => d.IdAtributo)
                    .HasConstraintName("FK_dbo.VALOR_ATRIBUTO_dbo.ATRIBUTOS_ARTICULOS_ID_ATRIBUTO");

                entity.HasOne(d => d.IdTipoNavigation)
                    .WithMany(p => p.ValorAtributo)
                    .HasForeignKey(d => d.IdTipo)
                    .HasConstraintName("FK_dbo.VALOR_ATRIBUTO_dbo.TIPO_ATRIBUTOS_ID_TIPO");

                entity.HasOne(d => d.IdUnidVentaNavigation)
                    .WithMany(p => p.ValorAtributo)
                    .HasForeignKey(d => d.IdUnidVenta)
                    .HasConstraintName("FK_dbo.VALOR_ATRIBUTO_dbo.UNIDADES_VENTA_ID_UNID_VENTA");
            });

            modelBuilder.Entity<ValoresMarcado>(entity =>
            {
                entity.HasKey(e => e.IdValorMarcado);

                entity.ToTable("VALORES_MARCADO");

                entity.Property(e => e.IdValorMarcado).HasColumnName("ID_VALOR_MARCADO");

                entity.Property(e => e.EstadoRegistro).HasColumnName("ESTADO_REGISTRO");

                entity.Property(e => e.FechaActualizacion)
                    .HasColumnName("FECHA_ACTUALIZACION")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaCreacion)
                    .HasColumnName("FECHA_CREACION")
                    .HasColumnType("datetime");

                entity.Property(e => e.Precio).HasColumnName("PRECIO");

                entity.Property(e => e.Valor).HasColumnName("VALOR");
            });

            modelBuilder.Entity<VersionProducto>(entity =>
            {
                entity.HasKey(e => new { e.IdVersion, e.IdProducto });

                entity.ToTable("VERSION_PRODUCTO");

                entity.HasIndex(e => e.IdProducto)
                    .HasName("IX_ID_PRODUCTO");

                entity.Property(e => e.IdVersion).HasColumnName("ID_VERSION");

                entity.Property(e => e.IdProducto).HasColumnName("ID_PRODUCTO");

                entity.Property(e => e.EstadoRegistro).HasColumnName("ESTADO_REGISTRO");

                entity.Property(e => e.FechaActualizacion)
                    .HasColumnName("FECHA_ACTUALIZACION")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaCreacion)
                    .HasColumnName("FECHA_CREACION")
                    .HasColumnType("datetime");

                entity.Property(e => e.Nombre)
                    .HasColumnName("NOMBRE")
                    .HasMaxLength(45);

                entity.HasOne(d => d.IdProductoNavigation)
                    .WithMany(p => p.VersionProducto)
                    .HasForeignKey(d => d.IdProducto)
                    .HasConstraintName("FK_dbo.VERSION_PRODUCTO_dbo.PRODUCTOS_ID_PRODUCTO");
            });

            return modelBuilder;
        }
    }
}

