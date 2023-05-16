using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataWork.Migrations
{
    public partial class CreateActors : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Actors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Raiting = table.Column<int>(type: "int", nullable: false),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Actors", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Actors",
                columns: new[] { "Id", "Country", "DateBirth", "Name", "Raiting" },
                values: new object[] { 1, "Canada", new DateTime(1980, 11, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rayan Gosling", 10 });

            migrationBuilder.InsertData(
                table: "Actors",
                columns: new[] { "Id", "Country", "DateBirth", "Name", "Raiting" },
                values: new object[] { 2, "UK", new DateTime(1955, 11, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rowan Atkinson", 10 });

            migrationBuilder.InsertData(
                table: "Actors",
                columns: new[] { "Id", "Country", "DateBirth", "Name", "Raiting" },
                values: new object[] { 3, "UK", new DateTime(1967, 7, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jason Statham", 9 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Actors");
        }
    }
}
