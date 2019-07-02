using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace insuranceApp.Migrations
{
    public partial class AddModels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "OtherPremiums",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    SumInsured = table.Column<int>(nullable: false),
                    Field18_25 = table.Column<int>(nullable: false),
                    Field26_40 = table.Column<int>(nullable: false),
                    Field41_45 = table.Column<int>(nullable: false),
                    Field46_50 = table.Column<int>(nullable: false),
                    Field51_55 = table.Column<int>(nullable: false),
                    Field56_60 = table.Column<int>(nullable: false),
                    Field61_65 = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OtherPremiums", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OwnPremiums",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    SumInsured = table.Column<int>(nullable: false),
                    Field18_25 = table.Column<int>(nullable: false),
                    Field26_40 = table.Column<int>(nullable: false),
                    Field41_45 = table.Column<int>(nullable: false),
                    Field46_50 = table.Column<int>(nullable: false),
                    Field51_55 = table.Column<int>(nullable: false),
                    Field56_60 = table.Column<int>(nullable: false),
                    Field61_65 = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OwnPremiums", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OtherPremiums");

            migrationBuilder.DropTable(
                name: "OwnPremiums");
        }
    }
}
