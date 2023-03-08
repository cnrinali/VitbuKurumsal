using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    public partial class asdfadsfaaaaaa : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "isDeleted",
                table: "Vehicles",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "isDeleted",
                table: "VehicleModels",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "isDeleted",
                table: "VehicleCategories",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "isDeleted",
                table: "VehicleBrands",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "isDeleted",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "isDeleted",
                table: "UserRoles",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "isDeleted",
                table: "ServiceType",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "isDeleted",
                table: "Roles",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "isDeleted",
                table: "RoleAuthorizations",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "isDeleted",
                table: "Rezervation",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "isDeleted",
                table: "Reference",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "isDeleted",
                table: "Menus",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "isDeleted",
                table: "MenuCategories",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "isDeleted",
                table: "Customer",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "isDeleted",
                table: "Companies",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "isDeleted",
                table: "AdditionalServices",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "isDeleted",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "isDeleted",
                table: "VehicleModels");

            migrationBuilder.DropColumn(
                name: "isDeleted",
                table: "VehicleCategories");

            migrationBuilder.DropColumn(
                name: "isDeleted",
                table: "VehicleBrands");

            migrationBuilder.DropColumn(
                name: "isDeleted",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "isDeleted",
                table: "UserRoles");

            migrationBuilder.DropColumn(
                name: "isDeleted",
                table: "ServiceType");

            migrationBuilder.DropColumn(
                name: "isDeleted",
                table: "Roles");

            migrationBuilder.DropColumn(
                name: "isDeleted",
                table: "RoleAuthorizations");

            migrationBuilder.DropColumn(
                name: "isDeleted",
                table: "Rezervation");

            migrationBuilder.DropColumn(
                name: "isDeleted",
                table: "Reference");

            migrationBuilder.DropColumn(
                name: "isDeleted",
                table: "Menus");

            migrationBuilder.DropColumn(
                name: "isDeleted",
                table: "MenuCategories");

            migrationBuilder.DropColumn(
                name: "isDeleted",
                table: "Customer");

            migrationBuilder.DropColumn(
                name: "isDeleted",
                table: "Companies");

            migrationBuilder.DropColumn(
                name: "isDeleted",
                table: "AdditionalServices");
        }
    }
}
