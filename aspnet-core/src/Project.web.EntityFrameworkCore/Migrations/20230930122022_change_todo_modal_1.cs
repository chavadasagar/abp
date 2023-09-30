using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project.web.Migrations
{
    /// <inheritdoc />
    public partial class change_todo_modal_1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "DeleterUserId",
                table: "Todo",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletionTime",
                table: "Todo",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Todo",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DeleterUserId",
                table: "Todo");

            migrationBuilder.DropColumn(
                name: "DeletionTime",
                table: "Todo");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Todo");
        }
    }
}
