using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    public partial class alll12 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Rezervation_Customer_CustomerId",
                table: "Rezervation");

            migrationBuilder.DropIndex(
                name: "IX_Rezervation_CustomerId",
                table: "Rezervation");

            migrationBuilder.DropColumn(
                name: "CustomerId",
                table: "Rezervation");

            migrationBuilder.AddColumn<Guid>(
                name: "RezervationId",
                table: "Customer",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Customer_RezervationId",
                table: "Customer",
                column: "RezervationId");

            migrationBuilder.AddForeignKey(
                name: "FK_Customer_Rezervation_RezervationId",
                table: "Customer",
                column: "RezervationId",
                principalTable: "Rezervation",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Customer_Rezervation_RezervationId",
                table: "Customer");

            migrationBuilder.DropIndex(
                name: "IX_Customer_RezervationId",
                table: "Customer");

            migrationBuilder.DropColumn(
                name: "RezervationId",
                table: "Customer");

            migrationBuilder.AddColumn<Guid>(
                name: "CustomerId",
                table: "Rezervation",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Rezervation_CustomerId",
                table: "Rezervation",
                column: "CustomerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Rezervation_Customer_CustomerId",
                table: "Rezervation",
                column: "CustomerId",
                principalTable: "Customer",
                principalColumn: "Id");
        }
    }
}
