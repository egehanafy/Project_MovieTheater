using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Project.DAL.Migrations
{
    public partial class editShowTime : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ShowTimeId",
                table: "Tickets");

            migrationBuilder.AddColumn<DateTime>(
                name: "ShowTime",
                table: "TicketDetails",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "MovieId",
                table: "Halls",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Halls_MovieId",
                table: "Halls",
                column: "MovieId");

            migrationBuilder.AddForeignKey(
                name: "FK_Halls_Movies_MovieId",
                table: "Halls",
                column: "MovieId",
                principalTable: "Movies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Halls_Movies_MovieId",
                table: "Halls");

            migrationBuilder.DropIndex(
                name: "IX_Halls_MovieId",
                table: "Halls");

            migrationBuilder.DropColumn(
                name: "ShowTime",
                table: "TicketDetails");

            migrationBuilder.DropColumn(
                name: "MovieId",
                table: "Halls");

            migrationBuilder.AddColumn<int>(
                name: "ShowTimeId",
                table: "Tickets",
                type: "int",
                nullable: true);
        }
    }
}
