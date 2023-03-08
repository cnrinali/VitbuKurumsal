using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    public partial class migrationrefactordbson : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Rezervation_Users_ReferenceId",
                table: "Rezervation");

            migrationBuilder.RenameColumn(
                name: "ReferenceEmail",
                table: "Rezervation",
                newName: "StatusId");

            migrationBuilder.RenameColumn(
                name: "PersonQuantity",
                table: "Rezervation",
                newName: "RefCode");

            migrationBuilder.AddColumn<Guid>(
                name: "AdditionalServicesId",
                table: "Rezervation",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AirplaneTime",
                table: "Rezervation",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreateDate",
                table: "Rezervation",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FlightCode",
                table: "Rezervation",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ModifiedName",
                table: "Rezervation",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PersonCount",
                table: "Rezervation",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PersonalTC",
                table: "Rezervation",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "ServiceTypeId",
                table: "Rezervation",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "UserId",
                table: "Rezervation",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "VehicleId",
                table: "Rezervation",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "AdditionalServices",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AdditionalServiceName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StatusId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateDate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdditionalServices", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Reference",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NameSurname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StatusId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateDate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reference", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ServiceType",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ServiceName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StatusId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateDate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ServiceType", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Rezervation_AdditionalServicesId",
                table: "Rezervation",
                column: "AdditionalServicesId");

            migrationBuilder.CreateIndex(
                name: "IX_Rezervation_ServiceTypeId",
                table: "Rezervation",
                column: "ServiceTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Rezervation_UserId",
                table: "Rezervation",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Rezervation_VehicleId",
                table: "Rezervation",
                column: "VehicleId");

            migrationBuilder.AddForeignKey(
                name: "FK_Rezervation_AdditionalServices_AdditionalServicesId",
                table: "Rezervation",
                column: "AdditionalServicesId",
                principalTable: "AdditionalServices",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Rezervation_Reference_ReferenceId",
                table: "Rezervation",
                column: "ReferenceId",
                principalTable: "Reference",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Rezervation_ServiceType_ServiceTypeId",
                table: "Rezervation",
                column: "ServiceTypeId",
                principalTable: "ServiceType",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Rezervation_Users_UserId",
                table: "Rezervation",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Rezervation_Vehicles_VehicleId",
                table: "Rezervation",
                column: "VehicleId",
                principalTable: "Vehicles",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Rezervation_AdditionalServices_AdditionalServicesId",
                table: "Rezervation");

            migrationBuilder.DropForeignKey(
                name: "FK_Rezervation_Reference_ReferenceId",
                table: "Rezervation");

            migrationBuilder.DropForeignKey(
                name: "FK_Rezervation_ServiceType_ServiceTypeId",
                table: "Rezervation");

            migrationBuilder.DropForeignKey(
                name: "FK_Rezervation_Users_UserId",
                table: "Rezervation");

            migrationBuilder.DropForeignKey(
                name: "FK_Rezervation_Vehicles_VehicleId",
                table: "Rezervation");

            migrationBuilder.DropTable(
                name: "AdditionalServices");

            migrationBuilder.DropTable(
                name: "Reference");

            migrationBuilder.DropTable(
                name: "ServiceType");

            migrationBuilder.DropIndex(
                name: "IX_Rezervation_AdditionalServicesId",
                table: "Rezervation");

            migrationBuilder.DropIndex(
                name: "IX_Rezervation_ServiceTypeId",
                table: "Rezervation");

            migrationBuilder.DropIndex(
                name: "IX_Rezervation_UserId",
                table: "Rezervation");

            migrationBuilder.DropIndex(
                name: "IX_Rezervation_VehicleId",
                table: "Rezervation");

            migrationBuilder.DropColumn(
                name: "AdditionalServicesId",
                table: "Rezervation");

            migrationBuilder.DropColumn(
                name: "AirplaneTime",
                table: "Rezervation");

            migrationBuilder.DropColumn(
                name: "CreateDate",
                table: "Rezervation");

            migrationBuilder.DropColumn(
                name: "FlightCode",
                table: "Rezervation");

            migrationBuilder.DropColumn(
                name: "ModifiedName",
                table: "Rezervation");

            migrationBuilder.DropColumn(
                name: "PersonCount",
                table: "Rezervation");

            migrationBuilder.DropColumn(
                name: "PersonalTC",
                table: "Rezervation");

            migrationBuilder.DropColumn(
                name: "ServiceTypeId",
                table: "Rezervation");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Rezervation");

            migrationBuilder.DropColumn(
                name: "VehicleId",
                table: "Rezervation");

            migrationBuilder.RenameColumn(
                name: "StatusId",
                table: "Rezervation",
                newName: "ReferenceEmail");

            migrationBuilder.RenameColumn(
                name: "RefCode",
                table: "Rezervation",
                newName: "PersonQuantity");

            migrationBuilder.AddForeignKey(
                name: "FK_Rezervation_Users_ReferenceId",
                table: "Rezervation",
                column: "ReferenceId",
                principalTable: "Users",
                principalColumn: "Id");
        }
    }
}
