using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace AdminCore.Migrations.Migrations
{
    public partial class CurrentModelReverseEngineering : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "__MigrationHistory",
                columns: table => new
                {
                    MigrationId = table.Column<string>(maxLength: 150, nullable: false),
                    ContextKey = table.Column<string>(maxLength: 300, nullable: false),
                    Model = table.Column<byte[]>(nullable: false),
                    ProductVersion = table.Column<string>(maxLength: 32, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK___MigrationHistory", x => new { x.MigrationId, x.ContextKey });
                });

            migrationBuilder.CreateTable(
                name: "ACTIVIDADES_ECONOMICAS",
                columns: table => new
                {
                    ID_ACTIVIDAD_ECONOMICA = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CODIGO_ACTIVIDAD = table.Column<string>(maxLength: 20, nullable: false),
                    CUENTA_ICA = table.Column<string>(maxLength: 30, nullable: true),
                    ESTADO_REGISTRO = table.Column<bool>(nullable: false),
                    FECHA_ACTUALIZACION = table.Column<DateTime>(type: "datetime", nullable: true),
                    FECHA_CREACION = table.Column<DateTime>(type: "datetime", nullable: true),
                    NOMBRE = table.Column<string>(maxLength: 80, nullable: false),
                    TARIFA = table.Column<decimal>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ACTIVIDADES_ECONOMICAS", x => x.ID_ACTIVIDAD_ECONOMICA);
                });

            migrationBuilder.CreateTable(
                name: "AJUSTES_INVENTARIO",
                columns: table => new
                {
                    ID_AJUSTE_INVENTARIO = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CONCEPTO = table.Column<string>(maxLength: 900, nullable: false),
                    ESTADO_REGISTRO = table.Column<bool>(nullable: false),
                    FECHA = table.Column<DateTime>(type: "datetime", nullable: false),
                    FECHA_ACTUALIZACION = table.Column<DateTime>(type: "datetime", nullable: true),
                    FECHA_CREACION = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AJUSTES_INVENTARIO", x => x.ID_AJUSTE_INVENTARIO);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(maxLength: 128, nullable: false),
                    Name = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(maxLength: 128, nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false),
                    ConfirmationToken = table.Column<string>(maxLength: 128, nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    Email = table.Column<string>(nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: true),
                    IsConfirmed = table.Column<bool>(nullable: true),
                    LastPasswordFailureDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: true),
                    LockoutEndDateUtc = table.Column<DateTime>(nullable: true),
                    PasswordChangedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    PasswordFailuresSinceLastSuccess = table.Column<int>(nullable: true, defaultValueSql: "((0))"),
                    PasswordHash = table.Column<string>(nullable: true),
                    PasswordVerificationToken = table.Column<string>(maxLength: 128, nullable: true),
                    PasswordVerificationTokenExpirationDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    TwoFactorEnabled = table.Column<bool>(nullable: true),
                    UserName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CAMPANAS",
                columns: table => new
                {
                    ID_CAMPANA = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DESCRIPCION = table.Column<string>(maxLength: 300, nullable: true),
                    ESTADO_REGISTRO = table.Column<bool>(nullable: false),
                    FECHA_ACTUALIZACION = table.Column<DateTime>(type: "datetime", nullable: true),
                    FECHA_CREACION = table.Column<DateTime>(type: "datetime", nullable: true),
                    FECHA_FIN_CAMPAMA = table.Column<DateTime>(type: "datetime", nullable: false),
                    FECHA_INICIO_CAMPANA = table.Column<DateTime>(type: "datetime", nullable: false),
                    TIPO = table.Column<string>(maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CAMPANAS", x => x.ID_CAMPANA);
                });

            migrationBuilder.CreateTable(
                name: "CARRITO_COMPRA",
                columns: table => new
                {
                    ID_CARRITO = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ALERTA = table.Column<string>(nullable: true),
                    AUTENTICADO = table.Column<bool>(nullable: false),
                    CODIGO_DESCUENTO = table.Column<string>(nullable: true),
                    CURSO = table.Column<string>(nullable: true),
                    DIRECCIONA_COLEGIO = table.Column<string>(nullable: true),
                    FECHA_EXPIRACION = table.Column<DateTime>(type: "datetime", nullable: false),
                    FECHA_LISTA = table.Column<int>(nullable: true),
                    ID_CIUDAD = table.Column<int>(nullable: true),
                    ID_GENERO = table.Column<int>(nullable: true),
                    ID_INDIVIDUO = table.Column<int>(nullable: true),
                    ID_LISTA = table.Column<string>(maxLength: 20, nullable: false),
                    ID_LISTA_REAL = table.Column<int>(nullable: true),
                    ID_USUARIO = table.Column<string>(maxLength: 128, nullable: false),
                    IsList = table.Column<bool>(nullable: false),
                    MINIMO_DESCUENTO = table.Column<decimal>(nullable: false),
                    NOMBRE_COLEGIO = table.Column<string>(nullable: true),
                    NOMBRE_CORTO_COLEGIO = table.Column<string>(maxLength: 45, nullable: true),
                    NOMBRE_MARCADO = table.Column<string>(maxLength: 35, nullable: true),
                    NOMBRE_OFICIAL_COLEGIO = table.Column<string>(maxLength: 80, nullable: true),
                    REDIS_SESION = table.Column<string>(maxLength: 50, nullable: true),
                    TIENE_MARCADO = table.Column<bool>(nullable: true),
                    TIPO_DESCUENTO = table.Column<string>(nullable: true),
                    URL_LOGO = table.Column<string>(nullable: true),
                    URL_LOGO_MIN = table.Column<string>(nullable: true),
                    VALOR_DESCUENTO = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CARRITO_COMPRA", x => x.ID_CARRITO);
                });

            migrationBuilder.CreateTable(
                name: "CARRITO_COMPRA_PREPEDIDO",
                columns: table => new
                {
                    ID_CARRITO = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ALERTA = table.Column<string>(nullable: true),
                    CODIGO_DESCUENTO = table.Column<string>(nullable: true),
                    COSTO_ENVIO = table.Column<decimal>(nullable: false, defaultValueSql: "((0))"),
                    COSTO_MARCADO = table.Column<decimal>(nullable: false, defaultValueSql: "((0))"),
                    CURSO = table.Column<string>(nullable: true),
                    ES_LISTA = table.Column<bool>(nullable: false),
                    FECHA_LISTA = table.Column<int>(nullable: false),
                    ID_COLEGIO = table.Column<int>(nullable: true),
                    ID_GENERO = table.Column<int>(nullable: true),
                    ID_INFORMACION_USUARIO = table.Column<int>(nullable: true),
                    ID_LISTA_REAL = table.Column<int>(nullable: true),
                    ID_SESION = table.Column<string>(nullable: true),
                    MINIMO_DESCUENTO = table.Column<decimal>(nullable: false),
                    NOMBRE_CORTO_COLEGIO = table.Column<string>(maxLength: 45, nullable: true),
                    NOMBRE_MARCADO = table.Column<string>(maxLength: 35, nullable: true),
                    TIENE_MARCADO = table.Column<bool>(nullable: true),
                    TIPO_DESCUENTO = table.Column<string>(nullable: true),
                    VALOR_DESCUENTO = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CARRITO_COMPRA_PREPEDIDO", x => x.ID_CARRITO);
                });

            migrationBuilder.CreateTable(
                name: "CATEGORIAS",
                columns: table => new
                {
                    ID_CATEGORIA = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DESCRIPCION_CORTA = table.Column<string>(maxLength: 300, nullable: true),
                    DESCRIPCION_LARGA = table.Column<string>(nullable: true),
                    ESTADO_REGISTRO = table.Column<bool>(nullable: false),
                    FECHA_ACTUALIZACION = table.Column<DateTime>(type: "datetime", nullable: true),
                    FECHA_CREACION = table.Column<DateTime>(type: "datetime", nullable: true),
                    NOMBRE = table.Column<string>(maxLength: 45, nullable: false),
                    NOMBRE_CORTO = table.Column<string>(maxLength: 30, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CATEGORIAS", x => x.ID_CATEGORIA);
                });

            migrationBuilder.CreateTable(
                name: "CATEGORIAS_CONTABILIDAD",
                columns: table => new
                {
                    ID_CATEGORIA = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CUENTA_CONTABLE = table.Column<int>(nullable: false),
                    ESTADO_REGISTRO = table.Column<bool>(nullable: false),
                    FECHA_ACTUALIZACION = table.Column<DateTime>(type: "datetime", nullable: true),
                    FECHA_CREACION = table.Column<DateTime>(type: "datetime", nullable: true),
                    NOMBRE = table.Column<string>(maxLength: 100, nullable: false),
                    TIPO_IVA = table.Column<string>(maxLength: 15, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CATEGORIAS_CONTABILIDAD", x => x.ID_CATEGORIA);
                });

            migrationBuilder.CreateTable(
                name: "CLIENTE_CARRITO_COMPRA",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CIUDAD = table.Column<string>(maxLength: 30, nullable: false, defaultValueSql: "('')"),
                    CODIGO_PEDIDO = table.Column<string>(maxLength: 20, nullable: true),
                    DIRECCION = table.Column<string>(maxLength: 120, nullable: false),
                    EMAIL = table.Column<string>(maxLength: 120, nullable: false, defaultValueSql: "('')"),
                    FechaCreacion = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "('1900-01-01T00:00:00.000')"),
                    ID_CIUDAD = table.Column<int>(nullable: false),
                    ID_INDIVIDUO = table.Column<int>(nullable: false, defaultValueSql: "((0))"),
                    ID_UBICACION = table.Column<int>(nullable: false, defaultValueSql: "((0))"),
                    NOMBRE = table.Column<string>(maxLength: 120, nullable: false),
                    NUMERO_IDENTIFICACION = table.Column<string>(maxLength: 15, nullable: false),
                    TELEFONO = table.Column<string>(maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CLIENTE_CARRITO_COMPRA", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "COTIZACIONES_LISTA_ESCOLAR",
                columns: table => new
                {
                    ID_COTIZACION = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CURSO = table.Column<string>(maxLength: 20, nullable: false),
                    EMAIL = table.Column<string>(maxLength: 64, nullable: false),
                    ESTADO = table.Column<bool>(nullable: false),
                    FECHA_RESPUESTA = table.Column<DateTime>(type: "datetime", nullable: true),
                    FECHA_SOLICITUD = table.Column<DateTime>(type: "datetime", nullable: false),
                    GENERO_ESTUDIANTE = table.Column<int>(nullable: true),
                    ID_LISTA_ESCOLAR = table.Column<int>(nullable: true),
                    NOMBRE_COLEGIO = table.Column<string>(maxLength: 120, nullable: false),
                    NOMBRE_COTIZADOR = table.Column<string>(maxLength: 100, nullable: false),
                    TELEFONO = table.Column<string>(maxLength: 15, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_COTIZACIONES_LISTA_ESCOLAR", x => x.ID_COTIZACION);
                });

            migrationBuilder.CreateTable(
                name: "ENTRADAS_INVENTARIO",
                columns: table => new
                {
                    ID_ENTRADA_INVENTARIO = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CONCEPTO = table.Column<string>(maxLength: 900, nullable: false),
                    ESTADO_REGISTRO = table.Column<bool>(nullable: false),
                    FECHA = table.Column<DateTime>(type: "datetime", nullable: false),
                    FECHA_ACTUALIZACION = table.Column<DateTime>(type: "datetime", nullable: true),
                    FECHA_CREACION = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ENTRADAS_INVENTARIO", x => x.ID_ENTRADA_INVENTARIO);
                });

            migrationBuilder.CreateTable(
                name: "INDIVIDUOS",
                columns: table => new
                {
                    ID_INDIVIDUO = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    COD_TIPO_INDIVIDUO = table.Column<string>(maxLength: 30, nullable: false),
                    EMAIL = table.Column<string>(maxLength: 254, nullable: true),
                    EMAIL2 = table.Column<string>(maxLength: 254, nullable: true),
                    ID_IDENTITY = table.Column<string>(maxLength: 128, nullable: true),
                    TEL2 = table.Column<string>(maxLength: 30, nullable: true),
                    TELEFONO = table.Column<string>(maxLength: 30, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_INDIVIDUOS", x => x.ID_INDIVIDUO);
                });

            migrationBuilder.CreateTable(
                name: "INVENTARIO",
                columns: table => new
                {
                    ID_ARTICULO = table.Column<int>(nullable: false),
                    ID_PRODUCTO = table.Column<int>(nullable: false),
                    CANTIDAD_AJUSTADA = table.Column<int>(nullable: true),
                    CANTIDAD_COMPRADA = table.Column<int>(nullable: true),
                    CANTIDAD_DISPONIBLE = table.Column<int>(nullable: false),
                    CANTIDAD_PERDIDA = table.Column<int>(nullable: true),
                    CANTIDAD_REGALADA = table.Column<int>(nullable: true),
                    CANTIDAD_VENDIDA = table.Column<int>(nullable: true),
                    ESTADO_REGISTRO = table.Column<bool>(nullable: false),
                    FECHA_ACTUALIZACION = table.Column<DateTime>(type: "datetime", nullable: true),
                    FECHA_CREACION = table.Column<DateTime>(type: "datetime", nullable: true),
                    PRECIO_PROMEDIO_COMPRA_SIN_IVA = table.Column<decimal>(type: "decimal(14, 6)", nullable: true),
                    PRECIO_PROMEDIO_VENTA_SIN_IVA = table.Column<decimal>(type: "decimal(14, 6)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_INVENTARIO", x => new { x.ID_ARTICULO, x.ID_PRODUCTO });
                });

            migrationBuilder.CreateTable(
                name: "MARCAS",
                columns: table => new
                {
                    ID_MARCA = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DESCRIPCION = table.Column<string>(maxLength: 300, nullable: true),
                    ESTADO_REGISTRO = table.Column<bool>(nullable: false),
                    FECHA_ACTUALIZACION = table.Column<DateTime>(type: "datetime", nullable: true),
                    FECHA_CREACION = table.Column<DateTime>(type: "datetime", nullable: true),
                    NOMBRE = table.Column<string>(maxLength: 45, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MARCAS", x => x.ID_MARCA);
                });

            migrationBuilder.CreateTable(
                name: "MOVIMIENTOS_INVENTARIO",
                columns: table => new
                {
                    ID_MOVIMIENTO = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CANTIDAD = table.Column<int>(nullable: false),
                    ESTADO_REGISTRO = table.Column<bool>(nullable: false),
                    FECHA_ACTUALIZACION = table.Column<DateTime>(type: "datetime", nullable: true),
                    FECHA_CREACION = table.Column<DateTime>(type: "datetime", nullable: true),
                    ID_ARTICULO = table.Column<int>(nullable: false),
                    ID_DETALLE_HIJO = table.Column<int>(nullable: false),
                    ID_DETALLE_PADRE = table.Column<int>(nullable: true),
                    ID_PRODUCTO = table.Column<int>(nullable: false),
                    PORCENTAJE_IVA = table.Column<decimal>(nullable: true),
                    TIPO_MOVIMIENTO = table.Column<int>(nullable: false),
                    VALOR_MOVIMIENTO_SIN_IVA = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MOVIMIENTOS_INVENTARIO", x => x.ID_MOVIMIENTO);
                });

            migrationBuilder.CreateTable(
                name: "PAISES",
                columns: table => new
                {
                    CODIGO_PAIS = table.Column<string>(type: "nchar(2)", nullable: false),
                    ESTADO_REGISTRO = table.Column<bool>(nullable: false),
                    FECHA_ACTUALIZACION = table.Column<DateTime>(type: "datetime", nullable: true),
                    FECHA_CREACION = table.Column<DateTime>(type: "datetime", nullable: true),
                    IDIOMA = table.Column<string>(maxLength: 16, nullable: true),
                    MONEDA = table.Column<string>(maxLength: 3, nullable: true),
                    NOMBRE_PAIS = table.Column<string>(maxLength: 40, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PAISES", x => x.CODIGO_PAIS);
                });

            migrationBuilder.CreateTable(
                name: "PALABRAS_CLAVE",
                columns: table => new
                {
                    ID_PALABRA = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    COD_ISO_IDIOMA = table.Column<string>(maxLength: 2, nullable: false),
                    ESTADO_REGISTRO = table.Column<bool>(nullable: false),
                    FECHA_ACTUALIZACION = table.Column<DateTime>(type: "datetime", nullable: true),
                    FECHA_CREACION = table.Column<DateTime>(type: "datetime", nullable: true),
                    PALABRA = table.Column<string>(maxLength: 45, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PALABRAS_CLAVE", x => x.ID_PALABRA);
                });

            migrationBuilder.CreateTable(
                name: "PARAMETRIZACIONES",
                columns: table => new
                {
                    ID_PARAMETRO = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DESCRIPCION = table.Column<string>(maxLength: 900, nullable: true),
                    ESTADO_REGISTRO = table.Column<bool>(nullable: false),
                    FECHA_ACTUALIZACION = table.Column<DateTime>(type: "datetime", nullable: true),
                    FECHA_CREACION = table.Column<DateTime>(type: "datetime", nullable: true),
                    PARAMETRO_ENTERO = table.Column<int>(nullable: true),
                    PARAMETRO_STRING = table.Column<string>(maxLength: 300, nullable: true),
                    TIPO_PARAMETRO = table.Column<string>(maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PARAMETRIZACIONES", x => x.ID_PARAMETRO);
                });

            migrationBuilder.CreateTable(
                name: "PAYU_RESPONSE_LOG",
                columns: table => new
                {
                    ID_PAYU_RESPONSE = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CHECKED = table.Column<bool>(nullable: false),
                    CODIGO_REFERENCIA = table.Column<string>(maxLength: 50, nullable: false),
                    EMAIL = table.Column<string>(maxLength: 100, nullable: false),
                    ESTADO_REGISTRO = table.Column<bool>(nullable: false),
                    FECHA_ACTUALIZACION = table.Column<DateTime>(type: "datetime", nullable: false),
                    FECHA_CREACION = table.Column<DateTime>(type: "datetime", nullable: false),
                    ID_USUARIO = table.Column<int>(nullable: false),
                    IDENTIFICADOR = table.Column<string>(maxLength: 30, nullable: false),
                    IVA = table.Column<decimal>(nullable: false, defaultValueSql: "((0))"),
                    LAP_PAYMENT_METHOD = table.Column<string>(maxLength: 255, nullable: true),
                    LAP_PAYMENT_METHOD_TYPE = table.Column<string>(maxLength: 255, nullable: true),
                    LAP_RESPONSE_CODE = table.Column<string>(maxLength: 64, nullable: true),
                    LAP_TRANSACTION_STATE = table.Column<string>(maxLength: 32, nullable: true),
                    MENSAJE = table.Column<string>(maxLength: 400, nullable: false),
                    NOMBRE_USUARIO = table.Column<string>(maxLength: 100, nullable: false),
                    ORIGEN_ERROR = table.Column<string>(maxLength: 100, nullable: true),
                    POL_REFERENCE = table.Column<string>(maxLength: 255, nullable: true),
                    POL_RESPONSE_CODE = table.Column<string>(maxLength: 64, nullable: true),
                    POL_TRANSACTION_STATE = table.Column<string>(maxLength: 32, nullable: true),
                    TRANSACTION_STATE = table.Column<int>(nullable: false),
                    VALOR_PAGADO = table.Column<decimal>(nullable: false, defaultValueSql: "((0))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PAYU_RESPONSE_LOG", x => x.ID_PAYU_RESPONSE);
                });

            migrationBuilder.CreateTable(
                name: "POSTS",
                columns: table => new
                {
                    ID_POST = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AUTOR = table.Column<string>(maxLength: 90, nullable: true),
                    EMAIL = table.Column<string>(maxLength: 80, nullable: true),
                    ESTADO_REGISTRO = table.Column<bool>(nullable: false),
                    FECHA_ACTUALIZACION = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "('1900-01-01T00:00:00.000')"),
                    FECHA_CREACION = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "('1900-01-01T00:00:00.000')"),
                    RESUMEN = table.Column<string>(maxLength: 500, nullable: true),
                    TIENE_IMAGEN = table.Column<bool>(nullable: false),
                    TIPO_POST = table.Column<string>(maxLength: 20, nullable: true),
                    TITULO = table.Column<string>(maxLength: 80, nullable: true),
                    URL_IMAGEN_PRINCIPAL = table.Column<string>(maxLength: 300, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_POSTS", x => x.ID_POST);
                });

            migrationBuilder.CreateTable(
                name: "PRE_PEDIDOS",
                columns: table => new
                {
                    ID_PRE_PEDIDO = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CHECKED = table.Column<bool>(nullable: false),
                    CIUDAD = table.Column<string>(maxLength: 50, nullable: true),
                    CODIGO_DESCUENTO = table.Column<string>(nullable: true),
                    CODIGO_PAIS = table.Column<string>(maxLength: 2, nullable: true),
                    COSTO_ENVIO = table.Column<decimal>(nullable: true),
                    COSTO_MARCADO = table.Column<decimal>(nullable: true),
                    DIRECCION = table.Column<string>(maxLength: 120, nullable: true),
                    EMAIL = table.Column<string>(maxLength: 254, nullable: true),
                    ESTADO_REGISTRO = table.Column<bool>(nullable: false),
                    FECHA_ACTUALIZACION = table.Column<DateTime>(type: "datetime", nullable: true),
                    FECHA_CREACION = table.Column<DateTime>(type: "datetime", nullable: true),
                    ID_PERSONA = table.Column<int>(nullable: true),
                    ID_UBICACION = table.Column<int>(nullable: true),
                    NOMBRE = table.Column<string>(maxLength: 120, nullable: true),
                    NOMBRE_MARCADO = table.Column<string>(maxLength: 100, nullable: true),
                    NUM_FACTURA = table.Column<string>(maxLength: 50, nullable: true),
                    NUM_IDENTIFICACION = table.Column<string>(maxLength: 15, nullable: true),
                    TELEFONO = table.Column<string>(maxLength: 32, nullable: true),
                    TIPO_DESCUENTO = table.Column<string>(nullable: true),
                    TOTAL = table.Column<decimal>(nullable: true),
                    VALOR_DESCUENTO = table.Column<decimal>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PRE_PEDIDOS", x => x.ID_PRE_PEDIDO);
                });

            migrationBuilder.CreateTable(
                name: "RESOLUCION_FACTURA",
                columns: table => new
                {
                    ID_RESOLUCION = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CODIGO = table.Column<string>(maxLength: 80, nullable: false),
                    ESTADO_REGISTRO = table.Column<bool>(nullable: false),
                    FECHA_ACTUALIZACION = table.Column<DateTime>(type: "datetime", nullable: false),
                    FECHA_LIMITE = table.Column<DateTime>(type: "datetime", nullable: false),
                    LIMITE_FACTURAS = table.Column<int>(nullable: false),
                    NOTIFICACION = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RESOLUCION_FACTURA", x => x.ID_RESOLUCION);
                });

            migrationBuilder.CreateTable(
                name: "SALIDAS_INVENTARIO",
                columns: table => new
                {
                    ID_SALIDA_INVENTARIO = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CONCEPTO = table.Column<string>(maxLength: 900, nullable: false),
                    ESTADO_REGISTRO = table.Column<bool>(nullable: false),
                    FECHA = table.Column<DateTime>(type: "datetime", nullable: false),
                    FECHA_ACTUALIZACION = table.Column<DateTime>(type: "datetime", nullable: true),
                    FECHA_CREACION = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SALIDAS_INVENTARIO", x => x.ID_SALIDA_INVENTARIO);
                });

            migrationBuilder.CreateTable(
                name: "TIPO_ATRIBUTOS",
                columns: table => new
                {
                    ID_TIPO = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DESCRIPCION = table.Column<string>(maxLength: 300, nullable: true),
                    ESTADO_REGISTRO = table.Column<bool>(nullable: false),
                    FECHA_ACTUALIZACION = table.Column<DateTime>(type: "datetime", nullable: true),
                    FECHA_CREACION = table.Column<DateTime>(type: "datetime", nullable: true),
                    NOMBRE = table.Column<string>(maxLength: 45, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TIPO_ATRIBUTOS", x => x.ID_TIPO);
                });

            migrationBuilder.CreateTable(
                name: "UNIDADES_VENTA",
                columns: table => new
                {
                    ID_UNID_VENTA = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ESTADO_REGISTRO = table.Column<bool>(nullable: false),
                    FECHA_ACTUALIZACION = table.Column<DateTime>(type: "datetime", nullable: true),
                    FECHA_CREACION = table.Column<DateTime>(type: "datetime", nullable: true),
                    NOMBRE = table.Column<string>(maxLength: 45, nullable: true),
                    SIMBOLO = table.Column<string>(maxLength: 3, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UNIDADES_VENTA", x => x.ID_UNID_VENTA);
                });

            migrationBuilder.CreateTable(
                name: "VALORES_MARCADO",
                columns: table => new
                {
                    ID_VALOR_MARCADO = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ESTADO_REGISTRO = table.Column<bool>(nullable: false),
                    FECHA_ACTUALIZACION = table.Column<DateTime>(type: "datetime", nullable: true),
                    FECHA_CREACION = table.Column<DateTime>(type: "datetime", nullable: true),
                    PRECIO = table.Column<decimal>(nullable: false),
                    VALOR = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VALORES_MARCADO", x => x.ID_VALOR_MARCADO);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(maxLength: 128, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_dbo.AspNetUserClaims_dbo.AspNetUsers_User_Id",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    UserId = table.Column<string>(maxLength: 128, nullable: false),
                    LoginProvider = table.Column<string>(maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(maxLength: 128, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.UserId, x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_dbo.AspNetUserLogins_dbo.AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(maxLength: 128, nullable: false),
                    RoleId = table.Column<string>(maxLength: 128, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_dbo.AspNetUserRoles_dbo.AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_dbo.AspNetUserRoles_dbo.AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DESCUENTOS",
                columns: table => new
                {
                    ID_DESCUENTO = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CODIGO = table.Column<string>(maxLength: 45, nullable: true),
                    ESTADO_REGISTRO = table.Column<bool>(nullable: false),
                    FECHA_ACTUALIZACION = table.Column<DateTime>(type: "datetime", nullable: true),
                    FECHA_CREACION = table.Column<DateTime>(type: "datetime", nullable: true),
                    ID_CAMPANA = table.Column<int>(nullable: false, defaultValueSql: "((0))"),
                    MINIMO_COMPRA = table.Column<decimal>(nullable: false, defaultValueSql: "((0))"),
                    USO_UNICO = table.Column<bool>(nullable: false),
                    VALIDO_DESDE = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "('1900-01-01T00:00:00.000')"),
                    VALIDO_HASTA = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "('1900-01-01T00:00:00.000')"),
                    VALOR_DESCUENTO = table.Column<decimal>(nullable: false, defaultValueSql: "((0))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DESCUENTOS", x => x.ID_DESCUENTO);
                    table.ForeignKey(
                        name: "FK_dbo.DESCUENTOS_dbo.CAMPANAS_ID_CAMPANA",
                        column: x => x.ID_CAMPANA,
                        principalTable: "CAMPANAS",
                        principalColumn: "ID_CAMPANA",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ARTICULOS_CARRITO_COMPRA",
                columns: table => new
                {
                    ID_ARTICULOS_CARRITO = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CANTIDAD = table.Column<int>(nullable: false),
                    CODIGO_LEC = table.Column<string>(maxLength: 64, nullable: true),
                    DISPONIBLE = table.Column<bool>(nullable: false),
                    DONACION = table.Column<bool>(nullable: false),
                    ES_CUADERNO = table.Column<bool>(nullable: false),
                    FECHA_LISTA = table.Column<int>(nullable: false),
                    ID_ARTICULO = table.Column<int>(nullable: false),
                    ID_ARTICULO_BACKUP = table.Column<int>(nullable: true),
                    ID_CARRITO = table.Column<int>(nullable: false),
                    ID_LISTA = table.Column<string>(maxLength: 20, nullable: false),
                    ID_PRODUCTO = table.Column<int>(nullable: false),
                    ID_USUARIO = table.Column<string>(maxLength: 128, nullable: false),
                    IVA = table.Column<decimal>(nullable: true),
                    LARGE_IMAGE = table.Column<string>(maxLength: 600, nullable: true),
                    MARCA = table.Column<string>(nullable: true),
                    NOMBRE = table.Column<string>(maxLength: 80, nullable: true),
                    PESO = table.Column<int>(nullable: true),
                    PRECIO = table.Column<decimal>(nullable: false),
                    TIENE_IMAGEN = table.Column<bool>(nullable: false),
                    TIENE_MARCADO = table.Column<bool>(nullable: false),
                    URL_THUMB = table.Column<string>(maxLength: 600, nullable: true),
                    VALOR_MARCADO = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ARTICULOS_CARRITO_COMPRA", x => x.ID_ARTICULOS_CARRITO);
                    table.ForeignKey(
                        name: "FK_dbo.ARTICULOS_CARRITO_COMPRA_dbo.CARRITO_COMPRA_ID_CARRITO",
                        column: x => x.ID_CARRITO,
                        principalTable: "CARRITO_COMPRA",
                        principalColumn: "ID_CARRITO",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ARTICULOS_CARRITO_COMPRA_PREPEDIDO",
                columns: table => new
                {
                    ID_ARTICULOS_CARRITO = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CANTIDAD = table.Column<int>(nullable: false),
                    DONACION = table.Column<bool>(nullable: false),
                    ID_ARTICULO = table.Column<int>(nullable: false),
                    ID_ARTICULO_BACKUP = table.Column<int>(nullable: true),
                    ID_CARRITO = table.Column<int>(nullable: false),
                    ID_PRODUCTO = table.Column<int>(nullable: false),
                    IVA = table.Column<decimal>(nullable: true),
                    NOMBRE = table.Column<string>(nullable: true),
                    PESO = table.Column<int>(nullable: true),
                    PRECIO = table.Column<decimal>(nullable: false),
                    TIENE_MARCADO = table.Column<bool>(nullable: false),
                    VALOR_MARCADO = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ARTICULOS_CARRITO_COMPRA_PREPEDIDO", x => x.ID_ARTICULOS_CARRITO);
                    table.ForeignKey(
                        name: "FK_dbo.ARTICULOS_CARRITO_COMPRA_PREPEDIDO_dbo.CARRITO_COMPRA_PREPEDIDO_ID_CARRITO",
                        column: x => x.ID_CARRITO,
                        principalTable: "CARRITO_COMPRA_PREPEDIDO",
                        principalColumn: "ID_CARRITO",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CATEGORIA_CATEGORIAS",
                columns: table => new
                {
                    ID_CATEGORIA_HIJO = table.Column<int>(nullable: false),
                    ID_CATEGORIA_PADRE = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CATEGORIA_CATEGORIAS", x => new { x.ID_CATEGORIA_HIJO, x.ID_CATEGORIA_PADRE });
                    table.ForeignKey(
                        name: "FK_dbo.CATEGORIA_CATEGORIAS_dbo.CATEGORIAS_ID_CATEGORIA_HIJO",
                        column: x => x.ID_CATEGORIA_HIJO,
                        principalTable: "CATEGORIAS",
                        principalColumn: "ID_CATEGORIA",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_dbo.CATEGORIA_CATEGORIAS_dbo.CATEGORIAS_ID_CATEGORIA_PADRE",
                        column: x => x.ID_CATEGORIA_PADRE,
                        principalTable: "CATEGORIAS",
                        principalColumn: "ID_CATEGORIA",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CATEGORIAS_CATEGORIAS_CONTABLE",
                columns: table => new
                {
                    ID_CATEGORIA = table.Column<int>(nullable: false),
                    ID_CATEGORIA_CONTABLE = table.Column<int>(nullable: false),
                    ESTADO_REGISTRO = table.Column<bool>(nullable: false),
                    FECHA_ACTUALIZACION = table.Column<DateTime>(type: "datetime", nullable: true),
                    FECHA_CREACION = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CATEGORIAS_CATEGORIAS_CONTABLE", x => new { x.ID_CATEGORIA, x.ID_CATEGORIA_CONTABLE });
                    table.ForeignKey(
                        name: "FK_dbo.CATEGORIAS_CATEGORIAS_CONTABLE_dbo.CATEGORIAS_ID_CATEGORIA",
                        column: x => x.ID_CATEGORIA,
                        principalTable: "CATEGORIAS",
                        principalColumn: "ID_CATEGORIA",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_dbo.CATEGORIAS_CATEGORIAS_CONTABLE_dbo.CATEGORIAS_CONTABILIDAD_ID_CATEGORIA_CONTABLE",
                        column: x => x.ID_CATEGORIA_CONTABLE,
                        principalTable: "CATEGORIAS_CONTABILIDAD",
                        principalColumn: "ID_CATEGORIA",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PERSONAS",
                columns: table => new
                {
                    ID_INDIVIDUO = table.Column<int>(nullable: false),
                    CLIENTE_IDENTITY = table.Column<bool>(nullable: true),
                    ESTADO_CIVIL = table.Column<string>(maxLength: 16, nullable: true),
                    ESTADO_REGISTRO = table.Column<bool>(nullable: false),
                    FECHA_ACTUALIZACION = table.Column<DateTime>(type: "datetime", nullable: true),
                    FECHA_CREACION = table.Column<DateTime>(type: "datetime", nullable: true),
                    FECHA_NACIMIENTO = table.Column<DateTime>(type: "datetime", nullable: true),
                    GENERO = table.Column<string>(maxLength: 1, nullable: true),
                    INGRESOS = table.Column<string>(maxLength: 20, nullable: true),
                    NUM_HIJOS = table.Column<int>(nullable: true),
                    NUM_IDENTIFICACION = table.Column<string>(maxLength: 15, nullable: true),
                    PRIMER_APELLIDO = table.Column<string>(maxLength: 32, nullable: true),
                    PRIMER_NOMBRE = table.Column<string>(maxLength: 120, nullable: true),
                    SEGUNDO_APELLIDO = table.Column<string>(maxLength: 32, nullable: true),
                    SEGUNDO_NOMBRE = table.Column<string>(maxLength: 32, nullable: true),
                    TIPO_IDENTIFICACION = table.Column<string>(maxLength: 3, nullable: true),
                    TIPO_PERSONA = table.Column<string>(maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PERSONAS", x => x.ID_INDIVIDUO);
                    table.ForeignKey(
                        name: "FK_dbo.PERSONAS_dbo.INDIVIDUOS_ID_INDIVIDUO",
                        column: x => x.ID_INDIVIDUO,
                        principalTable: "INDIVIDUOS",
                        principalColumn: "ID_INDIVIDUO",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PROVEEDORES",
                columns: table => new
                {
                    ID_INDIVIDUO = table.Column<int>(nullable: false),
                    AUTORETENEDOR = table.Column<bool>(nullable: true),
                    DAN_CREDITO = table.Column<bool>(nullable: true),
                    ESTADO_REGISTRO = table.Column<bool>(nullable: false),
                    FECHA_ACTUALIZACION = table.Column<DateTime>(type: "datetime", nullable: true),
                    FECHA_CREACION = table.Column<DateTime>(type: "datetime", nullable: true),
                    ID_ACVTIVIDAD_ECONOMICA = table.Column<int>(nullable: false, defaultValueSql: "((0))"),
                    NOMBRE_COMERCIAL = table.Column<string>(nullable: true),
                    NUM_IDENTIFICACION = table.Column<string>(maxLength: 16, nullable: true),
                    PAGO_TARJETA = table.Column<bool>(nullable: true),
                    RAZON_SOCIAL = table.Column<string>(maxLength: 64, nullable: true),
                    SECUENCIA = table.Column<int>(nullable: true),
                    TIPO_IDENTIFICACION = table.Column<string>(maxLength: 3, nullable: true),
                    TIPO_PROVEEDOR = table.Column<string>(maxLength: 32, nullable: true),
                    URL_SITIO_WEB = table.Column<string>(maxLength: 300, nullable: true),
                    VALOR_COMPRA_MIN = table.Column<double>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PROVEEDORES", x => x.ID_INDIVIDUO);
                    table.ForeignKey(
                        name: "FK_dbo.PROVEEDORES_dbo.ACTIVIDADES_ECONOMICAS_ID_ACVTIVIDAD_ECONOMICA",
                        column: x => x.ID_ACVTIVIDAD_ECONOMICA,
                        principalTable: "ACTIVIDADES_ECONOMICAS",
                        principalColumn: "ID_ACTIVIDAD_ECONOMICA",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_dbo.PROVEEDORES_dbo.INDIVIDUOS_ID_INDIVIDUO",
                        column: x => x.ID_INDIVIDUO,
                        principalTable: "INDIVIDUOS",
                        principalColumn: "ID_INDIVIDUO",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PRODUCTOS",
                columns: table => new
                {
                    ID_PRODUCTO = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DISPONIBLE = table.Column<bool>(nullable: false),
                    ESTADO_REGISTRO = table.Column<bool>(nullable: false),
                    FECHA_ACTUALIZACION = table.Column<DateTime>(type: "datetime", nullable: true),
                    FECHA_CREACION = table.Column<DateTime>(type: "datetime", nullable: true),
                    FECHA_VENCIMIENTO = table.Column<DateTime>(type: "datetime", nullable: true),
                    ID_CATEGORIA_CONTABILIDAD = table.Column<int>(nullable: true),
                    ID_MARCA = table.Column<int>(nullable: false),
                    IdUnidadVenta = table.Column<int>(nullable: true),
                    LARGE_IMG_URL = table.Column<string>(maxLength: 600, nullable: true),
                    MEDIUM_IMG_URL = table.Column<string>(maxLength: 600, nullable: true),
                    NOMBRE = table.Column<string>(maxLength: 45, nullable: false),
                    NOMBRE_BUSCADOR = table.Column<string>(maxLength: 200, nullable: true),
                    NUMERO_UNID_VENTA = table.Column<int>(nullable: true),
                    PESO = table.Column<int>(nullable: true),
                    POR_MAYOR = table.Column<bool>(nullable: false),
                    PRIORIDAD = table.Column<int>(nullable: true),
                    SECUENCIA = table.Column<int>(nullable: true),
                    SMALL_IMG_URL = table.Column<string>(maxLength: 600, nullable: true),
                    TIENE_IMAGEN = table.Column<bool>(nullable: true),
                    VALOR_MARCADO = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PRODUCTOS", x => x.ID_PRODUCTO);
                    table.ForeignKey(
                        name: "FK_dbo.PRODUCTOS_dbo.CATEGORIAS_CONTABILIDAD_ID_CATEGORIA_CONTABILIDAD",
                        column: x => x.ID_CATEGORIA_CONTABILIDAD,
                        principalTable: "CATEGORIAS_CONTABILIDAD",
                        principalColumn: "ID_CATEGORIA",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_dbo.PRODUCTOS_dbo.MARCAS_ID_MARCA",
                        column: x => x.ID_MARCA,
                        principalTable: "MARCAS",
                        principalColumn: "ID_MARCA",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "REGIONES",
                columns: table => new
                {
                    ID_REGION = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CODIGO_PAIS = table.Column<string>(type: "nchar(2)", nullable: false),
                    ESTADO_REGISTRO = table.Column<bool>(nullable: false),
                    FECHA_ACTUALIZACION = table.Column<DateTime>(type: "datetime", nullable: true),
                    FECHA_CREACION = table.Column<DateTime>(type: "datetime", nullable: true),
                    NOMBRE = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_REGIONES", x => x.ID_REGION);
                    table.ForeignKey(
                        name: "FK_dbo.REGIONES_dbo.PAISES_CODIGO_PAIS",
                        column: x => x.CODIGO_PAIS,
                        principalTable: "PAISES",
                        principalColumn: "CODIGO_PAIS",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "KEYWORDS_CATEGORIAS",
                columns: table => new
                {
                    CATEGORIAS_ID_CATEGORIA = table.Column<int>(nullable: false),
                    PALABRAS_CLAVE_ID_PALABRA = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KEYWORDS_CATEGORIAS", x => new { x.CATEGORIAS_ID_CATEGORIA, x.PALABRAS_CLAVE_ID_PALABRA });
                    table.ForeignKey(
                        name: "FK_dbo.KEYWORDS_CATEGORIAS_dbo.CATEGORIAS_CATEGORIAS_ID_CATEGORIA",
                        column: x => x.CATEGORIAS_ID_CATEGORIA,
                        principalTable: "CATEGORIAS",
                        principalColumn: "ID_CATEGORIA",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_dbo.KEYWORDS_CATEGORIAS_dbo.PALABRAS_CLAVE_PALABRAS_CLAVE_ID_PALABRA",
                        column: x => x.PALABRAS_CLAVE_ID_PALABRA,
                        principalTable: "PALABRAS_CLAVE",
                        principalColumn: "ID_PALABRA",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "IMAGENES_POST",
                columns: table => new
                {
                    ID_POST_IMAGEN = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ID_POST = table.Column<int>(nullable: true),
                    SECUENCIA = table.Column<int>(nullable: false),
                    TIPO_IMAGEN = table.Column<string>(maxLength: 20, nullable: true),
                    URL = table.Column<string>(maxLength: 300, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IMAGENES_POST", x => x.ID_POST_IMAGEN);
                    table.ForeignKey(
                        name: "FK_dbo.IMAGENES_POST_dbo.POSTS_ID_POST",
                        column: x => x.ID_POST,
                        principalTable: "POSTS",
                        principalColumn: "ID_POST",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PARRAFOS",
                columns: table => new
                {
                    ID_PARRAFO = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ID_POST = table.Column<int>(nullable: false),
                    QUOTE = table.Column<string>(maxLength: 2000, nullable: true),
                    SECUENCIA = table.Column<int>(nullable: false),
                    TEXTO = table.Column<string>(maxLength: 3000, nullable: true),
                    TIPO_PARRAFO = table.Column<string>(maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PARRAFOS", x => x.ID_PARRAFO);
                    table.ForeignKey(
                        name: "FK_dbo.PARRAFOS_dbo.POSTS_ID_POST",
                        column: x => x.ID_POST,
                        principalTable: "POSTS",
                        principalColumn: "ID_POST",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SUBTITULOS",
                columns: table => new
                {
                    ID_SUBTITULO = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ID_POST = table.Column<int>(nullable: true),
                    SECUENCIA = table.Column<int>(nullable: false),
                    TEXTO = table.Column<string>(maxLength: 300, nullable: true),
                    TIPO_ESTILO = table.Column<string>(maxLength: 30, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SUBTITULOS", x => x.ID_SUBTITULO);
                    table.ForeignKey(
                        name: "FK_dbo.SUBTITULOS_dbo.POSTS_ID_POST",
                        column: x => x.ID_POST,
                        principalTable: "POSTS",
                        principalColumn: "ID_POST",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ARTICULOS_POR_INSTITUCION_PRE_PEDIDO",
                columns: table => new
                {
                    ID_ARTICULO = table.Column<int>(nullable: false),
                    ID_INDIVIDUO = table.Column<int>(nullable: false),
                    ID_PRODUCTO = table.Column<int>(nullable: false),
                    ID_PRE_PEDIDO = table.Column<int>(nullable: false),
                    CANTIDAD = table.Column<int>(nullable: false),
                    ESTADO_REGISTRO = table.Column<bool>(nullable: false),
                    FECHA_ACTUALIZACION = table.Column<DateTime>(type: "datetime", nullable: true),
                    FECHA_CREACION = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ARTICULOS_POR_INSTITUCION_PRE_PEDIDO", x => new { x.ID_ARTICULO, x.ID_INDIVIDUO, x.ID_PRODUCTO, x.ID_PRE_PEDIDO });
                    table.ForeignKey(
                        name: "FK_dbo.ARTICULOS_POR_INSTITUCION_PRE_PEDIDO_dbo.PRE_PEDIDOS_ID_PRE_PEDIDO",
                        column: x => x.ID_PRE_PEDIDO,
                        principalTable: "PRE_PEDIDOS",
                        principalColumn: "ID_PRE_PEDIDO",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ARTICULOS_PRE_PEDIDO",
                columns: table => new
                {
                    ID_ARTICULO = table.Column<int>(nullable: false),
                    ID_PRE_PEDIDO = table.Column<int>(nullable: false),
                    ID_PRODUCTO = table.Column<int>(nullable: false),
                    CANTIDAD = table.Column<int>(nullable: false),
                    ESTADO_REGISTRO = table.Column<bool>(nullable: false),
                    FECHA_ACTUALIZACION = table.Column<DateTime>(type: "datetime", nullable: true),
                    FECHA_CREACION = table.Column<DateTime>(type: "datetime", nullable: true),
                    PRECIO_CON_IVA = table.Column<decimal>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ARTICULOS_PRE_PEDIDO", x => new { x.ID_ARTICULO, x.ID_PRE_PEDIDO, x.ID_PRODUCTO });
                    table.ForeignKey(
                        name: "FK_dbo.ARTICULOS_PRE_PEDIDO_dbo.PRE_PEDIDOS_ID_PRE_PEDIDO",
                        column: x => x.ID_PRE_PEDIDO,
                        principalTable: "PRE_PEDIDOS",
                        principalColumn: "ID_PRE_PEDIDO",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ATRIBUTOS_ARTICULOS",
                columns: table => new
                {
                    ID_ATRIBUTO = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DESCRIPCION = table.Column<string>(maxLength: 300, nullable: true),
                    ESTADO_REGISTRO = table.Column<bool>(nullable: false),
                    FECHA_ACTUALIZACION = table.Column<DateTime>(type: "datetime", nullable: true),
                    FECHA_CREACION = table.Column<DateTime>(type: "datetime", nullable: true),
                    ID_TIPO = table.Column<int>(nullable: false),
                    ID_UNID_VENTA = table.Column<int>(nullable: true),
                    NOMBRE = table.Column<string>(maxLength: 45, nullable: false),
                    SECUENCIA = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ATRIBUTOS_ARTICULOS", x => x.ID_ATRIBUTO);
                    table.ForeignKey(
                        name: "FK_dbo.ATRIBUTOS_ARTICULOS_dbo.TIPO_ATRIBUTOS_ID_TIPO",
                        column: x => x.ID_TIPO,
                        principalTable: "TIPO_ATRIBUTOS",
                        principalColumn: "ID_TIPO",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_dbo.ATRIBUTOS_ARTICULOS_dbo.UNIDADES_VENTA_ID_UNID_VENTA",
                        column: x => x.ID_UNID_VENTA,
                        principalTable: "UNIDADES_VENTA",
                        principalColumn: "ID_UNID_VENTA",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DESCUENTOS_USADOS",
                columns: table => new
                {
                    ID_IDENTITY = table.Column<string>(maxLength: 128, nullable: false),
                    ID_DESCUENTO = table.Column<int>(nullable: false),
                    ESTADO_REGISTRO = table.Column<bool>(nullable: false),
                    FECHA_ACTUALIZACION = table.Column<DateTime>(type: "datetime", nullable: true),
                    FECHA_CREACION = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DESCUENTOS_USADOS", x => new { x.ID_IDENTITY, x.ID_DESCUENTO });
                    table.ForeignKey(
                        name: "FK_dbo.DESCUENTOS_USADOS_dbo.DESCUENTOS_ID_DESCUENTO",
                        column: x => x.ID_DESCUENTO,
                        principalTable: "DESCUENTOS",
                        principalColumn: "ID_DESCUENTO",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "INSTITUCIONES",
                columns: table => new
                {
                    ID_INDIVIDUO = table.Column<int>(nullable: false),
                    ALIADO = table.Column<bool>(nullable: false),
                    CALENDARIO = table.Column<string>(maxLength: 1, nullable: true),
                    ESTADO_REGISTRO = table.Column<bool>(nullable: false),
                    FECHA_ACTUALIZACION = table.Column<DateTime>(type: "datetime", nullable: true),
                    FECHA_CREACION = table.Column<DateTime>(type: "datetime", nullable: true),
                    ID_DESCUENTO = table.Column<int>(nullable: true),
                    NOMBRE_BUSCADOR = table.Column<string>(maxLength: 200, nullable: true),
                    NOMBRE_CORTO = table.Column<string>(maxLength: 45, nullable: true),
                    NOMBRE_OFICIAL = table.Column<string>(maxLength: 80, nullable: true),
                    NUM_IDENTIFICACION = table.Column<string>(maxLength: 16, nullable: true),
                    PIDE_LISTA = table.Column<string>(maxLength: 2, nullable: false),
                    PUBLICO = table.Column<bool>(nullable: false),
                    TIPO_IDENTIFICACION = table.Column<string>(maxLength: 3, nullable: true),
                    TIPO_INSTITUCION = table.Column<string>(maxLength: 16, nullable: false),
                    URL_LOGO = table.Column<string>(maxLength: 300, nullable: true),
                    URL_LOGO_MIN = table.Column<string>(maxLength: 300, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_INSTITUCIONES", x => x.ID_INDIVIDUO);
                    table.ForeignKey(
                        name: "FK_dbo.INSTITUCIONES_dbo.DESCUENTOS_ID_DESCUENTO",
                        column: x => x.ID_DESCUENTO,
                        principalTable: "DESCUENTOS",
                        principalColumn: "ID_DESCUENTO",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_dbo.INSTITUCIONES_dbo.INDIVIDUOS_ID_INDIVIDUO",
                        column: x => x.ID_INDIVIDUO,
                        principalTable: "INDIVIDUOS",
                        principalColumn: "ID_INDIVIDUO",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "FACTURAS_COMPRAS",
                columns: table => new
                {
                    ID_FACTURA_COMPRA = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    COMENTARIO = table.Column<string>(maxLength: 900, nullable: true),
                    ES_LEGAL = table.Column<bool>(nullable: false),
                    ESTADO_PAGO = table.Column<string>(maxLength: 20, nullable: false),
                    ESTADO_REGISTRO = table.Column<bool>(nullable: false),
                    FECHA_ACTUALIZACION = table.Column<DateTime>(type: "datetime", nullable: true),
                    FECHA_COMPRA = table.Column<DateTime>(type: "datetime", nullable: false),
                    FECHA_CREACION = table.Column<DateTime>(type: "datetime", nullable: true),
                    ID_INDIVIDUO = table.Column<int>(nullable: false),
                    TOTAL_IVA_FACTURA = table.Column<decimal>(type: "decimal(15, 6)", nullable: false),
                    VALOR_DESCUENTO = table.Column<decimal>(nullable: false, defaultValueSql: "((0))"),
                    VALOR_IVA = table.Column<decimal>(type: "decimal(13, 6)", nullable: false, defaultValueSql: "((0))"),
                    VALOR_IVA_ARREGLO = table.Column<decimal>(type: "decimal(9, 4)", nullable: true),
                    VALOR_RETENCION_FUENTE = table.Column<decimal>(type: "decimal(13, 6)", nullable: false, defaultValueSql: "((0))"),
                    VALOR_RETENCION_FUENTE_ARREGLO = table.Column<decimal>(type: "decimal(9, 4)", nullable: true),
                    VALOR_TOTAL_ARREGLO = table.Column<decimal>(type: "decimal(9, 4)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FACTURAS_COMPRAS", x => x.ID_FACTURA_COMPRA);
                    table.ForeignKey(
                        name: "FK_dbo.FACTURAS_COMPRAS_dbo.PROVEEDORES_ID_INDIVIDUO",
                        column: x => x.ID_INDIVIDUO,
                        principalTable: "PROVEEDORES",
                        principalColumn: "ID_INDIVIDUO",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MARCAS_PROVEEDOR",
                columns: table => new
                {
                    MARCAS_ID_MARCA = table.Column<int>(nullable: false),
                    PROVEEDORES_ID_INDIVIDUO = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MARCAS_PROVEEDOR", x => new { x.MARCAS_ID_MARCA, x.PROVEEDORES_ID_INDIVIDUO });
                    table.ForeignKey(
                        name: "FK_dbo.MARCAS_PROVEEDOR_dbo.MARCAS_MARCAS_ID_MARCA",
                        column: x => x.MARCAS_ID_MARCA,
                        principalTable: "MARCAS",
                        principalColumn: "ID_MARCA",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_dbo.MARCAS_PROVEEDOR_dbo.PROVEEDORES_PROVEEDORES_ID_INDIVIDUO",
                        column: x => x.PROVEEDORES_ID_INDIVIDUO,
                        principalTable: "PROVEEDORES",
                        principalColumn: "ID_INDIVIDUO",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ORDEN_COMPRA",
                columns: table => new
                {
                    ID_ORDEN = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ESTADO_REGISTRO = table.Column<bool>(nullable: false),
                    FECHA_ACTUALIZACION = table.Column<DateTime>(type: "datetime", nullable: true),
                    FECHA_CREACION = table.Column<DateTime>(type: "datetime", nullable: true),
                    FECHA_LIMITE = table.Column<DateTime>(type: "datetime", nullable: true),
                    FECHA_PEDIDO = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "('1900-01-01T00:00:00.000')"),
                    OBSERVACIONES_GENERALES = table.Column<string>(maxLength: 900, nullable: true),
                    Proveedor_IdIndividuo = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ORDEN_COMPRA", x => x.ID_ORDEN);
                    table.ForeignKey(
                        name: "FK_dbo.ORDEN_COMPRA_dbo.PROVEEDORES_ID_INDIVIDUO",
                        column: x => x.Proveedor_IdIndividuo,
                        principalTable: "PROVEEDORES",
                        principalColumn: "ID_INDIVIDUO",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ARTICULOS",
                columns: table => new
                {
                    ID_ARTICULO = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ID_PRODUCTO = table.Column<int>(nullable: false),
                    COD_UNICO_FABRICANTE = table.Column<string>(maxLength: 64, nullable: true),
                    COD_UNICO_LISTAENCASA = table.Column<string>(maxLength: 64, nullable: true),
                    EN_PROMOCION = table.Column<bool>(nullable: false),
                    ES_CUADERNO = table.Column<bool>(nullable: false),
                    ESTADO_REGISTRO = table.Column<bool>(nullable: false),
                    FECHA_ACTUALIZACION = table.Column<DateTime>(type: "datetime", nullable: true),
                    FECHA_CREACION = table.Column<DateTime>(type: "datetime", nullable: true),
                    FECHA_DISPONIBLE = table.Column<DateTime>(type: "datetime", nullable: true),
                    IVA = table.Column<decimal>(nullable: true, defaultValueSql: "((0))"),
                    IVA_EXCLUIDO = table.Column<bool>(nullable: true, defaultValueSql: "((1))"),
                    LARGE_IMG_URL = table.Column<string>(maxLength: 600, nullable: true),
                    MEDIUM_IMG_URL = table.Column<string>(maxLength: 600, nullable: true),
                    NOMBRE = table.Column<string>(maxLength: 80, nullable: true),
                    NOMBRE_BUSCADOR = table.Column<string>(maxLength: 200, nullable: true),
                    TIENE_IMAGEN = table.Column<bool>(nullable: true),
                    ULTIMA_ORDEN = table.Column<DateTime>(type: "datetime", nullable: true),
                    URL_THUMBNAIL = table.Column<string>(maxLength: 600, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ARTICULOS", x => new { x.ID_ARTICULO, x.ID_PRODUCTO });
                    table.ForeignKey(
                        name: "FK_dbo.ARTICULOS_dbo.PRODUCTOS_ID_PRODUCTO",
                        column: x => x.ID_PRODUCTO,
                        principalTable: "PRODUCTOS",
                        principalColumn: "ID_PRODUCTO",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CATEGORIA_PROD",
                columns: table => new
                {
                    CATEGORIAS_ID_CATEGORIA = table.Column<int>(nullable: false),
                    PRODUCTOS_ID_PRODUCTO = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CATEGORIA_PROD", x => new { x.CATEGORIAS_ID_CATEGORIA, x.PRODUCTOS_ID_PRODUCTO });
                    table.ForeignKey(
                        name: "FK_dbo.CATEGORIA_PROD_dbo.CATEGORIAS_CATEGORIAS_ID_CATEGORIA",
                        column: x => x.CATEGORIAS_ID_CATEGORIA,
                        principalTable: "CATEGORIAS",
                        principalColumn: "ID_CATEGORIA",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_dbo.CATEGORIA_PROD_dbo.PRODUCTOS_PRODUCTOS_ID_PRODUCTO",
                        column: x => x.PRODUCTOS_ID_PRODUCTO,
                        principalTable: "PRODUCTOS",
                        principalColumn: "ID_PRODUCTO",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DESCRIPCION_PRODUCTO",
                columns: table => new
                {
                    TIPO_DESCRIPCION = table.Column<string>(maxLength: 32, nullable: false),
                    ID_PRODUCTO = table.Column<int>(nullable: false),
                    COD_ISO_IDIOMA = table.Column<string>(maxLength: 2, nullable: false),
                    DESC_CORTA = table.Column<string>(maxLength: 300, nullable: true),
                    DESC_LARGA = table.Column<string>(maxLength: 4000, nullable: true),
                    ESTADO_REGISTRO = table.Column<bool>(nullable: false),
                    FECHA_ACTUALIZACION = table.Column<DateTime>(type: "datetime", nullable: true),
                    FECHA_CREACION = table.Column<DateTime>(type: "datetime", nullable: true),
                    NOMBRE_PROD_TRADUCIDO = table.Column<string>(maxLength: 45, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DESCRIPCION_PRODUCTO", x => new { x.TIPO_DESCRIPCION, x.ID_PRODUCTO });
                    table.ForeignKey(
                        name: "FK_dbo.DESCRIPCION_PRODUCTO_dbo.PRODUCTOS_ID_PRODUCTO",
                        column: x => x.ID_PRODUCTO,
                        principalTable: "PRODUCTOS",
                        principalColumn: "ID_PRODUCTO",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "KEYWORDS_PRODUCTOS",
                columns: table => new
                {
                    PRODUCTOS_ID_PRODUCTO = table.Column<int>(nullable: false),
                    PALABRAS_CLAVE_ID_PALABRA = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KEYWORDS_PRODUCTOS", x => new { x.PRODUCTOS_ID_PRODUCTO, x.PALABRAS_CLAVE_ID_PALABRA });
                    table.ForeignKey(
                        name: "FK_dbo.KEYWORDS_PRODUCTOS_dbo.PALABRAS_CLAVE_PALABRAS_CLAVE_ID_PALABRA",
                        column: x => x.PALABRAS_CLAVE_ID_PALABRA,
                        principalTable: "PALABRAS_CLAVE",
                        principalColumn: "ID_PALABRA",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_dbo.KEYWORDS_PRODUCTOS_dbo.PRODUCTOS_PRODUCTOS_ID_PRODUCTO",
                        column: x => x.PRODUCTOS_ID_PRODUCTO,
                        principalTable: "PRODUCTOS",
                        principalColumn: "ID_PRODUCTO",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "VALORACIONES",
                columns: table => new
                {
                    ID_INDIVIDUO = table.Column<int>(nullable: false),
                    ID_PRODUCTO = table.Column<int>(nullable: false),
                    COMENTARIO = table.Column<string>(maxLength: 1000, nullable: true),
                    ESTADO_REGISTRO = table.Column<bool>(nullable: false),
                    FECHA_ACTUALIZACION = table.Column<DateTime>(type: "datetime", nullable: true),
                    FECHA_COMENTARIO = table.Column<DateTime>(type: "datetime", nullable: false),
                    FECHA_CREACION = table.Column<DateTime>(type: "datetime", nullable: true),
                    RANKING = table.Column<int>(nullable: false),
                    TITULO = table.Column<string>(maxLength: 60, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VALORACIONES", x => new { x.ID_INDIVIDUO, x.ID_PRODUCTO });
                    table.ForeignKey(
                        name: "FK_dbo.VALORACIONES_dbo.PERSONAS_ID_INDIVIDUO",
                        column: x => x.ID_INDIVIDUO,
                        principalTable: "PERSONAS",
                        principalColumn: "ID_INDIVIDUO",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_dbo.VALORACIONES_dbo.PRODUCTOS_ID_PRODUCTO",
                        column: x => x.ID_PRODUCTO,
                        principalTable: "PRODUCTOS",
                        principalColumn: "ID_PRODUCTO",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "VERSION_PRODUCTO",
                columns: table => new
                {
                    ID_VERSION = table.Column<int>(nullable: false),
                    ID_PRODUCTO = table.Column<int>(nullable: false),
                    ESTADO_REGISTRO = table.Column<bool>(nullable: false),
                    FECHA_ACTUALIZACION = table.Column<DateTime>(type: "datetime", nullable: true),
                    FECHA_CREACION = table.Column<DateTime>(type: "datetime", nullable: true),
                    NOMBRE = table.Column<string>(maxLength: 45, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VERSION_PRODUCTO", x => new { x.ID_VERSION, x.ID_PRODUCTO });
                    table.ForeignKey(
                        name: "FK_dbo.VERSION_PRODUCTO_dbo.PRODUCTOS_ID_PRODUCTO",
                        column: x => x.ID_PRODUCTO,
                        principalTable: "PRODUCTOS",
                        principalColumn: "ID_PRODUCTO",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CIUDADES",
                columns: table => new
                {
                    ID_CIUDAD = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CODIGO_CIUDAD = table.Column<string>(type: "nchar(5)", nullable: true),
                    ESTADO_REGISTRO = table.Column<bool>(nullable: false),
                    FECHA_ACTUALIZACION = table.Column<DateTime>(type: "datetime", nullable: false),
                    FECHA_CREACION = table.Column<DateTime>(type: "datetime", nullable: false),
                    ID_REGION = table.Column<int>(nullable: false),
                    NOMBRE_CIUDAD = table.Column<string>(maxLength: 50, nullable: true),
                    TIENE_COSTO_ENVIO = table.Column<bool>(nullable: false),
                    VALOR_DESCUENTO_ENVIO = table.Column<decimal>(nullable: true),
                    VALOR_ENVIO = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CIUDADES", x => x.ID_CIUDAD);
                    table.ForeignKey(
                        name: "FK_dbo.CIUDADES_dbo.REGIONES_ID_REGION",
                        column: x => x.ID_REGION,
                        principalTable: "REGIONES",
                        principalColumn: "ID_REGION",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "QUOTES",
                columns: table => new
                {
                    ID_QUOTE = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ID_PARRAFO = table.Column<int>(nullable: true),
                    SECUENCIA = table.Column<int>(nullable: false),
                    TEXTO = table.Column<string>(maxLength: 3000, nullable: true),
                    TIPO_QUOTE = table.Column<string>(maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QUOTES", x => x.ID_QUOTE);
                    table.ForeignKey(
                        name: "FK_dbo.QUOTES_dbo.PARRAFOS_ID_PARRAFO",
                        column: x => x.ID_PARRAFO,
                        principalTable: "PARRAFOS",
                        principalColumn: "ID_PARRAFO",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "VALOR_ATRIBUTO",
                columns: table => new
                {
                    ID_VALOR = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ESTADO_REGISTRO = table.Column<bool>(nullable: false),
                    FECHA_ACTUALIZACION = table.Column<DateTime>(type: "datetime", nullable: true),
                    FECHA_CREACION = table.Column<DateTime>(type: "datetime", nullable: true),
                    ID_ATRIBUTO = table.Column<int>(nullable: false),
                    ID_TIPO = table.Column<int>(nullable: false),
                    ID_UNID_VENTA = table.Column<int>(nullable: true),
                    SECUENCIA = table.Column<int>(nullable: false),
                    VALOR_BLOB = table.Column<string>(nullable: true),
                    ValorBool = table.Column<bool>(nullable: true),
                    VALOR_CADENA = table.Column<string>(maxLength: 45, nullable: true),
                    VALOR_DECIMAL = table.Column<decimal>(nullable: true),
                    VALOR_ENTERO = table.Column<int>(nullable: true),
                    VALOR_FECHA = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VALOR_ATRIBUTO", x => x.ID_VALOR);
                    table.ForeignKey(
                        name: "FK_dbo.VALOR_ATRIBUTO_dbo.ATRIBUTOS_ARTICULOS_ID_ATRIBUTO",
                        column: x => x.ID_ATRIBUTO,
                        principalTable: "ATRIBUTOS_ARTICULOS",
                        principalColumn: "ID_ATRIBUTO",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_dbo.VALOR_ATRIBUTO_dbo.TIPO_ATRIBUTOS_ID_TIPO",
                        column: x => x.ID_TIPO,
                        principalTable: "TIPO_ATRIBUTOS",
                        principalColumn: "ID_TIPO",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_dbo.VALOR_ATRIBUTO_dbo.UNIDADES_VENTA_ID_UNID_VENTA",
                        column: x => x.ID_UNID_VENTA,
                        principalTable: "UNIDADES_VENTA",
                        principalColumn: "ID_UNID_VENTA",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ATRIBS_INSTITUCIONES",
                columns: table => new
                {
                    ID_INDIVIDUO = table.Column<int>(nullable: false),
                    ANIO_PENSION = table.Column<int>(nullable: true),
                    ESTADO_REGISTRO = table.Column<bool>(nullable: false),
                    FECHA_ACTUALIZACION = table.Column<DateTime>(type: "datetime", nullable: true),
                    FECHA_CREACION = table.Column<DateTime>(type: "datetime", nullable: true),
                    FECHA_MATRICULA = table.Column<DateTime>(type: "datetime", nullable: true),
                    FIN_CLASES = table.Column<DateTime>(type: "datetime", nullable: true),
                    INICIO_CLASES = table.Column<DateTime>(type: "datetime", nullable: true),
                    JORNADA = table.Column<string>(maxLength: 30, nullable: true),
                    NOMBRE_RECTOR = table.Column<string>(maxLength: 100, nullable: true),
                    URL_SITIO_WEB = table.Column<string>(maxLength: 300, nullable: true),
                    VALOR_MATRICULA = table.Column<decimal>(nullable: true),
                    VALOR_PENSION_1 = table.Column<decimal>(nullable: true),
                    VENDE_TEXTOS = table.Column<bool>(nullable: true),
                    VENDE_UTILES = table.Column<bool>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ATRIBS_INSTITUCIONES", x => x.ID_INDIVIDUO);
                    table.ForeignKey(
                        name: "FK_dbo.ATRIBS_INSTITUCIONES_dbo.INSTITUCIONES_ID_INDIVIDUO",
                        column: x => x.ID_INDIVIDUO,
                        principalTable: "INSTITUCIONES",
                        principalColumn: "ID_INDIVIDUO",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "BENEFICIOS_ALIADOS",
                columns: table => new
                {
                    ID_BENEFICIO = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ES_COSTO_ENVIO_GRATIS = table.Column<bool>(nullable: false),
                    ES_COSTO_MARCADO_GRATIS = table.Column<bool>(nullable: false),
                    ESTADO_REGISTRO = table.Column<bool>(nullable: false),
                    FECHA_ACTUALIZACION = table.Column<DateTime>(type: "datetime", nullable: false),
                    FECHA_CREACION = table.Column<DateTime>(type: "datetime", nullable: false),
                    ID_CODIGO_DESCUENTO = table.Column<int>(nullable: true),
                    ID_INDIVIDUO = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BENEFICIOS_ALIADOS", x => x.ID_BENEFICIO);
                    table.ForeignKey(
                        name: "FK_dbo.BENEFICIOS_ALIADOS_dbo.DESCUENTOS_ID_CODIGO_DESCUENTO",
                        column: x => x.ID_CODIGO_DESCUENTO,
                        principalTable: "DESCUENTOS",
                        principalColumn: "ID_DESCUENTO",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_dbo.BENEFICIOS_ALIADOS_dbo.INSTITUCIONES_ID_INDIVIDUO",
                        column: x => x.ID_INDIVIDUO,
                        principalTable: "INSTITUCIONES",
                        principalColumn: "ID_INDIVIDUO",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CURSOS",
                columns: table => new
                {
                    ID_CURSO = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ESTADO_REGISTRO = table.Column<bool>(nullable: false),
                    FECHA_ACTUALIZACION = table.Column<DateTime>(type: "datetime", nullable: true),
                    FECHA_CREACION = table.Column<DateTime>(type: "datetime", nullable: true),
                    ID_INDIVIDUO = table.Column<int>(nullable: false),
                    NIVEL = table.Column<string>(maxLength: 15, nullable: true),
                    NOMBRE = table.Column<string>(maxLength: 45, nullable: false),
                    SECUENCIA = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CURSOS", x => x.ID_CURSO);
                    table.ForeignKey(
                        name: "FK_dbo.CURSOS_dbo.INSTITUCIONES_ID_INDIVIDUO",
                        column: x => x.ID_INDIVIDUO,
                        principalTable: "INSTITUCIONES",
                        principalColumn: "ID_INDIVIDUO",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ESTADISTICAS_ICFES",
                columns: table => new
                {
                    FECHA_PRUEBA = table.Column<DateTime>(type: "datetime", nullable: false),
                    ID_INDIVIDUO = table.Column<int>(nullable: false),
                    ESTADO_REGISTRO = table.Column<bool>(nullable: false),
                    ESTUDIANTES_ICFES = table.Column<int>(nullable: true),
                    FECHA_CREACION = table.Column<DateTime>(type: "datetime", nullable: true),
                    NIVEL_ICFES = table.Column<string>(maxLength: 16, nullable: true),
                    PUNTAJE_INSTITUCION = table.Column<decimal>(nullable: true),
                    TOTAL_ESTUDIANTES = table.Column<int>(nullable: true),
                    ULTIMA_MODIFICACION = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ESTADISTICAS_ICFES", x => new { x.FECHA_PRUEBA, x.ID_INDIVIDUO });
                    table.ForeignKey(
                        name: "FK_dbo.ESTADISTICAS_ICFES_dbo.INSTITUCIONES_ID_INDIVIDUO",
                        column: x => x.ID_INDIVIDUO,
                        principalTable: "INSTITUCIONES",
                        principalColumn: "ID_INDIVIDUO",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ARTICULOS_POR_FACTURA_COMPRA",
                columns: table => new
                {
                    ID_ARTICULO = table.Column<int>(nullable: false),
                    ID_FACTURA_COMPRA = table.Column<int>(nullable: false),
                    ID_PRODUCTO = table.Column<int>(nullable: false),
                    CANTIDAD = table.Column<int>(nullable: false),
                    ESTADO_REGISTRO = table.Column<bool>(nullable: false),
                    FECHA_ACTUALIZACION = table.Column<DateTime>(type: "datetime", nullable: true),
                    FECHA_CREACION = table.Column<DateTime>(type: "datetime", nullable: true),
                    PORCENTAJE_IVA = table.Column<decimal>(nullable: false),
                    PRECIO_COMPRA_SIN_IVA = table.Column<decimal>(type: "decimal(14, 6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ARTICULOS_POR_FACTURA_COMPRA", x => new { x.ID_ARTICULO, x.ID_FACTURA_COMPRA, x.ID_PRODUCTO });
                    table.ForeignKey(
                        name: "FK_dbo.ARTICULOS_POR_FACTURA_COMPRA_dbo.FACTURAS_COMPRAS_ID_FACTURA_COMPRA",
                        column: x => x.ID_FACTURA_COMPRA,
                        principalTable: "FACTURAS_COMPRAS",
                        principalColumn: "ID_FACTURA_COMPRA",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_dbo.ARTICULOS_POR_FACTURA_COMPRA_dbo.ARTICULOS_ID_ARTICULO_ID_PRODUCTO",
                        columns: x => new { x.ID_ARTICULO, x.ID_PRODUCTO },
                        principalTable: "ARTICULOS",
                        principalColumns: new[] { "ID_ARTICULO", "ID_PRODUCTO" },
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ARTICULOS_POR_ORDEN",
                columns: table => new
                {
                    ID_DETALLE_ORDEN_COMPRA = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CANTIDAD = table.Column<int>(nullable: false),
                    ESTADO_REGISTRO = table.Column<bool>(nullable: false),
                    FECHA_ACTUALIZACION = table.Column<DateTime>(type: "datetime", nullable: true),
                    FECHA_CREACION = table.Column<DateTime>(type: "datetime", nullable: true),
                    ID_ARTICULO = table.Column<int>(nullable: false),
                    ID_ORDEN = table.Column<int>(nullable: false),
                    ID_PRODUCTO = table.Column<int>(nullable: false),
                    LUGAR_ULTIMA_COMPRA = table.Column<string>(maxLength: 30, nullable: true),
                    PRECIO_ULTIMA_COMPRA = table.Column<decimal>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ARTICULOS_POR_ORDEN", x => x.ID_DETALLE_ORDEN_COMPRA);
                    table.ForeignKey(
                        name: "FK_dbo.ARTICULOS_POR_ORDEN_dbo.ORDEN_COMPRA_ID_ORDEN",
                        column: x => x.ID_ORDEN,
                        principalTable: "ORDEN_COMPRA",
                        principalColumn: "ID_ORDEN",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_dbo.ARTICULOS_POR_ORDEN_dbo.ARTICULOS_ID_ARTICULO_ID_PRODUCTO",
                        columns: x => new { x.ID_ARTICULO, x.ID_PRODUCTO },
                        principalTable: "ARTICULOS",
                        principalColumns: new[] { "ID_ARTICULO", "ID_PRODUCTO" },
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ARTICULOS_UNIDAD_VENTA",
                columns: table => new
                {
                    ID_UNIDAD_VENTA = table.Column<int>(nullable: false),
                    CANTIDAD = table.Column<int>(nullable: false),
                    ID_ARTICULO = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ID_ARTICULO_BASE = table.Column<int>(nullable: false),
                    ID_PRODUCTO = table.Column<int>(nullable: false),
                    ID_PRODUCTO_BASE = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ARTICULOS_UNIDAD_VENTA", x => x.ID_UNIDAD_VENTA);
                    table.ForeignKey(
                        name: "FK_dbo.ARTICULOS_UNIDAD_VENTA_dbo.ARTICULOS_ID_ARTICULO_ID_PRODUCTO",
                        columns: x => new { x.ID_ARTICULO, x.ID_PRODUCTO },
                        principalTable: "ARTICULOS",
                        principalColumns: new[] { "ID_ARTICULO", "ID_PRODUCTO" },
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_dbo.ARTICULOS_UNIDAD_VENTA_dbo.ARTICULOS_ID_ARTICULO_BASE_ID_PRODUCTO_BASE",
                        columns: x => new { x.ID_ARTICULO_BASE, x.ID_PRODUCTO_BASE },
                        principalTable: "ARTICULOS",
                        principalColumns: new[] { "ID_ARTICULO", "ID_PRODUCTO" },
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DETALLES_AJUSTE_INVENTARIO",
                columns: table => new
                {
                    ID_DETALLE_AJUSTE_INVENTARIO = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Cantidad = table.Column<int>(nullable: false),
                    ESTADO_REGISTRO = table.Column<bool>(nullable: false),
                    FECHA_ACTUALIZACION = table.Column<DateTime>(type: "datetime", nullable: true),
                    ID_AJUSTE_INVENTARIO = table.Column<int>(nullable: false),
                    ID_ARTICULO = table.Column<int>(nullable: false),
                    ID_PRODUCTO = table.Column<int>(nullable: false),
                    PORCENTAJE_IVA = table.Column<decimal>(nullable: false),
                    PRECIO_SIN_IVA = table.Column<decimal>(nullable: false),
                    TipoAjuste = table.Column<string>(maxLength: 20, nullable: false),
                    TIPO_AJUSTE = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DETALLES_AJUSTE_INVENTARIO", x => x.ID_DETALLE_AJUSTE_INVENTARIO);
                    table.ForeignKey(
                        name: "FK_dbo.DETALLES_AJUSTE_INVENTARIO_dbo.AJUSTES_INVENTARIO_ID_AJUSTE_INVENTARIO",
                        column: x => x.ID_AJUSTE_INVENTARIO,
                        principalTable: "AJUSTES_INVENTARIO",
                        principalColumn: "ID_AJUSTE_INVENTARIO",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_dbo.DETALLES_AJUSTE_INVENTARIO_dbo.ARTICULOS_ID_ARTICULO_ID_PRODUCTO",
                        columns: x => new { x.ID_ARTICULO, x.ID_PRODUCTO },
                        principalTable: "ARTICULOS",
                        principalColumns: new[] { "ID_ARTICULO", "ID_PRODUCTO" },
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DETALLES_ENTRADA_INVENTARIO",
                columns: table => new
                {
                    ID_DETALLE_ENTRADA_INVENTARIO = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Cantidad = table.Column<int>(nullable: false),
                    ESTADO_REGISTRO = table.Column<bool>(nullable: false),
                    FECHA_ACTUALIZACION = table.Column<DateTime>(type: "datetime", nullable: true),
                    FECHA_CREACION = table.Column<DateTime>(type: "datetime", nullable: true),
                    ID_ARTICULO = table.Column<int>(nullable: false),
                    ID_ENTRADA_INVENTARIO = table.Column<int>(nullable: false),
                    ID_FACTURA_COMPRA = table.Column<int>(nullable: false),
                    ID_PRODUCTO = table.Column<int>(nullable: false),
                    PORCENTAJE_IVA = table.Column<decimal>(nullable: false),
                    PRECIO_COMPRA_SIN_IVA = table.Column<decimal>(type: "decimal(14, 6)", nullable: false),
                    PRECIO_COMPRA_SIN_IVA_DESCUENTO = table.Column<decimal>(type: "decimal(14, 6)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DETALLES_ENTRADA_INVENTARIO", x => x.ID_DETALLE_ENTRADA_INVENTARIO);
                    table.ForeignKey(
                        name: "FK_dbo.DETALLES_ENTRADA_INVENTARIO_dbo.ENTRADAS_INVENTARIO_ID_ENTRADA_INVENTARIO",
                        column: x => x.ID_ENTRADA_INVENTARIO,
                        principalTable: "ENTRADAS_INVENTARIO",
                        principalColumn: "ID_ENTRADA_INVENTARIO",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_dbo.DETALLES_ENTRADA_INVENTARIO_dbo.FACTURAS_COMPRAS_ID_FACTURA_COMPRA",
                        column: x => x.ID_FACTURA_COMPRA,
                        principalTable: "FACTURAS_COMPRAS",
                        principalColumn: "ID_FACTURA_COMPRA",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_dbo.DETALLES_ENTRADA_INVENTARIO_dbo.ARTICULOS_ID_ARTICULO_ID_PRODUCTO",
                        columns: x => new { x.ID_ARTICULO, x.ID_PRODUCTO },
                        principalTable: "ARTICULOS",
                        principalColumns: new[] { "ID_ARTICULO", "ID_PRODUCTO" },
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "KEYWORDS_ARTICULOS",
                columns: table => new
                {
                    ARTICULOS_ID_ARTICULO = table.Column<int>(nullable: false),
                    ARTICULOS_ID_PRODUCTO = table.Column<int>(nullable: false),
                    PALABRAS_CLAVE_ID_PALABRA = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KEYWORDS_ARTICULOS", x => new { x.ARTICULOS_ID_ARTICULO, x.ARTICULOS_ID_PRODUCTO, x.PALABRAS_CLAVE_ID_PALABRA });
                    table.ForeignKey(
                        name: "FK_dbo.KEYWORDS_ARTICULOS_dbo.PALABRAS_CLAVE_PALABRAS_CLAVE_ID_PALABRA",
                        column: x => x.PALABRAS_CLAVE_ID_PALABRA,
                        principalTable: "PALABRAS_CLAVE",
                        principalColumn: "ID_PALABRA",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_dbo.KEYWORDS_ARTICULOS_dbo.ARTICULOS_ARTICULOS_ID_ARTICULO_ARTICULOS_ID_PRODUCTO",
                        columns: x => new { x.ARTICULOS_ID_ARTICULO, x.ARTICULOS_ID_PRODUCTO },
                        principalTable: "ARTICULOS",
                        principalColumns: new[] { "ID_ARTICULO", "ID_PRODUCTO" },
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PRECIOS",
                columns: table => new
                {
                    ID_PRECIO = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ESTADO_REGISTRO = table.Column<bool>(nullable: false),
                    FECHA_ACTUALIZACION = table.Column<DateTime>(type: "datetime", nullable: true),
                    FECHA_CREACION = table.Column<DateTime>(type: "datetime", nullable: true),
                    FECHA_VENCIMIENTO = table.Column<DateTime>(type: "datetime", nullable: true),
                    ID_ARTICULO = table.Column<int>(nullable: false),
                    ID_PRODUCTO = table.Column<int>(nullable: false),
                    MONEDA = table.Column<string>(maxLength: 3, nullable: false),
                    MONTO = table.Column<decimal>(nullable: false),
                    POR_DEFECTO = table.Column<bool>(nullable: false),
                    PRECIO_LINIO = table.Column<decimal>(nullable: true),
                    TIPO_CLIENTE1 = table.Column<string>(maxLength: 32, nullable: true),
                    TIPO_CLIENTE2 = table.Column<string>(maxLength: 32, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PRECIOS", x => x.ID_PRECIO);
                    table.ForeignKey(
                        name: "FK_dbo.PRECIOS_dbo.ARTICULOS_ID_ARTICULO_ID_PRODUCTO",
                        columns: x => new { x.ID_ARTICULO, x.ID_PRODUCTO },
                        principalTable: "ARTICULOS",
                        principalColumns: new[] { "ID_ARTICULO", "ID_PRODUCTO" },
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PRODUCTOS_RESPALDO",
                columns: table => new
                {
                    ID_RESPALDO = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ESTADO_REGISTRO = table.Column<bool>(nullable: false),
                    GENERO = table.Column<bool>(nullable: false),
                    ID_ARTICULO = table.Column<int>(nullable: false),
                    ID_ARTICULO_RES = table.Column<int>(nullable: false),
                    ID_PRODUCTO = table.Column<int>(nullable: false),
                    ID_PRODUCTO_RES = table.Column<int>(nullable: false),
                    PRIORIDAD = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PRODUCTOS_RESPALDO", x => x.ID_RESPALDO);
                    table.ForeignKey(
                        name: "FK_dbo.PRODUCTOS_RESPALDO_dbo.ARTICULOS_ID_ARTICULO_ID_PRODUCTO",
                        columns: x => new { x.ID_ARTICULO, x.ID_PRODUCTO },
                        principalTable: "ARTICULOS",
                        principalColumns: new[] { "ID_ARTICULO", "ID_PRODUCTO" },
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_dbo.PRODUCTOS_RESPALDO_dbo.ARTICULOS_ID_ARTICULO_RES_ID_PRODUCTO_RES",
                        columns: x => new { x.ID_ARTICULO_RES, x.ID_PRODUCTO_RES },
                        principalTable: "ARTICULOS",
                        principalColumns: new[] { "ID_ARTICULO", "ID_PRODUCTO" },
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "COSTO_ENVIO",
                columns: table => new
                {
                    ID_COSTO_ENVIO = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ESTADO_REGISTRO = table.Column<bool>(nullable: false),
                    FECHA_ACTUALIZACION = table.Column<DateTime>(type: "datetime", nullable: true),
                    FECHA_CREACION = table.Column<DateTime>(type: "datetime", nullable: true),
                    ID_CIUDAD = table.Column<int>(nullable: false),
                    PESO = table.Column<int>(nullable: false),
                    PRECIO = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_COSTO_ENVIO", x => x.ID_COSTO_ENVIO);
                    table.ForeignKey(
                        name: "FK_dbo.COSTO_ENVIO_dbo.CIUDADES_ID_CIUDAD",
                        column: x => x.ID_CIUDAD,
                        principalTable: "CIUDADES",
                        principalColumn: "ID_CIUDAD",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UBICACIONES",
                columns: table => new
                {
                    ID_UBICACION = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    BARRIO = table.Column<string>(maxLength: 32, nullable: true),
                    CODIGO_POSTAL = table.Column<string>(maxLength: 16, nullable: true),
                    COMPLEMENTO_DIRECCION = table.Column<string>(maxLength: 32, nullable: true),
                    COORDENADAS_GMAPS = table.Column<string>(nullable: true),
                    DEPARTAMENTO = table.Column<string>(maxLength: 32, nullable: true),
                    DIRECCION = table.Column<string>(maxLength: 120, nullable: false),
                    ESTADO_REGISTRO = table.Column<bool>(nullable: false),
                    ESTRATO = table.Column<int>(nullable: true),
                    FECHA_ACTUALIZACION = table.Column<DateTime>(type: "datetime", nullable: true),
                    FECHA_CREACION = table.Column<DateTime>(type: "datetime", nullable: true),
                    ID_CIUDAD = table.Column<int>(nullable: false),
                    LOCALIDAD = table.Column<string>(maxLength: 32, nullable: true),
                    RIESGO_ZONA = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UBICACIONES", x => x.ID_UBICACION);
                    table.ForeignKey(
                        name: "FK_dbo.UBICACIONES_dbo.CIUDADES_ID_CIUDAD",
                        column: x => x.ID_CIUDAD,
                        principalTable: "CIUDADES",
                        principalColumn: "ID_CIUDAD",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ARTICULOS_ATRIBUTOS_VALORES",
                columns: table => new
                {
                    ID_ARTICULO = table.Column<int>(nullable: false),
                    ID_PRODUCTO = table.Column<int>(nullable: false),
                    ID_ATRIBUTO = table.Column<int>(nullable: false),
                    ID_VALOR = table.Column<int>(nullable: false),
                    ESTADO_REGISTRO = table.Column<bool>(nullable: false),
                    FECHA_ACTUALIZACION = table.Column<DateTime>(type: "datetime", nullable: true),
                    FECHA_CREACION = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ARTICULOS_ATRIBUTOS_VALORES", x => new { x.ID_ARTICULO, x.ID_PRODUCTO, x.ID_ATRIBUTO, x.ID_VALOR });
                    table.ForeignKey(
                        name: "FK_dbo.ARTICULOS_ATRIBUTOS_VALORES_dbo.ATRIBUTOS_ARTICULOS_ID_ATRIBUTO",
                        column: x => x.ID_ATRIBUTO,
                        principalTable: "ATRIBUTOS_ARTICULOS",
                        principalColumn: "ID_ATRIBUTO",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_dbo.ARTICULOS_ATRIBUTOS_VALORES_dbo.VALOR_ATRIBUTO_ID_VALOR",
                        column: x => x.ID_VALOR,
                        principalTable: "VALOR_ATRIBUTO",
                        principalColumn: "ID_VALOR",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_dbo.ARTICULOS_ATRIBUTOS_VALORES_dbo.ARTICULOS_ID_ARTICULO_ID_PRODUCTO",
                        columns: x => new { x.ID_ARTICULO, x.ID_PRODUCTO },
                        principalTable: "ARTICULOS",
                        principalColumns: new[] { "ID_ARTICULO", "ID_PRODUCTO" },
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "BENEFICIARIOS_VALIDOS",
                columns: table => new
                {
                    ID_BENEFICIARIO = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CORREO_IDENTIFICACION = table.Column<string>(maxLength: 60, nullable: true),
                    ESTA_ACTIVO = table.Column<bool>(nullable: false),
                    ESTADO_REGISTRO = table.Column<bool>(nullable: false),
                    FECHA_ACTUALIZACION = table.Column<DateTime>(type: "datetime", nullable: false),
                    FECHA_CREACION = table.Column<DateTime>(type: "datetime", nullable: false),
                    ID_BENEFICIO = table.Column<int>(nullable: false),
                    NUMERO_IDENTIFICACION = table.Column<string>(maxLength: 40, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BENEFICIARIOS_VALIDOS", x => x.ID_BENEFICIARIO);
                    table.ForeignKey(
                        name: "FK_dbo.BENEFICIARIOS_VALIDOS_dbo.BENEFICIOS_ALIADOS_ID_BENEFICIO",
                        column: x => x.ID_BENEFICIO,
                        principalTable: "BENEFICIOS_ALIADOS",
                        principalColumn: "ID_BENEFICIO",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LISTAS_ESCOLARES",
                columns: table => new
                {
                    ID_LISTA = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ALERTA = table.Column<string>(maxLength: 600, nullable: true),
                    ANO_LISTA = table.Column<int>(nullable: true),
                    COD_UNICO_LISTAENCASA = table.Column<string>(maxLength: 64, nullable: true),
                    ESTADO_REGISTRO = table.Column<bool>(nullable: false),
                    FECHA_ACTUALIZACION = table.Column<DateTime>(type: "datetime", nullable: true),
                    FECHA_CREACION = table.Column<DateTime>(type: "datetime", nullable: true),
                    ID_CURSO = table.Column<int>(nullable: false),
                    ORIGEN = table.Column<string>(maxLength: 32, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LISTAS_ESCOLARES", x => x.ID_LISTA);
                    table.ForeignKey(
                        name: "FK_dbo.LISTAS_ESCOLARES_dbo.CURSOS_ID_CURSO",
                        column: x => x.ID_CURSO,
                        principalTable: "CURSOS",
                        principalColumn: "ID_CURSO",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TRAZABILIDAD_COMPRAS",
                columns: table => new
                {
                    ID_DETALLE_ENTRADA_INVENTARIO = table.Column<int>(nullable: false),
                    ID_DETALLE_ORDEN_COMPRA = table.Column<int>(nullable: false),
                    ESTADO_REGISTRO = table.Column<bool>(nullable: false),
                    FECHA_ACTUALIZACION = table.Column<DateTime>(type: "datetime", nullable: true),
                    FECHA_CREACION = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TRAZABILIDAD_COMPRAS", x => new { x.ID_DETALLE_ENTRADA_INVENTARIO, x.ID_DETALLE_ORDEN_COMPRA });
                    table.ForeignKey(
                        name: "FK_dbo.TRAZABILIDAD_COMPRAS_dbo.DETALLES_ENTRADA_INVENTARIO_ID_DETALLE_ENTRADA_INVENTARIO",
                        column: x => x.ID_DETALLE_ENTRADA_INVENTARIO,
                        principalTable: "DETALLES_ENTRADA_INVENTARIO",
                        principalColumn: "ID_DETALLE_ENTRADA_INVENTARIO",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_dbo.TRAZABILIDAD_COMPRAS_dbo.ARTICULOS_POR_ORDEN_ID_DETALLE_ORDEN_COMPRA",
                        column: x => x.ID_DETALLE_ORDEN_COMPRA,
                        principalTable: "ARTICULOS_POR_ORDEN",
                        principalColumn: "ID_DETALLE_ORDEN_COMPRA",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "BODEGAS",
                columns: table => new
                {
                    ID_BODEGA = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ESPECIFICACION = table.Column<string>(maxLength: 100, nullable: true),
                    ESTADO_REGISTRO = table.Column<bool>(nullable: false),
                    FECHA_ACTUALIZACION = table.Column<DateTime>(type: "datetime", nullable: true),
                    FECHA_CREACION = table.Column<DateTime>(type: "datetime", nullable: true),
                    ID_UBICACION = table.Column<int>(nullable: false),
                    NOMBRE_BODEGA = table.Column<string>(maxLength: 45, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BODEGAS", x => x.ID_BODEGA);
                    table.ForeignKey(
                        name: "FK_dbo.BODEGAS_dbo.UBICACIONES_ID_UBICACION",
                        column: x => x.ID_UBICACION,
                        principalTable: "UBICACIONES",
                        principalColumn: "ID_UBICACION",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PEDIDOS",
                columns: table => new
                {
                    ID_PEDIDO = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    COMENTARIO = table.Column<string>(maxLength: 255, nullable: true),
                    COSTO_ENVIO = table.Column<decimal>(nullable: true),
                    COSTO_MARCADO = table.Column<decimal>(nullable: true),
                    CURSO = table.Column<string>(maxLength: 50, nullable: true),
                    ESTADO_DE_PAGO = table.Column<string>(maxLength: 32, nullable: true),
                    ESTADO_DE_PEDIDO = table.Column<string>(maxLength: 32, nullable: true),
                    ESTADO_REGISTRO = table.Column<bool>(nullable: false),
                    FECHA_ACTUALIZACION = table.Column<DateTime>(type: "datetime", nullable: true),
                    FECHA_CLIENTE_CE = table.Column<DateTime>(type: "datetime", nullable: true),
                    FECHA_CREACION = table.Column<DateTime>(type: "datetime", nullable: true),
                    FECHA_PEDIDO = table.Column<DateTime>(type: "datetime", nullable: false),
                    ID_DESCUENTO = table.Column<int>(nullable: true),
                    ID_INDIVIDUO = table.Column<int>(nullable: false),
                    ID_ORDEN_COMPRA = table.Column<int>(nullable: true),
                    ID_UBICACION = table.Column<int>(nullable: false, defaultValueSql: "((1))"),
                    MEDIO_PAGO = table.Column<string>(maxLength: 32, nullable: true),
                    NOMBRE_ESTUDIANTE = table.Column<string>(maxLength: 120, nullable: true),
                    NOMBRE_MARCADO = table.Column<string>(maxLength: 100, nullable: true),
                    NUM_FACTURA = table.Column<string>(maxLength: 50, nullable: true),
                    TIPO_PAGO = table.Column<string>(maxLength: 32, nullable: true),
                    TOTAL = table.Column<decimal>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PEDIDOS", x => x.ID_PEDIDO);
                    table.ForeignKey(
                        name: "FK_dbo.PEDIDOS_dbo.DESCUENTOS_ID_DESCUENTO",
                        column: x => x.ID_DESCUENTO,
                        principalTable: "DESCUENTOS",
                        principalColumn: "ID_DESCUENTO",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_dbo.PEDIDOS_dbo.INDIVIDUOS_ID_INDIVIDUO",
                        column: x => x.ID_INDIVIDUO,
                        principalTable: "INDIVIDUOS",
                        principalColumn: "ID_INDIVIDUO",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_dbo.PEDIDOS_dbo.ORDEN_COMPRA_ID_ORDEN_COMPRA",
                        column: x => x.ID_ORDEN_COMPRA,
                        principalTable: "ORDEN_COMPRA",
                        principalColumn: "ID_ORDEN",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_dbo.PEDIDOS_dbo.UBICACIONES_ID_UBICACION",
                        column: x => x.ID_UBICACION,
                        principalTable: "UBICACIONES",
                        principalColumn: "ID_UBICACION",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SEDES",
                columns: table => new
                {
                    ID_SEDE = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ESTADO_REGISTRO = table.Column<bool>(nullable: false),
                    FECHA_ACTUALIZACION = table.Column<DateTime>(type: "datetime", nullable: true),
                    FECHA_CREACION = table.Column<DateTime>(type: "datetime", nullable: true),
                    FUNCION_ADICIONAL_1 = table.Column<string>(maxLength: 16, nullable: true),
                    FUNCION_ADICIONAL_2 = table.Column<string>(maxLength: 16, nullable: true),
                    FUNCION_ADICIONAL_3 = table.Column<string>(maxLength: 16, nullable: true),
                    FUNCION_PRINCIPAL = table.Column<string>(maxLength: 16, nullable: true),
                    ID_INDIVIDUO = table.Column<int>(nullable: true),
                    ID_UBICACION = table.Column<int>(nullable: false),
                    TIPO_SEDE = table.Column<string>(maxLength: 16, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SEDES", x => x.ID_SEDE);
                    table.ForeignKey(
                        name: "FK_dbo.SEDES_dbo.INDIVIDUOS_ID_INDIVIDUO",
                        column: x => x.ID_INDIVIDUO,
                        principalTable: "INDIVIDUOS",
                        principalColumn: "ID_INDIVIDUO",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_dbo.SEDES_dbo.UBICACIONES_ID_UBICACION",
                        column: x => x.ID_UBICACION,
                        principalTable: "UBICACIONES",
                        principalColumn: "ID_UBICACION",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UBIC_PERSONAS",
                columns: table => new
                {
                    UBICACIONES_ID_UBICACION = table.Column<int>(nullable: false),
                    PERSONAS_ID_INDIVIDUO = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UBIC_PERSONAS", x => new { x.UBICACIONES_ID_UBICACION, x.PERSONAS_ID_INDIVIDUO });
                    table.ForeignKey(
                        name: "FK_dbo.UBIC_PERSONAS_dbo.PERSONAS_PERSONAS_ID_INDIVIDUO",
                        column: x => x.PERSONAS_ID_INDIVIDUO,
                        principalTable: "PERSONAS",
                        principalColumn: "ID_INDIVIDUO",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_dbo.UBIC_PERSONAS_dbo.UBICACIONES_UBICACIONES_ID_UBICACION",
                        column: x => x.UBICACIONES_ID_UBICACION,
                        principalTable: "UBICACIONES",
                        principalColumn: "ID_UBICACION",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ARTICULOS_POR_LISTA",
                columns: table => new
                {
                    ID_ARTICULO = table.Column<int>(nullable: false),
                    ID_LISTA = table.Column<int>(nullable: false),
                    ID_PRODUCTO = table.Column<int>(nullable: false),
                    CANTIDAD = table.Column<int>(nullable: false),
                    ESTADO_REGISTRO = table.Column<bool>(nullable: false),
                    FECHA_ACTUALIZACION = table.Column<DateTime>(type: "datetime", nullable: true),
                    FECHA_CREACION = table.Column<DateTime>(type: "datetime", nullable: true),
                    OBLIGATORIO = table.Column<bool>(nullable: true),
                    SECUENCIA = table.Column<int>(nullable: true),
                    TIENE_MARCADO = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ARTICULOS_POR_LISTA", x => new { x.ID_ARTICULO, x.ID_LISTA, x.ID_PRODUCTO });
                    table.ForeignKey(
                        name: "FK_dbo.ARTICULOS_POR_LISTA_dbo.LISTAS_ESCOLARES_ID_LISTA",
                        column: x => x.ID_LISTA,
                        principalTable: "LISTAS_ESCOLARES",
                        principalColumn: "ID_LISTA",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_dbo.ARTICULOS_POR_LISTA_dbo.ARTICULOS_ID_ARTICULO_ID_PRODUCTO",
                        columns: x => new { x.ID_ARTICULO, x.ID_PRODUCTO },
                        principalTable: "ARTICULOS",
                        principalColumns: new[] { "ID_ARTICULO", "ID_PRODUCTO" },
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HISTORICO_LISTAS",
                columns: table => new
                {
                    FECHA_CAMBIO = table.Column<DateTime>(type: "datetime", nullable: false),
                    ID_LISTA = table.Column<int>(nullable: false),
                    ESTADO_REGISTRO = table.Column<bool>(nullable: false),
                    FECHA_ACTUALIZACION = table.Column<DateTime>(type: "datetime", nullable: true),
                    FECHA_CREACION = table.Column<DateTime>(type: "datetime", nullable: true),
                    FECHA_EST_PROX_CAMBIO = table.Column<DateTime>(type: "datetime", nullable: true),
                    REGISTRO_CAMBIOS = table.Column<string>(maxLength: 900, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HISTORICO_LISTAS", x => new { x.FECHA_CAMBIO, x.ID_LISTA });
                    table.ForeignKey(
                        name: "FK_dbo.HISTORICO_LISTAS_dbo.LISTAS_ESCOLARES_ID_LISTA",
                        column: x => x.ID_LISTA,
                        principalTable: "LISTAS_ESCOLARES",
                        principalColumn: "ID_LISTA",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ESTANTES",
                columns: table => new
                {
                    ID_ESTANTE = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AGRUPAMIENTO = table.Column<string>(maxLength: 20, nullable: true),
                    CODIGO_ESTANTE = table.Column<string>(maxLength: 20, nullable: false),
                    CONCEPTO = table.Column<string>(maxLength: 300, nullable: true),
                    ESTA_DISPONIBLE = table.Column<bool>(nullable: false),
                    ESTA_LLENO = table.Column<bool>(nullable: false),
                    ESTADO_REGISTRO = table.Column<bool>(nullable: false),
                    FECHA_ACTUALIZACION = table.Column<DateTime>(type: "datetime", nullable: true),
                    FECHA_CREACION = table.Column<DateTime>(type: "datetime", nullable: true),
                    ID_BODEGA = table.Column<int>(nullable: false),
                    RowVersion = table.Column<byte[]>(nullable: true),
                    TIPO_ESTANTE = table.Column<string>(maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ESTANTES", x => x.ID_ESTANTE);
                    table.ForeignKey(
                        name: "FK_dbo.ESTANTES_dbo.BODEGAS_ID_BODEGA",
                        column: x => x.ID_BODEGA,
                        principalTable: "BODEGAS",
                        principalColumn: "ID_BODEGA",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ARTICULOS_POR_INSTITUCION",
                columns: table => new
                {
                    ID_ARTICULO = table.Column<int>(nullable: false),
                    ID_INDIVIDUO = table.Column<int>(nullable: false),
                    ID_PRODUCTO = table.Column<int>(nullable: false),
                    ID_PEDIDO = table.Column<int>(nullable: false),
                    CANTIDAD = table.Column<int>(nullable: false),
                    ESTADO_REGISTRO = table.Column<bool>(nullable: false),
                    FECHA_ACTUALIZACION = table.Column<DateTime>(type: "datetime", nullable: true),
                    FECHA_CREACION = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ARTICULOS_POR_INSTITUCION", x => new { x.ID_ARTICULO, x.ID_INDIVIDUO, x.ID_PRODUCTO, x.ID_PEDIDO });
                    table.ForeignKey(
                        name: "FK_dbo.ARTICULOS_POR_INSTITUCION_dbo.INDIVIDUOS_ID_INDIVIDUO",
                        column: x => x.ID_INDIVIDUO,
                        principalTable: "INDIVIDUOS",
                        principalColumn: "ID_INDIVIDUO",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_dbo.ARTICULOS_POR_INSTITUCION_dbo.PEDIDOS_ID_PEDIDO",
                        column: x => x.ID_PEDIDO,
                        principalTable: "PEDIDOS",
                        principalColumn: "ID_PEDIDO",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_dbo.ARTICULOS_POR_INSTITUCION_dbo.ARTICULOS_ID_ARTICULO_ID_PRODUCTO",
                        columns: x => new { x.ID_ARTICULO, x.ID_PRODUCTO },
                        principalTable: "ARTICULOS",
                        principalColumns: new[] { "ID_ARTICULO", "ID_PRODUCTO" },
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ARTICULOS_POR_PEDIDO",
                columns: table => new
                {
                    ID_ARTICULO = table.Column<int>(nullable: false),
                    ID_PEDIDO = table.Column<int>(nullable: false),
                    ID_PRODUCTO = table.Column<int>(nullable: false),
                    CANTIDAD = table.Column<int>(nullable: false),
                    ESTADO_REGISTRO = table.Column<bool>(nullable: false),
                    FECHA_ACTUALIZACION = table.Column<DateTime>(type: "datetime", nullable: true),
                    FECHA_CREACION = table.Column<DateTime>(type: "datetime", nullable: true),
                    PRECIO_CON_IVA = table.Column<decimal>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ARTICULOS_POR_PEDIDO", x => new { x.ID_ARTICULO, x.ID_PEDIDO, x.ID_PRODUCTO });
                    table.ForeignKey(
                        name: "FK_dbo.ARTICULOS_POR_PEDIDO_dbo.PEDIDOS_ID_PEDIDO",
                        column: x => x.ID_PEDIDO,
                        principalTable: "PEDIDOS",
                        principalColumn: "ID_PEDIDO",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_dbo.ARTICULOS_POR_PEDIDO_dbo.ARTICULOS_ID_ARTICULO_ID_PRODUCTO",
                        columns: x => new { x.ID_ARTICULO, x.ID_PRODUCTO },
                        principalTable: "ARTICULOS",
                        principalColumns: new[] { "ID_ARTICULO", "ID_PRODUCTO" },
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DETALLES_LISTA_PEDIDO",
                columns: table => new
                {
                    ID_DETALLE_LISTA_PEDIDO = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ESTADO_REGISTRO = table.Column<DateTime>(type: "datetime", nullable: false),
                    EstadoRegistro = table.Column<bool>(nullable: false),
                    FECHA_ACTUALIZACION = table.Column<DateTime>(type: "datetime", nullable: false),
                    ID_LISTA = table.Column<int>(nullable: true),
                    ID_PEDIDO = table.Column<int>(nullable: false),
                    NOMBRE_MARCADO = table.Column<string>(maxLength: 35, nullable: true),
                    TIENE_MARCADO = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DETALLES_LISTA_PEDIDO", x => x.ID_DETALLE_LISTA_PEDIDO);
                    table.ForeignKey(
                        name: "FK_dbo.DETALLES_LISTA_PEDIDO_dbo.LISTAS_ESCOLARES_ID_LISTA",
                        column: x => x.ID_LISTA,
                        principalTable: "LISTAS_ESCOLARES",
                        principalColumn: "ID_LISTA",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_dbo.DETALLES_LISTA_PEDIDO_dbo.PEDIDOS_ID_PEDIDO",
                        column: x => x.ID_PEDIDO,
                        principalTable: "PEDIDOS",
                        principalColumn: "ID_PEDIDO",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FACTURAS_VENTAS",
                columns: table => new
                {
                    ID_FACTURA_VENTA = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    COMENTARIO = table.Column<string>(maxLength: 900, nullable: true),
                    DIAS_A_PAGAR = table.Column<int>(nullable: true),
                    ES_LEGAL = table.Column<bool>(nullable: false),
                    ESTADO_PAGO = table.Column<string>(maxLength: 20, nullable: false),
                    ESTADO_REGISTRO = table.Column<bool>(nullable: false),
                    FECHA_ACTUALIZACION = table.Column<DateTime>(type: "datetime", nullable: true),
                    FECHA_CREACION = table.Column<DateTime>(type: "datetime", nullable: true),
                    FECHA_VENTA = table.Column<DateTime>(type: "datetime", nullable: false),
                    ID_CLIENTE = table.Column<int>(nullable: false),
                    ID_FACTURA_GENERADA = table.Column<int>(nullable: true),
                    ID_PEDIDO = table.Column<int>(nullable: true),
                    ID_RESOLUCION = table.Column<int>(nullable: true),
                    NOMBRE_ARCHIVO = table.Column<string>(nullable: true),
                    TOTAL_IVA_FACTURA = table.Column<decimal>(nullable: false),
                    VALOR_DESCUENTO = table.Column<decimal>(nullable: false, defaultValueSql: "((0))"),
                    VALOR_ENVIO = table.Column<decimal>(nullable: true),
                    VALOR_MARCADO = table.Column<decimal>(nullable: false, defaultValueSql: "((0))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FACTURAS_VENTAS", x => x.ID_FACTURA_VENTA);
                    table.ForeignKey(
                        name: "FK_dbo.FACTURAS_VENTAS_dbo.PERSONAS_ID_PEDIDO",
                        column: x => x.ID_CLIENTE,
                        principalTable: "PERSONAS",
                        principalColumn: "ID_INDIVIDUO",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_dbo.FACTURAS_VENTAS_dbo.PEDIDOS_IdPedido",
                        column: x => x.ID_PEDIDO,
                        principalTable: "PEDIDOS",
                        principalColumn: "ID_PEDIDO",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PEDIDO_INFO_PAYU",
                columns: table => new
                {
                    ID_PEDIDO_INFO = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CODIGO_AUTORIZACION_VENTA = table.Column<string>(maxLength: 12, nullable: true),
                    CODIGO_REFERENCIA = table.Column<string>(maxLength: 50, nullable: false),
                    CODIGO_SEGUIMIENTO = table.Column<string>(maxLength: 64, nullable: true),
                    CUOTAS = table.Column<int>(nullable: true),
                    DESCRIPCIÓN = table.Column<string>(maxLength: 255, nullable: true),
                    ESTADO_REGISTRO = table.Column<bool>(nullable: false),
                    FECHA_PAGO = table.Column<DateTime>(type: "datetime", nullable: true),
                    ID_PEDIDO = table.Column<int>(nullable: false),
                    IMPUESTO_TX = table.Column<decimal>(nullable: true),
                    IVA = table.Column<decimal>(nullable: false, defaultValueSql: "((0))"),
                    LAP_RESPONSE_CODE = table.Column<string>(maxLength: 64, nullable: true),
                    MENSAJE_TRANSACCION = table.Column<string>(maxLength: 255, nullable: true),
                    MONEDA = table.Column<string>(maxLength: 3, nullable: true),
                    POL_RESPONSE_CODE = table.Column<string>(maxLength: 64, nullable: true),
                    POL_TRANSACTION_STATE = table.Column<string>(maxLength: 32, nullable: true),
                    PSE_CODIGO_SEGUIMIENTO = table.Column<string>(maxLength: 255, nullable: true),
                    PSE_ID = table.Column<int>(nullable: true),
                    PSE_REFERENCE1 = table.Column<string>(maxLength: 255, nullable: true),
                    PSE_REFERENCE2 = table.Column<string>(maxLength: 255, nullable: true),
                    PSE_REFERENCE3 = table.Column<string>(maxLength: 255, nullable: true),
                    REFERENCE_POL = table.Column<string>(maxLength: 255, nullable: true),
                    RIESGO = table.Column<decimal>(nullable: true),
                    TARIFA_ADMINISTRATIVA_TX = table.Column<decimal>(nullable: true),
                    TELEFONO_USUARIO_PAGO = table.Column<string>(maxLength: 20, nullable: true),
                    TRANSACCION_ID = table.Column<string>(maxLength: 36, nullable: true),
                    VALOR_BASE_TX = table.Column<decimal>(nullable: true),
                    VALOR_PAGADO = table.Column<decimal>(nullable: false, defaultValueSql: "((0))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PEDIDO_INFO_PAYU", x => x.ID_PEDIDO_INFO);
                    table.ForeignKey(
                        name: "FK_dbo.PEDIDO_INFO_PAYU_dbo.PEDIDOS_ID_PEDIDO",
                        column: x => x.ID_PEDIDO,
                        principalTable: "PEDIDOS",
                        principalColumn: "ID_PEDIDO",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ARTICULOS_ENTRADOS_ESTANTES",
                columns: table => new
                {
                    ID_DETALLE_ENTRADA_INVENTARIO = table.Column<int>(nullable: false),
                    ID_ESTANTE = table.Column<int>(nullable: false),
                    ESTADO_REGISTRO = table.Column<bool>(nullable: false),
                    FECHA_ACTUALIZACION = table.Column<DateTime>(type: "datetime", nullable: true),
                    FECHA_CREACION = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ARTICULOS_ENTRADOS_ESTANTES", x => new { x.ID_DETALLE_ENTRADA_INVENTARIO, x.ID_ESTANTE });
                    table.ForeignKey(
                        name: "FK_dbo.ARTICULOS_ENTRADOS_ESTANTES_dbo.DETALLES_ENTRADA_INVENTARIO_ID_DETALLE_ENTRADA_INVENTARIO",
                        column: x => x.ID_DETALLE_ENTRADA_INVENTARIO,
                        principalTable: "DETALLES_ENTRADA_INVENTARIO",
                        principalColumn: "ID_DETALLE_ENTRADA_INVENTARIO",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_dbo.ARTICULOS_ENTRADOS_ESTANTES_dbo.ESTANTES_ID_ESTANTE",
                        column: x => x.ID_ESTANTE,
                        principalTable: "ESTANTES",
                        principalColumn: "ID_ESTANTE",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ARTICULOS_DETALLES_LISTA_PEDIDO",
                columns: table => new
                {
                    ID_DETALLE_PEDIDO = table.Column<int>(nullable: false),
                    ID_ARTICULO = table.Column<int>(nullable: false),
                    ID_PRODUCTO = table.Column<int>(nullable: false),
                    CANTIDAD = table.Column<int>(nullable: false),
                    ESTADO_REGISTRO = table.Column<DateTime>(type: "datetime", nullable: false),
                    EstadoRegistro = table.Column<bool>(nullable: false),
                    FECHA_ACTUALIZACION = table.Column<DateTime>(type: "datetime", nullable: false),
                    TIENE_MARCADO = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ARTICULOS_DETALLES_LISTA_PEDIDO", x => new { x.ID_DETALLE_PEDIDO, x.ID_ARTICULO, x.ID_PRODUCTO });
                    table.ForeignKey(
                        name: "FK_dbo.ARTICULOS_DETALLES_LISTA_PEDIDO_dbo.DETALLES_LISTA_PEDIDO_ID_DETALLE_PEDIDO",
                        column: x => x.ID_DETALLE_PEDIDO,
                        principalTable: "DETALLES_LISTA_PEDIDO",
                        principalColumn: "ID_DETALLE_LISTA_PEDIDO",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_dbo.ARTICULOS_DETALLES_LISTA_PEDIDO_dbo.ARTICULOS_ID_ARTICULO_ID_PRODUCTO",
                        columns: x => new { x.ID_ARTICULO, x.ID_PRODUCTO },
                        principalTable: "ARTICULOS",
                        principalColumns: new[] { "ID_ARTICULO", "ID_PRODUCTO" },
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ARTICULOS_POR_FACTURA_VENTA",
                columns: table => new
                {
                    ID_ARTICULO = table.Column<int>(nullable: false),
                    ID_FACTURA_VENTA = table.Column<int>(nullable: false),
                    ID_PRODUCTO = table.Column<int>(nullable: false),
                    CANTIDAD = table.Column<int>(nullable: false),
                    ESTADO_REGISTRO = table.Column<bool>(nullable: false),
                    FECHA_ACTUALIZACION = table.Column<DateTime>(type: "datetime", nullable: true),
                    FECHA_CREACION = table.Column<DateTime>(type: "datetime", nullable: true),
                    PRECIO_CON_IVA = table.Column<decimal>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ARTICULOS_POR_FACTURA_VENTA", x => new { x.ID_ARTICULO, x.ID_FACTURA_VENTA, x.ID_PRODUCTO });
                    table.ForeignKey(
                        name: "FK_dbo.ARTICULOS_POR_FACTURA_VENTA_dbo.FACTURAS_VENTAS_ID_FACTURA_VENTA",
                        column: x => x.ID_FACTURA_VENTA,
                        principalTable: "FACTURAS_VENTAS",
                        principalColumn: "ID_FACTURA_VENTA",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_dbo.ARTICULOS_POR_FACTURA_VENTA_dbo.ARTICULOS_ID_ARTICULO_ID_PRODUCTO",
                        columns: x => new { x.ID_ARTICULO, x.ID_PRODUCTO },
                        principalTable: "ARTICULOS",
                        principalColumns: new[] { "ID_ARTICULO", "ID_PRODUCTO" },
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DETALLES_SALIDA_INVENTARIO",
                columns: table => new
                {
                    ID_DETALLE_SALIDA_INVENTARIO = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Cantidad = table.Column<int>(nullable: false),
                    ESTADO_REGISTRO = table.Column<bool>(nullable: false),
                    FECHA_ACTUALIZACION = table.Column<DateTime>(type: "datetime", nullable: true),
                    FECHA_CREACION = table.Column<DateTime>(type: "datetime", nullable: true),
                    ID_ARTICULO = table.Column<int>(nullable: false),
                    ID_FACTURA_VENTA = table.Column<int>(nullable: false),
                    ID_PRODUCTO = table.Column<int>(nullable: false),
                    ID_SALIDA_INVENTARIO = table.Column<int>(nullable: false),
                    PORCENTAJE_IVA = table.Column<decimal>(nullable: false),
                    PRECIO_VENTA_SIN_IVA = table.Column<decimal>(type: "decimal(13, 6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DETALLES_SALIDA_INVENTARIO", x => x.ID_DETALLE_SALIDA_INVENTARIO);
                    table.ForeignKey(
                        name: "FK_dbo.DETALLES_SALIDA_INVENTARIO_dbo.FACTURAS_VENTAS_ID_FACTURA_VENTA",
                        column: x => x.ID_FACTURA_VENTA,
                        principalTable: "FACTURAS_VENTAS",
                        principalColumn: "ID_FACTURA_VENTA",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_dbo.DETALLES_SALIDA_INVENTARIO_dbo.SALIDAS_INVENTARIO_ID_SALIDA_INVENTARIO",
                        column: x => x.ID_SALIDA_INVENTARIO,
                        principalTable: "SALIDAS_INVENTARIO",
                        principalColumn: "ID_SALIDA_INVENTARIO",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_dbo.DETALLES_SALIDA_INVENTARIO_dbo.ARTICULOS_ID_ARTICULO_ID_PRODUCTO",
                        columns: x => new { x.ID_ARTICULO, x.ID_PRODUCTO },
                        principalTable: "ARTICULOS",
                        principalColumns: new[] { "ID_ARTICULO", "ID_PRODUCTO" },
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ARTICULOS_PEDIDOS_FACTURAS_VENTA",
                columns: table => new
                {
                    ID_CAMBIO = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ESTADO_REGISTRO = table.Column<bool>(nullable: false),
                    FECHA_ACTUALIZACION = table.Column<DateTime>(type: "datetime", nullable: true),
                    FECHA_CREACION = table.Column<DateTime>(type: "datetime", nullable: true),
                    ID_ARTICULO = table.Column<int>(nullable: false),
                    ID_ARTICULO_CAMBIO = table.Column<int>(nullable: false),
                    ID_FACTURA = table.Column<int>(nullable: false),
                    ID_PEDIDO = table.Column<int>(nullable: false),
                    ID_PRODUCTO = table.Column<int>(nullable: false),
                    ID_PRODUCTO_CAMBIO = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ARTICULOS_PEDIDOS_FACTURAS_VENTA", x => x.ID_CAMBIO);
                    table.ForeignKey(
                        name: "FK_dbo.ARTICULOS_PEDIDOS_FACTURAS_VENTA_dbo.ARTICULOS_POR_PEDIDO_ID_ARTICULO_ID_PRODUCTO_ID_PEDIDO",
                        columns: x => new { x.ID_ARTICULO, x.ID_PEDIDO, x.ID_PRODUCTO },
                        principalTable: "ARTICULOS_POR_PEDIDO",
                        principalColumns: new[] { "ID_ARTICULO", "ID_PEDIDO", "ID_PRODUCTO" },
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_dbo.ARTICULOS_PEDIDOS_FACTURAS_VENTA_dbo.ARTICULOS_POR_FACTURA_VENTA_ID_ARTICULO_CAMBIO_ID_PRODUCTO_CAMBIO_ID_FACTURA",
                        columns: x => new { x.ID_ARTICULO_CAMBIO, x.ID_FACTURA, x.ID_PRODUCTO_CAMBIO },
                        principalTable: "ARTICULOS_POR_FACTURA_VENTA",
                        principalColumns: new[] { "ID_ARTICULO", "ID_FACTURA_VENTA", "ID_PRODUCTO" },
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ID_PRODUCTO",
                table: "ARTICULOS",
                column: "ID_PRODUCTO");

            migrationBuilder.CreateIndex(
                name: "IX_ID_ATRIBUTO",
                table: "ARTICULOS_ATRIBUTOS_VALORES",
                column: "ID_ATRIBUTO");

            migrationBuilder.CreateIndex(
                name: "IX_ID_VALOR",
                table: "ARTICULOS_ATRIBUTOS_VALORES",
                column: "ID_VALOR");

            migrationBuilder.CreateIndex(
                name: "IX_ID_ARTICULO_ID_PRODUCTO",
                table: "ARTICULOS_ATRIBUTOS_VALORES",
                columns: new[] { "ID_ARTICULO", "ID_PRODUCTO" });

            migrationBuilder.CreateIndex(
                name: "IX_ID_CARRITO",
                table: "ARTICULOS_CARRITO_COMPRA",
                column: "ID_CARRITO");

            migrationBuilder.CreateIndex(
                name: "IX_ID_CARRITO",
                table: "ARTICULOS_CARRITO_COMPRA_PREPEDIDO",
                column: "ID_CARRITO");

            migrationBuilder.CreateIndex(
                name: "IX_ID_DETALLE_PEDIDO",
                table: "ARTICULOS_DETALLES_LISTA_PEDIDO",
                column: "ID_DETALLE_PEDIDO");

            migrationBuilder.CreateIndex(
                name: "IX_ID_ARTICULO_ID_PRODUCTO",
                table: "ARTICULOS_DETALLES_LISTA_PEDIDO",
                columns: new[] { "ID_ARTICULO", "ID_PRODUCTO" });

            migrationBuilder.CreateIndex(
                name: "IX_ID_DETALLE_ENTRADA_INVENTARIO",
                table: "ARTICULOS_ENTRADOS_ESTANTES",
                column: "ID_DETALLE_ENTRADA_INVENTARIO");

            migrationBuilder.CreateIndex(
                name: "IX_ID_ESTANTE",
                table: "ARTICULOS_ENTRADOS_ESTANTES",
                column: "ID_ESTANTE");

            migrationBuilder.CreateIndex(
                name: "IX_ID_ARTICULO_ID_PEDIDO_ID_PRODUCTO",
                table: "ARTICULOS_PEDIDOS_FACTURAS_VENTA",
                columns: new[] { "ID_ARTICULO", "ID_PEDIDO", "ID_PRODUCTO" });

            migrationBuilder.CreateIndex(
                name: "IX_ID_ARTICULO_CAMBIO_ID_FACTURA_ID_PRODUCTO_CAMBIO",
                table: "ARTICULOS_PEDIDOS_FACTURAS_VENTA",
                columns: new[] { "ID_ARTICULO_CAMBIO", "ID_FACTURA", "ID_PRODUCTO_CAMBIO" });

            migrationBuilder.CreateIndex(
                name: "IX_ID_FACTURA_COMPRA",
                table: "ARTICULOS_POR_FACTURA_COMPRA",
                column: "ID_FACTURA_COMPRA");

            migrationBuilder.CreateIndex(
                name: "IX_ID_ARTICULO_ID_PRODUCTO",
                table: "ARTICULOS_POR_FACTURA_COMPRA",
                columns: new[] { "ID_ARTICULO", "ID_PRODUCTO" });

            migrationBuilder.CreateIndex(
                name: "IX_ID_FACTURA_VENTA",
                table: "ARTICULOS_POR_FACTURA_VENTA",
                column: "ID_FACTURA_VENTA");

            migrationBuilder.CreateIndex(
                name: "IX_ID_ARTICULO_ID_PRODUCTO",
                table: "ARTICULOS_POR_FACTURA_VENTA",
                columns: new[] { "ID_ARTICULO", "ID_PRODUCTO" });

            migrationBuilder.CreateIndex(
                name: "IX_ID_INDIVIDUO",
                table: "ARTICULOS_POR_INSTITUCION",
                column: "ID_INDIVIDUO");

            migrationBuilder.CreateIndex(
                name: "IX_ID_PEDIDO",
                table: "ARTICULOS_POR_INSTITUCION",
                column: "ID_PEDIDO");

            migrationBuilder.CreateIndex(
                name: "IX_ID_ARTICULO_ID_PRODUCTO",
                table: "ARTICULOS_POR_INSTITUCION",
                columns: new[] { "ID_ARTICULO", "ID_PRODUCTO" });

            migrationBuilder.CreateIndex(
                name: "IX_ID_PRE_PEDIDO",
                table: "ARTICULOS_POR_INSTITUCION_PRE_PEDIDO",
                column: "ID_PRE_PEDIDO");

            migrationBuilder.CreateIndex(
                name: "IX_ID_LISTA",
                table: "ARTICULOS_POR_LISTA",
                column: "ID_LISTA");

            migrationBuilder.CreateIndex(
                name: "IX_ID_ARTICULO_ID_PRODUCTO",
                table: "ARTICULOS_POR_LISTA",
                columns: new[] { "ID_ARTICULO", "ID_PRODUCTO" });

            migrationBuilder.CreateIndex(
                name: "IX_ID_ORDEN",
                table: "ARTICULOS_POR_ORDEN",
                column: "ID_ORDEN");

            migrationBuilder.CreateIndex(
                name: "IX_ID_ARTICULO_ID_PRODUCTO",
                table: "ARTICULOS_POR_ORDEN",
                columns: new[] { "ID_ARTICULO", "ID_PRODUCTO" });

            migrationBuilder.CreateIndex(
                name: "IX_ID_PEDIDO",
                table: "ARTICULOS_POR_PEDIDO",
                column: "ID_PEDIDO");

            migrationBuilder.CreateIndex(
                name: "IX_ID_ARTICULO_ID_PRODUCTO",
                table: "ARTICULOS_POR_PEDIDO",
                columns: new[] { "ID_ARTICULO", "ID_PRODUCTO" });

            migrationBuilder.CreateIndex(
                name: "IX_ID_PRE_PEDIDO",
                table: "ARTICULOS_PRE_PEDIDO",
                column: "ID_PRE_PEDIDO");

            migrationBuilder.CreateIndex(
                name: "IX_ID_ARTICULO_ID_PRODUCTO",
                table: "ARTICULOS_UNIDAD_VENTA",
                columns: new[] { "ID_ARTICULO", "ID_PRODUCTO" });

            migrationBuilder.CreateIndex(
                name: "IX_ID_ARTICULO_BASE_ID_PRODUCTO_BASE",
                table: "ARTICULOS_UNIDAD_VENTA",
                columns: new[] { "ID_ARTICULO_BASE", "ID_PRODUCTO_BASE" });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_ID_INDIVIDUO",
                table: "ATRIBS_INSTITUCIONES",
                column: "ID_INDIVIDUO",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ID_TIPO",
                table: "ATRIBUTOS_ARTICULOS",
                column: "ID_TIPO");

            migrationBuilder.CreateIndex(
                name: "IX_ID_UNID_VENTA",
                table: "ATRIBUTOS_ARTICULOS",
                column: "ID_UNID_VENTA");

            migrationBuilder.CreateIndex(
                name: "IX_ID_BENEFICIO",
                table: "BENEFICIARIOS_VALIDOS",
                column: "ID_BENEFICIO");

            migrationBuilder.CreateIndex(
                name: "IX_ID_CODIGO_DESCUENTO",
                table: "BENEFICIOS_ALIADOS",
                column: "ID_CODIGO_DESCUENTO");

            migrationBuilder.CreateIndex(
                name: "IX_ID_INDIVIDUO",
                table: "BENEFICIOS_ALIADOS",
                column: "ID_INDIVIDUO");

            migrationBuilder.CreateIndex(
                name: "IX_ID_UBICACION",
                table: "BODEGAS",
                column: "ID_UBICACION");

            migrationBuilder.CreateIndex(
                name: "IX_ID_INFORMACION_USUARIO",
                table: "CARRITO_COMPRA_PREPEDIDO",
                column: "ID_INFORMACION_USUARIO");

            migrationBuilder.CreateIndex(
                name: "IX_ID_CATEGORIA_HIJO",
                table: "CATEGORIA_CATEGORIAS",
                column: "ID_CATEGORIA_HIJO");

            migrationBuilder.CreateIndex(
                name: "IX_ID_CATEGORIA_PADRE",
                table: "CATEGORIA_CATEGORIAS",
                column: "ID_CATEGORIA_PADRE");

            migrationBuilder.CreateIndex(
                name: "IX_CATEGORIAS_ID_CATEGORIA",
                table: "CATEGORIA_PROD",
                column: "CATEGORIAS_ID_CATEGORIA");

            migrationBuilder.CreateIndex(
                name: "IX_PRODUCTOS_ID_PRODUCTO",
                table: "CATEGORIA_PROD",
                column: "PRODUCTOS_ID_PRODUCTO");

            migrationBuilder.CreateIndex(
                name: "IX_ID_CATEGORIA",
                table: "CATEGORIAS_CATEGORIAS_CONTABLE",
                column: "ID_CATEGORIA");

            migrationBuilder.CreateIndex(
                name: "IX_ID_CATEGORIA_CONTABLE",
                table: "CATEGORIAS_CATEGORIAS_CONTABLE",
                column: "ID_CATEGORIA_CONTABLE");

            migrationBuilder.CreateIndex(
                name: "IX_ID_REGION",
                table: "CIUDADES",
                column: "ID_REGION");

            migrationBuilder.CreateIndex(
                name: "IX_ID_CIUDAD",
                table: "COSTO_ENVIO",
                column: "ID_CIUDAD");

            migrationBuilder.CreateIndex(
                name: "IX_ID_INDIVIDUO",
                table: "CURSOS",
                column: "ID_INDIVIDUO");

            migrationBuilder.CreateIndex(
                name: "IX_ID_PRODUCTO",
                table: "DESCRIPCION_PRODUCTO",
                column: "ID_PRODUCTO");

            migrationBuilder.CreateIndex(
                name: "IX_ID_CAMPANA",
                table: "DESCUENTOS",
                column: "ID_CAMPANA");

            migrationBuilder.CreateIndex(
                name: "IX_ID_DESCUENTO",
                table: "DESCUENTOS_USADOS",
                column: "ID_DESCUENTO");

            migrationBuilder.CreateIndex(
                name: "IX_ID_AJUSTE_INVENTARIO",
                table: "DETALLES_AJUSTE_INVENTARIO",
                column: "ID_AJUSTE_INVENTARIO");

            migrationBuilder.CreateIndex(
                name: "IX_ID_ARTICULO_ID_PRODUCTO",
                table: "DETALLES_AJUSTE_INVENTARIO",
                columns: new[] { "ID_ARTICULO", "ID_PRODUCTO" });

            migrationBuilder.CreateIndex(
                name: "IX_ID_ENTRADA_INVENTARIO",
                table: "DETALLES_ENTRADA_INVENTARIO",
                column: "ID_ENTRADA_INVENTARIO");

            migrationBuilder.CreateIndex(
                name: "IX_ID_FACTURA_COMPRA",
                table: "DETALLES_ENTRADA_INVENTARIO",
                column: "ID_FACTURA_COMPRA");

            migrationBuilder.CreateIndex(
                name: "IX_ID_ARTICULO_ID_PRODUCTO",
                table: "DETALLES_ENTRADA_INVENTARIO",
                columns: new[] { "ID_ARTICULO", "ID_PRODUCTO" });

            migrationBuilder.CreateIndex(
                name: "IX_ID_LISTA",
                table: "DETALLES_LISTA_PEDIDO",
                column: "ID_LISTA");

            migrationBuilder.CreateIndex(
                name: "IX_ID_PEDIDO",
                table: "DETALLES_LISTA_PEDIDO",
                column: "ID_PEDIDO");

            migrationBuilder.CreateIndex(
                name: "IX_ID_FACTURA_VENTA",
                table: "DETALLES_SALIDA_INVENTARIO",
                column: "ID_FACTURA_VENTA");

            migrationBuilder.CreateIndex(
                name: "IX_ID_SALIDA_INVENTARIO",
                table: "DETALLES_SALIDA_INVENTARIO",
                column: "ID_SALIDA_INVENTARIO");

            migrationBuilder.CreateIndex(
                name: "IX_ID_ARTICULO_ID_PRODUCTO",
                table: "DETALLES_SALIDA_INVENTARIO",
                columns: new[] { "ID_ARTICULO", "ID_PRODUCTO" });

            migrationBuilder.CreateIndex(
                name: "IX_ID_INDIVIDUO",
                table: "ESTADISTICAS_ICFES",
                column: "ID_INDIVIDUO");

            migrationBuilder.CreateIndex(
                name: "IX_ID_BODEGA",
                table: "ESTANTES",
                column: "ID_BODEGA");

            migrationBuilder.CreateIndex(
                name: "IX_ID_INDIVIDUO",
                table: "FACTURAS_COMPRAS",
                column: "ID_INDIVIDUO");

            migrationBuilder.CreateIndex(
                name: "IX_ID_CLIENTE",
                table: "FACTURAS_VENTAS",
                column: "ID_CLIENTE");

            migrationBuilder.CreateIndex(
                name: "IX_ID_PEDIDO",
                table: "FACTURAS_VENTAS",
                column: "ID_PEDIDO");

            migrationBuilder.CreateIndex(
                name: "IX_ID_LISTA",
                table: "HISTORICO_LISTAS",
                column: "ID_LISTA");

            migrationBuilder.CreateIndex(
                name: "IX_ID_POST",
                table: "IMAGENES_POST",
                column: "ID_POST");

            migrationBuilder.CreateIndex(
                name: "IX_ID_DESCUENTO",
                table: "INSTITUCIONES",
                column: "ID_DESCUENTO");

            migrationBuilder.CreateIndex(
                name: "IX_ID_INDIVIDUO",
                table: "INSTITUCIONES",
                column: "ID_INDIVIDUO",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_PALABRAS_CLAVE_ID_PALABRA",
                table: "KEYWORDS_ARTICULOS",
                column: "PALABRAS_CLAVE_ID_PALABRA");

            migrationBuilder.CreateIndex(
                name: "IX_ARTICULOS_ID_ARTICULO_ARTICULOS_ID_PRODUCTO",
                table: "KEYWORDS_ARTICULOS",
                columns: new[] { "ARTICULOS_ID_ARTICULO", "ARTICULOS_ID_PRODUCTO" });

            migrationBuilder.CreateIndex(
                name: "IX_CATEGORIAS_ID_CATEGORIA",
                table: "KEYWORDS_CATEGORIAS",
                column: "CATEGORIAS_ID_CATEGORIA");

            migrationBuilder.CreateIndex(
                name: "IX_PALABRAS_CLAVE_ID_PALABRA",
                table: "KEYWORDS_CATEGORIAS",
                column: "PALABRAS_CLAVE_ID_PALABRA");

            migrationBuilder.CreateIndex(
                name: "IX_PALABRAS_CLAVE_ID_PALABRA",
                table: "KEYWORDS_PRODUCTOS",
                column: "PALABRAS_CLAVE_ID_PALABRA");

            migrationBuilder.CreateIndex(
                name: "IX_PRODUCTOS_ID_PRODUCTO",
                table: "KEYWORDS_PRODUCTOS",
                column: "PRODUCTOS_ID_PRODUCTO");

            migrationBuilder.CreateIndex(
                name: "IX_ID_CURSO",
                table: "LISTAS_ESCOLARES",
                column: "ID_CURSO");

            migrationBuilder.CreateIndex(
                name: "IX_MARCAS_ID_MARCA",
                table: "MARCAS_PROVEEDOR",
                column: "MARCAS_ID_MARCA");

            migrationBuilder.CreateIndex(
                name: "IX_PROVEEDORES_ID_INDIVIDUO",
                table: "MARCAS_PROVEEDOR",
                column: "PROVEEDORES_ID_INDIVIDUO");

            migrationBuilder.CreateIndex(
                name: "IX_Proveedor_IdIndividuo",
                table: "ORDEN_COMPRA",
                column: "Proveedor_IdIndividuo");

            migrationBuilder.CreateIndex(
                name: "IX_ID_POST",
                table: "PARRAFOS",
                column: "ID_POST");

            migrationBuilder.CreateIndex(
                name: "IX_ID_PEDIDO",
                table: "PEDIDO_INFO_PAYU",
                column: "ID_PEDIDO");

            migrationBuilder.CreateIndex(
                name: "IX_ID_DESCUENTO",
                table: "PEDIDOS",
                column: "ID_DESCUENTO");

            migrationBuilder.CreateIndex(
                name: "IX_ID_INDIVIDUO",
                table: "PEDIDOS",
                column: "ID_INDIVIDUO");

            migrationBuilder.CreateIndex(
                name: "IX_ID_ORDEN_COMPRA",
                table: "PEDIDOS",
                column: "ID_ORDEN_COMPRA");

            migrationBuilder.CreateIndex(
                name: "IX_ID_UBICACION",
                table: "PEDIDOS",
                column: "ID_UBICACION");

            migrationBuilder.CreateIndex(
                name: "IX_ID_INDIVIDUO",
                table: "PERSONAS",
                column: "ID_INDIVIDUO",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ID_ARTICULO_ID_PRODUCTO",
                table: "PRECIOS",
                columns: new[] { "ID_ARTICULO", "ID_PRODUCTO" });

            migrationBuilder.CreateIndex(
                name: "IX_ID_CATEGORIA_CONTABILIDAD",
                table: "PRODUCTOS",
                column: "ID_CATEGORIA_CONTABILIDAD");

            migrationBuilder.CreateIndex(
                name: "IX_ID_MARCA",
                table: "PRODUCTOS",
                column: "ID_MARCA");

            migrationBuilder.CreateIndex(
                name: "IX_ID_ARTICULO_ID_PRODUCTO",
                table: "PRODUCTOS_RESPALDO",
                columns: new[] { "ID_ARTICULO", "ID_PRODUCTO" });

            migrationBuilder.CreateIndex(
                name: "IX_ID_ARTICULO_RES_ID_PRODUCTO_RES",
                table: "PRODUCTOS_RESPALDO",
                columns: new[] { "ID_ARTICULO_RES", "ID_PRODUCTO_RES" });

            migrationBuilder.CreateIndex(
                name: "IX_ID_ACVTIVIDAD_ECONOMICA",
                table: "PROVEEDORES",
                column: "ID_ACVTIVIDAD_ECONOMICA");

            migrationBuilder.CreateIndex(
                name: "IX_ID_INDIVIDUO",
                table: "PROVEEDORES",
                column: "ID_INDIVIDUO");

            migrationBuilder.CreateIndex(
                name: "IX_ID_PARRAFO",
                table: "QUOTES",
                column: "ID_PARRAFO");

            migrationBuilder.CreateIndex(
                name: "IX_CODIGO_PAIS",
                table: "REGIONES",
                column: "CODIGO_PAIS");

            migrationBuilder.CreateIndex(
                name: "IX_ID_INDIVIDUO",
                table: "SEDES",
                column: "ID_INDIVIDUO");

            migrationBuilder.CreateIndex(
                name: "IX_ID_UBICACION",
                table: "SEDES",
                column: "ID_UBICACION");

            migrationBuilder.CreateIndex(
                name: "IX_ID_POST",
                table: "SUBTITULOS",
                column: "ID_POST");

            migrationBuilder.CreateIndex(
                name: "IX_ID_DETALLE_ENTRADA_INVENTARIO",
                table: "TRAZABILIDAD_COMPRAS",
                column: "ID_DETALLE_ENTRADA_INVENTARIO");

            migrationBuilder.CreateIndex(
                name: "IX_ID_DETALLE_ORDEN_COMPRA",
                table: "TRAZABILIDAD_COMPRAS",
                column: "ID_DETALLE_ORDEN_COMPRA");

            migrationBuilder.CreateIndex(
                name: "IX_PERSONAS_ID_INDIVIDUO",
                table: "UBIC_PERSONAS",
                column: "PERSONAS_ID_INDIVIDUO");

            migrationBuilder.CreateIndex(
                name: "IX_UBICACIONES_ID_UBICACION",
                table: "UBIC_PERSONAS",
                column: "UBICACIONES_ID_UBICACION");

            migrationBuilder.CreateIndex(
                name: "IX_ID_CIUDAD",
                table: "UBICACIONES",
                column: "ID_CIUDAD");

            migrationBuilder.CreateIndex(
                name: "IX_ID_ATRIBUTO",
                table: "VALOR_ATRIBUTO",
                column: "ID_ATRIBUTO");

            migrationBuilder.CreateIndex(
                name: "IX_ID_TIPO",
                table: "VALOR_ATRIBUTO",
                column: "ID_TIPO");

            migrationBuilder.CreateIndex(
                name: "IX_ID_UNID_VENTA",
                table: "VALOR_ATRIBUTO",
                column: "ID_UNID_VENTA");

            migrationBuilder.CreateIndex(
                name: "IX_ID_INDIVIDUO",
                table: "VALORACIONES",
                column: "ID_INDIVIDUO");

            migrationBuilder.CreateIndex(
                name: "IX_ID_PRODUCTO",
                table: "VALORACIONES",
                column: "ID_PRODUCTO");

            migrationBuilder.CreateIndex(
                name: "IX_ID_PRODUCTO",
                table: "VERSION_PRODUCTO",
                column: "ID_PRODUCTO");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "__MigrationHistory");

            migrationBuilder.DropTable(
                name: "ARTICULOS_ATRIBUTOS_VALORES");

            migrationBuilder.DropTable(
                name: "ARTICULOS_CARRITO_COMPRA");

            migrationBuilder.DropTable(
                name: "ARTICULOS_CARRITO_COMPRA_PREPEDIDO");

            migrationBuilder.DropTable(
                name: "ARTICULOS_DETALLES_LISTA_PEDIDO");

            migrationBuilder.DropTable(
                name: "ARTICULOS_ENTRADOS_ESTANTES");

            migrationBuilder.DropTable(
                name: "ARTICULOS_PEDIDOS_FACTURAS_VENTA");

            migrationBuilder.DropTable(
                name: "ARTICULOS_POR_FACTURA_COMPRA");

            migrationBuilder.DropTable(
                name: "ARTICULOS_POR_INSTITUCION");

            migrationBuilder.DropTable(
                name: "ARTICULOS_POR_INSTITUCION_PRE_PEDIDO");

            migrationBuilder.DropTable(
                name: "ARTICULOS_POR_LISTA");

            migrationBuilder.DropTable(
                name: "ARTICULOS_PRE_PEDIDO");

            migrationBuilder.DropTable(
                name: "ARTICULOS_UNIDAD_VENTA");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "ATRIBS_INSTITUCIONES");

            migrationBuilder.DropTable(
                name: "BENEFICIARIOS_VALIDOS");

            migrationBuilder.DropTable(
                name: "CATEGORIA_CATEGORIAS");

            migrationBuilder.DropTable(
                name: "CATEGORIA_PROD");

            migrationBuilder.DropTable(
                name: "CATEGORIAS_CATEGORIAS_CONTABLE");

            migrationBuilder.DropTable(
                name: "CLIENTE_CARRITO_COMPRA");

            migrationBuilder.DropTable(
                name: "COSTO_ENVIO");

            migrationBuilder.DropTable(
                name: "COTIZACIONES_LISTA_ESCOLAR");

            migrationBuilder.DropTable(
                name: "DESCRIPCION_PRODUCTO");

            migrationBuilder.DropTable(
                name: "DESCUENTOS_USADOS");

            migrationBuilder.DropTable(
                name: "DETALLES_AJUSTE_INVENTARIO");

            migrationBuilder.DropTable(
                name: "DETALLES_SALIDA_INVENTARIO");

            migrationBuilder.DropTable(
                name: "ESTADISTICAS_ICFES");

            migrationBuilder.DropTable(
                name: "HISTORICO_LISTAS");

            migrationBuilder.DropTable(
                name: "IMAGENES_POST");

            migrationBuilder.DropTable(
                name: "INVENTARIO");

            migrationBuilder.DropTable(
                name: "KEYWORDS_ARTICULOS");

            migrationBuilder.DropTable(
                name: "KEYWORDS_CATEGORIAS");

            migrationBuilder.DropTable(
                name: "KEYWORDS_PRODUCTOS");

            migrationBuilder.DropTable(
                name: "MARCAS_PROVEEDOR");

            migrationBuilder.DropTable(
                name: "MOVIMIENTOS_INVENTARIO");

            migrationBuilder.DropTable(
                name: "PARAMETRIZACIONES");

            migrationBuilder.DropTable(
                name: "PAYU_RESPONSE_LOG");

            migrationBuilder.DropTable(
                name: "PEDIDO_INFO_PAYU");

            migrationBuilder.DropTable(
                name: "PRECIOS");

            migrationBuilder.DropTable(
                name: "PRODUCTOS_RESPALDO");

            migrationBuilder.DropTable(
                name: "QUOTES");

            migrationBuilder.DropTable(
                name: "RESOLUCION_FACTURA");

            migrationBuilder.DropTable(
                name: "SEDES");

            migrationBuilder.DropTable(
                name: "SUBTITULOS");

            migrationBuilder.DropTable(
                name: "TRAZABILIDAD_COMPRAS");

            migrationBuilder.DropTable(
                name: "UBIC_PERSONAS");

            migrationBuilder.DropTable(
                name: "VALORACIONES");

            migrationBuilder.DropTable(
                name: "VALORES_MARCADO");

            migrationBuilder.DropTable(
                name: "VERSION_PRODUCTO");

            migrationBuilder.DropTable(
                name: "VALOR_ATRIBUTO");

            migrationBuilder.DropTable(
                name: "CARRITO_COMPRA");

            migrationBuilder.DropTable(
                name: "CARRITO_COMPRA_PREPEDIDO");

            migrationBuilder.DropTable(
                name: "DETALLES_LISTA_PEDIDO");

            migrationBuilder.DropTable(
                name: "ESTANTES");

            migrationBuilder.DropTable(
                name: "ARTICULOS_POR_PEDIDO");

            migrationBuilder.DropTable(
                name: "ARTICULOS_POR_FACTURA_VENTA");

            migrationBuilder.DropTable(
                name: "PRE_PEDIDOS");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "BENEFICIOS_ALIADOS");

            migrationBuilder.DropTable(
                name: "AJUSTES_INVENTARIO");

            migrationBuilder.DropTable(
                name: "SALIDAS_INVENTARIO");

            migrationBuilder.DropTable(
                name: "CATEGORIAS");

            migrationBuilder.DropTable(
                name: "PALABRAS_CLAVE");

            migrationBuilder.DropTable(
                name: "PARRAFOS");

            migrationBuilder.DropTable(
                name: "DETALLES_ENTRADA_INVENTARIO");

            migrationBuilder.DropTable(
                name: "ARTICULOS_POR_ORDEN");

            migrationBuilder.DropTable(
                name: "ATRIBUTOS_ARTICULOS");

            migrationBuilder.DropTable(
                name: "LISTAS_ESCOLARES");

            migrationBuilder.DropTable(
                name: "BODEGAS");

            migrationBuilder.DropTable(
                name: "FACTURAS_VENTAS");

            migrationBuilder.DropTable(
                name: "POSTS");

            migrationBuilder.DropTable(
                name: "ENTRADAS_INVENTARIO");

            migrationBuilder.DropTable(
                name: "FACTURAS_COMPRAS");

            migrationBuilder.DropTable(
                name: "ARTICULOS");

            migrationBuilder.DropTable(
                name: "TIPO_ATRIBUTOS");

            migrationBuilder.DropTable(
                name: "UNIDADES_VENTA");

            migrationBuilder.DropTable(
                name: "CURSOS");

            migrationBuilder.DropTable(
                name: "PERSONAS");

            migrationBuilder.DropTable(
                name: "PEDIDOS");

            migrationBuilder.DropTable(
                name: "PRODUCTOS");

            migrationBuilder.DropTable(
                name: "INSTITUCIONES");

            migrationBuilder.DropTable(
                name: "ORDEN_COMPRA");

            migrationBuilder.DropTable(
                name: "UBICACIONES");

            migrationBuilder.DropTable(
                name: "CATEGORIAS_CONTABILIDAD");

            migrationBuilder.DropTable(
                name: "MARCAS");

            migrationBuilder.DropTable(
                name: "DESCUENTOS");

            migrationBuilder.DropTable(
                name: "PROVEEDORES");

            migrationBuilder.DropTable(
                name: "CIUDADES");

            migrationBuilder.DropTable(
                name: "CAMPANAS");

            migrationBuilder.DropTable(
                name: "ACTIVIDADES_ECONOMICAS");

            migrationBuilder.DropTable(
                name: "INDIVIDUOS");

            migrationBuilder.DropTable(
                name: "REGIONES");

            migrationBuilder.DropTable(
                name: "PAISES");
        }
    }
}
