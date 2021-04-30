using Microsoft.EntityFrameworkCore.Migrations;

namespace SchoolDiaryMVC.Migrations
{
    public partial class AddIsFinalGradepropertytoGrade : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsFinalGrade",
                table: "Grades",
                type: "bit",
                nullable: false,
                defaultValue: false);
           
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsFinalGrade",
                table: "Grades");
        }
    }
}
