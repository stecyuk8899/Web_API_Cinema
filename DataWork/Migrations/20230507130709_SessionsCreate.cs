using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataWork.Migrations
{
    public partial class SessionsCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Sessions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameFilm = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Hall = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Start = table.Column<DateTime>(type: "datetime2", nullable: false),
                    End = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Price = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sessions", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Sessions",
                columns: new[] { "Id", "End", "Hall", "NameFilm", "Price", "Start" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 6, 1, 17, 40, 0, 0, DateTimeKind.Unspecified), "Alpha", "Schedryck", 100, new DateTime(2023, 6, 1, 15, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, new DateTime(2023, 6, 1, 18, 25, 0, 0, DateTimeKind.Unspecified), "Beta", "Sky wars", 50, new DateTime(2023, 6, 1, 15, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, new DateTime(2023, 6, 1, 18, 0, 0, 0, DateTimeKind.Unspecified), "Alpha", "Skazhene vesillya", 80, new DateTime(2023, 6, 4, 15, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, new DateTime(2023, 6, 1, 12, 40, 0, 0, DateTimeKind.Unspecified), "Beta", "Titanic", 100, new DateTime(2023, 6, 9, 9, 0, 0, 0, DateTimeKind.Unspecified) }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Sessions");
        }
    }
}
