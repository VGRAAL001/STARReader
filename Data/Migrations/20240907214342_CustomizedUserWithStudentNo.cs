using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BlazorApp.Data.Migrations
{
    /// <inheritdoc />
    public partial class CustomizedUserWithStudentNo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "StudentNo",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "362a38c8-e7f2-46d4-9a8b-69b420c188dd", null, "Supervisor", null },
                    { "5304bf46-5caf-4091-b34d-92f2ba12e1ca", null, "Administrator", null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "362a38c8-e7f2-46d4-9a8b-69b420c188dd");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5304bf46-5caf-4091-b34d-92f2ba12e1ca");

            migrationBuilder.DropColumn(
                name: "StudentNo",
                table: "AspNetUsers");
        }
    }
}
