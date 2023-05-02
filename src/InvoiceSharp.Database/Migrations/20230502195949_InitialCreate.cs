using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InvoiceSharp.Database.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "VatZones",
                columns: table => new
                {
                    VatZoneId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CountryCode = table.Column<string>(type: "TEXT", nullable: false),
                    Rate = table.Column<decimal>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VatZones", x => x.VatZoneId);
                });

            migrationBuilder.CreateTable(
                name: "VatNumbers",
                columns: table => new
                {
                    VatNumberId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Number = table.Column<string>(type: "TEXT", nullable: false),
                    Created = table.Column<DateTime>(type: "TEXT", nullable: false),
                    LastModified = table.Column<DateTime>(type: "TEXT", nullable: false),
                    ZoneId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VatNumbers", x => x.VatNumberId);
                    table.ForeignKey(
                        name: "FK_VatNumbers_VatZones_ZoneId",
                        column: x => x.ZoneId,
                        principalTable: "VatZones",
                        principalColumn: "VatZoneId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    CustomerId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    VatNumberId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.CustomerId);
                    table.ForeignKey(
                        name: "FK_Customers_VatNumbers_VatNumberId",
                        column: x => x.VatNumberId,
                        principalTable: "VatNumbers",
                        principalColumn: "VatNumberId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Customers_VatNumberId",
                table: "Customers",
                column: "VatNumberId");

            migrationBuilder.CreateIndex(
                name: "IX_VatNumbers_ZoneId",
                table: "VatNumbers",
                column: "ZoneId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "VatNumbers");

            migrationBuilder.DropTable(
                name: "VatZones");
        }
    }
}
