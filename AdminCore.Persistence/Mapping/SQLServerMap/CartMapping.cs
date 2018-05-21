using AdminCore.BusinessLogic.Products.Models;
using AdminCore.Persistence.Mapping.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace AdminCore.Persistence.Mapping.SQLServerMap
{
    public class CartMapping : ICartMapping
    {
        /* Modelos: Ordenados Alfabéticamente */
        public virtual DbSet<ArticulosCarritoCompra> ArticulosCarritoCompras { get; set; }
        public virtual DbSet<ArticulosCarritoCompraPrepedido> ArticulosCarritoCompraPrepedidos { get; set; }
        public virtual DbSet<ArticulosDetallesListaPedido> ArticulosDetallesListasPedidos { get; set; }
        public virtual DbSet<ArticulosPorInstitucion> ArticulosPorInstituciones { get; set; }
        public virtual DbSet<ArticulosPorInstitucionPrePedido> ArticulosPorInstitucionPrePedidos { get; set; }
        public virtual DbSet<ArticulosPorOrden> ArticulosPorOrdenes { get; set; }
        public virtual DbSet<ArticulosPorPedido> ArticulosPorPedidos { get; set; }
        public virtual DbSet<ArticulosPrePedido> ArticulosPrePedidos { get; set; }
        public virtual DbSet<CarritoCompra> CarritosCompra { get; set; }
        public virtual DbSet<CarritoCompraPrepedido> CarritosCompraPrepedidos { get; set; }
        public virtual DbSet<ClienteCarritoCompra> ClienteCarritosCompras { get; set; }
        public virtual DbSet<CostoEnvio> CostosEnvios { get; set; }
        public virtual DbSet<DetallesListaPedido> DetallesListaPedidos { get; set; }
        public virtual DbSet<PayuResponseLog> PayuResponseLogs { get; set; }
        public virtual DbSet<PedidoInfoPayu> PedidosInfoPayu { get; set; }
        public virtual DbSet<Pedidos> Pedidos { get; set; }
        public virtual DbSet<PrePedidos> PrePedidos { get; set; }

        public ModelBuilder LecDbBuilder(ModelBuilder modelBuilder)
        {
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

            return modelBuilder;
        }
    }
}
