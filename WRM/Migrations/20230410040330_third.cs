using Microsoft.EntityFrameworkCore.Migrations;

namespace WRM.Migrations
{
    public partial class third : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_WRequestTbl",
                table: "WRequestTbl");

            migrationBuilder.DropColumn(
                name: "Class",
                table: "PassengerTbl");

            migrationBuilder.AlterColumn<string>(
                name: "PNRNo",
                table: "WRequestTbl",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<int>(
                name: "SSRId",
                table: "WRequestTbl",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<string>(
                name: "FlightClass",
                table: "PassengerTbl",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_WRequestTbl",
                table: "WRequestTbl",
                column: "SSRId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_WRequestTbl",
                table: "WRequestTbl");

            migrationBuilder.DropColumn(
                name: "SSRId",
                table: "WRequestTbl");

            migrationBuilder.DropColumn(
                name: "FlightClass",
                table: "PassengerTbl");

            migrationBuilder.AlterColumn<string>(
                name: "PNRNo",
                table: "WRequestTbl",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AddColumn<string>(
                name: "Class",
                table: "PassengerTbl",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_WRequestTbl",
                table: "WRequestTbl",
                column: "PNRNo");
        }
    }
}
