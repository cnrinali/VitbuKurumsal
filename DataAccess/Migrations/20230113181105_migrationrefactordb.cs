using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    public partial class migrationrefactordb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            
            migrationBuilder.CreateTable(
                name: "Customer",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Uyruk = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cinsiyet = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Soyad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KimlikNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HesKodu = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Telefon = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Sms = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StatusId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateDate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customer", x => x.Id);
                });

            
            migrationBuilder.CreateTable(
                name: "Prices",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    StartIlId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    StartIlceId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    StartSemtMahId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    EndIlId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    EndIlceId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    EndtSemtMahId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TotalPrice = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompanyId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    VehicleCategoryId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Prices", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Prices_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companies",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Prices_VehicleCategories_VehicleCategoryId",
                        column: x => x.VehicleCategoryId,
                        principalTable: "VehicleCategories",
                        principalColumn: "Id");
                });


            migrationBuilder.CreateTable(
                name: "PriceCarriers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CompanyId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PriceId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    VehicleCategoryId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TotalPrice = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PriceCarriers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PriceCarriers_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PriceCarriers_Prices_PriceId",
                        column: x => x.PriceId,
                        principalTable: "Prices",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_PriceCarriers_VehicleCategories_VehicleCategoryId",
                        column: x => x.VehicleCategoryId,
                        principalTable: "VehicleCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PriceVehicles",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PriceId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    VehicleCategoryId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PriceVehicles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PriceVehicles_Prices_PriceId",
                        column: x => x.PriceId,
                        principalTable: "Prices",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_PriceVehicles_VehicleCategories_VehicleCategoryId",
                        column: x => x.VehicleCategoryId,
                        principalTable: "VehicleCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Rezervation",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DepartureRoute = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ArrivalRoute = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StartDate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EndDate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReferenceEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PersonQuantity = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeparturePoint = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Destination = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CarrierId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Plate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Personal = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PersonalGsm = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReferenceId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CompanyId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    VehicleCategoryId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    PriceId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CustomerId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    PriceVehicleId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rezervation", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Rezervation_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companies",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Rezervation_Customer_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customer",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Rezervation_Prices_PriceId",
                        column: x => x.PriceId,
                        principalTable: "Prices",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Rezervation_PriceVehicles_PriceVehicleId",
                        column: x => x.PriceVehicleId,
                        principalTable: "PriceVehicles",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Rezervation_Users_ReferenceId",
                        column: x => x.ReferenceId,
                        principalTable: "Users",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Rezervation_VehicleCategories_VehicleCategoryId",
                        column: x => x.VehicleCategoryId,
                        principalTable: "VehicleCategories",
                        principalColumn: "Id");
                });

            
            migrationBuilder.CreateIndex(
                name: "IX_PriceCarriers_CompanyId",
                table: "PriceCarriers",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_PriceCarriers_PriceId",
                table: "PriceCarriers",
                column: "PriceId");

            migrationBuilder.CreateIndex(
                name: "IX_PriceCarriers_VehicleCategoryId",
                table: "PriceCarriers",
                column: "VehicleCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Prices_CompanyId",
                table: "Prices",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_Prices_VehicleCategoryId",
                table: "Prices",
                column: "VehicleCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_PriceVehicles_PriceId",
                table: "PriceVehicles",
                column: "PriceId");

            migrationBuilder.CreateIndex(
                name: "IX_PriceVehicles_VehicleCategoryId",
                table: "PriceVehicles",
                column: "VehicleCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Rezervation_CompanyId",
                table: "Rezervation",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_Rezervation_CustomerId",
                table: "Rezervation",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Rezervation_PriceId",
                table: "Rezervation",
                column: "PriceId");

            migrationBuilder.CreateIndex(
                name: "IX_Rezervation_PriceVehicleId",
                table: "Rezervation",
                column: "PriceVehicleId");

            migrationBuilder.CreateIndex(
                name: "IX_Rezervation_ReferenceId",
                table: "Rezervation",
                column: "ReferenceId");

            migrationBuilder.CreateIndex(
                name: "IX_Rezervation_VehicleCategoryId",
                table: "Rezervation",
                column: "VehicleCategoryId");

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Ilceler");

            migrationBuilder.DropTable(
                name: "Logs");

            migrationBuilder.DropTable(
                name: "RoleAuthorizations");

            migrationBuilder.DropTable(
                name: "Sehirler");

            migrationBuilder.DropTable(
                name: "SemtMah");

            migrationBuilder.DropTable(
                name: "Ulkeler");

            migrationBuilder.DropTable(
                name: "UserRoles");

            migrationBuilder.DropTable(
                name: "Vehicles");

            migrationBuilder.DropTable(
                name: "WebSettingsParams");
     
            migrationBuilder.DropTable(
                name: "Menus");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "VehicleModels");

            migrationBuilder.DropTable(
                name: "MenuCategories");

            migrationBuilder.DropTable(
                name: "VehicleBrands");

            migrationBuilder.DropTable(
                name: "Companies");

            migrationBuilder.DropTable(
                name: "VehicleCategories");
        }
    }
}
