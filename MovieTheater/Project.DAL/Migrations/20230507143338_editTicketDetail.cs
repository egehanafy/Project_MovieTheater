using Microsoft.EntityFrameworkCore.Migrations;

namespace Project.DAL.Migrations
{
    public partial class editTicketDetail : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<string>(
                name: "HallNo",
                table: "TicketDetails",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SeatLetter",
                table: "TicketDetails",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SeatNo",
                table: "TicketDetails",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "HallNo",
                table: "TicketDetails");

            migrationBuilder.DropColumn(
                name: "SeatLetter",
                table: "TicketDetails");

            migrationBuilder.DropColumn(
                name: "SeatNo",
                table: "TicketDetails");

            migrationBuilder.AddColumn<string>(
                name: "HallNo",
                table: "Tickets",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SeatLetter",
                table: "Tickets",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SeatNo",
                table: "Tickets",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
