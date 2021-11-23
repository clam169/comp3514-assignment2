using Microsoft.EntityFrameworkCore.Migrations;

namespace SpeakerAPI.Data.Migrations
{
    public partial class M1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    SpeakerId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Mobile = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Specialization = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Province = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Employer = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.SpeakerId);
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "SpeakerId", "City", "Email", "Employer", "FirstName", "LastName", "Mobile", "Province", "Specialization" },
                values: new object[,]
                {
                    { "eb775c74-8314-4ae2-a7ce-af1cc91f87b6", "Burnaby", "tom@day.com", "Tinder", "Tom", "Day", "6041111111", "BC", "Love" },
                    { "3892da4a-c809-4580-8ab0-1cc4e0c99756", "Langley", "ann@fox.com", "Hunter", "Ann", "Fox", "6042222222", "BC", "Hunting" },
                    { "9f8ed802-42ce-46fe-944a-897a1f1360d0", "Vancouver", "art@ash.com", "Art Gallery", "Art", "Ash", "6043333333", "BC", "Art" },
                    { "b73f1fc6-b918-4767-8fdf-dee8013a8612", "Coquitlam", "mia@hay.com", "Hayers", "Mia", "Hay", "6044444444", "BC", "Farmer" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Students");
        }
    }
}
