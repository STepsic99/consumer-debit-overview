using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ConsumerDebit.Migrations
{
    public partial class TestDataTrafficMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Traffics",
                columns: new[] { "ID", "Claims", "Date", "Document", "Owes", "UserId" },
                values: new object[,]
                {
                    { 1, 0, new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Početno stanje", 580, "S00001" },
                    { 2, 581, new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Početno stanje", 0, "S00002" },
                    { 3, 0, new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Početno stanje", 1154, "S00003" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 3);
        }
    }
}
