using Microsoft.EntityFrameworkCore.Migrations;

namespace insuranceApp.Migrations
{
    public partial class AddPremiumField : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Premium",
                table: "PremiumsHistories",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Premium",
                table: "PremiumsHistories");
        }
    }
}
