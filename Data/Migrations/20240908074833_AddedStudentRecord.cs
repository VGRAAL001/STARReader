using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BlazorApp.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddedStudentRecord : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "362a38c8-e7f2-46d4-9a8b-69b420c188dd");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5304bf46-5caf-4091-b34d-92f2ba12e1ca");

            migrationBuilder.AlterColumn<string>(
                name: "StudentNo",
                table: "AspNetUsers",
                type: "nvarchar(32)",
                maxLength: 32,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateTable(
                name: "Student",
                columns: table => new
                {
                    StudentNo = table.Column<string>(type: "nvarchar(32)", maxLength: 32, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Student", x => x.StudentNo);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1a920b0e-c043-4d2e-9dee-88e933e0fa3e", null, "Supervisor", null },
                    { "97a0c900-1c64-495a-9101-ca84bd06b030", null, "Administrator", null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Student");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1a920b0e-c043-4d2e-9dee-88e933e0fa3e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "97a0c900-1c64-495a-9101-ca84bd06b030");

            migrationBuilder.AlterColumn<string>(
                name: "StudentNo",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(32)",
                oldMaxLength: 32);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "362a38c8-e7f2-46d4-9a8b-69b420c188dd", null, "Supervisor", null },
                    { "5304bf46-5caf-4091-b34d-92f2ba12e1ca", null, "Administrator", null }
                });
        }
    }
}
