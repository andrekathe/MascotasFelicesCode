using Microsoft.EntityFrameworkCore.Migrations;

namespace MascotaFeliz.app.Persistencia.Migrations
{
    public partial class segunda : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Mascota_TipoAnimal_IdTipoAnimal",
                table: "Mascota");

            migrationBuilder.DropForeignKey(
                name: "FK_Medico_TipoAnimal_IdTipoAnimal",
                table: "Medico");

            migrationBuilder.DropForeignKey(
                name: "FK_VisitaProgramada_TipoAnimal_IdTipoAnimal",
                table: "VisitaProgramada");

            migrationBuilder.DropIndex(
                name: "IX_VisitaProgramada_IdTipoAnimal",
                table: "VisitaProgramada");

            migrationBuilder.DropIndex(
                name: "IX_Medico_IdTipoAnimal",
                table: "Medico");

            migrationBuilder.DropIndex(
                name: "IX_Mascota_IdTipoAnimal",
                table: "Mascota");

            migrationBuilder.DropColumn(
                name: "IdTipoAnimal",
                table: "VisitaProgramada");

            migrationBuilder.DropColumn(
                name: "IdTipoAnimal",
                table: "Medico");

            migrationBuilder.DropColumn(
                name: "IdTipoAnimal",
                table: "Mascota");

            migrationBuilder.AddColumn<int>(
                name: "TipoAnimal",
                table: "VisitaProgramada",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Especializacion",
                table: "Medico",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TipoAnimal",
                table: "Mascota",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TipoAnimal",
                table: "VisitaProgramada");

            migrationBuilder.DropColumn(
                name: "Especializacion",
                table: "Medico");

            migrationBuilder.DropColumn(
                name: "TipoAnimal",
                table: "Mascota");

            migrationBuilder.AddColumn<int>(
                name: "IdTipoAnimal",
                table: "VisitaProgramada",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IdTipoAnimal",
                table: "Medico",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IdTipoAnimal",
                table: "Mascota",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_VisitaProgramada_IdTipoAnimal",
                table: "VisitaProgramada",
                column: "IdTipoAnimal");

            migrationBuilder.CreateIndex(
                name: "IX_Medico_IdTipoAnimal",
                table: "Medico",
                column: "IdTipoAnimal");

            migrationBuilder.CreateIndex(
                name: "IX_Mascota_IdTipoAnimal",
                table: "Mascota",
                column: "IdTipoAnimal");

            migrationBuilder.AddForeignKey(
                name: "FK_Mascota_TipoAnimal_IdTipoAnimal",
                table: "Mascota",
                column: "IdTipoAnimal",
                principalTable: "TipoAnimal",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Medico_TipoAnimal_IdTipoAnimal",
                table: "Medico",
                column: "IdTipoAnimal",
                principalTable: "TipoAnimal",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_VisitaProgramada_TipoAnimal_IdTipoAnimal",
                table: "VisitaProgramada",
                column: "IdTipoAnimal",
                principalTable: "TipoAnimal",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
