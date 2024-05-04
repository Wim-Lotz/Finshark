using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace api.Migrations
{
    /// <inheritdoc />
    public partial class fix_column_names : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MyProperty",
                table: "Stocks");

            migrationBuilder.RenameColumn(
                name: "MarkeyCap",
                table: "Stocks",
                newName: "MarketCap");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "MarketCap",
                table: "Stocks",
                newName: "MarkeyCap");

            migrationBuilder.AddColumn<int>(
                name: "MyProperty",
                table: "Stocks",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
