using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ASS3.Migrations
{
    /// <inheritdoc />
    public partial class ManyToMany2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CourseStudent_courses_coursesId",
                table: "CourseStudent");

            migrationBuilder.DropForeignKey(
                name: "FK_CourseStudent_students_studentsId",
                table: "CourseStudent");

            migrationBuilder.RenameColumn(
                name: "studentsId",
                table: "CourseStudent",
                newName: "CourseID");

            migrationBuilder.RenameColumn(
                name: "coursesId",
                table: "CourseStudent",
                newName: "StudentID");

            migrationBuilder.RenameIndex(
                name: "IX_CourseStudent_studentsId",
                table: "CourseStudent",
                newName: "IX_CourseStudent_CourseID");

            migrationBuilder.AddColumn<double>(
                name: "grade",
                table: "CourseStudent",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddForeignKey(
                name: "FK_CourseStudent_courses_CourseID",
                table: "CourseStudent",
                column: "CourseID",
                principalTable: "courses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CourseStudent_students_StudentID",
                table: "CourseStudent",
                column: "StudentID",
                principalTable: "students",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CourseStudent_courses_CourseID",
                table: "CourseStudent");

            migrationBuilder.DropForeignKey(
                name: "FK_CourseStudent_students_StudentID",
                table: "CourseStudent");

            migrationBuilder.DropColumn(
                name: "grade",
                table: "CourseStudent");

            migrationBuilder.RenameColumn(
                name: "CourseID",
                table: "CourseStudent",
                newName: "studentsId");

            migrationBuilder.RenameColumn(
                name: "StudentID",
                table: "CourseStudent",
                newName: "coursesId");

            migrationBuilder.RenameIndex(
                name: "IX_CourseStudent_CourseID",
                table: "CourseStudent",
                newName: "IX_CourseStudent_studentsId");

            migrationBuilder.AddForeignKey(
                name: "FK_CourseStudent_courses_coursesId",
                table: "CourseStudent",
                column: "coursesId",
                principalTable: "courses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CourseStudent_students_studentsId",
                table: "CourseStudent",
                column: "studentsId",
                principalTable: "students",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
