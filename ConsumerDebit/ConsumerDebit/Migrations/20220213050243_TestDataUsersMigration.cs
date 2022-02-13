using Microsoft.EntityFrameworkCore.Migrations;

namespace ConsumerDebit.Migrations
{
    public partial class TestDataUsersMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "IDUser", "Owner", "Password" },
                values: new object[,]
                {
                    { "S00001", "Novakovic Petar", "317D" },
                    { "S00002", "Miloševic Dragan", "EFFC" },
                    { "S00003", "Bardak Željko", "5110" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "IDUser",
                keyValue: "S00001");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "IDUser",
                keyValue: "S00002");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "IDUser",
                keyValue: "S00003");
        }
    }
}
