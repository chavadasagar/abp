using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project.web.Migrations
{
    /// <inheritdoc />
    public partial class change_todo_modal : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "CreationTime",
                table: "Todo",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<long>(
                name: "CreatorUserId",
                table: "Todo",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModificationTime",
                table: "Todo",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "LastModifierUserId",
                table: "Todo",
                type: "bigint",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreationTime",
                table: "Todo");

            migrationBuilder.DropColumn(
                name: "CreatorUserId",
                table: "Todo");

            migrationBuilder.DropColumn(
                name: "LastModificationTime",
                table: "Todo");

            migrationBuilder.DropColumn(
                name: "LastModifierUserId",
                table: "Todo");
        }
    }
}
