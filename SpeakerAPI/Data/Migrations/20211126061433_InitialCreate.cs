using Microsoft.EntityFrameworkCore.Migrations;

namespace SpeakerAPI.Data.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Speakers",
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
                    table.PrimaryKey("PK_Speakers", x => x.SpeakerId);
                });

            migrationBuilder.InsertData(
                table: "Speakers",
                columns: new[] { "SpeakerId", "City", "Email", "Employer", "FirstName", "LastName", "Mobile", "Province", "Specialization" },
                values: new object[,]
                {
                    { "3c008559-c39f-4854-af5e-6a46a88a151d", "Burnaby", "tom@day.com", "Tinder", "Tom", "Day", "6041111111", "BC", "Love" },
                    { "e338154c-ea64-490a-87ad-69bea86fe777", "Langley", "ann@fox.com", "Hunter", "Ann", "Fox", "6042222222", "BC", "Hunting" },
                    { "9d424e1e-4f86-4f9a-a0e9-569a473a5166", "Vancouver", "art@ash.com", "Art Gallery", "Art", "Ash", "6043333333", "BC", "Art" },
                    { "3d9289cb-21f3-48cc-ad98-af6dc55ba974", "Coquitlam", "mia@hay.com", "Hayers", "Mia", "Hay", "6044444444", "BC", "Farmer" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Speakers");
        }
    }
}
