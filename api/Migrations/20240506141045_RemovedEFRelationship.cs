using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace api.Migrations
{
    /// <inheritdoc />
    public partial class RemovedEFRelationship : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ToDoLists_AspNetUsers_AppUserId",
                table: "ToDoLists");

            migrationBuilder.DropIndex(
                name: "IX_ToDoLists_AppUserId",
                table: "ToDoLists");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "82764774-a95e-4c32-8691-24ed75a1f664");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d190be5d-27d4-4d3c-a32d-fe084a598eae");

            migrationBuilder.DropColumn(
                name: "AppUserId",
                table: "ToDoLists");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "21f45195-1612-45bc-95a3-0c00460641a1", null, "User", "USER" },
                    { "80139d67-a1f4-4d87-8979-9743b06b630c", null, "Admin", "ADMIN" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "21f45195-1612-45bc-95a3-0c00460641a1");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "80139d67-a1f4-4d87-8979-9743b06b630c");

            migrationBuilder.AddColumn<string>(
                name: "AppUserId",
                table: "ToDoLists",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "82764774-a95e-4c32-8691-24ed75a1f664", null, "Admin", "ADMIN" },
                    { "d190be5d-27d4-4d3c-a32d-fe084a598eae", null, "User", "USER" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ToDoLists_AppUserId",
                table: "ToDoLists",
                column: "AppUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_ToDoLists_AspNetUsers_AppUserId",
                table: "ToDoLists",
                column: "AppUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }
    }
}
