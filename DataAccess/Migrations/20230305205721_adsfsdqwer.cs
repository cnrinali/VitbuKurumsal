using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    public partial class adsfsdqwer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AdditionalServices_Statu_StatuId",
                table: "AdditionalServices");

            migrationBuilder.DropForeignKey(
                name: "FK_Companies_Statu_StatuId",
                table: "Companies");

            migrationBuilder.DropForeignKey(
                name: "FK_Customer_Statu_StatuId",
                table: "Customer");

            migrationBuilder.DropForeignKey(
                name: "FK_MenuCategories_Statu_StatuId",
                table: "MenuCategories");

            migrationBuilder.DropForeignKey(
                name: "FK_Menus_Statu_StatuId",
                table: "Menus");

            migrationBuilder.DropForeignKey(
                name: "FK_Reference_Statu_StatuId",
                table: "Reference");

            migrationBuilder.DropForeignKey(
                name: "FK_Rezervation_Statu_StatuId",
                table: "Rezervation");

            migrationBuilder.DropForeignKey(
                name: "FK_RoleAuthorizations_Statu_StatuId",
                table: "RoleAuthorizations");

            migrationBuilder.DropForeignKey(
                name: "FK_Roles_Statu_StatuId",
                table: "Roles");

            migrationBuilder.DropForeignKey(
                name: "FK_ServiceType_Statu_StatuId",
                table: "ServiceType");

            migrationBuilder.DropForeignKey(
                name: "FK_UserRoles_Statu_StatuId",
                table: "UserRoles");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Statu_StatuId",
                table: "Users");

            migrationBuilder.DropForeignKey(
                name: "FK_VehicleBrands_Statu_StatuId",
                table: "VehicleBrands");

            migrationBuilder.DropForeignKey(
                name: "FK_VehicleCategories_Statu_StatuId",
                table: "VehicleCategories");

            migrationBuilder.DropForeignKey(
                name: "FK_VehicleModels_Statu_StatuId",
                table: "VehicleModels");

            migrationBuilder.DropForeignKey(
                name: "FK_Vehicles_Statu_StatuId",
                table: "Vehicles");

            migrationBuilder.DropTable(
                name: "Statu");

            migrationBuilder.DropIndex(
                name: "IX_Vehicles_StatuId",
                table: "Vehicles");

            migrationBuilder.DropIndex(
                name: "IX_VehicleModels_StatuId",
                table: "VehicleModels");

            migrationBuilder.DropIndex(
                name: "IX_VehicleCategories_StatuId",
                table: "VehicleCategories");

            migrationBuilder.DropIndex(
                name: "IX_VehicleBrands_StatuId",
                table: "VehicleBrands");

            migrationBuilder.DropIndex(
                name: "IX_Users_StatuId",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_UserRoles_StatuId",
                table: "UserRoles");

            migrationBuilder.DropIndex(
                name: "IX_ServiceType_StatuId",
                table: "ServiceType");

            migrationBuilder.DropIndex(
                name: "IX_Roles_StatuId",
                table: "Roles");

            migrationBuilder.DropIndex(
                name: "IX_RoleAuthorizations_StatuId",
                table: "RoleAuthorizations");

            migrationBuilder.DropIndex(
                name: "IX_Rezervation_StatuId",
                table: "Rezervation");

            migrationBuilder.DropIndex(
                name: "IX_Reference_StatuId",
                table: "Reference");

            migrationBuilder.DropIndex(
                name: "IX_Menus_StatuId",
                table: "Menus");

            migrationBuilder.DropIndex(
                name: "IX_MenuCategories_StatuId",
                table: "MenuCategories");

            migrationBuilder.DropIndex(
                name: "IX_Customer_StatuId",
                table: "Customer");

            migrationBuilder.DropIndex(
                name: "IX_Companies_StatuId",
                table: "Companies");

            migrationBuilder.DropIndex(
                name: "IX_AdditionalServices_StatuId",
                table: "AdditionalServices");

            migrationBuilder.DropColumn(
                name: "StatuId",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "StatuId",
                table: "VehicleModels");

            migrationBuilder.DropColumn(
                name: "StatuId",
                table: "VehicleCategories");

            migrationBuilder.DropColumn(
                name: "StatuId",
                table: "VehicleBrands");

            migrationBuilder.DropColumn(
                name: "StatuId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "StatuId",
                table: "UserRoles");

            migrationBuilder.DropColumn(
                name: "StatuId",
                table: "ServiceType");

            migrationBuilder.DropColumn(
                name: "StatuId",
                table: "Roles");

            migrationBuilder.DropColumn(
                name: "StatuId",
                table: "RoleAuthorizations");

            migrationBuilder.DropColumn(
                name: "StatuId",
                table: "Rezervation");

            migrationBuilder.DropColumn(
                name: "StatuId",
                table: "Reference");

            migrationBuilder.DropColumn(
                name: "StatuId",
                table: "Menus");

            migrationBuilder.DropColumn(
                name: "StatuId",
                table: "MenuCategories");

            migrationBuilder.DropColumn(
                name: "StatuId",
                table: "Customer");

            migrationBuilder.DropColumn(
                name: "StatuId",
                table: "Companies");

            migrationBuilder.DropColumn(
                name: "StatuId",
                table: "AdditionalServices");

            migrationBuilder.AddColumn<string>(
                name: "StatusId",
                table: "Vehicles",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "StatusId",
                table: "VehicleModels",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "StatusId",
                table: "VehicleCategories",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "StatusId",
                table: "VehicleBrands",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "StatusId",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "StatusId",
                table: "UserRoles",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "StatusId",
                table: "ServiceType",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "StatusId",
                table: "Roles",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "StatusId",
                table: "RoleAuthorizations",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "StatusId",
                table: "Rezervation",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "StatusId",
                table: "Reference",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "StatusId",
                table: "Menus",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "StatusId",
                table: "MenuCategories",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "StatusId",
                table: "Customer",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "StatusId",
                table: "Companies",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "StatusId",
                table: "AdditionalServices",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "StatusId",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "StatusId",
                table: "VehicleModels");

            migrationBuilder.DropColumn(
                name: "StatusId",
                table: "VehicleCategories");

            migrationBuilder.DropColumn(
                name: "StatusId",
                table: "VehicleBrands");

            migrationBuilder.DropColumn(
                name: "StatusId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "StatusId",
                table: "UserRoles");

            migrationBuilder.DropColumn(
                name: "StatusId",
                table: "ServiceType");

            migrationBuilder.DropColumn(
                name: "StatusId",
                table: "Roles");

            migrationBuilder.DropColumn(
                name: "StatusId",
                table: "RoleAuthorizations");

            migrationBuilder.DropColumn(
                name: "StatusId",
                table: "Rezervation");

            migrationBuilder.DropColumn(
                name: "StatusId",
                table: "Reference");

            migrationBuilder.DropColumn(
                name: "StatusId",
                table: "Menus");

            migrationBuilder.DropColumn(
                name: "StatusId",
                table: "MenuCategories");

            migrationBuilder.DropColumn(
                name: "StatusId",
                table: "Customer");

            migrationBuilder.DropColumn(
                name: "StatusId",
                table: "Companies");

            migrationBuilder.DropColumn(
                name: "StatusId",
                table: "AdditionalServices");

            migrationBuilder.AddColumn<Guid>(
                name: "StatuId",
                table: "Vehicles",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "StatuId",
                table: "VehicleModels",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "StatuId",
                table: "VehicleCategories",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "StatuId",
                table: "VehicleBrands",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "StatuId",
                table: "Users",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "StatuId",
                table: "UserRoles",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "StatuId",
                table: "ServiceType",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "StatuId",
                table: "Roles",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "StatuId",
                table: "RoleAuthorizations",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "StatuId",
                table: "Rezervation",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "StatuId",
                table: "Reference",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "StatuId",
                table: "Menus",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "StatuId",
                table: "MenuCategories",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "StatuId",
                table: "Customer",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "StatuId",
                table: "Companies",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "StatuId",
                table: "AdditionalServices",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Statu",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Text = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Statu", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Vehicles_StatuId",
                table: "Vehicles",
                column: "StatuId");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleModels_StatuId",
                table: "VehicleModels",
                column: "StatuId");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleCategories_StatuId",
                table: "VehicleCategories",
                column: "StatuId");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleBrands_StatuId",
                table: "VehicleBrands",
                column: "StatuId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_StatuId",
                table: "Users",
                column: "StatuId");

            migrationBuilder.CreateIndex(
                name: "IX_UserRoles_StatuId",
                table: "UserRoles",
                column: "StatuId");

            migrationBuilder.CreateIndex(
                name: "IX_ServiceType_StatuId",
                table: "ServiceType",
                column: "StatuId");

            migrationBuilder.CreateIndex(
                name: "IX_Roles_StatuId",
                table: "Roles",
                column: "StatuId");

            migrationBuilder.CreateIndex(
                name: "IX_RoleAuthorizations_StatuId",
                table: "RoleAuthorizations",
                column: "StatuId");

            migrationBuilder.CreateIndex(
                name: "IX_Rezervation_StatuId",
                table: "Rezervation",
                column: "StatuId");

            migrationBuilder.CreateIndex(
                name: "IX_Reference_StatuId",
                table: "Reference",
                column: "StatuId");

            migrationBuilder.CreateIndex(
                name: "IX_Menus_StatuId",
                table: "Menus",
                column: "StatuId");

            migrationBuilder.CreateIndex(
                name: "IX_MenuCategories_StatuId",
                table: "MenuCategories",
                column: "StatuId");

            migrationBuilder.CreateIndex(
                name: "IX_Customer_StatuId",
                table: "Customer",
                column: "StatuId");

            migrationBuilder.CreateIndex(
                name: "IX_Companies_StatuId",
                table: "Companies",
                column: "StatuId");

            migrationBuilder.CreateIndex(
                name: "IX_AdditionalServices_StatuId",
                table: "AdditionalServices",
                column: "StatuId");

            migrationBuilder.AddForeignKey(
                name: "FK_AdditionalServices_Statu_StatuId",
                table: "AdditionalServices",
                column: "StatuId",
                principalTable: "Statu",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Companies_Statu_StatuId",
                table: "Companies",
                column: "StatuId",
                principalTable: "Statu",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Customer_Statu_StatuId",
                table: "Customer",
                column: "StatuId",
                principalTable: "Statu",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_MenuCategories_Statu_StatuId",
                table: "MenuCategories",
                column: "StatuId",
                principalTable: "Statu",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Menus_Statu_StatuId",
                table: "Menus",
                column: "StatuId",
                principalTable: "Statu",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Reference_Statu_StatuId",
                table: "Reference",
                column: "StatuId",
                principalTable: "Statu",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Rezervation_Statu_StatuId",
                table: "Rezervation",
                column: "StatuId",
                principalTable: "Statu",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_RoleAuthorizations_Statu_StatuId",
                table: "RoleAuthorizations",
                column: "StatuId",
                principalTable: "Statu",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Roles_Statu_StatuId",
                table: "Roles",
                column: "StatuId",
                principalTable: "Statu",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ServiceType_Statu_StatuId",
                table: "ServiceType",
                column: "StatuId",
                principalTable: "Statu",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_UserRoles_Statu_StatuId",
                table: "UserRoles",
                column: "StatuId",
                principalTable: "Statu",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Statu_StatuId",
                table: "Users",
                column: "StatuId",
                principalTable: "Statu",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_VehicleBrands_Statu_StatuId",
                table: "VehicleBrands",
                column: "StatuId",
                principalTable: "Statu",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_VehicleCategories_Statu_StatuId",
                table: "VehicleCategories",
                column: "StatuId",
                principalTable: "Statu",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_VehicleModels_Statu_StatuId",
                table: "VehicleModels",
                column: "StatuId",
                principalTable: "Statu",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Vehicles_Statu_StatuId",
                table: "Vehicles",
                column: "StatuId",
                principalTable: "Statu",
                principalColumn: "Id");
        }
    }
}
