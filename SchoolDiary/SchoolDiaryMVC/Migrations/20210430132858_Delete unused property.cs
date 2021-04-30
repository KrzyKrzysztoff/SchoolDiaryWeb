using Microsoft.EntityFrameworkCore.Migrations;

namespace SchoolDiaryMVC.Migrations
{
    public partial class Deleteunusedproperty : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
           migrationBuilder.DropColumn("Test2", "Lessons");
           migrationBuilder.DropColumn("Test", "Lessons");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
