using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CarRentalManagement.Migrations
{
    /// <inheritdoc />
    public partial class SeedUserRole : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "ad2bcf0c-20db-474f-8407-5a6b159518ba", null, "Administrator", "ADMINISTRATOR" },
                    { "bd2bcf0c-20db-474f-8407-5a6b159518bb", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "3781efa7-66dc-47f0-860f-e506d04102e4", 0, "3539f861-9601-4251-a48a-617d82d7859a", "admin@localhost.com", true, "Admin", "User", false, null, "ADMIN@LOCALHOST.COM", "ADMIN@LOCALHOST.COM", "AQAAAAIAAYagAAAAEBRVkvV/vU/b8Tk2mHCQeNw9bAiiUvd48yrRfi+LzeWcym5d7IsB/iebOSw16ITlRA==", null, false, "c78a1be8-f4f9-4584-909c-3c70ee1c3c83", false, "admin@localhost.com" });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 27, 23, 25, 51, 0, DateTimeKind.Local).AddTicks(6034), new DateTime(2025, 11, 27, 23, 25, 51, 0, DateTimeKind.Local).AddTicks(6048) });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 27, 23, 25, 51, 0, DateTimeKind.Local).AddTicks(6051), new DateTime(2025, 11, 27, 23, 25, 51, 0, DateTimeKind.Local).AddTicks(6051) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 27, 23, 25, 51, 0, DateTimeKind.Local).AddTicks(6240), new DateTime(2025, 11, 27, 23, 25, 51, 0, DateTimeKind.Local).AddTicks(6240) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 27, 23, 25, 51, 0, DateTimeKind.Local).AddTicks(6242), new DateTime(2025, 11, 27, 23, 25, 51, 0, DateTimeKind.Local).AddTicks(6243) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 27, 23, 25, 51, 0, DateTimeKind.Local).AddTicks(6394), new DateTime(2025, 11, 27, 23, 25, 51, 0, DateTimeKind.Local).AddTicks(6394) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 27, 23, 25, 51, 0, DateTimeKind.Local).AddTicks(6396), new DateTime(2025, 11, 27, 23, 25, 51, 0, DateTimeKind.Local).AddTicks(6396) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 27, 23, 25, 51, 0, DateTimeKind.Local).AddTicks(6398), new DateTime(2025, 11, 27, 23, 25, 51, 0, DateTimeKind.Local).AddTicks(6398) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 27, 23, 25, 51, 0, DateTimeKind.Local).AddTicks(6399), new DateTime(2025, 11, 27, 23, 25, 51, 0, DateTimeKind.Local).AddTicks(6400) });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd2bcf0c-20db-474f-8407-5a6b159518bb");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad2bcf0c-20db-474f-8407-5a6b159518ba");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 27, 22, 58, 26, 489, DateTimeKind.Local).AddTicks(1668), new DateTime(2025, 11, 27, 22, 58, 26, 489, DateTimeKind.Local).AddTicks(1683) });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 27, 22, 58, 26, 489, DateTimeKind.Local).AddTicks(1685), new DateTime(2025, 11, 27, 22, 58, 26, 489, DateTimeKind.Local).AddTicks(1686) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 27, 22, 58, 26, 489, DateTimeKind.Local).AddTicks(1915), new DateTime(2025, 11, 27, 22, 58, 26, 489, DateTimeKind.Local).AddTicks(1915) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 27, 22, 58, 26, 489, DateTimeKind.Local).AddTicks(1917), new DateTime(2025, 11, 27, 22, 58, 26, 489, DateTimeKind.Local).AddTicks(1918) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 27, 22, 58, 26, 489, DateTimeKind.Local).AddTicks(2088), new DateTime(2025, 11, 27, 22, 58, 26, 489, DateTimeKind.Local).AddTicks(2089) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 27, 22, 58, 26, 489, DateTimeKind.Local).AddTicks(2091), new DateTime(2025, 11, 27, 22, 58, 26, 489, DateTimeKind.Local).AddTicks(2091) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 27, 22, 58, 26, 489, DateTimeKind.Local).AddTicks(2093), new DateTime(2025, 11, 27, 22, 58, 26, 489, DateTimeKind.Local).AddTicks(2093) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 27, 22, 58, 26, 489, DateTimeKind.Local).AddTicks(2095), new DateTime(2025, 11, 27, 22, 58, 26, 489, DateTimeKind.Local).AddTicks(2095) });
        }
    }
}
