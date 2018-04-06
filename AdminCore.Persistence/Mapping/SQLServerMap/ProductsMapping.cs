using AdminCore.BusinessLogic.Products.Models;
using AdminCore.Persistence.Mapping.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace AdminCore.Persistence.Mapping.SQLServerMap
{
    public class ProductsMapping : IProductsMapping
    {
        //public ModelBuilder BrandMapping(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Brand>().ToTable("dbo.MARCAS").HasKey(x => x.Id);
        //    modelBuilder.Entity<Brand>(e => {
        //            e.Property(x => x.Id).HasColumnName("ID_MARCA").IsRequired();
        //            e.Property(x => x.Name).HasColumnName("NOMBRE").HasMaxLength(45);
        //            e.Property(x => x.Description).HasColumnName("DESCRIPCION").HasMaxLength(300);
        //            e.Property(x => x.IsActive).HasColumnName("ESTADO_REGISTRO").IsRequired();
        //            e.Property(x => x.DateCreated).HasColumnName("FECHA_CREACION");
        //            e.Property(x => x.DateModified).HasColumnName("FECHA_ACTUALIZACION");
        //            e.Property(x => x.CreatedBy).HasColumnName("USUARIO_CREADOR");
        //            e.Property(x => x.ModifiedBy).HasColumnName("USUARIO_MODIFICADOR");
        //        }
        //    );

        //    return modelBuilder;
        //}

        //public ModelBuilder ProductMapping(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Product>().ToTable("dbo.PRODUCTOS").HasKey(x => x.Id);
        //    modelBuilder.Entity<Product>(e => {
        //            e.Property(x => x.Id).HasColumnName("ID_PRODUCTO").IsRequired();
        //            e.Property(x => x.Name).HasColumnName("NOMBRE").HasMaxLength(45).IsRequired();
        //        }
        //    );

        //    return modelBuilder;
        //}

        public virtual DbSet<ActividadesEconomicas> ActividadesEconomicas { get; set; }
        public virtual DbSet<AjustesInventario> AjustesInventario { get; set; }
        public virtual DbSet<Articulos> Articulos { get; set; }
        public virtual DbSet<ArticulosAtributosValores> ArticulosAtributosValores { get; set; }
        public virtual DbSet<ArticulosCarritoCompra> ArticulosCarritoCompra { get; set; }
        public virtual DbSet<ArticulosCarritoCompraPrepedido> ArticulosCarritoCompraPrepedido { get; set; }
        public virtual DbSet<ArticulosDetallesListaPedido> ArticulosDetallesListaPedido { get; set; }
        public virtual DbSet<ArticulosEntradosEstantes> ArticulosEntradosEstantes { get; set; }
        public virtual DbSet<ArticulosPedidosFacturasVenta> ArticulosPedidosFacturasVenta { get; set; }
        public virtual DbSet<ArticulosPorFacturaCompra> ArticulosPorFacturaCompra { get; set; }
        public virtual DbSet<ArticulosPorFacturaVenta> ArticulosPorFacturaVenta { get; set; }
        public virtual DbSet<ArticulosPorInstitucion> ArticulosPorInstitucion { get; set; }
        public virtual DbSet<ArticulosPorInstitucionPrePedido> ArticulosPorInstitucionPrePedido { get; set; }
        public virtual DbSet<ArticulosPorLista> ArticulosPorLista { get; set; }
        public virtual DbSet<ArticulosPorOrden> ArticulosPorOrden { get; set; }
        public virtual DbSet<ArticulosPorPedido> ArticulosPorPedido { get; set; }
        public virtual DbSet<ArticulosPrePedido> ArticulosPrePedido { get; set; }
        public virtual DbSet<ArticulosUnidadVenta> ArticulosUnidadVenta { get; set; }
        public virtual DbSet<AspNetRoles> AspNetRoles { get; set; }
        public virtual DbSet<AspNetUserClaims> AspNetUserClaims { get; set; }
        public virtual DbSet<AspNetUserLogins> AspNetUserLogins { get; set; }
        public virtual DbSet<AspNetUserRoles> AspNetUserRoles { get; set; }
        public virtual DbSet<AspNetUsers> AspNetUsers { get; set; }
        public virtual DbSet<AtribsInstituciones> AtribsInstituciones { get; set; }
        public virtual DbSet<AtributosArticulos> AtributosArticulos { get; set; }
        public virtual DbSet<BeneficiariosValidos> BeneficiariosValidos { get; set; }
        public virtual DbSet<BeneficiosAliados> BeneficiosAliados { get; set; }
        public virtual DbSet<Bodegas> Bodegas { get; set; }
        public virtual DbSet<Campanas> Campanas { get; set; }
        public virtual DbSet<CarritoCompra> CarritoCompra { get; set; }
        public virtual DbSet<CarritoCompraPrepedido> CarritoCompraPrepedido { get; set; }
        public virtual DbSet<CategoriaCategorias> CategoriaCategorias { get; set; }
        public virtual DbSet<CategoriaProd> CategoriaProd { get; set; }
        public virtual DbSet<Categorias> Categorias { get; set; }
        public virtual DbSet<CategoriasCategoriasContable> CategoriasCategoriasContable { get; set; }
        public virtual DbSet<CategoriasContabilidad> CategoriasContabilidad { get; set; }
        public virtual DbSet<Ciudades> Ciudades { get; set; }
        public virtual DbSet<ClienteCarritoCompra> ClienteCarritoCompra { get; set; }
        public virtual DbSet<CostoEnvio> CostoEnvio { get; set; }
        public virtual DbSet<CotizacionesListaEscolar> CotizacionesListaEscolar { get; set; }
        public virtual DbSet<Cursos> Cursos { get; set; }
        public virtual DbSet<DescripcionProducto> DescripcionProducto { get; set; }
        public virtual DbSet<Descuentos> Descuentos { get; set; }
        public virtual DbSet<DescuentosUsados> DescuentosUsados { get; set; }
        public virtual DbSet<DetallesAjusteInventario> DetallesAjusteInventario { get; set; }
        public virtual DbSet<DetallesEntradaInventario> DetallesEntradaInventario { get; set; }
        public virtual DbSet<DetallesListaPedido> DetallesListaPedido { get; set; }
        public virtual DbSet<DetallesSalidaInventario> DetallesSalidaInventario { get; set; }
        public virtual DbSet<EntradasInventario> EntradasInventario { get; set; }
        public virtual DbSet<EstadisticasIcfes> EstadisticasIcfes { get; set; }
        public virtual DbSet<Estantes> Estantes { get; set; }
        public virtual DbSet<FacturasCompras> FacturasCompras { get; set; }
        public virtual DbSet<FacturasVentas> FacturasVentas { get; set; }
        public virtual DbSet<HistoricoListas> HistoricoListas { get; set; }
        public virtual DbSet<ImagenesPost> ImagenesPost { get; set; }
        public virtual DbSet<Individuos> Individuos { get; set; }
        public virtual DbSet<Instituciones> Instituciones { get; set; }
        public virtual DbSet<Inventario> Inventario { get; set; }
        public virtual DbSet<KeywordsArticulos> KeywordsArticulos { get; set; }
        public virtual DbSet<KeywordsCategorias> KeywordsCategorias { get; set; }
        public virtual DbSet<KeywordsProductos> KeywordsProductos { get; set; }
        public virtual DbSet<ListasEscolares> ListasEscolares { get; set; }
        public virtual DbSet<Marcas> Marcas { get; set; }
        public virtual DbSet<MarcasProveedor> MarcasProveedor { get; set; }
        public virtual DbSet<MigrationHistory> MigrationHistory { get; set; }
        public virtual DbSet<MovimientosInventario> MovimientosInventario { get; set; }
        public virtual DbSet<OrdenCompra> OrdenCompra { get; set; }
        public virtual DbSet<Paises> Paises { get; set; }
        public virtual DbSet<PalabrasClave> PalabrasClave { get; set; }
        public virtual DbSet<Parametrizaciones> Parametrizaciones { get; set; }
        public virtual DbSet<Parrafos> Parrafos { get; set; }
        public virtual DbSet<PayuResponseLog> PayuResponseLog { get; set; }
        public virtual DbSet<PedidoInfoPayu> PedidoInfoPayu { get; set; }
        public virtual DbSet<Pedidos> Pedidos { get; set; }
        public virtual DbSet<Personas> Personas { get; set; }
        public virtual DbSet<Posts> Posts { get; set; }
        public virtual DbSet<Precios> Precios { get; set; }
        public virtual DbSet<PrePedidos> PrePedidos { get; set; }
        public virtual DbSet<Productos> Productos { get; set; }
        public virtual DbSet<ProductosRespaldo> ProductosRespaldo { get; set; }
        public virtual DbSet<Proveedores> Proveedores { get; set; }
        public virtual DbSet<Quotes> Quotes { get; set; }
        public virtual DbSet<Regiones> Regiones { get; set; }
        public virtual DbSet<ResolucionFactura> ResolucionFactura { get; set; }
        public virtual DbSet<SalidasInventario> SalidasInventario { get; set; }
        public virtual DbSet<Sedes> Sedes { get; set; }
        public virtual DbSet<Subtitulos> Subtitulos { get; set; }
        public virtual DbSet<TipoAtributos> TipoAtributos { get; set; }
        public virtual DbSet<TrazabilidadCompras> TrazabilidadCompras { get; set; }
        public virtual DbSet<Ubicaciones> Ubicaciones { get; set; }
        public virtual DbSet<UbicPersonas> UbicPersonas { get; set; }
        public virtual DbSet<UnidadesVenta> UnidadesVenta { get; set; }
        public virtual DbSet<Valoraciones> Valoraciones { get; set; }
        public virtual DbSet<ValorAtributo> ValorAtributo { get; set; }
        public virtual DbSet<ValoresMarcado> ValoresMarcado { get; set; }
        public virtual DbSet<VersionProducto> VersionProducto { get; set; }

        // Unable to generate entity type for table 'dbo.IP2LOCATION-LITE-DB3'. Please see the warning messages.

//        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//        {
//            if (!optionsBuilder.IsConfigured)
//            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
//                optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=LECDatabaseLocal;Trusted_Connection=True;");
//            }
//        }

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

            modelBuilder.Entity<AjustesInventario>(entity =>
            {
                entity.HasKey(e => e.IdAjusteInventario);

                entity.ToTable("AJUSTES_INVENTARIO");

                entity.Property(e => e.IdAjusteInventario).HasColumnName("ID_AJUSTE_INVENTARIO");

                entity.Property(e => e.Concepto)
                    .IsRequired()
                    .HasColumnName("CONCEPTO")
                    .HasMaxLength(900);

                entity.Property(e => e.EstadoRegistro).HasColumnName("ESTADO_REGISTRO");

                entity.Property(e => e.Fecha)
                    .HasColumnName("FECHA")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaActualizacion)
                    .HasColumnName("FECHA_ACTUALIZACION")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaCreacion)
                    .HasColumnName("FECHA_CREACION")
                    .HasColumnType("datetime");
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

            modelBuilder.Entity<ArticulosCarritoCompra>(entity =>
            {
                entity.HasKey(e => e.IdArticulosCarrito);

                entity.ToTable("ARTICULOS_CARRITO_COMPRA");

                entity.HasIndex(e => e.IdCarrito)
                    .HasName("IX_ID_CARRITO");

                entity.Property(e => e.IdArticulosCarrito).HasColumnName("ID_ARTICULOS_CARRITO");

                entity.Property(e => e.Cantidad).HasColumnName("CANTIDAD");

                entity.Property(e => e.CodigoLec)
                    .HasColumnName("CODIGO_LEC")
                    .HasMaxLength(64);

                entity.Property(e => e.Disponible).HasColumnName("DISPONIBLE");

                entity.Property(e => e.Donacion).HasColumnName("DONACION");

                entity.Property(e => e.EsCuaderno).HasColumnName("ES_CUADERNO");

                entity.Property(e => e.FechaLista).HasColumnName("FECHA_LISTA");

                entity.Property(e => e.IdArticulo).HasColumnName("ID_ARTICULO");

                entity.Property(e => e.IdArticuloBackup).HasColumnName("ID_ARTICULO_BACKUP");

                entity.Property(e => e.IdCarrito).HasColumnName("ID_CARRITO");

                entity.Property(e => e.IdLista)
                    .IsRequired()
                    .HasColumnName("ID_LISTA")
                    .HasMaxLength(20);

                entity.Property(e => e.IdProducto).HasColumnName("ID_PRODUCTO");

                entity.Property(e => e.IdUsuario)
                    .IsRequired()
                    .HasColumnName("ID_USUARIO")
                    .HasMaxLength(128);

                entity.Property(e => e.Iva).HasColumnName("IVA");

                entity.Property(e => e.LargeImage)
                    .HasColumnName("LARGE_IMAGE")
                    .HasMaxLength(600);

                entity.Property(e => e.Marca).HasColumnName("MARCA");

                entity.Property(e => e.Nombre)
                    .HasColumnName("NOMBRE")
                    .HasMaxLength(80);

                entity.Property(e => e.Peso).HasColumnName("PESO");

                entity.Property(e => e.Precio).HasColumnName("PRECIO");

                entity.Property(e => e.TieneImagen).HasColumnName("TIENE_IMAGEN");

                entity.Property(e => e.TieneMarcado).HasColumnName("TIENE_MARCADO");

                entity.Property(e => e.UrlThumb)
                    .HasColumnName("URL_THUMB")
                    .HasMaxLength(600);

                entity.Property(e => e.ValorMarcado).HasColumnName("VALOR_MARCADO");

                entity.HasOne(d => d.IdCarritoNavigation)
                    .WithMany(p => p.ArticulosCarritoCompra)
                    .HasForeignKey(d => d.IdCarrito)
                    .HasConstraintName("FK_dbo.ARTICULOS_CARRITO_COMPRA_dbo.CARRITO_COMPRA_ID_CARRITO");
            });

            modelBuilder.Entity<ArticulosCarritoCompraPrepedido>(entity =>
            {
                entity.HasKey(e => e.IdArticulosCarrito);

                entity.ToTable("ARTICULOS_CARRITO_COMPRA_PREPEDIDO");

                entity.HasIndex(e => e.IdCarrito)
                    .HasName("IX_ID_CARRITO");

                entity.Property(e => e.IdArticulosCarrito).HasColumnName("ID_ARTICULOS_CARRITO");

                entity.Property(e => e.Cantidad).HasColumnName("CANTIDAD");

                entity.Property(e => e.Donacion).HasColumnName("DONACION");

                entity.Property(e => e.IdArticulo).HasColumnName("ID_ARTICULO");

                entity.Property(e => e.IdArticuloBackup).HasColumnName("ID_ARTICULO_BACKUP");

                entity.Property(e => e.IdCarrito).HasColumnName("ID_CARRITO");

                entity.Property(e => e.IdProducto).HasColumnName("ID_PRODUCTO");

                entity.Property(e => e.Iva).HasColumnName("IVA");

                entity.Property(e => e.Nombre).HasColumnName("NOMBRE");

                entity.Property(e => e.Peso).HasColumnName("PESO");

                entity.Property(e => e.Precio).HasColumnName("PRECIO");

                entity.Property(e => e.TieneMarcado).HasColumnName("TIENE_MARCADO");

                entity.Property(e => e.ValorMarcado).HasColumnName("VALOR_MARCADO");

                entity.HasOne(d => d.IdCarritoNavigation)
                    .WithMany(p => p.ArticulosCarritoCompraPrepedido)
                    .HasForeignKey(d => d.IdCarrito)
                    .HasConstraintName("FK_dbo.ARTICULOS_CARRITO_COMPRA_PREPEDIDO_dbo.CARRITO_COMPRA_PREPEDIDO_ID_CARRITO");
            });

            modelBuilder.Entity<ArticulosDetallesListaPedido>(entity =>
            {
                entity.HasKey(e => new { e.IdDetallePedido, e.IdArticulo, e.IdProducto });

                entity.ToTable("ARTICULOS_DETALLES_LISTA_PEDIDO");

                entity.HasIndex(e => e.IdDetallePedido)
                    .HasName("IX_ID_DETALLE_PEDIDO");

                entity.HasIndex(e => new { e.IdArticulo, e.IdProducto })
                    .HasName("IX_ID_ARTICULO_ID_PRODUCTO");

                entity.Property(e => e.IdDetallePedido).HasColumnName("ID_DETALLE_PEDIDO");

                entity.Property(e => e.IdArticulo).HasColumnName("ID_ARTICULO");

                entity.Property(e => e.IdProducto).HasColumnName("ID_PRODUCTO");

                entity.Property(e => e.Cantidad).HasColumnName("CANTIDAD");

                entity.Property(e => e.EstadoRegistro)
                    .HasColumnName("ESTADO_REGISTRO")
                    .HasColumnType("datetime");

                entity.Property(e => e.EstadoRegistro1).HasColumnName("EstadoRegistro");

                entity.Property(e => e.FechaActualizacion)
                    .HasColumnName("FECHA_ACTUALIZACION")
                    .HasColumnType("datetime");

                entity.Property(e => e.TieneMarcado).HasColumnName("TIENE_MARCADO");

                entity.HasOne(d => d.IdDetallePedidoNavigation)
                    .WithMany(p => p.ArticulosDetallesListaPedido)
                    .HasForeignKey(d => d.IdDetallePedido)
                    .HasConstraintName("FK_dbo.ARTICULOS_DETALLES_LISTA_PEDIDO_dbo.DETALLES_LISTA_PEDIDO_ID_DETALLE_PEDIDO");

                entity.HasOne(d => d.Id)
                    .WithMany(p => p.ArticulosDetallesListaPedido)
                    .HasForeignKey(d => new { d.IdArticulo, d.IdProducto })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.ARTICULOS_DETALLES_LISTA_PEDIDO_dbo.ARTICULOS_ID_ARTICULO_ID_PRODUCTO");
            });

            modelBuilder.Entity<ArticulosEntradosEstantes>(entity =>
            {
                entity.HasKey(e => new { e.IdDetalleEntradaInventario, e.IdEstante });

                entity.ToTable("ARTICULOS_ENTRADOS_ESTANTES");

                entity.HasIndex(e => e.IdDetalleEntradaInventario)
                    .HasName("IX_ID_DETALLE_ENTRADA_INVENTARIO");

                entity.HasIndex(e => e.IdEstante)
                    .HasName("IX_ID_ESTANTE");

                entity.Property(e => e.IdDetalleEntradaInventario).HasColumnName("ID_DETALLE_ENTRADA_INVENTARIO");

                entity.Property(e => e.IdEstante).HasColumnName("ID_ESTANTE");

                entity.Property(e => e.EstadoRegistro).HasColumnName("ESTADO_REGISTRO");

                entity.Property(e => e.FechaActualizacion)
                    .HasColumnName("FECHA_ACTUALIZACION")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaCreacion)
                    .HasColumnName("FECHA_CREACION")
                    .HasColumnType("datetime");

                entity.HasOne(d => d.IdDetalleEntradaInventarioNavigation)
                    .WithMany(p => p.ArticulosEntradosEstantes)
                    .HasForeignKey(d => d.IdDetalleEntradaInventario)
                    .HasConstraintName("FK_dbo.ARTICULOS_ENTRADOS_ESTANTES_dbo.DETALLES_ENTRADA_INVENTARIO_ID_DETALLE_ENTRADA_INVENTARIO");

                entity.HasOne(d => d.IdEstanteNavigation)
                    .WithMany(p => p.ArticulosEntradosEstantes)
                    .HasForeignKey(d => d.IdEstante)
                    .HasConstraintName("FK_dbo.ARTICULOS_ENTRADOS_ESTANTES_dbo.ESTANTES_ID_ESTANTE");
            });

            modelBuilder.Entity<ArticulosPedidosFacturasVenta>(entity =>
            {
                entity.HasKey(e => e.IdCambio);

                entity.ToTable("ARTICULOS_PEDIDOS_FACTURAS_VENTA");

                entity.HasIndex(e => new { e.IdArticulo, e.IdPedido, e.IdProducto })
                    .HasName("IX_ID_ARTICULO_ID_PEDIDO_ID_PRODUCTO");

                entity.HasIndex(e => new { e.IdArticuloCambio, e.IdFactura, e.IdProductoCambio })
                    .HasName("IX_ID_ARTICULO_CAMBIO_ID_FACTURA_ID_PRODUCTO_CAMBIO");

                entity.Property(e => e.IdCambio).HasColumnName("ID_CAMBIO");

                entity.Property(e => e.EstadoRegistro).HasColumnName("ESTADO_REGISTRO");

                entity.Property(e => e.FechaActualizacion)
                    .HasColumnName("FECHA_ACTUALIZACION")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaCreacion)
                    .HasColumnName("FECHA_CREACION")
                    .HasColumnType("datetime");

                entity.Property(e => e.IdArticulo).HasColumnName("ID_ARTICULO");

                entity.Property(e => e.IdArticuloCambio).HasColumnName("ID_ARTICULO_CAMBIO");

                entity.Property(e => e.IdFactura).HasColumnName("ID_FACTURA");

                entity.Property(e => e.IdPedido).HasColumnName("ID_PEDIDO");

                entity.Property(e => e.IdProducto).HasColumnName("ID_PRODUCTO");

                entity.Property(e => e.IdProductoCambio).HasColumnName("ID_PRODUCTO_CAMBIO");

                entity.HasOne(d => d.Id)
                    .WithMany(p => p.ArticulosPedidosFacturasVenta)
                    .HasForeignKey(d => new { d.IdArticulo, d.IdPedido, d.IdProducto })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.ARTICULOS_PEDIDOS_FACTURAS_VENTA_dbo.ARTICULOS_POR_PEDIDO_ID_ARTICULO_ID_PRODUCTO_ID_PEDIDO");

                entity.HasOne(d => d.IdNavigation)
                    .WithMany(p => p.ArticulosPedidosFacturasVenta)
                    .HasForeignKey(d => new { d.IdArticuloCambio, d.IdFactura, d.IdProductoCambio })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.ARTICULOS_PEDIDOS_FACTURAS_VENTA_dbo.ARTICULOS_POR_FACTURA_VENTA_ID_ARTICULO_CAMBIO_ID_PRODUCTO_CAMBIO_ID_FACTURA");
            });

            modelBuilder.Entity<ArticulosPorFacturaCompra>(entity =>
            {
                entity.HasKey(e => new { e.IdArticulo, e.IdFacturaCompra, e.IdProducto });

                entity.ToTable("ARTICULOS_POR_FACTURA_COMPRA");

                entity.HasIndex(e => e.IdFacturaCompra)
                    .HasName("IX_ID_FACTURA_COMPRA");

                entity.HasIndex(e => new { e.IdArticulo, e.IdProducto })
                    .HasName("IX_ID_ARTICULO_ID_PRODUCTO");

                entity.Property(e => e.IdArticulo).HasColumnName("ID_ARTICULO");

                entity.Property(e => e.IdFacturaCompra).HasColumnName("ID_FACTURA_COMPRA");

                entity.Property(e => e.IdProducto).HasColumnName("ID_PRODUCTO");

                entity.Property(e => e.Cantidad).HasColumnName("CANTIDAD");

                entity.Property(e => e.EstadoRegistro).HasColumnName("ESTADO_REGISTRO");

                entity.Property(e => e.FechaActualizacion)
                    .HasColumnName("FECHA_ACTUALIZACION")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaCreacion)
                    .HasColumnName("FECHA_CREACION")
                    .HasColumnType("datetime");

                entity.Property(e => e.PorcentajeIva).HasColumnName("PORCENTAJE_IVA");

                entity.Property(e => e.PrecioCompraSinIva)
                    .HasColumnName("PRECIO_COMPRA_SIN_IVA")
                    .HasColumnType("decimal(14, 6)");

                entity.HasOne(d => d.IdFacturaCompraNavigation)
                    .WithMany(p => p.ArticulosPorFacturaCompra)
                    .HasForeignKey(d => d.IdFacturaCompra)
                    .HasConstraintName("FK_dbo.ARTICULOS_POR_FACTURA_COMPRA_dbo.FACTURAS_COMPRAS_ID_FACTURA_COMPRA");

                entity.HasOne(d => d.Id)
                    .WithMany(p => p.ArticulosPorFacturaCompra)
                    .HasForeignKey(d => new { d.IdArticulo, d.IdProducto })
                    .HasConstraintName("FK_dbo.ARTICULOS_POR_FACTURA_COMPRA_dbo.ARTICULOS_ID_ARTICULO_ID_PRODUCTO");
            });

            modelBuilder.Entity<ArticulosPorFacturaVenta>(entity =>
            {
                entity.HasKey(e => new { e.IdArticulo, e.IdFacturaVenta, e.IdProducto });

                entity.ToTable("ARTICULOS_POR_FACTURA_VENTA");

                entity.HasIndex(e => e.IdFacturaVenta)
                    .HasName("IX_ID_FACTURA_VENTA");

                entity.HasIndex(e => new { e.IdArticulo, e.IdProducto })
                    .HasName("IX_ID_ARTICULO_ID_PRODUCTO");

                entity.Property(e => e.IdArticulo).HasColumnName("ID_ARTICULO");

                entity.Property(e => e.IdFacturaVenta).HasColumnName("ID_FACTURA_VENTA");

                entity.Property(e => e.IdProducto).HasColumnName("ID_PRODUCTO");

                entity.Property(e => e.Cantidad).HasColumnName("CANTIDAD");

                entity.Property(e => e.EstadoRegistro).HasColumnName("ESTADO_REGISTRO");

                entity.Property(e => e.FechaActualizacion)
                    .HasColumnName("FECHA_ACTUALIZACION")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaCreacion)
                    .HasColumnName("FECHA_CREACION")
                    .HasColumnType("datetime");

                entity.Property(e => e.PrecioConIva).HasColumnName("PRECIO_CON_IVA");

                entity.HasOne(d => d.IdFacturaVentaNavigation)
                    .WithMany(p => p.ArticulosPorFacturaVenta)
                    .HasForeignKey(d => d.IdFacturaVenta)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.ARTICULOS_POR_FACTURA_VENTA_dbo.FACTURAS_VENTAS_ID_FACTURA_VENTA");

                entity.HasOne(d => d.Id)
                    .WithMany(p => p.ArticulosPorFacturaVenta)
                    .HasForeignKey(d => new { d.IdArticulo, d.IdProducto })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.ARTICULOS_POR_FACTURA_VENTA_dbo.ARTICULOS_ID_ARTICULO_ID_PRODUCTO");
            });

            modelBuilder.Entity<ArticulosPorInstitucion>(entity =>
            {
                entity.HasKey(e => new { e.IdArticulo, e.IdIndividuo, e.IdProducto, e.IdPedido });

                entity.ToTable("ARTICULOS_POR_INSTITUCION");

                entity.HasIndex(e => e.IdIndividuo)
                    .HasName("IX_ID_INDIVIDUO");

                entity.HasIndex(e => e.IdPedido)
                    .HasName("IX_ID_PEDIDO");

                entity.HasIndex(e => new { e.IdArticulo, e.IdProducto })
                    .HasName("IX_ID_ARTICULO_ID_PRODUCTO");

                entity.Property(e => e.IdArticulo).HasColumnName("ID_ARTICULO");

                entity.Property(e => e.IdIndividuo).HasColumnName("ID_INDIVIDUO");

                entity.Property(e => e.IdProducto).HasColumnName("ID_PRODUCTO");

                entity.Property(e => e.IdPedido).HasColumnName("ID_PEDIDO");

                entity.Property(e => e.Cantidad).HasColumnName("CANTIDAD");

                entity.Property(e => e.EstadoRegistro).HasColumnName("ESTADO_REGISTRO");

                entity.Property(e => e.FechaActualizacion)
                    .HasColumnName("FECHA_ACTUALIZACION")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaCreacion)
                    .HasColumnName("FECHA_CREACION")
                    .HasColumnType("datetime");

                entity.HasOne(d => d.IdIndividuoNavigation)
                    .WithMany(p => p.ArticulosPorInstitucion)
                    .HasForeignKey(d => d.IdIndividuo)
                    .HasConstraintName("FK_dbo.ARTICULOS_POR_INSTITUCION_dbo.INDIVIDUOS_ID_INDIVIDUO");

                entity.HasOne(d => d.IdPedidoNavigation)
                    .WithMany(p => p.ArticulosPorInstitucion)
                    .HasForeignKey(d => d.IdPedido)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.ARTICULOS_POR_INSTITUCION_dbo.PEDIDOS_ID_PEDIDO");

                entity.HasOne(d => d.Id)
                    .WithMany(p => p.ArticulosPorInstitucion)
                    .HasForeignKey(d => new { d.IdArticulo, d.IdProducto })
                    .HasConstraintName("FK_dbo.ARTICULOS_POR_INSTITUCION_dbo.ARTICULOS_ID_ARTICULO_ID_PRODUCTO");
            });

            modelBuilder.Entity<ArticulosPorInstitucionPrePedido>(entity =>
            {
                entity.HasKey(e => new { e.IdArticulo, e.IdIndividuo, e.IdProducto, e.IdPrePedido });

                entity.ToTable("ARTICULOS_POR_INSTITUCION_PRE_PEDIDO");

                entity.HasIndex(e => e.IdPrePedido)
                    .HasName("IX_ID_PRE_PEDIDO");

                entity.Property(e => e.IdArticulo).HasColumnName("ID_ARTICULO");

                entity.Property(e => e.IdIndividuo).HasColumnName("ID_INDIVIDUO");

                entity.Property(e => e.IdProducto).HasColumnName("ID_PRODUCTO");

                entity.Property(e => e.IdPrePedido).HasColumnName("ID_PRE_PEDIDO");

                entity.Property(e => e.Cantidad).HasColumnName("CANTIDAD");

                entity.Property(e => e.EstadoRegistro).HasColumnName("ESTADO_REGISTRO");

                entity.Property(e => e.FechaActualizacion)
                    .HasColumnName("FECHA_ACTUALIZACION")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaCreacion)
                    .HasColumnName("FECHA_CREACION")
                    .HasColumnType("datetime");

                entity.HasOne(d => d.IdPrePedidoNavigation)
                    .WithMany(p => p.ArticulosPorInstitucionPrePedido)
                    .HasForeignKey(d => d.IdPrePedido)
                    .HasConstraintName("FK_dbo.ARTICULOS_POR_INSTITUCION_PRE_PEDIDO_dbo.PRE_PEDIDOS_ID_PRE_PEDIDO");
            });

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

            modelBuilder.Entity<ArticulosPorOrden>(entity =>
            {
                entity.HasKey(e => e.IdDetalleOrdenCompra);

                entity.ToTable("ARTICULOS_POR_ORDEN");

                entity.HasIndex(e => e.IdOrden)
                    .HasName("IX_ID_ORDEN");

                entity.HasIndex(e => new { e.IdArticulo, e.IdProducto })
                    .HasName("IX_ID_ARTICULO_ID_PRODUCTO");

                entity.Property(e => e.IdDetalleOrdenCompra).HasColumnName("ID_DETALLE_ORDEN_COMPRA");

                entity.Property(e => e.Cantidad).HasColumnName("CANTIDAD");

                entity.Property(e => e.EstadoRegistro).HasColumnName("ESTADO_REGISTRO");

                entity.Property(e => e.FechaActualizacion)
                    .HasColumnName("FECHA_ACTUALIZACION")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaCreacion)
                    .HasColumnName("FECHA_CREACION")
                    .HasColumnType("datetime");

                entity.Property(e => e.IdArticulo).HasColumnName("ID_ARTICULO");

                entity.Property(e => e.IdOrden).HasColumnName("ID_ORDEN");

                entity.Property(e => e.IdProducto).HasColumnName("ID_PRODUCTO");

                entity.Property(e => e.LugarUltimaCompra)
                    .HasColumnName("LUGAR_ULTIMA_COMPRA")
                    .HasMaxLength(30);

                entity.Property(e => e.PrecioUltimaCompra).HasColumnName("PRECIO_ULTIMA_COMPRA");

                entity.HasOne(d => d.IdOrdenNavigation)
                    .WithMany(p => p.ArticulosPorOrden)
                    .HasForeignKey(d => d.IdOrden)
                    .HasConstraintName("FK_dbo.ARTICULOS_POR_ORDEN_dbo.ORDEN_COMPRA_ID_ORDEN");

                entity.HasOne(d => d.Id)
                    .WithMany(p => p.ArticulosPorOrden)
                    .HasForeignKey(d => new { d.IdArticulo, d.IdProducto })
                    .HasConstraintName("FK_dbo.ARTICULOS_POR_ORDEN_dbo.ARTICULOS_ID_ARTICULO_ID_PRODUCTO");
            });

            modelBuilder.Entity<ArticulosPorPedido>(entity =>
            {
                entity.HasKey(e => new { e.IdArticulo, e.IdPedido, e.IdProducto });

                entity.ToTable("ARTICULOS_POR_PEDIDO");

                entity.HasIndex(e => e.IdPedido)
                    .HasName("IX_ID_PEDIDO");

                entity.HasIndex(e => new { e.IdArticulo, e.IdProducto })
                    .HasName("IX_ID_ARTICULO_ID_PRODUCTO");

                entity.Property(e => e.IdArticulo).HasColumnName("ID_ARTICULO");

                entity.Property(e => e.IdPedido).HasColumnName("ID_PEDIDO");

                entity.Property(e => e.IdProducto).HasColumnName("ID_PRODUCTO");

                entity.Property(e => e.Cantidad).HasColumnName("CANTIDAD");

                entity.Property(e => e.EstadoRegistro).HasColumnName("ESTADO_REGISTRO");

                entity.Property(e => e.FechaActualizacion)
                    .HasColumnName("FECHA_ACTUALIZACION")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaCreacion)
                    .HasColumnName("FECHA_CREACION")
                    .HasColumnType("datetime");

                entity.Property(e => e.PrecioConIva).HasColumnName("PRECIO_CON_IVA");

                entity.HasOne(d => d.IdPedidoNavigation)
                    .WithMany(p => p.ArticulosPorPedido)
                    .HasForeignKey(d => d.IdPedido)
                    .HasConstraintName("FK_dbo.ARTICULOS_POR_PEDIDO_dbo.PEDIDOS_ID_PEDIDO");

                entity.HasOne(d => d.Id)
                    .WithMany(p => p.ArticulosPorPedido)
                    .HasForeignKey(d => new { d.IdArticulo, d.IdProducto })
                    .HasConstraintName("FK_dbo.ARTICULOS_POR_PEDIDO_dbo.ARTICULOS_ID_ARTICULO_ID_PRODUCTO");
            });

            modelBuilder.Entity<ArticulosPrePedido>(entity =>
            {
                entity.HasKey(e => new { e.IdArticulo, e.IdPrePedido, e.IdProducto });

                entity.ToTable("ARTICULOS_PRE_PEDIDO");

                entity.HasIndex(e => e.IdPrePedido)
                    .HasName("IX_ID_PRE_PEDIDO");

                entity.Property(e => e.IdArticulo).HasColumnName("ID_ARTICULO");

                entity.Property(e => e.IdPrePedido).HasColumnName("ID_PRE_PEDIDO");

                entity.Property(e => e.IdProducto).HasColumnName("ID_PRODUCTO");

                entity.Property(e => e.Cantidad).HasColumnName("CANTIDAD");

                entity.Property(e => e.EstadoRegistro).HasColumnName("ESTADO_REGISTRO");

                entity.Property(e => e.FechaActualizacion)
                    .HasColumnName("FECHA_ACTUALIZACION")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaCreacion)
                    .HasColumnName("FECHA_CREACION")
                    .HasColumnType("datetime");

                entity.Property(e => e.PrecioConIva).HasColumnName("PRECIO_CON_IVA");

                entity.HasOne(d => d.IdPrePedidoNavigation)
                    .WithMany(p => p.ArticulosPrePedido)
                    .HasForeignKey(d => d.IdPrePedido)
                    .HasConstraintName("FK_dbo.ARTICULOS_PRE_PEDIDO_dbo.PRE_PEDIDOS_ID_PRE_PEDIDO");
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

            modelBuilder.Entity<Bodegas>(entity =>
            {
                entity.HasKey(e => e.IdBodega);

                entity.ToTable("BODEGAS");

                entity.HasIndex(e => e.IdUbicacion)
                    .HasName("IX_ID_UBICACION");

                entity.Property(e => e.IdBodega).HasColumnName("ID_BODEGA");

                entity.Property(e => e.Especificacion)
                    .HasColumnName("ESPECIFICACION")
                    .HasMaxLength(100);

                entity.Property(e => e.EstadoRegistro).HasColumnName("ESTADO_REGISTRO");

                entity.Property(e => e.FechaActualizacion)
                    .HasColumnName("FECHA_ACTUALIZACION")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaCreacion)
                    .HasColumnName("FECHA_CREACION")
                    .HasColumnType("datetime");

                entity.Property(e => e.IdUbicacion).HasColumnName("ID_UBICACION");

                entity.Property(e => e.NombreBodega)
                    .IsRequired()
                    .HasColumnName("NOMBRE_BODEGA")
                    .HasMaxLength(45);

                entity.HasOne(d => d.IdUbicacionNavigation)
                    .WithMany(p => p.Bodegas)
                    .HasForeignKey(d => d.IdUbicacion)
                    .HasConstraintName("FK_dbo.BODEGAS_dbo.UBICACIONES_ID_UBICACION");
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

            modelBuilder.Entity<CarritoCompra>(entity =>
            {
                entity.HasKey(e => e.IdCarrito);

                entity.ToTable("CARRITO_COMPRA");

                entity.Property(e => e.IdCarrito).HasColumnName("ID_CARRITO");

                entity.Property(e => e.Alerta).HasColumnName("ALERTA");

                entity.Property(e => e.Autenticado).HasColumnName("AUTENTICADO");

                entity.Property(e => e.CodigoDescuento).HasColumnName("CODIGO_DESCUENTO");

                entity.Property(e => e.Curso).HasColumnName("CURSO");

                entity.Property(e => e.DireccionaColegio).HasColumnName("DIRECCIONA_COLEGIO");

                entity.Property(e => e.FechaExpiracion)
                    .HasColumnName("FECHA_EXPIRACION")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaLista).HasColumnName("FECHA_LISTA");

                entity.Property(e => e.IdCiudad).HasColumnName("ID_CIUDAD");

                entity.Property(e => e.IdGenero).HasColumnName("ID_GENERO");

                entity.Property(e => e.IdIndividuo).HasColumnName("ID_INDIVIDUO");

                entity.Property(e => e.IdLista)
                    .IsRequired()
                    .HasColumnName("ID_LISTA")
                    .HasMaxLength(20);

                entity.Property(e => e.IdListaReal).HasColumnName("ID_LISTA_REAL");

                entity.Property(e => e.IdUsuario)
                    .IsRequired()
                    .HasColumnName("ID_USUARIO")
                    .HasMaxLength(128);

                entity.Property(e => e.MinimoDescuento).HasColumnName("MINIMO_DESCUENTO");

                entity.Property(e => e.NombreColegio).HasColumnName("NOMBRE_COLEGIO");

                entity.Property(e => e.NombreCortoColegio)
                    .HasColumnName("NOMBRE_CORTO_COLEGIO")
                    .HasMaxLength(45);

                entity.Property(e => e.NombreMarcado)
                    .HasColumnName("NOMBRE_MARCADO")
                    .HasMaxLength(35);

                entity.Property(e => e.NombreOficialColegio)
                    .HasColumnName("NOMBRE_OFICIAL_COLEGIO")
                    .HasMaxLength(80);

                entity.Property(e => e.RedisSesion)
                    .HasColumnName("REDIS_SESION")
                    .HasMaxLength(50);

                entity.Property(e => e.TieneMarcado).HasColumnName("TIENE_MARCADO");

                entity.Property(e => e.TipoDescuento).HasColumnName("TIPO_DESCUENTO");

                entity.Property(e => e.UrlLogo).HasColumnName("URL_LOGO");

                entity.Property(e => e.UrlLogoMin).HasColumnName("URL_LOGO_MIN");

                entity.Property(e => e.ValorDescuento).HasColumnName("VALOR_DESCUENTO");
            });

            modelBuilder.Entity<CarritoCompraPrepedido>(entity =>
            {
                entity.HasKey(e => e.IdCarrito);

                entity.ToTable("CARRITO_COMPRA_PREPEDIDO");

                entity.HasIndex(e => e.IdInformacionUsuario)
                    .HasName("IX_ID_INFORMACION_USUARIO");

                entity.Property(e => e.IdCarrito).HasColumnName("ID_CARRITO");

                entity.Property(e => e.Alerta).HasColumnName("ALERTA");

                entity.Property(e => e.CodigoDescuento).HasColumnName("CODIGO_DESCUENTO");

                entity.Property(e => e.CostoEnvio)
                    .HasColumnName("COSTO_ENVIO")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CostoMarcado)
                    .HasColumnName("COSTO_MARCADO")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Curso).HasColumnName("CURSO");

                entity.Property(e => e.EsLista).HasColumnName("ES_LISTA");

                entity.Property(e => e.FechaLista).HasColumnName("FECHA_LISTA");

                entity.Property(e => e.IdColegio).HasColumnName("ID_COLEGIO");

                entity.Property(e => e.IdGenero).HasColumnName("ID_GENERO");

                entity.Property(e => e.IdInformacionUsuario).HasColumnName("ID_INFORMACION_USUARIO");

                entity.Property(e => e.IdListaReal).HasColumnName("ID_LISTA_REAL");

                entity.Property(e => e.IdSesion).HasColumnName("ID_SESION");

                entity.Property(e => e.MinimoDescuento).HasColumnName("MINIMO_DESCUENTO");

                entity.Property(e => e.NombreCortoColegio)
                    .HasColumnName("NOMBRE_CORTO_COLEGIO")
                    .HasMaxLength(45);

                entity.Property(e => e.NombreMarcado)
                    .HasColumnName("NOMBRE_MARCADO")
                    .HasMaxLength(35);

                entity.Property(e => e.TieneMarcado).HasColumnName("TIENE_MARCADO");

                entity.Property(e => e.TipoDescuento).HasColumnName("TIPO_DESCUENTO");

                entity.Property(e => e.ValorDescuento).HasColumnName("VALOR_DESCUENTO");
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

            modelBuilder.Entity<ClienteCarritoCompra>(entity =>
            {
                entity.ToTable("CLIENTE_CARRITO_COMPRA");

                entity.Property(e => e.Ciudad)
                    .IsRequired()
                    .HasColumnName("CIUDAD")
                    .HasMaxLength(30)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CodigoPedido)
                    .HasColumnName("CODIGO_PEDIDO")
                    .HasMaxLength(20);

                entity.Property(e => e.Direccion)
                    .IsRequired()
                    .HasColumnName("DIRECCION")
                    .HasMaxLength(120);

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasColumnName("EMAIL")
                    .HasMaxLength(120)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.FechaCreacion)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("('1900-01-01T00:00:00.000')");

                entity.Property(e => e.IdCiudad).HasColumnName("ID_CIUDAD");

                entity.Property(e => e.IdIndividuo)
                    .HasColumnName("ID_INDIVIDUO")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.IdUbicacion)
                    .HasColumnName("ID_UBICACION")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("NOMBRE")
                    .HasMaxLength(120);

                entity.Property(e => e.NumeroIdentificacion)
                    .IsRequired()
                    .HasColumnName("NUMERO_IDENTIFICACION")
                    .HasMaxLength(15);

                entity.Property(e => e.Telefono)
                    .IsRequired()
                    .HasColumnName("TELEFONO")
                    .HasMaxLength(30);
            });

            modelBuilder.Entity<CostoEnvio>(entity =>
            {
                entity.HasKey(e => e.IdCostoEnvio);

                entity.ToTable("COSTO_ENVIO");

                entity.HasIndex(e => e.IdCiudad)
                    .HasName("IX_ID_CIUDAD");

                entity.Property(e => e.IdCostoEnvio).HasColumnName("ID_COSTO_ENVIO");

                entity.Property(e => e.EstadoRegistro).HasColumnName("ESTADO_REGISTRO");

                entity.Property(e => e.FechaActualizacion)
                    .HasColumnName("FECHA_ACTUALIZACION")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaCreacion)
                    .HasColumnName("FECHA_CREACION")
                    .HasColumnType("datetime");

                entity.Property(e => e.IdCiudad).HasColumnName("ID_CIUDAD");

                entity.Property(e => e.Peso).HasColumnName("PESO");

                entity.Property(e => e.Precio).HasColumnName("PRECIO");

                entity.HasOne(d => d.IdCiudadNavigation)
                    .WithMany(p => p.CostoEnvio)
                    .HasForeignKey(d => d.IdCiudad)
                    .HasConstraintName("FK_dbo.COSTO_ENVIO_dbo.CIUDADES_ID_CIUDAD");
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

            modelBuilder.Entity<DetallesAjusteInventario>(entity =>
            {
                entity.HasKey(e => e.IdDetalleAjusteInventario);

                entity.ToTable("DETALLES_AJUSTE_INVENTARIO");

                entity.HasIndex(e => e.IdAjusteInventario)
                    .HasName("IX_ID_AJUSTE_INVENTARIO");

                entity.HasIndex(e => new { e.IdArticulo, e.IdProducto })
                    .HasName("IX_ID_ARTICULO_ID_PRODUCTO");

                entity.Property(e => e.IdDetalleAjusteInventario).HasColumnName("ID_DETALLE_AJUSTE_INVENTARIO");

                entity.Property(e => e.EstadoRegistro).HasColumnName("ESTADO_REGISTRO");

                entity.Property(e => e.FechaActualizacion)
                    .HasColumnName("FECHA_ACTUALIZACION")
                    .HasColumnType("datetime");

                entity.Property(e => e.IdAjusteInventario).HasColumnName("ID_AJUSTE_INVENTARIO");

                entity.Property(e => e.IdArticulo).HasColumnName("ID_ARTICULO");

                entity.Property(e => e.IdProducto).HasColumnName("ID_PRODUCTO");

                entity.Property(e => e.PorcentajeIva).HasColumnName("PORCENTAJE_IVA");

                entity.Property(e => e.PrecioSinIva).HasColumnName("PRECIO_SIN_IVA");

                entity.Property(e => e.TipoAjuste)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.TipoAjuste1)
                    .HasColumnName("TIPO_AJUSTE")
                    .HasColumnType("datetime");

                entity.HasOne(d => d.IdAjusteInventarioNavigation)
                    .WithMany(p => p.DetallesAjusteInventario)
                    .HasForeignKey(d => d.IdAjusteInventario)
                    .HasConstraintName("FK_dbo.DETALLES_AJUSTE_INVENTARIO_dbo.AJUSTES_INVENTARIO_ID_AJUSTE_INVENTARIO");

                entity.HasOne(d => d.Id)
                    .WithMany(p => p.DetallesAjusteInventario)
                    .HasForeignKey(d => new { d.IdArticulo, d.IdProducto })
                    .HasConstraintName("FK_dbo.DETALLES_AJUSTE_INVENTARIO_dbo.ARTICULOS_ID_ARTICULO_ID_PRODUCTO");
            });

            modelBuilder.Entity<DetallesEntradaInventario>(entity =>
            {
                entity.HasKey(e => e.IdDetalleEntradaInventario);

                entity.ToTable("DETALLES_ENTRADA_INVENTARIO");

                entity.HasIndex(e => e.IdEntradaInventario)
                    .HasName("IX_ID_ENTRADA_INVENTARIO");

                entity.HasIndex(e => e.IdFacturaCompra)
                    .HasName("IX_ID_FACTURA_COMPRA");

                entity.HasIndex(e => new { e.IdArticulo, e.IdProducto })
                    .HasName("IX_ID_ARTICULO_ID_PRODUCTO");

                entity.Property(e => e.IdDetalleEntradaInventario).HasColumnName("ID_DETALLE_ENTRADA_INVENTARIO");

                entity.Property(e => e.EstadoRegistro).HasColumnName("ESTADO_REGISTRO");

                entity.Property(e => e.FechaActualizacion)
                    .HasColumnName("FECHA_ACTUALIZACION")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaCreacion)
                    .HasColumnName("FECHA_CREACION")
                    .HasColumnType("datetime");

                entity.Property(e => e.IdArticulo).HasColumnName("ID_ARTICULO");

                entity.Property(e => e.IdEntradaInventario).HasColumnName("ID_ENTRADA_INVENTARIO");

                entity.Property(e => e.IdFacturaCompra).HasColumnName("ID_FACTURA_COMPRA");

                entity.Property(e => e.IdProducto).HasColumnName("ID_PRODUCTO");

                entity.Property(e => e.PorcentajeIva).HasColumnName("PORCENTAJE_IVA");

                entity.Property(e => e.PrecioCompraSinIva)
                    .HasColumnName("PRECIO_COMPRA_SIN_IVA")
                    .HasColumnType("decimal(14, 6)");

                entity.Property(e => e.PrecioCompraSinIvaDescuento)
                    .HasColumnName("PRECIO_COMPRA_SIN_IVA_DESCUENTO")
                    .HasColumnType("decimal(14, 6)");

                entity.HasOne(d => d.IdEntradaInventarioNavigation)
                    .WithMany(p => p.DetallesEntradaInventario)
                    .HasForeignKey(d => d.IdEntradaInventario)
                    .HasConstraintName("FK_dbo.DETALLES_ENTRADA_INVENTARIO_dbo.ENTRADAS_INVENTARIO_ID_ENTRADA_INVENTARIO");

                entity.HasOne(d => d.IdFacturaCompraNavigation)
                    .WithMany(p => p.DetallesEntradaInventario)
                    .HasForeignKey(d => d.IdFacturaCompra)
                    .HasConstraintName("FK_dbo.DETALLES_ENTRADA_INVENTARIO_dbo.FACTURAS_COMPRAS_ID_FACTURA_COMPRA");

                entity.HasOne(d => d.Id)
                    .WithMany(p => p.DetallesEntradaInventario)
                    .HasForeignKey(d => new { d.IdArticulo, d.IdProducto })
                    .HasConstraintName("FK_dbo.DETALLES_ENTRADA_INVENTARIO_dbo.ARTICULOS_ID_ARTICULO_ID_PRODUCTO");
            });

            modelBuilder.Entity<DetallesListaPedido>(entity =>
            {
                entity.HasKey(e => e.IdDetalleListaPedido);

                entity.ToTable("DETALLES_LISTA_PEDIDO");

                entity.HasIndex(e => e.IdLista)
                    .HasName("IX_ID_LISTA");

                entity.HasIndex(e => e.IdPedido)
                    .HasName("IX_ID_PEDIDO");

                entity.Property(e => e.IdDetalleListaPedido).HasColumnName("ID_DETALLE_LISTA_PEDIDO");

                entity.Property(e => e.EstadoRegistro)
                    .HasColumnName("ESTADO_REGISTRO")
                    .HasColumnType("datetime");

                entity.Property(e => e.EstadoRegistro1).HasColumnName("EstadoRegistro");

                entity.Property(e => e.FechaActualizacion)
                    .HasColumnName("FECHA_ACTUALIZACION")
                    .HasColumnType("datetime");

                entity.Property(e => e.IdLista).HasColumnName("ID_LISTA");

                entity.Property(e => e.IdPedido).HasColumnName("ID_PEDIDO");

                entity.Property(e => e.NombreMarcado)
                    .HasColumnName("NOMBRE_MARCADO")
                    .HasMaxLength(35);

                entity.Property(e => e.TieneMarcado).HasColumnName("TIENE_MARCADO");

                entity.HasOne(d => d.IdListaNavigation)
                    .WithMany(p => p.DetallesListaPedido)
                    .HasForeignKey(d => d.IdLista)
                    .HasConstraintName("FK_dbo.DETALLES_LISTA_PEDIDO_dbo.LISTAS_ESCOLARES_ID_LISTA");

                entity.HasOne(d => d.IdPedidoNavigation)
                    .WithMany(p => p.DetallesListaPedido)
                    .HasForeignKey(d => d.IdPedido)
                    .HasConstraintName("FK_dbo.DETALLES_LISTA_PEDIDO_dbo.PEDIDOS_ID_PEDIDO");
            });

            modelBuilder.Entity<DetallesSalidaInventario>(entity =>
            {
                entity.HasKey(e => e.IdDetalleSalidaInventario);

                entity.ToTable("DETALLES_SALIDA_INVENTARIO");

                entity.HasIndex(e => e.IdFacturaVenta)
                    .HasName("IX_ID_FACTURA_VENTA");

                entity.HasIndex(e => e.IdSalidaInventario)
                    .HasName("IX_ID_SALIDA_INVENTARIO");

                entity.HasIndex(e => new { e.IdArticulo, e.IdProducto })
                    .HasName("IX_ID_ARTICULO_ID_PRODUCTO");

                entity.Property(e => e.IdDetalleSalidaInventario).HasColumnName("ID_DETALLE_SALIDA_INVENTARIO");

                entity.Property(e => e.EstadoRegistro).HasColumnName("ESTADO_REGISTRO");

                entity.Property(e => e.FechaActualizacion)
                    .HasColumnName("FECHA_ACTUALIZACION")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaCreacion)
                    .HasColumnName("FECHA_CREACION")
                    .HasColumnType("datetime");

                entity.Property(e => e.IdArticulo).HasColumnName("ID_ARTICULO");

                entity.Property(e => e.IdFacturaVenta).HasColumnName("ID_FACTURA_VENTA");

                entity.Property(e => e.IdProducto).HasColumnName("ID_PRODUCTO");

                entity.Property(e => e.IdSalidaInventario).HasColumnName("ID_SALIDA_INVENTARIO");

                entity.Property(e => e.PorcentajeIva).HasColumnName("PORCENTAJE_IVA");

                entity.Property(e => e.PrecioVentaSinIva)
                    .HasColumnName("PRECIO_VENTA_SIN_IVA")
                    .HasColumnType("decimal(13, 6)");

                entity.HasOne(d => d.IdFacturaVentaNavigation)
                    .WithMany(p => p.DetallesSalidaInventario)
                    .HasForeignKey(d => d.IdFacturaVenta)
                    .HasConstraintName("FK_dbo.DETALLES_SALIDA_INVENTARIO_dbo.FACTURAS_VENTAS_ID_FACTURA_VENTA");

                entity.HasOne(d => d.IdSalidaInventarioNavigation)
                    .WithMany(p => p.DetallesSalidaInventario)
                    .HasForeignKey(d => d.IdSalidaInventario)
                    .HasConstraintName("FK_dbo.DETALLES_SALIDA_INVENTARIO_dbo.SALIDAS_INVENTARIO_ID_SALIDA_INVENTARIO");

                entity.HasOne(d => d.Id)
                    .WithMany(p => p.DetallesSalidaInventario)
                    .HasForeignKey(d => new { d.IdArticulo, d.IdProducto })
                    .HasConstraintName("FK_dbo.DETALLES_SALIDA_INVENTARIO_dbo.ARTICULOS_ID_ARTICULO_ID_PRODUCTO");
            });

            modelBuilder.Entity<EntradasInventario>(entity =>
            {
                entity.HasKey(e => e.IdEntradaInventario);

                entity.ToTable("ENTRADAS_INVENTARIO");

                entity.Property(e => e.IdEntradaInventario).HasColumnName("ID_ENTRADA_INVENTARIO");

                entity.Property(e => e.Concepto)
                    .IsRequired()
                    .HasColumnName("CONCEPTO")
                    .HasMaxLength(900);

                entity.Property(e => e.EstadoRegistro).HasColumnName("ESTADO_REGISTRO");

                entity.Property(e => e.Fecha)
                    .HasColumnName("FECHA")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaActualizacion)
                    .HasColumnName("FECHA_ACTUALIZACION")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaCreacion)
                    .HasColumnName("FECHA_CREACION")
                    .HasColumnType("datetime");
            });

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

            modelBuilder.Entity<Estantes>(entity =>
            {
                entity.HasKey(e => e.IdEstante);

                entity.ToTable("ESTANTES");

                entity.HasIndex(e => e.IdBodega)
                    .HasName("IX_ID_BODEGA");

                entity.Property(e => e.IdEstante).HasColumnName("ID_ESTANTE");

                entity.Property(e => e.Agrupamiento)
                    .HasColumnName("AGRUPAMIENTO")
                    .HasMaxLength(20);

                entity.Property(e => e.CodigoEstante)
                    .IsRequired()
                    .HasColumnName("CODIGO_ESTANTE")
                    .HasMaxLength(20);

                entity.Property(e => e.Concepto)
                    .HasColumnName("CONCEPTO")
                    .HasMaxLength(300);

                entity.Property(e => e.EstaDisponible).HasColumnName("ESTA_DISPONIBLE");

                entity.Property(e => e.EstaLleno).HasColumnName("ESTA_LLENO");

                entity.Property(e => e.EstadoRegistro).HasColumnName("ESTADO_REGISTRO");

                entity.Property(e => e.FechaActualizacion)
                    .HasColumnName("FECHA_ACTUALIZACION")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaCreacion)
                    .HasColumnName("FECHA_CREACION")
                    .HasColumnType("datetime");

                entity.Property(e => e.IdBodega).HasColumnName("ID_BODEGA");

                entity.Property(e => e.TipoEstante)
                    .IsRequired()
                    .HasColumnName("TIPO_ESTANTE")
                    .HasMaxLength(20);

                entity.HasOne(d => d.IdBodegaNavigation)
                    .WithMany(p => p.Estantes)
                    .HasForeignKey(d => d.IdBodega)
                    .HasConstraintName("FK_dbo.ESTANTES_dbo.BODEGAS_ID_BODEGA");
            });

            modelBuilder.Entity<FacturasCompras>(entity =>
            {
                entity.HasKey(e => e.IdFacturaCompra);

                entity.ToTable("FACTURAS_COMPRAS");

                entity.HasIndex(e => e.IdIndividuo)
                    .HasName("IX_ID_INDIVIDUO");

                entity.Property(e => e.IdFacturaCompra).HasColumnName("ID_FACTURA_COMPRA");

                entity.Property(e => e.Comentario)
                    .HasColumnName("COMENTARIO")
                    .HasMaxLength(900);

                entity.Property(e => e.EsLegal).HasColumnName("ES_LEGAL");

                entity.Property(e => e.EstadoPago)
                    .IsRequired()
                    .HasColumnName("ESTADO_PAGO")
                    .HasMaxLength(20);

                entity.Property(e => e.EstadoRegistro).HasColumnName("ESTADO_REGISTRO");

                entity.Property(e => e.FechaActualizacion)
                    .HasColumnName("FECHA_ACTUALIZACION")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaCompra)
                    .HasColumnName("FECHA_COMPRA")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaCreacion)
                    .HasColumnName("FECHA_CREACION")
                    .HasColumnType("datetime");

                entity.Property(e => e.IdIndividuo).HasColumnName("ID_INDIVIDUO");

                entity.Property(e => e.TotalIvaFactura)
                    .HasColumnName("TOTAL_IVA_FACTURA")
                    .HasColumnType("decimal(15, 6)");

                entity.Property(e => e.ValorDescuento)
                    .HasColumnName("VALOR_DESCUENTO")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ValorIva)
                    .HasColumnName("VALOR_IVA")
                    .HasColumnType("decimal(13, 6)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ValorIvaArreglo)
                    .HasColumnName("VALOR_IVA_ARREGLO")
                    .HasColumnType("decimal(9, 4)");

                entity.Property(e => e.ValorRetencionFuente)
                    .HasColumnName("VALOR_RETENCION_FUENTE")
                    .HasColumnType("decimal(13, 6)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ValorRetencionFuenteArreglo)
                    .HasColumnName("VALOR_RETENCION_FUENTE_ARREGLO")
                    .HasColumnType("decimal(9, 4)");

                entity.Property(e => e.ValorTotalArreglo)
                    .HasColumnName("VALOR_TOTAL_ARREGLO")
                    .HasColumnType("decimal(9, 4)");

                entity.HasOne(d => d.IdIndividuoNavigation)
                    .WithMany(p => p.FacturasCompras)
                    .HasForeignKey(d => d.IdIndividuo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.FACTURAS_COMPRAS_dbo.PROVEEDORES_ID_INDIVIDUO");
            });

            modelBuilder.Entity<FacturasVentas>(entity =>
            {
                entity.HasKey(e => e.IdFacturaVenta);

                entity.ToTable("FACTURAS_VENTAS");

                entity.HasIndex(e => e.IdCliente)
                    .HasName("IX_ID_CLIENTE");

                entity.HasIndex(e => e.IdPedido)
                    .HasName("IX_ID_PEDIDO");

                entity.Property(e => e.IdFacturaVenta).HasColumnName("ID_FACTURA_VENTA");

                entity.Property(e => e.Comentario)
                    .HasColumnName("COMENTARIO")
                    .HasMaxLength(900);

                entity.Property(e => e.DiasAPagar).HasColumnName("DIAS_A_PAGAR");

                entity.Property(e => e.EsLegal).HasColumnName("ES_LEGAL");

                entity.Property(e => e.EstadoPago)
                    .IsRequired()
                    .HasColumnName("ESTADO_PAGO")
                    .HasMaxLength(20);

                entity.Property(e => e.EstadoRegistro).HasColumnName("ESTADO_REGISTRO");

                entity.Property(e => e.FechaActualizacion)
                    .HasColumnName("FECHA_ACTUALIZACION")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaCreacion)
                    .HasColumnName("FECHA_CREACION")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaVenta)
                    .HasColumnName("FECHA_VENTA")
                    .HasColumnType("datetime");

                entity.Property(e => e.IdCliente).HasColumnName("ID_CLIENTE");

                entity.Property(e => e.IdFacturaGenerada).HasColumnName("ID_FACTURA_GENERADA");

                entity.Property(e => e.IdPedido).HasColumnName("ID_PEDIDO");

                entity.Property(e => e.IdResolucion).HasColumnName("ID_RESOLUCION");

                entity.Property(e => e.NombreArchivo).HasColumnName("NOMBRE_ARCHIVO");

                entity.Property(e => e.TotalIvaFactura).HasColumnName("TOTAL_IVA_FACTURA");

                entity.Property(e => e.ValorDescuento)
                    .HasColumnName("VALOR_DESCUENTO")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ValorEnvio).HasColumnName("VALOR_ENVIO");

                entity.Property(e => e.ValorMarcado)
                    .HasColumnName("VALOR_MARCADO")
                    .HasDefaultValueSql("((0))");

                entity.HasOne(d => d.IdClienteNavigation)
                    .WithMany(p => p.FacturasVentas)
                    .HasForeignKey(d => d.IdCliente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.FACTURAS_VENTAS_dbo.PERSONAS_ID_PEDIDO");

                entity.HasOne(d => d.IdPedidoNavigation)
                    .WithMany(p => p.FacturasVentas)
                    .HasForeignKey(d => d.IdPedido)
                    .HasConstraintName("FK_dbo.FACTURAS_VENTAS_dbo.PEDIDOS_IdPedido");
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

            modelBuilder.Entity<Inventario>(entity =>
            {
                entity.HasKey(e => new { e.IdArticulo, e.IdProducto });

                entity.ToTable("INVENTARIO");

                entity.Property(e => e.IdArticulo).HasColumnName("ID_ARTICULO");

                entity.Property(e => e.IdProducto).HasColumnName("ID_PRODUCTO");

                entity.Property(e => e.CantidadAjustada).HasColumnName("CANTIDAD_AJUSTADA");

                entity.Property(e => e.CantidadComprada).HasColumnName("CANTIDAD_COMPRADA");

                entity.Property(e => e.CantidadDisponible).HasColumnName("CANTIDAD_DISPONIBLE");

                entity.Property(e => e.CantidadPerdida).HasColumnName("CANTIDAD_PERDIDA");

                entity.Property(e => e.CantidadRegalada).HasColumnName("CANTIDAD_REGALADA");

                entity.Property(e => e.CantidadVendida).HasColumnName("CANTIDAD_VENDIDA");

                entity.Property(e => e.EstadoRegistro).HasColumnName("ESTADO_REGISTRO");

                entity.Property(e => e.FechaActualizacion)
                    .HasColumnName("FECHA_ACTUALIZACION")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaCreacion)
                    .HasColumnName("FECHA_CREACION")
                    .HasColumnType("datetime");

                entity.Property(e => e.PrecioPromedioCompraSinIva)
                    .HasColumnName("PRECIO_PROMEDIO_COMPRA_SIN_IVA")
                    .HasColumnType("decimal(14, 6)");

                entity.Property(e => e.PrecioPromedioVentaSinIva)
                    .HasColumnName("PRECIO_PROMEDIO_VENTA_SIN_IVA")
                    .HasColumnType("decimal(14, 6)");
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

            modelBuilder.Entity<MarcasProveedor>(entity =>
            {
                entity.HasKey(e => new { e.MarcasIdMarca, e.ProveedoresIdIndividuo });

                entity.ToTable("MARCAS_PROVEEDOR");

                entity.HasIndex(e => e.MarcasIdMarca)
                    .HasName("IX_MARCAS_ID_MARCA");

                entity.HasIndex(e => e.ProveedoresIdIndividuo)
                    .HasName("IX_PROVEEDORES_ID_INDIVIDUO");

                entity.Property(e => e.MarcasIdMarca).HasColumnName("MARCAS_ID_MARCA");

                entity.Property(e => e.ProveedoresIdIndividuo).HasColumnName("PROVEEDORES_ID_INDIVIDUO");

                entity.HasOne(d => d.MarcasIdMarcaNavigation)
                    .WithMany(p => p.MarcasProveedor)
                    .HasForeignKey(d => d.MarcasIdMarca)
                    .HasConstraintName("FK_dbo.MARCAS_PROVEEDOR_dbo.MARCAS_MARCAS_ID_MARCA");

                entity.HasOne(d => d.ProveedoresIdIndividuoNavigation)
                    .WithMany(p => p.MarcasProveedor)
                    .HasForeignKey(d => d.ProveedoresIdIndividuo)
                    .HasConstraintName("FK_dbo.MARCAS_PROVEEDOR_dbo.PROVEEDORES_PROVEEDORES_ID_INDIVIDUO");
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

            modelBuilder.Entity<MovimientosInventario>(entity =>
            {
                entity.HasKey(e => e.IdMovimiento);

                entity.ToTable("MOVIMIENTOS_INVENTARIO");

                entity.Property(e => e.IdMovimiento).HasColumnName("ID_MOVIMIENTO");

                entity.Property(e => e.Cantidad).HasColumnName("CANTIDAD");

                entity.Property(e => e.EstadoRegistro).HasColumnName("ESTADO_REGISTRO");

                entity.Property(e => e.FechaActualizacion)
                    .HasColumnName("FECHA_ACTUALIZACION")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaCreacion)
                    .HasColumnName("FECHA_CREACION")
                    .HasColumnType("datetime");

                entity.Property(e => e.IdArticulo).HasColumnName("ID_ARTICULO");

                entity.Property(e => e.IdDetalleHijo).HasColumnName("ID_DETALLE_HIJO");

                entity.Property(e => e.IdDetallePadre).HasColumnName("ID_DETALLE_PADRE");

                entity.Property(e => e.IdProducto).HasColumnName("ID_PRODUCTO");

                entity.Property(e => e.PorcentajeIva).HasColumnName("PORCENTAJE_IVA");

                entity.Property(e => e.TipoMovimiento).HasColumnName("TIPO_MOVIMIENTO");

                entity.Property(e => e.ValorMovimientoSinIva).HasColumnName("VALOR_MOVIMIENTO_SIN_IVA");
            });

            modelBuilder.Entity<OrdenCompra>(entity =>
            {
                entity.HasKey(e => e.IdOrden);

                entity.ToTable("ORDEN_COMPRA");

                entity.HasIndex(e => e.ProveedorIdIndividuo)
                    .HasName("IX_Proveedor_IdIndividuo");

                entity.Property(e => e.IdOrden).HasColumnName("ID_ORDEN");

                entity.Property(e => e.EstadoRegistro).HasColumnName("ESTADO_REGISTRO");

                entity.Property(e => e.FechaActualizacion)
                    .HasColumnName("FECHA_ACTUALIZACION")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaCreacion)
                    .HasColumnName("FECHA_CREACION")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaLimite)
                    .HasColumnName("FECHA_LIMITE")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaPedido)
                    .HasColumnName("FECHA_PEDIDO")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("('1900-01-01T00:00:00.000')");

                entity.Property(e => e.ObservacionesGenerales)
                    .HasColumnName("OBSERVACIONES_GENERALES")
                    .HasMaxLength(900);

                entity.Property(e => e.ProveedorIdIndividuo).HasColumnName("Proveedor_IdIndividuo");

                entity.HasOne(d => d.ProveedorIdIndividuoNavigation)
                    .WithMany(p => p.OrdenCompra)
                    .HasForeignKey(d => d.ProveedorIdIndividuo)
                    .HasConstraintName("FK_dbo.ORDEN_COMPRA_dbo.PROVEEDORES_ID_INDIVIDUO");
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

            modelBuilder.Entity<PayuResponseLog>(entity =>
            {
                entity.HasKey(e => e.IdPayuResponse);

                entity.ToTable("PAYU_RESPONSE_LOG");

                entity.Property(e => e.IdPayuResponse).HasColumnName("ID_PAYU_RESPONSE");

                entity.Property(e => e.Checked).HasColumnName("CHECKED");

                entity.Property(e => e.CodigoReferencia)
                    .IsRequired()
                    .HasColumnName("CODIGO_REFERENCIA")
                    .HasMaxLength(50);

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasColumnName("EMAIL")
                    .HasMaxLength(100);

                entity.Property(e => e.EstadoRegistro).HasColumnName("ESTADO_REGISTRO");

                entity.Property(e => e.FechaActualizacion)
                    .HasColumnName("FECHA_ACTUALIZACION")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaCreacion)
                    .HasColumnName("FECHA_CREACION")
                    .HasColumnType("datetime");

                entity.Property(e => e.IdUsuario).HasColumnName("ID_USUARIO");

                entity.Property(e => e.Identificador)
                    .IsRequired()
                    .HasColumnName("IDENTIFICADOR")
                    .HasMaxLength(30);

                entity.Property(e => e.Iva)
                    .HasColumnName("IVA")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.LapPaymentMethod)
                    .HasColumnName("LAP_PAYMENT_METHOD")
                    .HasMaxLength(255);

                entity.Property(e => e.LapPaymentMethodType)
                    .HasColumnName("LAP_PAYMENT_METHOD_TYPE")
                    .HasMaxLength(255);

                entity.Property(e => e.LapResponseCode)
                    .HasColumnName("LAP_RESPONSE_CODE")
                    .HasMaxLength(64);

                entity.Property(e => e.LapTransactionState)
                    .HasColumnName("LAP_TRANSACTION_STATE")
                    .HasMaxLength(32);

                entity.Property(e => e.Mensaje)
                    .IsRequired()
                    .HasColumnName("MENSAJE")
                    .HasMaxLength(400);

                entity.Property(e => e.NombreUsuario)
                    .IsRequired()
                    .HasColumnName("NOMBRE_USUARIO")
                    .HasMaxLength(100);

                entity.Property(e => e.OrigenError)
                    .HasColumnName("ORIGEN_ERROR")
                    .HasMaxLength(100);

                entity.Property(e => e.PolReference)
                    .HasColumnName("POL_REFERENCE")
                    .HasMaxLength(255);

                entity.Property(e => e.PolResponseCode)
                    .HasColumnName("POL_RESPONSE_CODE")
                    .HasMaxLength(64);

                entity.Property(e => e.PolTransactionState)
                    .HasColumnName("POL_TRANSACTION_STATE")
                    .HasMaxLength(32);

                entity.Property(e => e.TransactionState).HasColumnName("TRANSACTION_STATE");

                entity.Property(e => e.ValorPagado)
                    .HasColumnName("VALOR_PAGADO")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<PedidoInfoPayu>(entity =>
            {
                entity.HasKey(e => e.IdPedidoInfo);

                entity.ToTable("PEDIDO_INFO_PAYU");

                entity.HasIndex(e => e.IdPedido)
                    .HasName("IX_ID_PEDIDO");

                entity.Property(e => e.IdPedidoInfo).HasColumnName("ID_PEDIDO_INFO");

                entity.Property(e => e.CodigoAutorizacionVenta)
                    .HasColumnName("CODIGO_AUTORIZACION_VENTA")
                    .HasMaxLength(12);

                entity.Property(e => e.CodigoReferencia)
                    .IsRequired()
                    .HasColumnName("CODIGO_REFERENCIA")
                    .HasMaxLength(50);

                entity.Property(e => e.CodigoSeguimiento)
                    .HasColumnName("CODIGO_SEGUIMIENTO")
                    .HasMaxLength(64);

                entity.Property(e => e.Cuotas).HasColumnName("CUOTAS");

                entity.Property(e => e.Descripción)
                    .HasColumnName("DESCRIPCIÓN")
                    .HasMaxLength(255);

                entity.Property(e => e.EstadoRegistro).HasColumnName("ESTADO_REGISTRO");

                entity.Property(e => e.FechaPago)
                    .HasColumnName("FECHA_PAGO")
                    .HasColumnType("datetime");

                entity.Property(e => e.IdPedido).HasColumnName("ID_PEDIDO");

                entity.Property(e => e.ImpuestoTx).HasColumnName("IMPUESTO_TX");

                entity.Property(e => e.Iva)
                    .HasColumnName("IVA")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.LapResponseCode)
                    .HasColumnName("LAP_RESPONSE_CODE")
                    .HasMaxLength(64);

                entity.Property(e => e.MensajeTransaccion)
                    .HasColumnName("MENSAJE_TRANSACCION")
                    .HasMaxLength(255);

                entity.Property(e => e.Moneda)
                    .HasColumnName("MONEDA")
                    .HasMaxLength(3);

                entity.Property(e => e.PolResponseCode)
                    .HasColumnName("POL_RESPONSE_CODE")
                    .HasMaxLength(64);

                entity.Property(e => e.PolTransactionState)
                    .HasColumnName("POL_TRANSACTION_STATE")
                    .HasMaxLength(32);

                entity.Property(e => e.PseCodigoSeguimiento)
                    .HasColumnName("PSE_CODIGO_SEGUIMIENTO")
                    .HasMaxLength(255);

                entity.Property(e => e.PseId).HasColumnName("PSE_ID");

                entity.Property(e => e.PseReference1)
                    .HasColumnName("PSE_REFERENCE1")
                    .HasMaxLength(255);

                entity.Property(e => e.PseReference2)
                    .HasColumnName("PSE_REFERENCE2")
                    .HasMaxLength(255);

                entity.Property(e => e.PseReference3)
                    .HasColumnName("PSE_REFERENCE3")
                    .HasMaxLength(255);

                entity.Property(e => e.ReferencePol)
                    .HasColumnName("REFERENCE_POL")
                    .HasMaxLength(255);

                entity.Property(e => e.Riesgo).HasColumnName("RIESGO");

                entity.Property(e => e.TarifaAdministrativaTx).HasColumnName("TARIFA_ADMINISTRATIVA_TX");

                entity.Property(e => e.TelefonoUsuarioPago)
                    .HasColumnName("TELEFONO_USUARIO_PAGO")
                    .HasMaxLength(20);

                entity.Property(e => e.TransaccionId)
                    .HasColumnName("TRANSACCION_ID")
                    .HasMaxLength(36);

                entity.Property(e => e.ValorBaseTx).HasColumnName("VALOR_BASE_TX");

                entity.Property(e => e.ValorPagado)
                    .HasColumnName("VALOR_PAGADO")
                    .HasDefaultValueSql("((0))");

                entity.HasOne(d => d.IdPedidoNavigation)
                    .WithMany(p => p.PedidoInfoPayu)
                    .HasForeignKey(d => d.IdPedido)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.PEDIDO_INFO_PAYU_dbo.PEDIDOS_ID_PEDIDO");
            });

            modelBuilder.Entity<Pedidos>(entity =>
            {
                entity.HasKey(e => e.IdPedido);

                entity.ToTable("PEDIDOS");

                entity.HasIndex(e => e.IdDescuento)
                    .HasName("IX_ID_DESCUENTO");

                entity.HasIndex(e => e.IdIndividuo)
                    .HasName("IX_ID_INDIVIDUO");

                entity.HasIndex(e => e.IdOrdenCompra)
                    .HasName("IX_ID_ORDEN_COMPRA");

                entity.HasIndex(e => e.IdUbicacion)
                    .HasName("IX_ID_UBICACION");

                entity.Property(e => e.IdPedido).HasColumnName("ID_PEDIDO");

                entity.Property(e => e.Comentario)
                    .HasColumnName("COMENTARIO")
                    .HasMaxLength(255);

                entity.Property(e => e.CostoEnvio).HasColumnName("COSTO_ENVIO");

                entity.Property(e => e.CostoMarcado).HasColumnName("COSTO_MARCADO");

                entity.Property(e => e.Curso)
                    .HasColumnName("CURSO")
                    .HasMaxLength(50);

                entity.Property(e => e.EstadoDePago)
                    .HasColumnName("ESTADO_DE_PAGO")
                    .HasMaxLength(32);

                entity.Property(e => e.EstadoDePedido)
                    .HasColumnName("ESTADO_DE_PEDIDO")
                    .HasMaxLength(32);

                entity.Property(e => e.EstadoRegistro).HasColumnName("ESTADO_REGISTRO");

                entity.Property(e => e.FechaActualizacion)
                    .HasColumnName("FECHA_ACTUALIZACION")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaClienteCe)
                    .HasColumnName("FECHA_CLIENTE_CE")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaCreacion)
                    .HasColumnName("FECHA_CREACION")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaPedido)
                    .HasColumnName("FECHA_PEDIDO")
                    .HasColumnType("datetime");

                entity.Property(e => e.IdDescuento).HasColumnName("ID_DESCUENTO");

                entity.Property(e => e.IdIndividuo).HasColumnName("ID_INDIVIDUO");

                entity.Property(e => e.IdOrdenCompra).HasColumnName("ID_ORDEN_COMPRA");

                entity.Property(e => e.IdUbicacion)
                    .HasColumnName("ID_UBICACION")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.MedioPago)
                    .HasColumnName("MEDIO_PAGO")
                    .HasMaxLength(32);

                entity.Property(e => e.NombreEstudiante)
                    .HasColumnName("NOMBRE_ESTUDIANTE")
                    .HasMaxLength(120);

                entity.Property(e => e.NombreMarcado)
                    .HasColumnName("NOMBRE_MARCADO")
                    .HasMaxLength(100);

                entity.Property(e => e.NumFactura)
                    .HasColumnName("NUM_FACTURA")
                    .HasMaxLength(50);

                entity.Property(e => e.TipoPago)
                    .HasColumnName("TIPO_PAGO")
                    .HasMaxLength(32);

                entity.Property(e => e.Total).HasColumnName("TOTAL");

                entity.HasOne(d => d.IdDescuentoNavigation)
                    .WithMany(p => p.Pedidos)
                    .HasForeignKey(d => d.IdDescuento)
                    .HasConstraintName("FK_dbo.PEDIDOS_dbo.DESCUENTOS_ID_DESCUENTO");

                entity.HasOne(d => d.IdIndividuoNavigation)
                    .WithMany(p => p.Pedidos)
                    .HasForeignKey(d => d.IdIndividuo)
                    .HasConstraintName("FK_dbo.PEDIDOS_dbo.INDIVIDUOS_ID_INDIVIDUO");

                entity.HasOne(d => d.IdOrdenCompraNavigation)
                    .WithMany(p => p.Pedidos)
                    .HasForeignKey(d => d.IdOrdenCompra)
                    .HasConstraintName("FK_dbo.PEDIDOS_dbo.ORDEN_COMPRA_ID_ORDEN_COMPRA");

                entity.HasOne(d => d.IdUbicacionNavigation)
                    .WithMany(p => p.Pedidos)
                    .HasForeignKey(d => d.IdUbicacion)
                    .HasConstraintName("FK_dbo.PEDIDOS_dbo.UBICACIONES_ID_UBICACION");
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

            modelBuilder.Entity<PrePedidos>(entity =>
            {
                entity.HasKey(e => e.IdPrePedido);

                entity.ToTable("PRE_PEDIDOS");

                entity.Property(e => e.IdPrePedido).HasColumnName("ID_PRE_PEDIDO");

                entity.Property(e => e.Checked).HasColumnName("CHECKED");

                entity.Property(e => e.Ciudad)
                    .HasColumnName("CIUDAD")
                    .HasMaxLength(50);

                entity.Property(e => e.CodigoDescuento).HasColumnName("CODIGO_DESCUENTO");

                entity.Property(e => e.CodigoPais)
                    .HasColumnName("CODIGO_PAIS")
                    .HasMaxLength(2);

                entity.Property(e => e.CostoEnvio).HasColumnName("COSTO_ENVIO");

                entity.Property(e => e.CostoMarcado).HasColumnName("COSTO_MARCADO");

                entity.Property(e => e.Direccion)
                    .HasColumnName("DIRECCION")
                    .HasMaxLength(120);

                entity.Property(e => e.Email)
                    .HasColumnName("EMAIL")
                    .HasMaxLength(254);

                entity.Property(e => e.EstadoRegistro).HasColumnName("ESTADO_REGISTRO");

                entity.Property(e => e.FechaActualizacion)
                    .HasColumnName("FECHA_ACTUALIZACION")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaCreacion)
                    .HasColumnName("FECHA_CREACION")
                    .HasColumnType("datetime");

                entity.Property(e => e.IdPersona).HasColumnName("ID_PERSONA");

                entity.Property(e => e.IdUbicacion).HasColumnName("ID_UBICACION");

                entity.Property(e => e.Nombre)
                    .HasColumnName("NOMBRE")
                    .HasMaxLength(120);

                entity.Property(e => e.NombreMarcado)
                    .HasColumnName("NOMBRE_MARCADO")
                    .HasMaxLength(100);

                entity.Property(e => e.NumFactura)
                    .HasColumnName("NUM_FACTURA")
                    .HasMaxLength(50);

                entity.Property(e => e.NumIdentificacion)
                    .HasColumnName("NUM_IDENTIFICACION")
                    .HasMaxLength(15);

                entity.Property(e => e.Telefono)
                    .HasColumnName("TELEFONO")
                    .HasMaxLength(32);

                entity.Property(e => e.TipoDescuento).HasColumnName("TIPO_DESCUENTO");

                entity.Property(e => e.Total).HasColumnName("TOTAL");

                entity.Property(e => e.ValorDescuento).HasColumnName("VALOR_DESCUENTO");
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

            modelBuilder.Entity<ResolucionFactura>(entity =>
            {
                entity.HasKey(e => e.IdResolucion);

                entity.ToTable("RESOLUCION_FACTURA");

                entity.Property(e => e.IdResolucion).HasColumnName("ID_RESOLUCION");

                entity.Property(e => e.Codigo)
                    .IsRequired()
                    .HasColumnName("CODIGO")
                    .HasMaxLength(80);

                entity.Property(e => e.EstadoRegistro).HasColumnName("ESTADO_REGISTRO");

                entity.Property(e => e.FechaActualizacion)
                    .HasColumnName("FECHA_ACTUALIZACION")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaLimite)
                    .HasColumnName("FECHA_LIMITE")
                    .HasColumnType("datetime");

                entity.Property(e => e.LimiteFacturas).HasColumnName("LIMITE_FACTURAS");

                entity.Property(e => e.Notificacion).HasColumnName("NOTIFICACION");
            });

            modelBuilder.Entity<SalidasInventario>(entity =>
            {
                entity.HasKey(e => e.IdSalidaInventario);

                entity.ToTable("SALIDAS_INVENTARIO");

                entity.Property(e => e.IdSalidaInventario).HasColumnName("ID_SALIDA_INVENTARIO");

                entity.Property(e => e.Concepto)
                    .IsRequired()
                    .HasColumnName("CONCEPTO")
                    .HasMaxLength(900);

                entity.Property(e => e.EstadoRegistro).HasColumnName("ESTADO_REGISTRO");

                entity.Property(e => e.Fecha)
                    .HasColumnName("FECHA")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaActualizacion)
                    .HasColumnName("FECHA_ACTUALIZACION")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaCreacion)
                    .HasColumnName("FECHA_CREACION")
                    .HasColumnType("datetime");
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

            modelBuilder.Entity<TrazabilidadCompras>(entity =>
            {
                entity.HasKey(e => new { e.IdDetalleEntradaInventario, e.IdDetalleOrdenCompra });

                entity.ToTable("TRAZABILIDAD_COMPRAS");

                entity.HasIndex(e => e.IdDetalleEntradaInventario)
                    .HasName("IX_ID_DETALLE_ENTRADA_INVENTARIO");

                entity.HasIndex(e => e.IdDetalleOrdenCompra)
                    .HasName("IX_ID_DETALLE_ORDEN_COMPRA");

                entity.Property(e => e.IdDetalleEntradaInventario).HasColumnName("ID_DETALLE_ENTRADA_INVENTARIO");

                entity.Property(e => e.IdDetalleOrdenCompra).HasColumnName("ID_DETALLE_ORDEN_COMPRA");

                entity.Property(e => e.EstadoRegistro).HasColumnName("ESTADO_REGISTRO");

                entity.Property(e => e.FechaActualizacion)
                    .HasColumnName("FECHA_ACTUALIZACION")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaCreacion)
                    .HasColumnName("FECHA_CREACION")
                    .HasColumnType("datetime");

                entity.HasOne(d => d.IdDetalleEntradaInventarioNavigation)
                    .WithMany(p => p.TrazabilidadCompras)
                    .HasForeignKey(d => d.IdDetalleEntradaInventario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.TRAZABILIDAD_COMPRAS_dbo.DETALLES_ENTRADA_INVENTARIO_ID_DETALLE_ENTRADA_INVENTARIO");

                entity.HasOne(d => d.IdDetalleOrdenCompraNavigation)
                    .WithMany(p => p.TrazabilidadCompras)
                    .HasForeignKey(d => d.IdDetalleOrdenCompra)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.TRAZABILIDAD_COMPRAS_dbo.ARTICULOS_POR_ORDEN_ID_DETALLE_ORDEN_COMPRA");
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

