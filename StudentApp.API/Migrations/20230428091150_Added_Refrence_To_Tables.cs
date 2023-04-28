using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StudentApp.API.Migrations
{
    public partial class Added_Refrence_To_Tables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SubjectId",
                table: "Students",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Students_SubjectId",
                table: "Students",
                column: "SubjectId");

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Subjects_SubjectId",
                table: "Students",
                column: "SubjectId",
                principalTable: "Subjects",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Students_Subjects_SubjectId",
                table: "Students");

            migrationBuilder.DropIndex(
                name: "IX_Students_SubjectId",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "SubjectId",
                table: "Students");
        }
    }
}
