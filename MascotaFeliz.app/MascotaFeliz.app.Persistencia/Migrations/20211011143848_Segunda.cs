using Microsoft.EntityFrameworkCore.Migrations;

namespace MascotaFeliz.app.Persistencia.Migrations
{
    public partial class Segunda : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Medico");

            migrationBuilder.DropTable(
                name: "Propietario");

            migrationBuilder.AddColumn<string>(
                name: "Direccion",
                table: "Persona",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "Persona",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "IdCentroVeterinario",
                table: "Persona",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IdTipoAnimal",
                table: "Persona",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TarjetaProfesional",
                table: "Persona",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Persona_IdTipoAnimal",
                table: "Persona",
                column: "IdTipoAnimal");

            migrationBuilder.AddForeignKey(
                name: "FK_Persona_TipoAnimal_IdTipoAnimal",
                table: "Persona",
                column: "IdTipoAnimal",
                principalTable: "TipoAnimal",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Persona_TipoAnimal_IdTipoAnimal",
                table: "Persona");

            migrationBuilder.DropIndex(
                name: "IX_Persona_IdTipoAnimal",
                table: "Persona");

            migrationBuilder.DropColumn(
                name: "Direccion",
                table: "Persona");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "Persona");

            migrationBuilder.DropColumn(
                name: "IdCentroVeterinario",
                table: "Persona");

            migrationBuilder.DropColumn(
                name: "IdTipoAnimal",
                table: "Persona");

            migrationBuilder.DropColumn(
                name: "TarjetaProfesional",
                table: "Persona");

            migrationBuilder.CreateTable(
                name: "Medico",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    IdCentroVeterinario = table.Column<int>(type: "int", nullable: false),
                    IdTipoAnimal = table.Column<int>(type: "int", nullable: true),
                    TarjetaProfesional = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Medico", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Medico_Persona_Id",
                        column: x => x.Id,
                        principalTable: "Persona",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Medico_TipoAnimal_IdTipoAnimal",
                        column: x => x.IdTipoAnimal,
                        principalTable: "TipoAnimal",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Propietario",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    Direccion = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Propietario", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Propietario_Persona_Id",
                        column: x => x.Id,
                        principalTable: "Persona",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Medico_IdTipoAnimal",
                table: "Medico",
                column: "IdTipoAnimal");
        }
    }
}
