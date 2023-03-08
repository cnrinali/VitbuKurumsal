using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    public partial class kasjdfkasdjkfas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AdditionalServicesRezervations",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AdditionalServicesId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    RezervationId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ServicePrice = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StatuId = table.Column<int>(type: "int", nullable: true),
                    CreateDate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    isDeleted = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdditionalServicesRezervations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AdditionalServicesRezervations_Status_StatuId",
                        column: x => x.StatuId,
                        principalTable: "Status",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_AdditionalServicesRezervations_StatuId",
                table: "AdditionalServicesRezervations",
                column: "StatuId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AdditionalServicesRezervations");
        }
    }
}
