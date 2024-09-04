using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WebApplication1.Migrations
{
    /// <inheritdoc />
    public partial class _2ndmigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "policyDetails",
                keyColumn: "QuotationNumber",
                keyValue: new Guid("4416443a-5779-4c8d-a756-cc63c19cd0cc"));

            migrationBuilder.DeleteData(
                table: "policyDetails",
                keyColumn: "QuotationNumber",
                keyValue: new Guid("7629592b-a02d-40a0-b889-2ab39f75bc34"));

            migrationBuilder.DeleteData(
                table: "policyDetails",
                keyColumn: "QuotationNumber",
                keyValue: new Guid("fdb16cb1-06d0-4b94-8529-4382deadc5f4"));

            migrationBuilder.InsertData(
                table: "policyDetails",
                columns: new[] { "QuotationNumber", "CarMake", "CarYearOfMake", "CreationDate", "PolicyOwner", "QuotationStatus" },
                values: new object[,]
                {
                    { new Guid("0f9f9e05-e79c-40bd-b8ed-b2568b59e6fa"), "Range", "2023", new DateTime(2024, 8, 29, 13, 55, 54, 623, DateTimeKind.Local).AddTicks(465), "Rita", 0 },
                    { new Guid("418c4d9f-382b-4c15-a90c-c386f6336396"), "Mercedes", "2023", new DateTime(2024, 8, 29, 13, 55, 54, 623, DateTimeKind.Local).AddTicks(401), "Charbel", 1 },
                    { new Guid("4c1ef98b-148e-4358-8468-545dd8199bf8"), "Camaro", "2023", new DateTime(2024, 8, 29, 13, 55, 54, 623, DateTimeKind.Local).AddTicks(442), "Elie", 1 },
                    { new Guid("6173ff4a-531f-4ac9-a041-cf24d0040454"), "Nissan", "2023", new DateTime(2024, 8, 29, 13, 55, 54, 623, DateTimeKind.Local).AddTicks(497), "Miguel", 0 },
                    { new Guid("69978987-f4dc-4031-8638-1ada98e0f2dd"), "BMW", "2019", new DateTime(2024, 8, 29, 13, 55, 54, 623, DateTimeKind.Local).AddTicks(491), "Roudy", 0 },
                    { new Guid("6e3d51a4-22b6-4eda-823d-ed49096b624f"), "Kia", "2015", new DateTime(2024, 8, 29, 13, 55, 54, 623, DateTimeKind.Local).AddTicks(458), "Abdo", 0 },
                    { new Guid("744c30e4-45fd-482c-90d6-136dfecdc9d1"), "Golf", "2023", new DateTime(2024, 8, 29, 13, 55, 54, 623, DateTimeKind.Local).AddTicks(445), "Etienne", 0 },
                    { new Guid("a01dee98-5c78-4c48-8552-477d29d35d87"), "Mercedes", "2012", new DateTime(2024, 8, 29, 13, 55, 54, 623, DateTimeKind.Local).AddTicks(463), "Thierry", 0 },
                    { new Guid("a3df4993-cb53-4752-b2e2-26c6106a40f9"), "bmw", "2020", new DateTime(2024, 8, 29, 13, 55, 54, 623, DateTimeKind.Local).AddTicks(455), "Bob", 0 },
                    { new Guid("b4737127-01a3-45fa-83f4-82fa309bff1a"), "Lexus", "2016", new DateTime(2024, 8, 29, 13, 55, 54, 623, DateTimeKind.Local).AddTicks(493), "Fredy", 0 },
                    { new Guid("cac22ba8-136a-4fd3-854e-cacd002a5da6"), "jeep", "2017", new DateTime(2024, 8, 29, 13, 55, 54, 623, DateTimeKind.Local).AddTicks(488), "James", 0 },
                    { new Guid("cfb56a74-e103-40c2-bd08-efd76f7df9a7"), "suzuki", "2028", new DateTime(2024, 8, 29, 13, 55, 54, 623, DateTimeKind.Local).AddTicks(461), "Roula", 0 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "policyDetails",
                keyColumn: "QuotationNumber",
                keyValue: new Guid("0f9f9e05-e79c-40bd-b8ed-b2568b59e6fa"));

            migrationBuilder.DeleteData(
                table: "policyDetails",
                keyColumn: "QuotationNumber",
                keyValue: new Guid("418c4d9f-382b-4c15-a90c-c386f6336396"));

            migrationBuilder.DeleteData(
                table: "policyDetails",
                keyColumn: "QuotationNumber",
                keyValue: new Guid("4c1ef98b-148e-4358-8468-545dd8199bf8"));

            migrationBuilder.DeleteData(
                table: "policyDetails",
                keyColumn: "QuotationNumber",
                keyValue: new Guid("6173ff4a-531f-4ac9-a041-cf24d0040454"));

            migrationBuilder.DeleteData(
                table: "policyDetails",
                keyColumn: "QuotationNumber",
                keyValue: new Guid("69978987-f4dc-4031-8638-1ada98e0f2dd"));

            migrationBuilder.DeleteData(
                table: "policyDetails",
                keyColumn: "QuotationNumber",
                keyValue: new Guid("6e3d51a4-22b6-4eda-823d-ed49096b624f"));

            migrationBuilder.DeleteData(
                table: "policyDetails",
                keyColumn: "QuotationNumber",
                keyValue: new Guid("744c30e4-45fd-482c-90d6-136dfecdc9d1"));

            migrationBuilder.DeleteData(
                table: "policyDetails",
                keyColumn: "QuotationNumber",
                keyValue: new Guid("a01dee98-5c78-4c48-8552-477d29d35d87"));

            migrationBuilder.DeleteData(
                table: "policyDetails",
                keyColumn: "QuotationNumber",
                keyValue: new Guid("a3df4993-cb53-4752-b2e2-26c6106a40f9"));

            migrationBuilder.DeleteData(
                table: "policyDetails",
                keyColumn: "QuotationNumber",
                keyValue: new Guid("b4737127-01a3-45fa-83f4-82fa309bff1a"));

            migrationBuilder.DeleteData(
                table: "policyDetails",
                keyColumn: "QuotationNumber",
                keyValue: new Guid("cac22ba8-136a-4fd3-854e-cacd002a5da6"));

            migrationBuilder.DeleteData(
                table: "policyDetails",
                keyColumn: "QuotationNumber",
                keyValue: new Guid("cfb56a74-e103-40c2-bd08-efd76f7df9a7"));

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
    }
}
