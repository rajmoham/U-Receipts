using Microsoft.EntityFrameworkCore.Migrations;

namespace Hackathon_KCLMS.Migrations
{
    public partial class AddCardName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "BankCardLink",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "BankCardLink");
        }
    }
}
