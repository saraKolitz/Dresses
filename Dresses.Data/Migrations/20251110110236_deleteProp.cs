using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Dresses.Data.Migrations
{
    /// <inheritdoc />
    public partial class deleteProp : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "description",
                table: "Dresses",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "name",
                table: "Dresses",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "rental_price",
                table: "Dresses",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "size",
                table: "Dresses",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "description",
                table: "Dresses");

            migrationBuilder.DropColumn(
                name: "name",
                table: "Dresses");

            migrationBuilder.DropColumn(
                name: "rental_price",
                table: "Dresses");

            migrationBuilder.DropColumn(
                name: "size",
                table: "Dresses");
        }
    }
}
