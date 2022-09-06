using Microsoft.EntityFrameworkCore.Migrations;

namespace Restaurante.Persistencia.Migrations
{
    public partial class Inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Menus",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    descripcion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    precio = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Menus", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Mesas",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    descripcion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ubicacion = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mesas", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Personas",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    documento = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    apellido = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    telefono = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    idpersona = table.Column<int>(type: "int", nullable: true),
                    tipoP = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personas", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Asignaciones",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    personaid = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Asignaciones", x => x.id);
                    table.ForeignKey(
                        name: "FK_Asignaciones_Personas_personaid",
                        column: x => x.personaid,
                        principalTable: "Personas",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Comandas",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    mesaid = table.Column<int>(type: "int", nullable: true),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    idcomanda = table.Column<int>(type: "int", nullable: true),
                    Detal_comanda_cant = table.Column<int>(type: "int", nullable: true),
                    Detal_comanda_menuid = table.Column<int>(type: "int", nullable: true),
                    precio = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Factura_idcomanda = table.Column<int>(type: "int", nullable: true),
                    personaid = table.Column<int>(type: "int", nullable: true),
                    idFactura = table.Column<int>(type: "int", nullable: true),
                    cant = table.Column<int>(type: "int", nullable: true),
                    menuid = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comandas", x => x.id);
                    table.ForeignKey(
                        name: "FK_Comandas_Menus_Detal_comanda_menuid",
                        column: x => x.Detal_comanda_menuid,
                        principalTable: "Menus",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Comandas_Menus_menuid",
                        column: x => x.menuid,
                        principalTable: "Menus",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Comandas_Mesas_mesaid",
                        column: x => x.mesaid,
                        principalTable: "Mesas",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Comandas_Personas_personaid",
                        column: x => x.personaid,
                        principalTable: "Personas",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Deta_Asignaciones",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    asignacionid = table.Column<int>(type: "int", nullable: true),
                    mesaid = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Deta_Asignaciones", x => x.id);
                    table.ForeignKey(
                        name: "FK_Deta_Asignaciones_Asignaciones_asignacionid",
                        column: x => x.asignacionid,
                        principalTable: "Asignaciones",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Deta_Asignaciones_Mesas_mesaid",
                        column: x => x.mesaid,
                        principalTable: "Mesas",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Asignaciones_personaid",
                table: "Asignaciones",
                column: "personaid");

            migrationBuilder.CreateIndex(
                name: "IX_Comandas_Detal_comanda_menuid",
                table: "Comandas",
                column: "Detal_comanda_menuid");

            migrationBuilder.CreateIndex(
                name: "IX_Comandas_menuid",
                table: "Comandas",
                column: "menuid");

            migrationBuilder.CreateIndex(
                name: "IX_Comandas_mesaid",
                table: "Comandas",
                column: "mesaid");

            migrationBuilder.CreateIndex(
                name: "IX_Comandas_personaid",
                table: "Comandas",
                column: "personaid");

            migrationBuilder.CreateIndex(
                name: "IX_Deta_Asignaciones_asignacionid",
                table: "Deta_Asignaciones",
                column: "asignacionid");

            migrationBuilder.CreateIndex(
                name: "IX_Deta_Asignaciones_mesaid",
                table: "Deta_Asignaciones",
                column: "mesaid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Comandas");

            migrationBuilder.DropTable(
                name: "Deta_Asignaciones");

            migrationBuilder.DropTable(
                name: "Menus");

            migrationBuilder.DropTable(
                name: "Asignaciones");

            migrationBuilder.DropTable(
                name: "Mesas");

            migrationBuilder.DropTable(
                name: "Personas");
        }
    }
}
