using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ASS3.Migrations
{
    /// <inheritdoc />
    public partial class ManyToMany1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_courses_courses_CourseId",
                table: "courses");

            migrationBuilder.DropForeignKey(
                name: "FK_students_students_StudentId",
                table: "students");

            migrationBuilder.DropIndex(
                name: "IX_students_StudentId",
                table: "students");

            migrationBuilder.DropIndex(
                name: "IX_courses_CourseId",
                table: "courses");

            migrationBuilder.DropColumn(
                name: "StudentId",
                table: "students");

            migrationBuilder.DropColumn(
                name: "CourseId",
                table: "courses");

            migrationBuilder.CreateTable(
                name: "CourseStudent",
                columns: table => new
                {
                    coursesId = table.Column<int>(type: "int", nullable: false),
                    studentsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CourseStudent", x => new { x.coursesId, x.studentsId });
                    table.ForeignKey(
                        name: "FK_CourseStudent_courses_coursesId",
                        column: x => x.coursesId,
                        principalTable: "courses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CourseStudent_students_studentsId",
                        column: x => x.studentsId,
                        principalTable: "students",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CourseStudent_studentsId",
                table: "CourseStudent",
                column: "studentsId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CourseStudent");

            migrationBuilder.AddColumn<int>(
                name: "StudentId",
                table: "students",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CourseId",
                table: "courses",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_students_StudentId",
                table: "students",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_courses_CourseId",
                table: "courses",
                column: "CourseId");

            migrationBuilder.AddForeignKey(
                name: "FK_courses_courses_CourseId",
                table: "courses",
                column: "CourseId",
                principalTable: "courses",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_students_students_StudentId",
                table: "students",
                column: "StudentId",
                principalTable: "students",
                principalColumn: "Id");
        }
    }
}
