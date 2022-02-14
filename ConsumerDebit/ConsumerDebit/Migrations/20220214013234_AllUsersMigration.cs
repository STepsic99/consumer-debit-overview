using Microsoft.EntityFrameworkCore.Migrations;

namespace ConsumerDebit.Migrations
{
    public partial class AllUsersMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "IDUser", "Owner", "Password" },
                values: new object[,]
                {
                    { "S00004", "Gligoric Svetislav", "B522" },
                    { "S00005", "Vukovic Mirjana", "A290" },
                    { "S00006", "Nikolic Dragan", "3000" },
                    { "S00007", "Dedouh Dragutin", "A662" },
                    { "S00008", "Petruš Ornela", "A590" },
                    { "S00009", "Filipovic Ljiljana", "EE7F" },
                    { "S00010", "Borojevic Boris", "CB60" },
                    { "S00011", "Žebeljanovic Zoran", "6D0D" },
                    { "S00012", "Vujanic Ivkov Gordana", "17ED" },
                    { "S00013", "Andric Gavrilovic Dragan", "092B" },
                    { "S00014", "Kostic Miloš", "3CD3" },
                    { "S00015", "Lukićević Srbislava", "67EC" },
                    { "S00016", "Ilic Danka", "B045" },
                    { "S00017", "Tešinovic Pero", "31B5" },
                    { "S00018", "Vejinovic Mirko", "61EE" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "IDUser",
                keyValue: "S00004");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "IDUser",
                keyValue: "S00005");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "IDUser",
                keyValue: "S00006");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "IDUser",
                keyValue: "S00007");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "IDUser",
                keyValue: "S00008");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "IDUser",
                keyValue: "S00009");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "IDUser",
                keyValue: "S00010");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "IDUser",
                keyValue: "S00011");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "IDUser",
                keyValue: "S00012");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "IDUser",
                keyValue: "S00013");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "IDUser",
                keyValue: "S00014");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "IDUser",
                keyValue: "S00015");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "IDUser",
                keyValue: "S00016");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "IDUser",
                keyValue: "S00017");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "IDUser",
                keyValue: "S00018");
        }
    }
}
