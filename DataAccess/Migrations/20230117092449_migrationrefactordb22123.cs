using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    public partial class migrationrefactordb22123 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "VehicleCategoryId",
                table: "VehicleCategories",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_VehicleCategories_VehicleCategoryId",
                table: "VehicleCategories",
                column: "VehicleCategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_VehicleCategories_VehicleCategories_VehicleCategoryId",
                table: "VehicleCategories",
                column: "VehicleCategoryId",
                principalTable: "VehicleCategories",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_VehicleCategories_VehicleCategories_VehicleCategoryId",
                table: "VehicleCategories");

            migrationBuilder.DropIndex(
                name: "IX_VehicleCategories_VehicleCategoryId",
                table: "VehicleCategories");

            migrationBuilder.DropColumn(
                name: "VehicleCategoryId",
                table: "VehicleCategories");
        }
    }
}
