using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace AdminCore.Migrations.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "dbo.MARCAS",
                columns: table => new
                {
                    ID_MARCA = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    USUARIO_CREADOR = table.Column<Guid>(nullable: false),
                    FECHA_CREACION = table.Column<DateTime>(nullable: false),
                    FECHA_ACTUALIZACION = table.Column<DateTime>(nullable: false),
                    DESCRIPCION = table.Column<string>(maxLength: 300, nullable: true),
                    ESTADO_REGISTRO = table.Column<bool>(nullable: false),
                    USUARIO_MODIFICADOR = table.Column<Guid>(nullable: false),
                    NOMBRE = table.Column<string>(maxLength: 45, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dbo.MARCAS", x => x.ID_MARCA);
                });

            migrationBuilder.CreateTable(
                name: "dbo.PRODUCTOS",
                columns: table => new
                {
                    ID_PRODUCTO = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    NOMBRE = table.Column<string>(maxLength: 45, nullable: false),
                    Price = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dbo.PRODUCTOS", x => x.ID_PRODUCTO);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "dbo.MARCAS");

            migrationBuilder.DropTable(
                name: "dbo.PRODUCTOS");
        }
    }
}
