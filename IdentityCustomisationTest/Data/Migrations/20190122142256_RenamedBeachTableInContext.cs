using Microsoft.EntityFrameworkCore.Migrations;

namespace SurfShop.Data.Migrations
{
    public partial class RenamedBeachTableInContext : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Feedback_Beaches_BeachID",
                table: "Feedback");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Beaches",
                table: "Beaches");

            migrationBuilder.RenameTable(
                name: "Beaches",
                newName: "Beach");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Beach",
                table: "Beach",
                column: "BeachID");

            migrationBuilder.AddForeignKey(
                name: "FK_Feedback_Beach_BeachID",
                table: "Feedback",
                column: "BeachID",
                principalTable: "Beach",
                principalColumn: "BeachID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Feedback_Beach_BeachID",
                table: "Feedback");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Beach",
                table: "Beach");

            migrationBuilder.RenameTable(
                name: "Beach",
                newName: "Beaches");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Beaches",
                table: "Beaches",
                column: "BeachID");

            migrationBuilder.AddForeignKey(
                name: "FK_Feedback_Beaches_BeachID",
                table: "Feedback",
                column: "BeachID",
                principalTable: "Beaches",
                principalColumn: "BeachID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
