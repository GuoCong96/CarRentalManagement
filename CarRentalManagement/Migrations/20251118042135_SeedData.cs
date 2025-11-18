using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CarRentalManagement.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Colour",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2025, 11, 18, 12, 21, 34, 77, DateTimeKind.Local).AddTicks(3222), new DateTime(2025, 11, 18, 12, 21, 34, 77, DateTimeKind.Local).AddTicks(3239), "Black", "System" },
                    { 2, "System", new DateTime(2025, 11, 18, 12, 21, 34, 77, DateTimeKind.Local).AddTicks(3242), new DateTime(2025, 11, 18, 12, 21, 34, 77, DateTimeKind.Local).AddTicks(3243), "Blue", "System" }
                });

            migrationBuilder.InsertData(
                table: "Make",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2025, 11, 18, 12, 21, 34, 77, DateTimeKind.Local).AddTicks(3538), new DateTime(2025, 11, 18, 12, 21, 34, 77, DateTimeKind.Local).AddTicks(3539), "BMW", "System" },
                    { 2, "System", new DateTime(2025, 11, 18, 12, 21, 34, 77, DateTimeKind.Local).AddTicks(3544), new DateTime(2025, 11, 18, 12, 21, 34, 77, DateTimeKind.Local).AddTicks(3544), "Toyota", "System" }
                });

            migrationBuilder.InsertData(
                table: "Model",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2025, 11, 18, 12, 21, 34, 77, DateTimeKind.Local).AddTicks(3707), new DateTime(2025, 11, 18, 12, 21, 34, 77, DateTimeKind.Local).AddTicks(3707), "i4", "System" },
                    { 2, "System", new DateTime(2025, 11, 18, 12, 21, 34, 77, DateTimeKind.Local).AddTicks(3710), new DateTime(2025, 11, 18, 12, 21, 34, 77, DateTimeKind.Local).AddTicks(3711), "x5", "System" },
                    { 3, "System", new DateTime(2025, 11, 18, 12, 21, 34, 77, DateTimeKind.Local).AddTicks(3713), new DateTime(2025, 11, 18, 12, 21, 34, 77, DateTimeKind.Local).AddTicks(3714), "Prius", "System" },
                    { 4, "System", new DateTime(2025, 11, 18, 12, 21, 34, 77, DateTimeKind.Local).AddTicks(3716), new DateTime(2025, 11, 18, 12, 21, 34, 77, DateTimeKind.Local).AddTicks(3716), "C-HR", "System" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
