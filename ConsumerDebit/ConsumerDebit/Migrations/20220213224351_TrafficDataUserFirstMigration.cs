using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ConsumerDebit.Migrations
{
    public partial class TrafficDataUserFirstMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Traffics",
                columns: new[] { "ID", "Claims", "Date", "Document", "Owes", "UserId" },
                values: new object[,]
                {
                    { 4, 0, new DateTime(2021, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00001" },
                    { 5, 0, new DateTime(2021, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 180, "S00001" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 5);
        }
    }
}
