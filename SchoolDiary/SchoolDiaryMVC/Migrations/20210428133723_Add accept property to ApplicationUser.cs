using Microsoft.EntityFrameworkCore.Migrations;

namespace SchoolDiaryMVC.Migrations
{
    public partial class AddacceptpropertytoApplicationUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Accepted",
                table: "AspNetUsers",
                type: "bit",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Accepted",
                table: "AspNetUsers");
        }
    }
}
