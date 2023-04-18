using Microsoft.EntityFrameworkCore.Migrations;

namespace WRM.Migrations
{
    public partial class second : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CPassword",
                table: "SupervisorTbl");

            migrationBuilder.DropColumn(
                name: "CPassword",
                table: "StaffTbl");

            migrationBuilder.AddColumn<int>(
                name: "gateno",
                table: "StaffTbl",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "pnrno",
                table: "StaffTbl",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "gateno",
                table: "StaffTbl");

            migrationBuilder.DropColumn(
                name: "pnrno",
                table: "StaffTbl");

            migrationBuilder.AddColumn<string>(
                name: "CPassword",
                table: "SupervisorTbl",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CPassword",
                table: "StaffTbl",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
