using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Avancerd_.NET_Labb3.Migrations
{
    /// <inheritdoc />
    public partial class ChangedtoCollection : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Hobbies_Persons_PersonID",
                table: "Hobbies");

            migrationBuilder.DropIndex(
                name: "IX_Hobbies_PersonID",
                table: "Hobbies");

            migrationBuilder.DropColumn(
                name: "PersonID",
                table: "Hobbies");

            migrationBuilder.CreateTable(
                name: "HobbyPerson",
                columns: table => new
                {
                    HobbiesHobbyID = table.Column<int>(type: "int", nullable: false),
                    PersonsPersonID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HobbyPerson", x => new { x.HobbiesHobbyID, x.PersonsPersonID });
                    table.ForeignKey(
                        name: "FK_HobbyPerson_Hobbies_HobbiesHobbyID",
                        column: x => x.HobbiesHobbyID,
                        principalTable: "Hobbies",
                        principalColumn: "HobbyID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HobbyPerson_Persons_PersonsPersonID",
                        column: x => x.PersonsPersonID,
                        principalTable: "Persons",
                        principalColumn: "PersonID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_HobbyPerson_PersonsPersonID",
                table: "HobbyPerson",
                column: "PersonsPersonID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HobbyPerson");

            migrationBuilder.AddColumn<int>(
                name: "PersonID",
                table: "Hobbies",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 1,
                column: "PersonID",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 2,
                column: "PersonID",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 3,
                column: "PersonID",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 4,
                column: "PersonID",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 5,
                column: "PersonID",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 6,
                column: "PersonID",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 7,
                column: "PersonID",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 8,
                column: "PersonID",
                value: 2);

            migrationBuilder.CreateIndex(
                name: "IX_Hobbies_PersonID",
                table: "Hobbies",
                column: "PersonID");

            migrationBuilder.AddForeignKey(
                name: "FK_Hobbies_Persons_PersonID",
                table: "Hobbies",
                column: "PersonID",
                principalTable: "Persons",
                principalColumn: "PersonID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
