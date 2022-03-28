using Microsoft.EntityFrameworkCore.Migrations;

namespace NFLTeams.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Conferences",
                columns: table => new
                {
                    ConferenceID = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Conferences", x => x.ConferenceID);
                });

            migrationBuilder.CreateTable(
                name: "Divisions",
                columns: table => new
                {
                    DivisionID = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Divisions", x => x.DivisionID);
                });

            migrationBuilder.CreateTable(
                name: "Teams",
                columns: table => new
                {
                    TeamID = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    ConferenceID = table.Column<string>(nullable: true),
                    DivisionID = table.Column<string>(nullable: true),
                    LogoImage = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teams", x => x.TeamID);
                    table.ForeignKey(
                        name: "FK_Teams_Conferences_ConferenceID",
                        column: x => x.ConferenceID,
                        principalTable: "Conferences",
                        principalColumn: "ConferenceID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Teams_Divisions_DivisionID",
                        column: x => x.DivisionID,
                        principalTable: "Divisions",
                        principalColumn: "DivisionID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Conferences",
                columns: new[] { "ConferenceID", "Name" },
                values: new object[] { "afc", "AFC" });

            migrationBuilder.InsertData(
                table: "Conferences",
                columns: new[] { "ConferenceID", "Name" },
                values: new object[] { "nfc", "NFC" });

            migrationBuilder.InsertData(
                table: "Divisions",
                columns: new[] { "DivisionID", "Name" },
                values: new object[] { "north", "North" });

            migrationBuilder.InsertData(
                table: "Divisions",
                columns: new[] { "DivisionID", "Name" },
                values: new object[] { "south", "South" });

            migrationBuilder.InsertData(
                table: "Divisions",
                columns: new[] { "DivisionID", "Name" },
                values: new object[] { "east", "East" });

            migrationBuilder.InsertData(
                table: "Divisions",
                columns: new[] { "DivisionID", "Name" },
                values: new object[] { "west", "West" });

            migrationBuilder.InsertData(
                table: "Teams",
                columns: new[] { "TeamID", "ConferenceID", "DivisionID", "LogoImage", "Name" },
                values: new object[] { "bal", "afc", "north", "BAL.png", "Baltimore Ravens" });

            migrationBuilder.InsertData(
                table: "Teams",
                columns: new[] { "TeamID", "ConferenceID", "DivisionID", "LogoImage", "Name" },
                values: new object[] { "oak", "afc", "west", "OAK.png", "Oakland Raiders" });

            migrationBuilder.InsertData(
                table: "Teams",
                columns: new[] { "TeamID", "ConferenceID", "DivisionID", "LogoImage", "Name" },
                values: new object[] { "lar", "nfc", "west", "LAR.png", "Los Angeles Rams" });

            migrationBuilder.InsertData(
                table: "Teams",
                columns: new[] { "TeamID", "ConferenceID", "DivisionID", "LogoImage", "Name" },
                values: new object[] { "lac", "afc", "west", "LAC.png", "Los Angeles Chargers" });

            migrationBuilder.InsertData(
                table: "Teams",
                columns: new[] { "TeamID", "ConferenceID", "DivisionID", "LogoImage", "Name" },
                values: new object[] { "kc", "afc", "west", "KC.png", "Kansas City Chiefs" });

            migrationBuilder.InsertData(
                table: "Teams",
                columns: new[] { "TeamID", "ConferenceID", "DivisionID", "LogoImage", "Name" },
                values: new object[] { "den", "afc", "west", "DEN.png", "Denver Broncos" });

            migrationBuilder.InsertData(
                table: "Teams",
                columns: new[] { "TeamID", "ConferenceID", "DivisionID", "LogoImage", "Name" },
                values: new object[] { "ari", "nfc", "west", "ARI.png", "Arizona Cardinals" });

            migrationBuilder.InsertData(
                table: "Teams",
                columns: new[] { "TeamID", "ConferenceID", "DivisionID", "LogoImage", "Name" },
                values: new object[] { "was", "nfc", "east", "WAS.png", "Washington Redskins" });

            migrationBuilder.InsertData(
                table: "Teams",
                columns: new[] { "TeamID", "ConferenceID", "DivisionID", "LogoImage", "Name" },
                values: new object[] { "phi", "nfc", "east", "PHI.png", "Philadelphia Eagles" });

            migrationBuilder.InsertData(
                table: "Teams",
                columns: new[] { "TeamID", "ConferenceID", "DivisionID", "LogoImage", "Name" },
                values: new object[] { "nyj", "afc", "east", "NYJ.png", "New York Jets" });

            migrationBuilder.InsertData(
                table: "Teams",
                columns: new[] { "TeamID", "ConferenceID", "DivisionID", "LogoImage", "Name" },
                values: new object[] { "nyg", "nfc", "east", "NYG.png", "New York Giants" });

            migrationBuilder.InsertData(
                table: "Teams",
                columns: new[] { "TeamID", "ConferenceID", "DivisionID", "LogoImage", "Name" },
                values: new object[] { "ne", "afc", "east", "NE.png", "New England Patriots" });

            migrationBuilder.InsertData(
                table: "Teams",
                columns: new[] { "TeamID", "ConferenceID", "DivisionID", "LogoImage", "Name" },
                values: new object[] { "mia", "afc", "east", "MIA.png", "Miami Dolphins" });

            migrationBuilder.InsertData(
                table: "Teams",
                columns: new[] { "TeamID", "ConferenceID", "DivisionID", "LogoImage", "Name" },
                values: new object[] { "dal", "nfc", "east", "DAL.png", "Dallas Cowboys" });

            migrationBuilder.InsertData(
                table: "Teams",
                columns: new[] { "TeamID", "ConferenceID", "DivisionID", "LogoImage", "Name" },
                values: new object[] { "buf", "afc", "east", "BUF.png", "Buffalo Bills" });

            migrationBuilder.InsertData(
                table: "Teams",
                columns: new[] { "TeamID", "ConferenceID", "DivisionID", "LogoImage", "Name" },
                values: new object[] { "ten", "afc", "south", "TEN.png", "Tennessee Titans" });

            migrationBuilder.InsertData(
                table: "Teams",
                columns: new[] { "TeamID", "ConferenceID", "DivisionID", "LogoImage", "Name" },
                values: new object[] { "tb", "nfc", "south", "TB.png", "Tampa Bay Buccaneers" });

            migrationBuilder.InsertData(
                table: "Teams",
                columns: new[] { "TeamID", "ConferenceID", "DivisionID", "LogoImage", "Name" },
                values: new object[] { "no", "nfc", "south", "NO.png", "New Orleans Saints" });

            migrationBuilder.InsertData(
                table: "Teams",
                columns: new[] { "TeamID", "ConferenceID", "DivisionID", "LogoImage", "Name" },
                values: new object[] { "jax", "afc", "south", "JAX.png", "Jacksonville Jaguars" });

            migrationBuilder.InsertData(
                table: "Teams",
                columns: new[] { "TeamID", "ConferenceID", "DivisionID", "LogoImage", "Name" },
                values: new object[] { "ind", "afc", "south", "IND.png", "Indianapolis Colts" });

            migrationBuilder.InsertData(
                table: "Teams",
                columns: new[] { "TeamID", "ConferenceID", "DivisionID", "LogoImage", "Name" },
                values: new object[] { "hou", "afc", "south", "HOU.png", "Houston Texans" });

            migrationBuilder.InsertData(
                table: "Teams",
                columns: new[] { "TeamID", "ConferenceID", "DivisionID", "LogoImage", "Name" },
                values: new object[] { "car", "nfc", "south", "CAR.png", "Carolina Panthers" });

            migrationBuilder.InsertData(
                table: "Teams",
                columns: new[] { "TeamID", "ConferenceID", "DivisionID", "LogoImage", "Name" },
                values: new object[] { "atl", "nfc", "south", "ATL.png", "Atlanta Falcons" });

            migrationBuilder.InsertData(
                table: "Teams",
                columns: new[] { "TeamID", "ConferenceID", "DivisionID", "LogoImage", "Name" },
                values: new object[] { "pit", "afc", "north", "PIT.png", "Pittsburgh Steelers" });

            migrationBuilder.InsertData(
                table: "Teams",
                columns: new[] { "TeamID", "ConferenceID", "DivisionID", "LogoImage", "Name" },
                values: new object[] { "min", "nfc", "north", "MIN.png", "Minnesota Vikings" });

            migrationBuilder.InsertData(
                table: "Teams",
                columns: new[] { "TeamID", "ConferenceID", "DivisionID", "LogoImage", "Name" },
                values: new object[] { "gb", "nfc", "north", "GB.png", "Green Bay Packers" });

            migrationBuilder.InsertData(
                table: "Teams",
                columns: new[] { "TeamID", "ConferenceID", "DivisionID", "LogoImage", "Name" },
                values: new object[] { "det", "nfc", "north", "DET.png", "Detroit Lions" });

            migrationBuilder.InsertData(
                table: "Teams",
                columns: new[] { "TeamID", "ConferenceID", "DivisionID", "LogoImage", "Name" },
                values: new object[] { "cle", "afc", "north", "CLE.png", "Cleveland Browns" });

            migrationBuilder.InsertData(
                table: "Teams",
                columns: new[] { "TeamID", "ConferenceID", "DivisionID", "LogoImage", "Name" },
                values: new object[] { "cin", "afc", "north", "CIN.png", "Cincinnati Bengals" });

            migrationBuilder.InsertData(
                table: "Teams",
                columns: new[] { "TeamID", "ConferenceID", "DivisionID", "LogoImage", "Name" },
                values: new object[] { "chi", "nfc", "north", "CHI.png", "Chicago Bears" });

            migrationBuilder.InsertData(
                table: "Teams",
                columns: new[] { "TeamID", "ConferenceID", "DivisionID", "LogoImage", "Name" },
                values: new object[] { "sea", "nfc", "west", "SEA.png", "Seattle Seahawks" });

            migrationBuilder.InsertData(
                table: "Teams",
                columns: new[] { "TeamID", "ConferenceID", "DivisionID", "LogoImage", "Name" },
                values: new object[] { "sf", "nfc", "west", "SF.png", "San Francisco 49ers" });

            migrationBuilder.CreateIndex(
                name: "IX_Teams_ConferenceID",
                table: "Teams",
                column: "ConferenceID");

            migrationBuilder.CreateIndex(
                name: "IX_Teams_DivisionID",
                table: "Teams",
                column: "DivisionID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Teams");

            migrationBuilder.DropTable(
                name: "Conferences");

            migrationBuilder.DropTable(
                name: "Divisions");
        }
    }
}
