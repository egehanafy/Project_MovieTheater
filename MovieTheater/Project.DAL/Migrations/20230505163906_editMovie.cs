using Microsoft.EntityFrameworkCore.Migrations;

namespace Project.DAL.Migrations
{
    public partial class editMovie : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Movies_Halls_HallId",
                table: "Movies");

            migrationBuilder.DropIndex(
                name: "IX_Movies_HallId",
                table: "Movies");

            migrationBuilder.DropColumn(
                name: "HallId",
                table: "Movies");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "HallId",
                table: "Movies",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Movies_HallId",
                table: "Movies",
                column: "HallId");

            migrationBuilder.AddForeignKey(
                name: "FK_Movies_Halls_HallId",
                table: "Movies",
                column: "HallId",
                principalTable: "Halls",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
