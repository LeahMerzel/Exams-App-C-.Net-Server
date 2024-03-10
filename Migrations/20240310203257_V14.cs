using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Exams_App_C__.Net_Server.Migrations
{
    /// <inheritdoc />
    public partial class V14 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-1",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 22, 32, 56, 704, DateTimeKind.Local).AddTicks(4616));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-2",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 22, 32, 56, 704, DateTimeKind.Local).AddTicks(4677));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-21",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 22, 32, 56, 704, DateTimeKind.Local).AddTicks(4685));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-22",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 22, 32, 56, 704, DateTimeKind.Local).AddTicks(4687));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-23",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 22, 32, 56, 704, DateTimeKind.Local).AddTicks(4690));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-24",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 22, 32, 56, 704, DateTimeKind.Local).AddTicks(4701));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-3",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 22, 32, 56, 704, DateTimeKind.Local).AddTicks(4680));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-31",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 22, 32, 56, 704, DateTimeKind.Local).AddTicks(4704));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-32",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 22, 32, 56, 704, DateTimeKind.Local).AddTicks(4706));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-33",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 22, 32, 56, 704, DateTimeKind.Local).AddTicks(4709));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-34",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 22, 32, 56, 704, DateTimeKind.Local).AddTicks(4711));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-4",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 22, 32, 56, 704, DateTimeKind.Local).AddTicks(4683));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: "c-1",
                columns: new[] { "CourseEndingDate", "CourseStartingDate", "CreatedAt" },
                values: new object[] { new DateTime(2024, 6, 10, 22, 32, 56, 704, DateTimeKind.Local).AddTicks(4848), new DateTime(2024, 3, 10, 22, 32, 56, 704, DateTimeKind.Local).AddTicks(4846), new DateTime(2024, 3, 10, 22, 32, 56, 704, DateTimeKind.Local).AddTicks(4840) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: "c-2",
                columns: new[] { "CourseEndingDate", "CourseStartingDate", "CreatedAt" },
                values: new object[] { new DateTime(2024, 6, 10, 22, 32, 56, 704, DateTimeKind.Local).AddTicks(4856), new DateTime(2024, 3, 10, 22, 32, 56, 704, DateTimeKind.Local).AddTicks(4855), new DateTime(2024, 3, 10, 22, 32, 56, 704, DateTimeKind.Local).AddTicks(4853) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: "c-3",
                columns: new[] { "CourseEndingDate", "CourseStartingDate", "CreatedAt" },
                values: new object[] { new DateTime(2024, 6, 10, 22, 32, 56, 704, DateTimeKind.Local).AddTicks(4863), new DateTime(2024, 3, 10, 22, 32, 56, 704, DateTimeKind.Local).AddTicks(4861), new DateTime(2024, 3, 10, 22, 32, 56, 704, DateTimeKind.Local).AddTicks(4859) });

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: "e-1",
                columns: new[] { "CreatedAt", "StartExamDateTime" },
                values: new object[] { new DateTime(2024, 3, 10, 22, 32, 56, 704, DateTimeKind.Local).AddTicks(4891), new DateTime(2024, 3, 17, 22, 32, 56, 704, DateTimeKind.Local).AddTicks(4896) });

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: "e-2",
                columns: new[] { "CreatedAt", "StartExamDateTime" },
                values: new object[] { new DateTime(2024, 3, 10, 22, 32, 56, 704, DateTimeKind.Local).AddTicks(4903), new DateTime(2024, 3, 24, 22, 32, 56, 704, DateTimeKind.Local).AddTicks(4905) });

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: "e-3",
                columns: new[] { "CreatedAt", "StartExamDateTime" },
                values: new object[] { new DateTime(2024, 3, 10, 22, 32, 56, 704, DateTimeKind.Local).AddTicks(4908), new DateTime(2024, 3, 31, 22, 32, 56, 704, DateTimeKind.Local).AddTicks(4910) });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-1",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 22, 32, 56, 704, DateTimeKind.Local).AddTicks(4960));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-2",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 22, 32, 56, 704, DateTimeKind.Local).AddTicks(4965));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-3",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 22, 32, 56, 704, DateTimeKind.Local).AddTicks(4970));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-4",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 22, 32, 56, 704, DateTimeKind.Local).AddTicks(4974));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-5",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 22, 32, 56, 704, DateTimeKind.Local).AddTicks(4978));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-6",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 22, 32, 56, 704, DateTimeKind.Local).AddTicks(4984));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-7",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 22, 32, 56, 704, DateTimeKind.Local).AddTicks(4988));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-8",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 22, 32, 56, 704, DateTimeKind.Local).AddTicks(4992));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-9",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 22, 32, 56, 704, DateTimeKind.Local).AddTicks(4996));

            migrationBuilder.UpdateData(
                table: "StudentsExams",
                keyColumn: "Id",
                keyValue: "se-1",
                columns: new[] { "CreatedAt", "ExamStartTime" },
                values: new object[] { new DateTime(2024, 3, 10, 22, 32, 56, 704, DateTimeKind.Local).AddTicks(5025), new DateTime(2024, 3, 10, 20, 32, 56, 704, DateTimeKind.Local).AddTicks(5031) });

            migrationBuilder.UpdateData(
                table: "StudentsExams",
                keyColumn: "Id",
                keyValue: "se-2",
                columns: new[] { "CreatedAt", "ExamStartTime" },
                values: new object[] { new DateTime(2024, 3, 10, 22, 32, 56, 704, DateTimeKind.Local).AddTicks(5034), new DateTime(2024, 3, 10, 19, 32, 56, 704, DateTimeKind.Local).AddTicks(5036) });

            migrationBuilder.UpdateData(
                table: "StudentsExams",
                keyColumn: "Id",
                keyValue: "se-3",
                columns: new[] { "CreatedAt", "ExamStartTime" },
                values: new object[] { new DateTime(2024, 3, 10, 22, 32, 56, 704, DateTimeKind.Local).AddTicks(5038), new DateTime(2024, 3, 10, 18, 32, 56, 704, DateTimeKind.Local).AddTicks(5040) });

            migrationBuilder.UpdateData(
                table: "StudentsExams",
                keyColumn: "Id",
                keyValue: "se-4",
                columns: new[] { "CreatedAt", "ExamStartTime" },
                values: new object[] { new DateTime(2024, 3, 10, 22, 32, 56, 704, DateTimeKind.Local).AddTicks(5042), new DateTime(2024, 3, 10, 17, 32, 56, 704, DateTimeKind.Local).AddTicks(5044) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "a-1",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 22, 32, 56, 704, DateTimeKind.Local).AddTicks(5068));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "s-1",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 22, 32, 56, 704, DateTimeKind.Local).AddTicks(5080));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "s-2",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 22, 32, 56, 704, DateTimeKind.Local).AddTicks(5084));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "t-1",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 22, 32, 56, 704, DateTimeKind.Local).AddTicks(5076));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-1",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 19, 30, 18, 249, DateTimeKind.Local).AddTicks(5305));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-2",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 19, 30, 18, 249, DateTimeKind.Local).AddTicks(5369));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-21",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 19, 30, 18, 249, DateTimeKind.Local).AddTicks(5378));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-22",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 19, 30, 18, 249, DateTimeKind.Local).AddTicks(5394));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-23",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 19, 30, 18, 249, DateTimeKind.Local).AddTicks(5397));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-24",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 19, 30, 18, 249, DateTimeKind.Local).AddTicks(5399));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-3",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 19, 30, 18, 249, DateTimeKind.Local).AddTicks(5373));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-31",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 19, 30, 18, 249, DateTimeKind.Local).AddTicks(5402));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-32",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 19, 30, 18, 249, DateTimeKind.Local).AddTicks(5405));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-33",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 19, 30, 18, 249, DateTimeKind.Local).AddTicks(5407));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-34",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 19, 30, 18, 249, DateTimeKind.Local).AddTicks(5409));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-4",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 19, 30, 18, 249, DateTimeKind.Local).AddTicks(5376));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: "c-1",
                columns: new[] { "CourseEndingDate", "CourseStartingDate", "CreatedAt" },
                values: new object[] { new DateTime(2024, 6, 10, 19, 30, 18, 249, DateTimeKind.Local).AddTicks(5570), new DateTime(2024, 3, 10, 19, 30, 18, 249, DateTimeKind.Local).AddTicks(5569), new DateTime(2024, 3, 10, 19, 30, 18, 249, DateTimeKind.Local).AddTicks(5535) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: "c-2",
                columns: new[] { "CourseEndingDate", "CourseStartingDate", "CreatedAt" },
                values: new object[] { new DateTime(2024, 6, 10, 19, 30, 18, 249, DateTimeKind.Local).AddTicks(5583), new DateTime(2024, 3, 10, 19, 30, 18, 249, DateTimeKind.Local).AddTicks(5581), new DateTime(2024, 3, 10, 19, 30, 18, 249, DateTimeKind.Local).AddTicks(5579) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: "c-3",
                columns: new[] { "CourseEndingDate", "CourseStartingDate", "CreatedAt" },
                values: new object[] { new DateTime(2024, 6, 10, 19, 30, 18, 249, DateTimeKind.Local).AddTicks(5588), new DateTime(2024, 3, 10, 19, 30, 18, 249, DateTimeKind.Local).AddTicks(5587), new DateTime(2024, 3, 10, 19, 30, 18, 249, DateTimeKind.Local).AddTicks(5585) });

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: "e-1",
                columns: new[] { "CreatedAt", "StartExamDateTime" },
                values: new object[] { new DateTime(2024, 3, 10, 19, 30, 18, 249, DateTimeKind.Local).AddTicks(5613), new DateTime(2024, 3, 17, 19, 30, 18, 249, DateTimeKind.Local).AddTicks(5618) });

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: "e-2",
                columns: new[] { "CreatedAt", "StartExamDateTime" },
                values: new object[] { new DateTime(2024, 3, 10, 19, 30, 18, 249, DateTimeKind.Local).AddTicks(5623), new DateTime(2024, 3, 24, 19, 30, 18, 249, DateTimeKind.Local).AddTicks(5625) });

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: "e-3",
                columns: new[] { "CreatedAt", "StartExamDateTime" },
                values: new object[] { new DateTime(2024, 3, 10, 19, 30, 18, 249, DateTimeKind.Local).AddTicks(5628), new DateTime(2024, 3, 31, 19, 30, 18, 249, DateTimeKind.Local).AddTicks(5630) });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-1",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 19, 30, 18, 249, DateTimeKind.Local).AddTicks(5653));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-2",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 19, 30, 18, 249, DateTimeKind.Local).AddTicks(5659));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-3",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 19, 30, 18, 249, DateTimeKind.Local).AddTicks(5663));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-4",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 19, 30, 18, 249, DateTimeKind.Local).AddTicks(5669));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-5",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 19, 30, 18, 249, DateTimeKind.Local).AddTicks(5673));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-6",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 19, 30, 18, 249, DateTimeKind.Local).AddTicks(5677));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-7",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 19, 30, 18, 249, DateTimeKind.Local).AddTicks(5681));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-8",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 19, 30, 18, 249, DateTimeKind.Local).AddTicks(5685));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-9",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 19, 30, 18, 249, DateTimeKind.Local).AddTicks(5690));

            migrationBuilder.UpdateData(
                table: "StudentsExams",
                keyColumn: "Id",
                keyValue: "se-1",
                columns: new[] { "CreatedAt", "ExamStartTime" },
                values: new object[] { new DateTime(2024, 3, 10, 19, 30, 18, 249, DateTimeKind.Local).AddTicks(5726), new DateTime(2024, 3, 10, 17, 30, 18, 249, DateTimeKind.Local).AddTicks(5732) });

            migrationBuilder.UpdateData(
                table: "StudentsExams",
                keyColumn: "Id",
                keyValue: "se-2",
                columns: new[] { "CreatedAt", "ExamStartTime" },
                values: new object[] { new DateTime(2024, 3, 10, 19, 30, 18, 249, DateTimeKind.Local).AddTicks(5735), new DateTime(2024, 3, 10, 16, 30, 18, 249, DateTimeKind.Local).AddTicks(5737) });

            migrationBuilder.UpdateData(
                table: "StudentsExams",
                keyColumn: "Id",
                keyValue: "se-3",
                columns: new[] { "CreatedAt", "ExamStartTime" },
                values: new object[] { new DateTime(2024, 3, 10, 19, 30, 18, 249, DateTimeKind.Local).AddTicks(5742), new DateTime(2024, 3, 10, 15, 30, 18, 249, DateTimeKind.Local).AddTicks(5743) });

            migrationBuilder.UpdateData(
                table: "StudentsExams",
                keyColumn: "Id",
                keyValue: "se-4",
                columns: new[] { "CreatedAt", "ExamStartTime" },
                values: new object[] { new DateTime(2024, 3, 10, 19, 30, 18, 249, DateTimeKind.Local).AddTicks(5746), new DateTime(2024, 3, 10, 14, 30, 18, 249, DateTimeKind.Local).AddTicks(5748) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "a-1",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 19, 30, 18, 249, DateTimeKind.Local).AddTicks(5772));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "s-1",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 19, 30, 18, 249, DateTimeKind.Local).AddTicks(5784));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "s-2",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 19, 30, 18, 249, DateTimeKind.Local).AddTicks(5788));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "t-1",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 19, 30, 18, 249, DateTimeKind.Local).AddTicks(5781));
        }
    }
}
