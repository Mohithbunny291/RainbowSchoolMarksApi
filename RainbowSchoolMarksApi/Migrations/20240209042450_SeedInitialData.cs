using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RainbowSchoolMarksApi.Migrations
{
    public partial class SeedInitialData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Student",
                columns: new[] { "Id", "Email", "Name" },
                values: new object[,]
                {
                    { 1, "alice.johnson@example.com", "Alice Johnson" },
                    { 2, "bob.smith@example.com", "Bob Smith" },
                    { 3, "carol.taylor@example.com", "Carol Taylor" }
                });

            migrationBuilder.InsertData(
                table: "Subject",
                columns: new[] { "Id", "Credits", "Name" },
                values: new object[,]
                {
                    { 1, 4, "Mathematics" },
                    { 2, 3, "English Literature" },
                    { 3, 4, "Physics" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
