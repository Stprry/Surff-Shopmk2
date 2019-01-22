using Microsoft.EntityFrameworkCore.Migrations;

namespace SurfShop.Data.Migrations
{
    public partial class RenamedBeachModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Feedback_Beaches_BeachesID",
                table: "Feedback");

            migrationBuilder.RenameColumn(
                name: "BeachesID",
                table: "Feedback",
                newName: "BeachID");

            migrationBuilder.RenameIndex(
                name: "IX_Feedback_BeachesID",
                table: "Feedback",
                newName: "IX_Feedback_BeachID");

            migrationBuilder.RenameColumn(
                name: "BeachesID",
                table: "Beaches",
                newName: "BeachID");

            migrationBuilder.AddForeignKey(
                name: "FK_Feedback_Beaches_BeachID",
                table: "Feedback",
                column: "BeachID",
                principalTable: "Beaches",
                principalColumn: "BeachID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Feedback_Beaches_BeachID",
                table: "Feedback");

            migrationBuilder.RenameColumn(
                name: "BeachID",
                table: "Feedback",
                newName: "BeachesID");

            migrationBuilder.RenameIndex(
                name: "IX_Feedback_BeachID",
                table: "Feedback",
                newName: "IX_Feedback_BeachesID");

            migrationBuilder.RenameColumn(
                name: "BeachID",
                table: "Beaches",
                newName: "BeachesID");

            migrationBuilder.AddForeignKey(
                name: "FK_Feedback_Beaches_BeachesID",
                table: "Feedback",
                column: "BeachesID",
                principalTable: "Beaches",
                principalColumn: "BeachesID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
