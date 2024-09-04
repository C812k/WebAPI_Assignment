using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WebApplication1.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "policyDetails",
                columns: table => new
                {
                    QuotationNumber = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PolicyOwner = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CarMake = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CarYearOfMake = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    QuotationStatus = table.Column<int>(type: "int", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_policyDetails", x => x.QuotationNumber);
                });

            migrationBuilder.InsertData(
                table: "policyDetails",
                columns: new[] { "QuotationNumber", "CarMake", "CarYearOfMake", "CreationDate", "PolicyOwner", "QuotationStatus" },
                values: new object[,]
                {
                    { new Guid("4416443a-5779-4c8d-a756-cc63c19cd0cc"), "Mercedes", "2023", new DateTime(2024, 8, 29, 10, 8, 14, 518, DateTimeKind.Local).AddTicks(4971), "Charbel", 1 },
                    { new Guid("7629592b-a02d-40a0-b889-2ab39f75bc34"), "Golf", "2023", new DateTime(2024, 8, 29, 10, 8, 14, 518, DateTimeKind.Local).AddTicks(5025), "Etienne", 0 },
                    { new Guid("fdb16cb1-06d0-4b94-8529-4382deadc5f4"), "Camaro", "2023", new DateTime(2024, 8, 29, 10, 8, 14, 518, DateTimeKind.Local).AddTicks(5022), "Elie", 1 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "policyDetails");
        }
    }
}
