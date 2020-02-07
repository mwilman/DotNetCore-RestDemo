using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class seed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "ID", "Name" },
                values: new object[] { 1, "Tetris" });

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "ID", "Name" },
                values: new object[] { 2, "Mario" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "ID",
                keyValue: 2);
        }
    }
}
