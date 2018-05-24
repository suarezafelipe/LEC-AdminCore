using AdminCore.BusinessLogic.Products.Models;
using AdminCore.Persistence.Mapping.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace AdminCore.Persistence.Mapping.SQLServerMap
{
    public class InventarioMapping : IInventarioMapping
    {
        public virtual DbSet<AjustesInventario> AjustesInventario { get; set; }
        public virtual DbSet<ArticulosEntradosEstantes> ArticulosEntradosEstantes { get; set; }
        public virtual DbSet<ArticulosPedidosFacturasVenta> ArticulosPedidosFacturasVentas { get; set; }
        public virtual DbSet<ArticulosPorFacturaCompra> ArticulosPorFacturasCompras { get; set; }
        public virtual DbSet<ArticulosPorFacturaVenta> ArticulosPorFacturasVentas { get; set; }
        public virtual DbSet<Bodegas> Bodegas { get; set; }
        public virtual DbSet<DetallesAjusteInventario> DetallesAjustesInventario { get; set; }
        public virtual DbSet<DetallesEntradaInventario> DetallesEntradasInventario { get; set; }
        public virtual DbSet<DetallesSalidaInventario> DetallesSalidasInventario { get; set; }
        public virtual DbSet<EntradasInventario> EntradasInventarios { get; set; }
        public virtual DbSet<Estantes> Estantes { get; set; }
        public virtual DbSet<FacturasCompras> FacturasCompra { get; set; }
        public virtual DbSet<FacturasVentas> FacturasVenta { get; set; }
        public virtual DbSet<Inventario> Inventario { get; set; }
        public virtual DbSet<MarcasProveedor> MarcasProveedores { get; set; }
        public virtual DbSet<MovimientosInventario> MovimientosInventario { get; set; }
        public virtual DbSet<OrdenCompra> OrdenesCompras { get; set; }
        public virtual DbSet<ResolucionFactura> ResolucionesFacturas { get; set; }
        public virtual DbSet<SalidasInventario> SalidasInventarios { get; set; }
        public virtual DbSet<TrazabilidadCompras> TrazabilidadCompras { get; set; }
        
        public ModelBuilder LecDbBuilder(ModelBuilder modelBuilder)
        {
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
            
            return modelBuilder;
        }
    }
}
