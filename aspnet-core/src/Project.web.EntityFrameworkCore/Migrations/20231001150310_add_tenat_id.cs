using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project.web.Migrations
{
    /// <inheritdoc />
    public partial class add_tenat_id : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TenantId",
                table: "Todo",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TenantId",
                table: "Todo");
        }
    }
}
