using Microsoft.EntityFrameworkCore.Migrations;

namespace Project.DAL.Migrations
{
    public partial class editTicket : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "HallNo",
                table: "Tickets",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SeatLetter",
                table: "Tickets",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SeatNo",
                table: "Tickets",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ShowTimeId",
                table: "Tickets",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "No",
                table: "Seats",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "HallNo",
                table: "Tickets");

            migrationBuilder.DropColumn(
                name: "SeatLetter",
                table: "Tickets");

            migrationBuilder.DropColumn(
                name: "SeatNo",
                table: "Tickets");

            migrationBuilder.DropColumn(
                name: "ShowTimeId",
                table: "Tickets");

            migrationBuilder.AlterColumn<int>(
                name: "No",
                table: "Seats",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
