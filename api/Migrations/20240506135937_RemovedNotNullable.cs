using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace api.Migrations
{
    /// <inheritdoc />
    public partial class RemovedNotNullable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "33cc60d1-e31d-450e-adf5-53d90b052492");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3edbed3f-8eaa-42c9-a65f-8ba7f9480042");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "82764774-a95e-4c32-8691-24ed75a1f664", null, "Admin", "ADMIN" },
                    { "d190be5d-27d4-4d3c-a32d-fe084a598eae", null, "User", "USER" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "82764774-a95e-4c32-8691-24ed75a1f664");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d190be5d-27d4-4d3c-a32d-fe084a598eae");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "33cc60d1-e31d-450e-adf5-53d90b052492", null, "User", "USER" },
                    { "3edbed3f-8eaa-42c9-a65f-8ba7f9480042", null, "Admin", "ADMIN" }
                });
        }
    }
}
