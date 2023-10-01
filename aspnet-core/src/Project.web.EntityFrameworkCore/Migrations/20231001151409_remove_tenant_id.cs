using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project.web.Migrations
{
    /// <inheritdoc />
    public partial class remove_tenant_id : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TenantId",
                table: "Todo");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TenantId",
                table: "Todo",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
