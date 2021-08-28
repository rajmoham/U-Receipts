using Microsoft.EntityFrameworkCore.Migrations;

namespace Hackathon_KCLMS.Migrations
{
    public partial class AddUserIdToBankCard : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "BankCardLink",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_BankCardLink_UserId",
                table: "BankCardLink",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_BankCardLink_AspNetUsers_UserId",
                table: "BankCardLink",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BankCardLink_AspNetUsers_UserId",
                table: "BankCardLink");

            migrationBuilder.DropIndex(
                name: "IX_BankCardLink_UserId",
                table: "BankCardLink");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "BankCardLink");
        }
    }
}
