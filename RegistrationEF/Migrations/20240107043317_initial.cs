using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RegistrationEF.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Registration",
                columns: table => new
                {
                    RegistrationId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ConfirmPassword = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    State = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Registration", x => x.RegistrationId);
                });

            migrationBuilder.CreateTable(
                name: "tblCountry",
                columns: table => new
                {
                    CountryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CountryName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblCountry", x => x.CountryId);
                });

            migrationBuilder.CreateTable(
                name: "tblState",
                columns: table => new
                {
                    StateId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StateName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FKCountryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblState", x => x.StateId);
                    table.ForeignKey(
                        name: "FK_tblState_tblCountry_FKCountryId",
                        column: x => x.FKCountryId,
                        principalTable: "tblCountry",
                        principalColumn: "CountryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tblCity",
                columns: table => new
                {
                    CityId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CityName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FKStateId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblCity", x => x.CityId);
                    table.ForeignKey(
                        name: "FK_tblCity_tblState_FKStateId",
                        column: x => x.FKStateId,
                        principalTable: "tblState",
                        principalColumn: "StateId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_tblCity_FKStateId",
                table: "tblCity",
                column: "FKStateId");

            migrationBuilder.CreateIndex(
                name: "IX_tblState_FKCountryId",
                table: "tblState",
                column: "FKCountryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Registration");

            migrationBuilder.DropTable(
                name: "tblCity");

            migrationBuilder.DropTable(
                name: "tblState");

            migrationBuilder.DropTable(
                name: "tblCountry");
        }
    }
}
