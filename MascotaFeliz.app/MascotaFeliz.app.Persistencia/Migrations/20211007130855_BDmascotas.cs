using Microsoft.EntityFrameworkCore.Migrations;

namespace MascotaFeliz.app.Persistencia.Migrations
{
    public partial class BDmascotas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_CentrosVeterinarios",
                table: "CentrosVeterinarios");

            migrationBuilder.AlterColumn<int>(
                name: "Nit",
                table: "CentrosVeterinarios",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "CentrosVeterinarios",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CentrosVeterinarios",
                table: "CentrosVeterinarios",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_CentrosVeterinarios",
                table: "CentrosVeterinarios");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "CentrosVeterinarios");

            migrationBuilder.AlterColumn<int>(
                name: "Nit",
                table: "CentrosVeterinarios",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CentrosVeterinarios",
                table: "CentrosVeterinarios",
                column: "Nit");
        }
    }
}
