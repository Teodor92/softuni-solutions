using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Eventmi.Infrastructure.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Events",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Start = table.Column<DateTime>(type: "datetime2", nullable: false),
                    End = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Place = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Events", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Events",
                columns: new[] { "Name", "Start", "End", "Place" },
                values: new object[,]
                {
                    { "InnovateTech 2024", new DateTime(2024, 6, 15, 9, 0, 0), new DateTime(2024, 6, 16, 17, 0, 0), "SofiaTechPark" },
                    { "DataCon 2024", new DateTime(2024, 6, 20, 9, 0, 0), new DateTime(2024, 6, 22, 18, 0, 0), "CityTechHall" },
                    { "MedTech Summit 2024", new DateTime(2024, 9, 10, 19, 30, 0), new DateTime(2024, 9, 10, 22, 0, 0), "MedicalHomePalace" },
                    { "ArtFest 2024", new DateTime(2024, 8, 22, 12, 0, 0), new DateTime(2024, 8, 29, 22, 0, 0), "CentralSquare-OpenSpace" },
                    { "LaunchPad 2024", new DateTime(2024, 10, 10, 22, 0, 0), new DateTime(2024, 10, 10, 22, 45, 0), "OnlineEventHappening" },
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Events");
        }
    }
}
