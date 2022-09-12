using Microsoft.EntityFrameworkCore.Migrations;

namespace Restaurante.Persistencia.Migrations
{
    public partial class Restaurante : Migration
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
                    tipoRol = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    password = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personas", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "TipoPersonas",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    idpersona = table.Column<int>(type: "int", nullable: false),
                    tipoP = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoPersonas", x => x.id);
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
                    personaid = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comandas", x => x.id);
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
                name: "Logins",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    idRolid = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Logins", x => x.id);
                    table.ForeignKey(
                        name: "FK_Logins_Personas_idRolid",
                        column: x => x.idRolid,
                        principalTable: "Personas",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Detal_Asignaciones",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    asignacionid = table.Column<int>(type: "int", nullable: true),
                    mesaid = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Detal_Asignaciones", x => x.id);
                    table.ForeignKey(
                        name: "FK_Detal_Asignaciones_Asignaciones_asignacionid",
                        column: x => x.asignacionid,
                        principalTable: "Asignaciones",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Detal_Asignaciones_Mesas_mesaid",
                        column: x => x.mesaid,
                        principalTable: "Mesas",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Detal_comandas",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    cant = table.Column<int>(type: "int", nullable: false),
                    menuid = table.Column<int>(type: "int", nullable: true),
                    comandaid = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Detal_comandas", x => x.id);
                    table.ForeignKey(
                        name: "FK_Detal_comandas_Comandas_comandaid",
                        column: x => x.comandaid,
                        principalTable: "Comandas",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Detal_comandas_Menus_menuid",
                        column: x => x.menuid,
                        principalTable: "Menus",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Facturas",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    precio = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    idcomandaid = table.Column<int>(type: "int", nullable: true),
                    personaid = table.Column<int>(type: "int", nullable: true),
                    mesaid = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Facturas", x => x.id);
                    table.ForeignKey(
                        name: "FK_Facturas_Comandas_idcomandaid",
                        column: x => x.idcomandaid,
                        principalTable: "Comandas",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Facturas_Mesas_mesaid",
                        column: x => x.mesaid,
                        principalTable: "Mesas",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Facturas_Personas_personaid",
                        column: x => x.personaid,
                        principalTable: "Personas",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Deta_Facts",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    cant = table.Column<int>(type: "int", nullable: false),
                    menuid = table.Column<int>(type: "int", nullable: true),
                    facturaid = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Deta_Facts", x => x.id);
                    table.ForeignKey(
                        name: "FK_Deta_Facts_Facturas_facturaid",
                        column: x => x.facturaid,
                        principalTable: "Facturas",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Deta_Facts_Menus_menuid",
                        column: x => x.menuid,
                        principalTable: "Menus",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Asignaciones_personaid",
                table: "Asignaciones",
                column: "personaid");

            migrationBuilder.CreateIndex(
                name: "IX_Comandas_mesaid",
                table: "Comandas",
                column: "mesaid");

            migrationBuilder.CreateIndex(
                name: "IX_Comandas_personaid",
                table: "Comandas",
                column: "personaid");

            migrationBuilder.CreateIndex(
                name: "IX_Deta_Facts_facturaid",
                table: "Deta_Facts",
                column: "facturaid");

            migrationBuilder.CreateIndex(
                name: "IX_Deta_Facts_menuid",
                table: "Deta_Facts",
                column: "menuid");

            migrationBuilder.CreateIndex(
                name: "IX_Detal_Asignaciones_asignacionid",
                table: "Detal_Asignaciones",
                column: "asignacionid");

            migrationBuilder.CreateIndex(
                name: "IX_Detal_Asignaciones_mesaid",
                table: "Detal_Asignaciones",
                column: "mesaid");

            migrationBuilder.CreateIndex(
                name: "IX_Detal_comandas_comandaid",
                table: "Detal_comandas",
                column: "comandaid");

            migrationBuilder.CreateIndex(
                name: "IX_Detal_comandas_menuid",
                table: "Detal_comandas",
                column: "menuid");

            migrationBuilder.CreateIndex(
                name: "IX_Facturas_idcomandaid",
                table: "Facturas",
                column: "idcomandaid");

            migrationBuilder.CreateIndex(
                name: "IX_Facturas_mesaid",
                table: "Facturas",
                column: "mesaid");

            migrationBuilder.CreateIndex(
                name: "IX_Facturas_personaid",
                table: "Facturas",
                column: "personaid");

            migrationBuilder.CreateIndex(
                name: "IX_Logins_idRolid",
                table: "Logins",
                column: "idRolid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Deta_Facts");

            migrationBuilder.DropTable(
                name: "Detal_Asignaciones");

            migrationBuilder.DropTable(
                name: "Detal_comandas");

            migrationBuilder.DropTable(
                name: "Logins");

            migrationBuilder.DropTable(
                name: "TipoPersonas");

            migrationBuilder.DropTable(
                name: "Facturas");

            migrationBuilder.DropTable(
                name: "Asignaciones");

            migrationBuilder.DropTable(
                name: "Menus");

            migrationBuilder.DropTable(
                name: "Comandas");

            migrationBuilder.DropTable(
                name: "Mesas");

            migrationBuilder.DropTable(
                name: "Personas");
        }
    }
}
