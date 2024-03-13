using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Exams_App_C__.Net_Server.Migrations
{
    /// <inheritdoc />
    public partial class v4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CoursesUsers");

            migrationBuilder.AddColumn<string>(
                name: "CourseId",
                table: "Users",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-1",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 22, 22, 47, 490, DateTimeKind.Local).AddTicks(9256));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-2",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 22, 22, 47, 490, DateTimeKind.Local).AddTicks(9317));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-21",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 22, 22, 47, 490, DateTimeKind.Local).AddTicks(9336));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-22",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 22, 22, 47, 490, DateTimeKind.Local).AddTicks(9363));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-23",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 22, 22, 47, 490, DateTimeKind.Local).AddTicks(9367));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-24",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 22, 22, 47, 490, DateTimeKind.Local).AddTicks(9369));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-3",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 22, 22, 47, 490, DateTimeKind.Local).AddTicks(9320));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-31",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 22, 22, 47, 490, DateTimeKind.Local).AddTicks(9372));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-32",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 22, 22, 47, 490, DateTimeKind.Local).AddTicks(9374));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-33",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 22, 22, 47, 490, DateTimeKind.Local).AddTicks(9377));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-34",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 22, 22, 47, 490, DateTimeKind.Local).AddTicks(9381));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-4",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 22, 22, 47, 490, DateTimeKind.Local).AddTicks(9333));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: "c-1",
                columns: new[] { "CourseEndingDate", "CourseStartingDate", "CreatedAt" },
                values: new object[] { new DateTime(2024, 6, 13, 22, 22, 47, 490, DateTimeKind.Local).AddTicks(9514), new DateTime(2024, 3, 13, 22, 22, 47, 490, DateTimeKind.Local).AddTicks(9513), new DateTime(2024, 3, 13, 22, 22, 47, 490, DateTimeKind.Local).AddTicks(9507) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: "c-2",
                columns: new[] { "CourseEndingDate", "CourseStartingDate", "CreatedAt" },
                values: new object[] { new DateTime(2024, 6, 13, 22, 22, 47, 490, DateTimeKind.Local).AddTicks(9523), new DateTime(2024, 3, 13, 22, 22, 47, 490, DateTimeKind.Local).AddTicks(9522), new DateTime(2024, 3, 13, 22, 22, 47, 490, DateTimeKind.Local).AddTicks(9520) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: "c-3",
                columns: new[] { "CourseEndingDate", "CourseStartingDate", "CreatedAt" },
                values: new object[] { new DateTime(2024, 6, 13, 22, 22, 47, 490, DateTimeKind.Local).AddTicks(9529), new DateTime(2024, 3, 13, 22, 22, 47, 490, DateTimeKind.Local).AddTicks(9528), new DateTime(2024, 3, 13, 22, 22, 47, 490, DateTimeKind.Local).AddTicks(9526) });

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: "e-1",
                columns: new[] { "CreatedAt", "StartExamDateTime" },
                values: new object[] { new DateTime(2024, 3, 13, 22, 22, 47, 490, DateTimeKind.Local).AddTicks(9551), new DateTime(2024, 3, 20, 22, 22, 47, 490, DateTimeKind.Local).AddTicks(9554) });

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: "e-2",
                columns: new[] { "CreatedAt", "StartExamDateTime" },
                values: new object[] { new DateTime(2024, 3, 13, 22, 22, 47, 490, DateTimeKind.Local).AddTicks(9559), new DateTime(2024, 3, 27, 22, 22, 47, 490, DateTimeKind.Local).AddTicks(9561) });

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: "e-3",
                columns: new[] { "CreatedAt", "StartExamDateTime" },
                values: new object[] { new DateTime(2024, 3, 13, 22, 22, 47, 490, DateTimeKind.Local).AddTicks(9564), new DateTime(2024, 4, 3, 22, 22, 47, 490, DateTimeKind.Local).AddTicks(9565) });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-1",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 22, 22, 47, 490, DateTimeKind.Local).AddTicks(9595));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-2",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 22, 22, 47, 490, DateTimeKind.Local).AddTicks(9602));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-3",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 22, 22, 47, 490, DateTimeKind.Local).AddTicks(9606));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-4",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 22, 22, 47, 490, DateTimeKind.Local).AddTicks(9610));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-5",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 22, 22, 47, 490, DateTimeKind.Local).AddTicks(9614));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-6",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 22, 22, 47, 490, DateTimeKind.Local).AddTicks(9618));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-7",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 22, 22, 47, 490, DateTimeKind.Local).AddTicks(9621));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-8",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 22, 22, 47, 490, DateTimeKind.Local).AddTicks(9625));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-9",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 22, 22, 47, 490, DateTimeKind.Local).AddTicks(9629));

            migrationBuilder.UpdateData(
                table: "StudentsExams",
                keyColumn: "Id",
                keyValue: "se-1",
                columns: new[] { "CreatedAt", "ExamStartTime" },
                values: new object[] { new DateTime(2024, 3, 13, 22, 22, 47, 490, DateTimeKind.Local).AddTicks(9658), new DateTime(2024, 3, 13, 20, 22, 47, 490, DateTimeKind.Local).AddTicks(9663) });

            migrationBuilder.UpdateData(
                table: "StudentsExams",
                keyColumn: "Id",
                keyValue: "se-2",
                columns: new[] { "CreatedAt", "ExamStartTime" },
                values: new object[] { new DateTime(2024, 3, 13, 22, 22, 47, 490, DateTimeKind.Local).AddTicks(9666), new DateTime(2024, 3, 13, 19, 22, 47, 490, DateTimeKind.Local).AddTicks(9669) });

            migrationBuilder.UpdateData(
                table: "StudentsExams",
                keyColumn: "Id",
                keyValue: "se-3",
                columns: new[] { "CreatedAt", "ExamStartTime" },
                values: new object[] { new DateTime(2024, 3, 13, 22, 22, 47, 490, DateTimeKind.Local).AddTicks(9671), new DateTime(2024, 3, 13, 18, 22, 47, 490, DateTimeKind.Local).AddTicks(9673) });

            migrationBuilder.UpdateData(
                table: "StudentsExams",
                keyColumn: "Id",
                keyValue: "se-4",
                columns: new[] { "CreatedAt", "ExamStartTime" },
                values: new object[] { new DateTime(2024, 3, 13, 22, 22, 47, 490, DateTimeKind.Local).AddTicks(9675), new DateTime(2024, 3, 13, 17, 22, 47, 490, DateTimeKind.Local).AddTicks(9677) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "a-1",
                columns: new[] { "CourseId", "CreatedAt" },
                values: new object[] { null, new DateTime(2024, 3, 13, 22, 22, 47, 490, DateTimeKind.Local).AddTicks(9698) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "s-1",
                columns: new[] { "CourseId", "CreatedAt" },
                values: new object[] { "c-1", new DateTime(2024, 3, 13, 22, 22, 47, 490, DateTimeKind.Local).AddTicks(9707) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "s-2",
                columns: new[] { "CourseId", "CreatedAt" },
                values: new object[] { "c-1", new DateTime(2024, 3, 13, 22, 22, 47, 490, DateTimeKind.Local).AddTicks(9723) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "t-1",
                columns: new[] { "CourseId", "CreatedAt" },
                values: new object[] { "c-1", new DateTime(2024, 3, 13, 22, 22, 47, 490, DateTimeKind.Local).AddTicks(9704) });

            migrationBuilder.CreateIndex(
                name: "IX_Users_CourseId",
                table: "Users",
                column: "CourseId");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Courses_CourseId",
                table: "Users",
                column: "CourseId",
                principalTable: "Courses",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_Courses_CourseId",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_CourseId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "CourseId",
                table: "Users");

            migrationBuilder.CreateTable(
                name: "CoursesUsers",
                columns: table => new
                {
                    CourseId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.ForeignKey(
                        name: "FK_CoursesUsers_Courses_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Courses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CoursesUsers_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-1",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 22, 14, 45, 771, DateTimeKind.Local).AddTicks(3223));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-2",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 22, 14, 45, 771, DateTimeKind.Local).AddTicks(3286));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-21",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 22, 14, 45, 771, DateTimeKind.Local).AddTicks(3306));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-22",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 22, 14, 45, 771, DateTimeKind.Local).AddTicks(3310));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-23",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 22, 14, 45, 771, DateTimeKind.Local).AddTicks(3312));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-24",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 22, 14, 45, 771, DateTimeKind.Local).AddTicks(3315));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-3",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 22, 14, 45, 771, DateTimeKind.Local).AddTicks(3290));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-31",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 22, 14, 45, 771, DateTimeKind.Local).AddTicks(3318));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-32",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 22, 14, 45, 771, DateTimeKind.Local).AddTicks(3320));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-33",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 22, 14, 45, 771, DateTimeKind.Local).AddTicks(3323));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-34",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 22, 14, 45, 771, DateTimeKind.Local).AddTicks(3326));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-4",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 22, 14, 45, 771, DateTimeKind.Local).AddTicks(3293));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: "c-1",
                columns: new[] { "CourseEndingDate", "CourseStartingDate", "CreatedAt" },
                values: new object[] { new DateTime(2024, 6, 13, 22, 14, 45, 771, DateTimeKind.Local).AddTicks(3485), new DateTime(2024, 3, 13, 22, 14, 45, 771, DateTimeKind.Local).AddTicks(3484), new DateTime(2024, 3, 13, 22, 14, 45, 771, DateTimeKind.Local).AddTicks(3476) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: "c-2",
                columns: new[] { "CourseEndingDate", "CourseStartingDate", "CreatedAt" },
                values: new object[] { new DateTime(2024, 6, 13, 22, 14, 45, 771, DateTimeKind.Local).AddTicks(3495), new DateTime(2024, 3, 13, 22, 14, 45, 771, DateTimeKind.Local).AddTicks(3493), new DateTime(2024, 3, 13, 22, 14, 45, 771, DateTimeKind.Local).AddTicks(3491) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: "c-3",
                columns: new[] { "CourseEndingDate", "CourseStartingDate", "CreatedAt" },
                values: new object[] { new DateTime(2024, 6, 13, 22, 14, 45, 771, DateTimeKind.Local).AddTicks(3501), new DateTime(2024, 3, 13, 22, 14, 45, 771, DateTimeKind.Local).AddTicks(3500), new DateTime(2024, 3, 13, 22, 14, 45, 771, DateTimeKind.Local).AddTicks(3498) });

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: "e-1",
                columns: new[] { "CreatedAt", "StartExamDateTime" },
                values: new object[] { new DateTime(2024, 3, 13, 22, 14, 45, 771, DateTimeKind.Local).AddTicks(3527), new DateTime(2024, 3, 20, 22, 14, 45, 771, DateTimeKind.Local).AddTicks(3532) });

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: "e-2",
                columns: new[] { "CreatedAt", "StartExamDateTime" },
                values: new object[] { new DateTime(2024, 3, 13, 22, 14, 45, 771, DateTimeKind.Local).AddTicks(3537), new DateTime(2024, 3, 27, 22, 14, 45, 771, DateTimeKind.Local).AddTicks(3539) });

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: "e-3",
                columns: new[] { "CreatedAt", "StartExamDateTime" },
                values: new object[] { new DateTime(2024, 3, 13, 22, 14, 45, 771, DateTimeKind.Local).AddTicks(3542), new DateTime(2024, 4, 3, 22, 14, 45, 771, DateTimeKind.Local).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-1",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 22, 14, 45, 771, DateTimeKind.Local).AddTicks(3576));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-2",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 22, 14, 45, 771, DateTimeKind.Local).AddTicks(3581));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-3",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 22, 14, 45, 771, DateTimeKind.Local).AddTicks(3636));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-4",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 22, 14, 45, 771, DateTimeKind.Local).AddTicks(3640));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-5",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 22, 14, 45, 771, DateTimeKind.Local).AddTicks(3644));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-6",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 22, 14, 45, 771, DateTimeKind.Local).AddTicks(3649));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-7",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 22, 14, 45, 771, DateTimeKind.Local).AddTicks(3654));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-8",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 22, 14, 45, 771, DateTimeKind.Local).AddTicks(3658));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-9",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 22, 14, 45, 771, DateTimeKind.Local).AddTicks(3663));

            migrationBuilder.UpdateData(
                table: "StudentsExams",
                keyColumn: "Id",
                keyValue: "se-1",
                columns: new[] { "CreatedAt", "ExamStartTime" },
                values: new object[] { new DateTime(2024, 3, 13, 22, 14, 45, 771, DateTimeKind.Local).AddTicks(3694), new DateTime(2024, 3, 13, 20, 14, 45, 771, DateTimeKind.Local).AddTicks(3705) });

            migrationBuilder.UpdateData(
                table: "StudentsExams",
                keyColumn: "Id",
                keyValue: "se-2",
                columns: new[] { "CreatedAt", "ExamStartTime" },
                values: new object[] { new DateTime(2024, 3, 13, 22, 14, 45, 771, DateTimeKind.Local).AddTicks(3710), new DateTime(2024, 3, 13, 19, 14, 45, 771, DateTimeKind.Local).AddTicks(3712) });

            migrationBuilder.UpdateData(
                table: "StudentsExams",
                keyColumn: "Id",
                keyValue: "se-3",
                columns: new[] { "CreatedAt", "ExamStartTime" },
                values: new object[] { new DateTime(2024, 3, 13, 22, 14, 45, 771, DateTimeKind.Local).AddTicks(3715), new DateTime(2024, 3, 13, 18, 14, 45, 771, DateTimeKind.Local).AddTicks(3717) });

            migrationBuilder.UpdateData(
                table: "StudentsExams",
                keyColumn: "Id",
                keyValue: "se-4",
                columns: new[] { "CreatedAt", "ExamStartTime" },
                values: new object[] { new DateTime(2024, 3, 13, 22, 14, 45, 771, DateTimeKind.Local).AddTicks(3719), new DateTime(2024, 3, 13, 17, 14, 45, 771, DateTimeKind.Local).AddTicks(3722) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "a-1",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 22, 14, 45, 771, DateTimeKind.Local).AddTicks(3748));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "s-1",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 22, 14, 45, 771, DateTimeKind.Local).AddTicks(3759));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "s-2",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 22, 14, 45, 771, DateTimeKind.Local).AddTicks(3764));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "t-1",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 22, 14, 45, 771, DateTimeKind.Local).AddTicks(3755));

            migrationBuilder.CreateIndex(
                name: "IX_CoursesUsers_CourseId",
                table: "CoursesUsers",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_CoursesUsers_UserId",
                table: "CoursesUsers",
                column: "UserId");
        }
    }
}
