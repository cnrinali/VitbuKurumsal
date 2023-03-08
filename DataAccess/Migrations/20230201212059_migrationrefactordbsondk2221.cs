using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    public partial class migrationrefactordbsondk2221 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DepartureRoute",
                table: "Rezervation",
                newName: "StartSemtMah");

            migrationBuilder.RenameColumn(
                name: "ArrivalRoute",
                table: "Rezervation",
                newName: "StartSehir");

            migrationBuilder.AddColumn<string>(
                name: "EndIlce",
                table: "Rezervation",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EndSehir",
                table: "Rezervation",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EndSemtMah",
                table: "Rezervation",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "StartIlce",
                table: "Rezervation",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EndIlce",
                table: "Rezervation");

            migrationBuilder.DropColumn(
                name: "EndSehir",
                table: "Rezervation");

            migrationBuilder.DropColumn(
                name: "EndSemtMah",
                table: "Rezervation");

            migrationBuilder.DropColumn(
                name: "StartIlce",
                table: "Rezervation");

            migrationBuilder.RenameColumn(
                name: "StartSemtMah",
                table: "Rezervation",
                newName: "DepartureRoute");

            migrationBuilder.RenameColumn(
                name: "StartSehir",
                table: "Rezervation",
                newName: "ArrivalRoute");
        }
    }
}
