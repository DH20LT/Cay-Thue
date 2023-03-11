using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CayThue.Migrations
{
    /// <inheritdoc />
    public partial class AddTableAccountLolInfo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "GameId",
                table: "Accounts",
                newName: "GameID");

            migrationBuilder.CreateTable(
                name: "AccountLolInfos",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    AccountId = table.Column<Guid>(type: "TEXT", nullable: true),
                    AvailableRiotPoints = table.Column<string>(type: "TEXT", nullable: true),
                    Level = table.Column<string>(type: "TEXT", nullable: true),
                    ProfileBanner = table.Column<string>(type: "TEXT", nullable: true),
                    Honor = table.Column<string>(type: "TEXT", nullable: true),
                    Server = table.Column<string>(type: "TEXT", nullable: true),
                    Champions = table.Column<string>(type: "TEXT", nullable: true),
                    Skins = table.Column<string>(type: "TEXT", nullable: true),
                    Chroma = table.Column<string>(type: "TEXT", nullable: true),
                    WardSkins = table.Column<string>(type: "TEXT", nullable: true),
                    SumIcons = table.Column<string>(type: "TEXT", nullable: true),
                    Emotes = table.Column<string>(type: "TEXT", nullable: true),
                    FlexDivision = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AccountLolInfos", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AccountLolInfos");

            migrationBuilder.RenameColumn(
                name: "GameID",
                table: "Accounts",
                newName: "GameId");
        }
    }
}
