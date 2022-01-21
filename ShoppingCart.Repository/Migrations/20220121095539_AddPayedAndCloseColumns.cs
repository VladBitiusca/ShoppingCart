using Microsoft.EntityFrameworkCore.Migrations;

namespace ShoppingCart.Repository.Migrations
{
    public partial class AddPayedAndCloseColumns : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Close",
                table: "Baskets",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Payed",
                table: "Baskets",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Close",
                table: "Baskets");

            migrationBuilder.DropColumn(
                name: "Payed",
                table: "Baskets");
        }
    }
}
