using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Avancerd_.NET_Labb3.Migrations
{
    /// <inheritdoc />
    public partial class InitalCreation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Persons",
                columns: table => new
                {
                    PersonID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Persons", x => x.PersonID);
                });

            migrationBuilder.CreateTable(
                name: "Hobbies",
                columns: table => new
                {
                    HobbyID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HobbyTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HobbyDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PersonID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hobbies", x => x.HobbyID);
                    table.ForeignKey(
                        name: "FK_Hobbies_Persons_PersonID",
                        column: x => x.PersonID,
                        principalTable: "Persons",
                        principalColumn: "PersonID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Links",
                columns: table => new
                {
                    LinkID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    URL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HobbyID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Links", x => x.LinkID);
                    table.ForeignKey(
                        name: "FK_Links_Hobbies_HobbyID",
                        column: x => x.HobbyID,
                        principalTable: "Hobbies",
                        principalColumn: "HobbyID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Persons",
                columns: new[] { "PersonID", "FirstName", "LastName", "PhoneNumber" },
                values: new object[,]
                {
                    { 1, "Ludwig", "Qlok", "070123456" },
                    { 2, "Anas", "Qlok", "070765431" },
                    { 3, "Reidar", "Qlok", "070098765" }
                });

            migrationBuilder.InsertData(
                table: "Hobbies",
                columns: new[] { "HobbyID", "HobbyDescription", "HobbyTitle", "PersonID" },
                values: new object[,]
                {
                    { 1, "Skiing down the mountains... ", "Skiing", 3 },
                    { 2, "Knitting shirts, mittens and hats ", "Knitting", 3 },
                    { 3, "Surfing the waves like a real proffesional ", "Surfing", 2 },
                    { 4, "Hacking computers since 1996 ", "Hacking", 2 },
                    { 5, "Swimming like Phelps since 1996", "Swimming", 1 },
                    { 6, "Throwing larger balls at smaller balls, really fun", "Boule", 1 },
                    { 7, "Gaming all kinds of games, FPS, MMORPG and RTS games", "Gaming", 1 },
                    { 8, "Skating and punching people since 1996", "Hockey", 2 }
                });

            migrationBuilder.InsertData(
                table: "Links",
                columns: new[] { "LinkID", "HobbyID", "URL" },
                values: new object[,]
                {
                    { 1, 1, "https://en.wikipedia.org/wiki/Skiing" },
                    { 2, 1, "https://visitsweden.com/what-to-do/nature-outdoors/winter-activities/skiing-sweden/" },
                    { 3, 2, "https://en.wikipedia.org/wiki/Knitting" },
                    { 4, 2, "https://sheepandstitch.com/how-to-knit/" },
                    { 5, 3, "https://sv.wikipedia.org/wiki/Surfing" },
                    { 6, 3, "https://www.kilroy.se/reseblogg/8-fantastiska-surfdestinationer-over-hela-varlden" },
                    { 7, 4, "https://www.ibm.com/topics/cyber-hacking" },
                    { 8, 5, "https://en.wikipedia.org/wiki/Swimming_(sport)" },
                    { 9, 5, "https://www.britannica.com/sports/swimming-sport" },
                    { 10, 6, "https://sv.wikipedia.org/wiki/Boule" },
                    { 11, 7, "https://sv.wikipedia.org/wiki/Gamer" },
                    { 12, 8, "https://www.swehockey.se" },
                    { 13, 8, "https://sv.wikipedia.org/wiki/Ishockey" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Hobbies_PersonID",
                table: "Hobbies",
                column: "PersonID");

            migrationBuilder.CreateIndex(
                name: "IX_Links_HobbyID",
                table: "Links",
                column: "HobbyID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Links");

            migrationBuilder.DropTable(
                name: "Hobbies");

            migrationBuilder.DropTable(
                name: "Persons");
        }
    }
}
