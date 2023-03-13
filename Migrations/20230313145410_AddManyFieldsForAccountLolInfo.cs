using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CayThue.Migrations
{
    /// <inheritdoc />
    public partial class AddManyFieldsForAccountLolInfo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AccountCreatedAt",
                table: "AccountLolInfos",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AvailableBlueEssence",
                table: "AccountLolInfos",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateUpdateAccount",
                table: "AccountLolInfos",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FirstServerOfAccount",
                table: "AccountLolInfos",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "OffineTime",
                table: "AccountLolInfos",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Prestige",
                table: "AccountLolInfos",
                type: "INTEGER",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AccountCreatedAt",
                table: "AccountLolInfos");

            migrationBuilder.DropColumn(
                name: "AvailableBlueEssence",
                table: "AccountLolInfos");

            migrationBuilder.DropColumn(
                name: "DateUpdateAccount",
                table: "AccountLolInfos");

            migrationBuilder.DropColumn(
                name: "FirstServerOfAccount",
                table: "AccountLolInfos");

            migrationBuilder.DropColumn(
                name: "OffineTime",
                table: "AccountLolInfos");

            migrationBuilder.DropColumn(
                name: "Prestige",
                table: "AccountLolInfos");
        }
    }
}
