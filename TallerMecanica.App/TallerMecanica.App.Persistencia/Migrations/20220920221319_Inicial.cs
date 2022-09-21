using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TallerMecanica.App.Persistencia.Migrations
{
    public partial class Inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    ClienteId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PersonaId = table.Column<int>(type: "int", nullable: false),
                    NumeroIdentificacion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nombres = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Apellidos = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Direccion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Telefono = table.Column<int>(type: "int", nullable: false),
                    Genero = table.Column<int>(type: "int", nullable: false),
                    Ciudad = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.ClienteId);
                });

            migrationBuilder.CreateTable(
                name: "Tecnicos",
                columns: table => new
                {
                    TecnicoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Usuario = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Contraseña = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaContrato = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PersonaId = table.Column<int>(type: "int", nullable: false),
                    NumeroIdentificacion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nombres = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Apellidos = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Direccion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Telefono = table.Column<int>(type: "int", nullable: false),
                    Genero = table.Column<int>(type: "int", nullable: false),
                    Ciudad = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tecnicos", x => x.TecnicoId);
                });

            migrationBuilder.CreateTable(
                name: "Vehiculos",
                columns: table => new
                {
                    VehiculoId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Marca = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Color = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tipo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Modelo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Placa = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClienteId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vehiculos", x => x.VehiculoId);
                    table.ForeignKey(
                        name: "FK_Vehiculos_Clientes_ClienteId",
                        column: x => x.ClienteId,
                        principalTable: "Clientes",
                        principalColumn: "ClienteId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Revisiones",
                columns: table => new
                {
                    MatenimientoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TipoMantenimiento = table.Column<int>(type: "int", nullable: false),
                    FechaMantenimiento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EstadoAceite = table.Column<int>(type: "int", nullable: false),
                    EstadoFiltroGasolina = table.Column<int>(type: "int", nullable: false),
                    EstadoFiltroAire = table.Column<int>(type: "int", nullable: false),
                    ObservacionMantenimiento = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SuVehiculoVehiculoId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    SuTecnicoTecnicoId = table.Column<int>(type: "int", nullable: true),
                    Valor = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Revisiones", x => x.MatenimientoId);
                    table.ForeignKey(
                        name: "FK_Revisiones_Tecnicos_SuTecnicoTecnicoId",
                        column: x => x.SuTecnicoTecnicoId,
                        principalTable: "Tecnicos",
                        principalColumn: "TecnicoId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Revisiones_Vehiculos_SuVehiculoVehiculoId",
                        column: x => x.SuVehiculoVehiculoId,
                        principalTable: "Vehiculos",
                        principalColumn: "VehiculoId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Repuestos",
                columns: table => new
                {
                    RepuestoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreRespuesto = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RevisionMatenimientoId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Repuestos", x => x.RepuestoId);
                    table.ForeignKey(
                        name: "FK_Repuestos_Revisiones_RevisionMatenimientoId",
                        column: x => x.RevisionMatenimientoId,
                        principalTable: "Revisiones",
                        principalColumn: "MatenimientoId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Repuestos_RevisionMatenimientoId",
                table: "Repuestos",
                column: "RevisionMatenimientoId");

            migrationBuilder.CreateIndex(
                name: "IX_Revisiones_SuTecnicoTecnicoId",
                table: "Revisiones",
                column: "SuTecnicoTecnicoId");

            migrationBuilder.CreateIndex(
                name: "IX_Revisiones_SuVehiculoVehiculoId",
                table: "Revisiones",
                column: "SuVehiculoVehiculoId");

            migrationBuilder.CreateIndex(
                name: "IX_Vehiculos_ClienteId",
                table: "Vehiculos",
                column: "ClienteId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Repuestos");

            migrationBuilder.DropTable(
                name: "Revisiones");

            migrationBuilder.DropTable(
                name: "Tecnicos");

            migrationBuilder.DropTable(
                name: "Vehiculos");

            migrationBuilder.DropTable(
                name: "Clientes");
        }
    }
}
