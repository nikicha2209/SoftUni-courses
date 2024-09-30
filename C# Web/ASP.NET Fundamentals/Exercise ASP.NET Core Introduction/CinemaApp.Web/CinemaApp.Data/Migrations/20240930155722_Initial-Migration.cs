using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CinemaApp.Data.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Movies",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    Genre = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    ReleaseDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Director = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: false),
                    Duration = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movies", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Description", "Director", "Duration", "Genre", "ReleaseDate", "Title" },
                values: new object[,]
                {
                    { new Guid("97928290-048d-4f8d-abfd-563982147cb1"), "Inside Out 2 is a 2024 American animated coming-of-age film produced by Pixar Animation Studios for Walt Disney Pictures. The sequel to Inside Out (2015), it was directed by Kelsey Mann (in his feature directorial debut) and produced by Mark Nielsen, from a screenplay written by Meg LeFauve and Dave Holstein, and a story conceived by Mann and LeFauve.", "Kelsey Mann", 96, "Comedy", new DateTime(2024, 6, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Inside Out 2" },
                    { new Guid("cf442983-aca5-4177-8a3f-dcdd986bbd30"), "Demon Slayer: Kimetsu no Yaiba – To the Hashira Training is a 2024 Japanese animated dark fantasy action film based on the \"Swordsmith Village\" and \"Hashira Training\" arcs of the 2016–20 manga series Demon Slayer: Kimetsu no Yaiba by Koyoharu Gotouge. It is a direct sequel to the third season of the anime television series as well as its third film adaptation, following Demon Slayer: Kimetsu no Yaiba – The Movie: Mugen Train (2020) and Demon Slayer: Kimetsu no Yaiba – To the Swordsmith Village (2023).", "Haruo Sotozaki", 104, "Fantasy", new DateTime(2024, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Demon Slayer: Kimetsu no Yaiba – To the Hashira Training" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Movies");
        }
    }
}
