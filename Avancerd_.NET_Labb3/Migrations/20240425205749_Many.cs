using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Avancerd_.NET_Labb3.Migrations
{
    /// <inheritdoc />
    public partial class Many : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Links_Links_LinkID1",
                table: "Links");

            migrationBuilder.DropForeignKey(
                name: "FK_Links_Persons_PersonID",
                table: "Links");

            migrationBuilder.DropIndex(
                name: "IX_Links_LinkID1",
                table: "Links");

            migrationBuilder.DropIndex(
                name: "IX_Links_PersonID",
                table: "Links");

            migrationBuilder.DropColumn(
                name: "HobbyID",
                table: "Links");

            migrationBuilder.DropColumn(
                name: "LinkID1",
                table: "Links");

            migrationBuilder.DropColumn(
                name: "PersonID",
                table: "Links");

            migrationBuilder.CreateTable(
                name: "LinkPerson",
                columns: table => new
                {
                    LinksLinkID = table.Column<int>(type: "int", nullable: false),
                    PersonsPersonID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LinkPerson", x => new { x.LinksLinkID, x.PersonsPersonID });
                    table.ForeignKey(
                        name: "FK_LinkPerson_Links_LinksLinkID",
                        column: x => x.LinksLinkID,
                        principalTable: "Links",
                        principalColumn: "LinkID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LinkPerson_Persons_PersonsPersonID",
                        column: x => x.PersonsPersonID,
                        principalTable: "Persons",
                        principalColumn: "PersonID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_LinkPerson_PersonsPersonID",
                table: "LinkPerson",
                column: "PersonsPersonID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LinkPerson");

            migrationBuilder.AddColumn<int>(
                name: "HobbyID",
                table: "Links",
                type: "int",
                nullable: false,
                defaultValue: 0);

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

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "LinkID",
                keyValue: 1,
                columns: new[] { "HobbyID", "LinkID1", "PersonID" },
                values: new object[] { 1, null, null });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "LinkID",
                keyValue: 2,
                columns: new[] { "HobbyID", "LinkID1", "PersonID" },
                values: new object[] { 1, null, null });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "LinkID",
                keyValue: 3,
                columns: new[] { "HobbyID", "LinkID1", "PersonID" },
                values: new object[] { 2, null, null });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "LinkID",
                keyValue: 4,
                columns: new[] { "HobbyID", "LinkID1", "PersonID" },
                values: new object[] { 2, null, null });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "LinkID",
                keyValue: 5,
                columns: new[] { "HobbyID", "LinkID1", "PersonID" },
                values: new object[] { 3, null, null });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "LinkID",
                keyValue: 6,
                columns: new[] { "HobbyID", "LinkID1", "PersonID" },
                values: new object[] { 3, null, null });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "LinkID",
                keyValue: 7,
                columns: new[] { "HobbyID", "LinkID1", "PersonID" },
                values: new object[] { 4, null, null });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "LinkID",
                keyValue: 8,
                columns: new[] { "HobbyID", "LinkID1", "PersonID" },
                values: new object[] { 5, null, null });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "LinkID",
                keyValue: 9,
                columns: new[] { "HobbyID", "LinkID1", "PersonID" },
                values: new object[] { 5, null, null });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "LinkID",
                keyValue: 10,
                columns: new[] { "HobbyID", "LinkID1", "PersonID" },
                values: new object[] { 6, null, null });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "LinkID",
                keyValue: 11,
                columns: new[] { "HobbyID", "LinkID1", "PersonID" },
                values: new object[] { 7, null, null });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "LinkID",
                keyValue: 12,
                columns: new[] { "HobbyID", "LinkID1", "PersonID" },
                values: new object[] { 8, null, null });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "LinkID",
                keyValue: 13,
                columns: new[] { "HobbyID", "LinkID1", "PersonID" },
                values: new object[] { 8, null, null });

            migrationBuilder.CreateIndex(
                name: "IX_Links_LinkID1",
                table: "Links",
                column: "LinkID1");

            migrationBuilder.CreateIndex(
                name: "IX_Links_PersonID",
                table: "Links",
                column: "PersonID");

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
    }
}
