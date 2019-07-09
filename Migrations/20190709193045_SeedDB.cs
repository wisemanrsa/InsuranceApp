using Microsoft.EntityFrameworkCore.Migrations;

namespace insuranceApp.Migrations {
    public partial class SeedDB : Migration {
        protected override void Up (MigrationBuilder migrationBuilder) {
            migrationBuilder.Sql ("INSERT INTO OwnPremiums(SumInsured, Field18_25, Field26_40, Field41_45, Field46_50, Field51_55, Field56_60, Field61_65) VALUES(10000.00, 36.00, 47.00, 52.00, 57.00, 64.00, 74.00, 90.00)");
            migrationBuilder.Sql ("INSERT INTO OwnPremiums(SumInsured, Field18_25, Field26_40, Field41_45, Field46_50, Field51_55, Field56_60, Field61_65) VALUES(15000.00, 49.05, 64.95, 73.05, 79.95, 90.00, 106.05, 130.05)");
            migrationBuilder.Sql ("INSERT INTO OwnPremiums(SumInsured, Field18_25, Field26_40, Field41_45, Field46_50, Field51_55, Field56_60, Field61_65) VALUES(18000.00, 57.06, 75.42, 85.32, 93.42, 105.84, 125.46, 154.26)");
            migrationBuilder.Sql ("INSERT INTO OwnPremiums(SumInsured, Field18_25, Field26_40, Field41_45, Field46_50, Field51_55, Field56_60, Field61_65) VALUES(20000.00, 62.00, 82.00, 93.00, 102.00, 116.00, 138.00, 170.00)");
            migrationBuilder.Sql ("INSERT INTO OwnPremiums(SumInsured, Field18_25, Field26_40, Field41_45, Field46_50, Field51_55, Field56_60, Field61_65) VALUES(30000.00, 93.00, 123.00, 139.50, 153.00, 174.00, 207.00, 255.00)");

            migrationBuilder.Sql ("INSERT INTO OtherPremiums(SumInsured, Field18_25, Field26_40, Field41_45, Field46_50, Field51_55, Field56_60, Field61_65) VALUES(5000.00, 30.00, 38.00, 42.00, 46.00, 51.00, 61.00, 74.00)");
            migrationBuilder.Sql ("INSERT INTO OtherPremiums(SumInsured, Field18_25, Field26_40, Field41_45, Field46_50, Field51_55, Field56_60, Field61_65) VALUES(12000.00, 36.00, 48.00, 54.00, 58.95, 67.95, 82.05, 103.05)");
            migrationBuilder.Sql ("INSERT INTO OtherPremiums(SumInsured, Field18_25, Field26_40, Field41_45, Field46_50, Field51_55, Field56_60, Field61_65) VALUES(18000.00, 39.96, 54.36, 61.56, 67.68, 78.48, 95.58, 120.24)");
            migrationBuilder.Sql ("INSERT INTO OtherPremiums(SumInsured, Field18_25, Field26_40, Field41_45, Field46_50, Field51_55, Field56_60, Field61_65) VALUES(22000.00, 42.00, 58.00, 66.00, 73.00, 85.00, 104.00, 131.00)");
            migrationBuilder.Sql ("INSERT INTO OtherPremiums(SumInsured, Field18_25, Field26_40, Field41_45, Field46_50, Field51_55, Field56_60, Field61_65) VALUES(25000.00, 63.00, 87.00, 99.00, 109.50, 127.50, 156.00, 196.50)");
        }

        protected override void Down (MigrationBuilder migrationBuilder) {

        }
    }
}