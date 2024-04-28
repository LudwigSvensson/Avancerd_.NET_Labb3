using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Avancerd_.NET_Labb3.Migrations
{
    /// <inheritdoc />
    public partial class MANYTOMANYTOMANYTOTOTOMANYMANYTOOT : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Links_Hobbies_HobbyID",
                table: "Links");

            migrationBuilder.DropIndex(
                name: "IX_Links_HobbyID",
                table: "Links");

            migrationBuilder.AddColumn<int>(
                name: "LinkID1",
                table: "Links",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PersonID",
                table: "Links",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "HobbyLink",
                columns: table => new
                {
                    HobbiesHobbyID = table.Column<int>(type: "int", nullable: false),
                    LinksLinkID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HobbyLink", x => new { x.HobbiesHobbyID, x.LinksLinkID });
                    table.ForeignKey(
                        name: "FK_HobbyLink_Hobbies_HobbiesHobbyID",
                        column: x => x.HobbiesHobbyID,
                        principalTable: "Hobbies",
                        principalColumn: "HobbyID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HobbyLink_Links_LinksLinkID",
                        column: x => x.LinksLinkID,
                        principalTable: "Links",
                        principalColumn: "LinkID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "LinkID",
                keyValue: 1,
                columns: new[] { "LinkID1", "PersonID" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "LinkID",
                keyValue: 2,
                columns: new[] { "LinkID1", "PersonID" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "LinkID",
                keyValue: 3,
                columns: new[] { "LinkID1", "PersonID" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "LinkID",
                keyValue: 4,
                columns: new[] { "LinkID1", "PersonID" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "LinkID",
                keyValue: 5,
                columns: new[] { "LinkID1", "PersonID" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "LinkID",
                keyValue: 6,
                columns: new[] { "LinkID1", "PersonID" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "LinkID",
                keyValue: 7,
                columns: new[] { "LinkID1", "PersonID" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "LinkID",
                keyValue: 8,
                columns: new[] { "LinkID1", "PersonID" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "LinkID",
                keyValue: 9,
                columns: new[] { "LinkID1", "PersonID" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "LinkID",
                keyValue: 10,
                columns: new[] { "LinkID1", "PersonID" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "LinkID",
                keyValue: 11,
                columns: new[] { "LinkID1", "PersonID" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "LinkID",
                keyValue: 12,
                columns: new[] { "LinkID1", "PersonID" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "LinkID",
                keyValue: 13,
                columns: new[] { "LinkID1", "PersonID" },
                values: new object[] { null, null });

            migrationBuilder.CreateIndex(
                name: "IX_Links_LinkID1",
                table: "Links",
                column: "LinkID1");

            migrationBuilder.CreateIndex(
                name: "IX_Links_PersonID",
                table: "Links",
                column: "PersonID");

            migrationBuilder.CreateIndex(
                name: "IX_HobbyLink_LinksLinkID",
                table: "HobbyLink",
                column: "LinksLinkID");

            migrationBuilder.AddForeignKey(
                name: "FK_Links_Links_LinkID1",
                table: "Links",
                column: "LinkID1",
                principalTable: "Links",
                principalColumn: "LinkID");

            migrationBuilder.AddForeignKey(
                name: "FK_Links_Persons_PersonID",
                table: "Links",
                column: "PersonID",
                principalTable: "Persons",
                principalColumn: "PersonID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Links_Links_LinkID1",
                table: "Links");

            migrationBuilder.DropForeignKey(
                name: "FK_Links_Persons_PersonID",
                table: "Links");

            migrationBuilder.DropTable(
                name: "HobbyLink");

            migrationBuilder.DropIndex(
                name: "IX_Links_LinkID1",
                table: "Links");

            migrationBuilder.DropIndex(
                name: "IX_Links_PersonID",
                table: "Links");

            migrationBuilder.DropColumn(
                name: "LinkID1",
                table: "Links");

            migrationBuilder.DropColumn(
                name: "PersonID",
                table: "Links");

            migrationBuilder.CreateIndex(
                name: "IX_Links_HobbyID",
                table: "Links",
                column: "HobbyID");

            migrationBuilder.AddForeignKey(
                name: "FK_Links_Hobbies_HobbyID",
                table: "Links",
                column: "HobbyID",
                principalTable: "Hobbies",
                principalColumn: "HobbyID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
