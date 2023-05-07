using Microsoft.EntityFrameworkCore.Migrations;

namespace Project.DAL.Migrations
{
    public partial class editMovie : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Halls_Movies_MovieId",
                table: "Halls");

            migrationBuilder.DropIndex(
                name: "IX_Halls_MovieId",
                table: "Halls");

            migrationBuilder.DropColumn(
                name: "MovieId",
                table: "Halls");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MovieId",
                table: "Halls",
                type: "int",
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
    }
}
