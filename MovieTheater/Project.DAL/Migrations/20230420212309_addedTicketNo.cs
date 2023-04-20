using Microsoft.EntityFrameworkCore.Migrations;

namespace Project.DAL.Migrations
{
    public partial class addedTicketNo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "TicketNo",
                table: "Tickets",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TicketNo",
                table: "Tickets");
        }
    }
}
