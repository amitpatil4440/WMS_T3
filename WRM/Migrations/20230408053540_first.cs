using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WRM.Migrations
{
    public partial class first : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PassengerTbl",
                columns: table => new
                {
                    PId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PName = table.Column<string>(nullable: true),
                    PNRNo = table.Column<string>(nullable: false),
                    GateNo = table.Column<int>(nullable: false),
                    ContactNo = table.Column<string>(nullable: true),
                    StartDate = table.Column<DateTime>(nullable: false),
                    EndDate = table.Column<DateTime>(nullable: false),
                    Departure = table.Column<string>(nullable: true),
                    Arrival = table.Column<string>(nullable: true),
                    SeatNo = table.Column<int>(nullable: false),
                    Class = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PassengerTbl", x => x.PId);
                });

            migrationBuilder.CreateTable(
                name: "StaffTbl",
                columns: table => new
                {
                    Email = table.Column<string>(nullable: false),
                    StaffId = table.Column<int>(nullable: false),
                    StaffName = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: false),
                    CPassword = table.Column<string>(nullable: true),
                    Availability = table.Column<string>(nullable: true),
                    WorkingStatus = table.Column<string>(nullable: true),
                    ContactNo = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StaffTbl", x => x.Email);
                });

            migrationBuilder.CreateTable(
                name: "SupervisorTbl",
                columns: table => new
                {
                    Email = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: false),
                    CPassword = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SupervisorTbl", x => x.Email);
                });

            migrationBuilder.CreateTable(
                name: "WheelChairTbl",
                columns: table => new
                {
                    WId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Status = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WheelChairTbl", x => x.WId);
                });

            migrationBuilder.CreateTable(
                name: "WRequestTbl",
                columns: table => new
                {
                    PNRNo = table.Column<string>(nullable: false),
                    GateNo = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WRequestTbl", x => x.PNRNo);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PassengerTbl");

            migrationBuilder.DropTable(
                name: "StaffTbl");

            migrationBuilder.DropTable(
                name: "SupervisorTbl");

            migrationBuilder.DropTable(
                name: "WheelChairTbl");

            migrationBuilder.DropTable(
                name: "WRequestTbl");
        }
    }
}
