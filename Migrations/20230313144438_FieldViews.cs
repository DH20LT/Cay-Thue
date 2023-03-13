using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CayThue.Migrations
{
    /// <inheritdoc />
    public partial class FieldViews : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ProfileBanner",
                table: "AccountLolInfos",
                newName: "RankSoloDuo");

            migrationBuilder.RenameColumn(
                name: "FlexDivision",
                table: "AccountLolInfos",
                newName: "RankFlex");

            migrationBuilder.AddColumn<int>(
                name: "Views",
                table: "Accounts",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PrevSeasonFlex",
                table: "AccountLolInfos",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PrevSeasonSoloDuo",
                table: "AccountLolInfos",
                type: "TEXT",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Library.Rank",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Library.Rank", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Library.Rank");

            migrationBuilder.DropColumn(
                name: "Views",
                table: "Accounts");

            migrationBuilder.DropColumn(
                name: "PrevSeasonFlex",
                table: "AccountLolInfos");

            migrationBuilder.DropColumn(
                name: "PrevSeasonSoloDuo",
                table: "AccountLolInfos");

            migrationBuilder.RenameColumn(
                name: "RankSoloDuo",
                table: "AccountLolInfos",
                newName: "ProfileBanner");

            migrationBuilder.RenameColumn(
                name: "RankFlex",
                table: "AccountLolInfos",
                newName: "FlexDivision");
        }
    }
}
