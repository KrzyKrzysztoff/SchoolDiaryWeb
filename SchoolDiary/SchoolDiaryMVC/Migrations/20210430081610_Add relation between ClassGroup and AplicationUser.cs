using Microsoft.EntityFrameworkCore.Migrations;

namespace SchoolDiaryMVC.Migrations
{
    public partial class AddrelationbetweenClassGroupandAplicationUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ClassGroupId",
                table: "AspNetUsers",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_ClassGroupId",
                table: "AspNetUsers",
                column: "ClassGroupId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_ClassesGroup_ClassGroupId",
                table: "AspNetUsers",
                column: "ClassGroupId",
                principalTable: "ClassesGroup",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_ClassesGroup_ClassGroupId",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_ClassGroupId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "ClassGroupId",
                table: "AspNetUsers");
        }
    }
}
