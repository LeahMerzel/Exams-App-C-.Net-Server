using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Exams_App_C__.Net_Server.Migrations
{
    /// <inheritdoc />
    public partial class V7 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-1",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 17, 11, 34, 344, DateTimeKind.Local).AddTicks(4997));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-2",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 17, 11, 34, 344, DateTimeKind.Local).AddTicks(5061));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-21",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 17, 11, 34, 344, DateTimeKind.Local).AddTicks(5081));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-22",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 17, 11, 34, 344, DateTimeKind.Local).AddTicks(5084));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-23",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 17, 11, 34, 344, DateTimeKind.Local).AddTicks(5087));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-24",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 17, 11, 34, 344, DateTimeKind.Local).AddTicks(5090));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-3",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 17, 11, 34, 344, DateTimeKind.Local).AddTicks(5064));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-31",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 17, 11, 34, 344, DateTimeKind.Local).AddTicks(5092));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-32",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 17, 11, 34, 344, DateTimeKind.Local).AddTicks(5095));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-33",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 17, 11, 34, 344, DateTimeKind.Local).AddTicks(5098));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-34",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 17, 11, 34, 344, DateTimeKind.Local).AddTicks(5121));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-4",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 17, 11, 34, 344, DateTimeKind.Local).AddTicks(5067));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: "c-1",
                columns: new[] { "CourseEndingDate", "CourseStartingDate", "CreatedAt" },
                values: new object[] { new DateTime(2024, 6, 10, 17, 11, 34, 344, DateTimeKind.Local).AddTicks(5256), new DateTime(2024, 3, 10, 17, 11, 34, 344, DateTimeKind.Local).AddTicks(5255), new DateTime(2024, 3, 10, 17, 11, 34, 344, DateTimeKind.Local).AddTicks(5250) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: "c-2",
                columns: new[] { "CourseEndingDate", "CourseStartingDate", "CreatedAt" },
                values: new object[] { new DateTime(2024, 6, 10, 17, 11, 34, 344, DateTimeKind.Local).AddTicks(5266), new DateTime(2024, 3, 10, 17, 11, 34, 344, DateTimeKind.Local).AddTicks(5264), new DateTime(2024, 3, 10, 17, 11, 34, 344, DateTimeKind.Local).AddTicks(5262) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: "c-3",
                columns: new[] { "CourseEndingDate", "CourseStartingDate", "CreatedAt" },
                values: new object[] { new DateTime(2024, 6, 10, 17, 11, 34, 344, DateTimeKind.Local).AddTicks(5271), new DateTime(2024, 3, 10, 17, 11, 34, 344, DateTimeKind.Local).AddTicks(5270), new DateTime(2024, 3, 10, 17, 11, 34, 344, DateTimeKind.Local).AddTicks(5268) });

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: "e-1",
                columns: new[] { "CreatedAt", "StartExamDateTime" },
                values: new object[] { new DateTime(2024, 3, 10, 17, 11, 34, 344, DateTimeKind.Local).AddTicks(5300), new DateTime(2024, 3, 17, 17, 11, 34, 344, DateTimeKind.Local).AddTicks(5304) });

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: "e-2",
                columns: new[] { "CreatedAt", "StartExamDateTime" },
                values: new object[] { new DateTime(2024, 3, 10, 17, 11, 34, 344, DateTimeKind.Local).AddTicks(5308), new DateTime(2024, 3, 24, 17, 11, 34, 344, DateTimeKind.Local).AddTicks(5311) });

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: "e-3",
                columns: new[] { "CreatedAt", "StartExamDateTime" },
                values: new object[] { new DateTime(2024, 3, 10, 17, 11, 34, 344, DateTimeKind.Local).AddTicks(5313), new DateTime(2024, 3, 31, 17, 11, 34, 344, DateTimeKind.Local).AddTicks(5315) });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-1",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 17, 11, 34, 344, DateTimeKind.Local).AddTicks(5339));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-2",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 17, 11, 34, 344, DateTimeKind.Local).AddTicks(5344));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-3",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 17, 11, 34, 344, DateTimeKind.Local).AddTicks(5351));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-4",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 17, 11, 34, 344, DateTimeKind.Local).AddTicks(5355));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-5",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 17, 11, 34, 344, DateTimeKind.Local).AddTicks(5359));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-6",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 17, 11, 34, 344, DateTimeKind.Local).AddTicks(5363));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-7",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 17, 11, 34, 344, DateTimeKind.Local).AddTicks(5367));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-8",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 17, 11, 34, 344, DateTimeKind.Local).AddTicks(5371));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-9",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 17, 11, 34, 344, DateTimeKind.Local).AddTicks(5376));

            migrationBuilder.UpdateData(
                table: "StudentsExams",
                keyColumn: "Id",
                keyValue: "se-1",
                columns: new[] { "CreatedAt", "ExamStartTime" },
                values: new object[] { new DateTime(2024, 3, 10, 17, 11, 34, 344, DateTimeKind.Local).AddTicks(5406), new DateTime(2024, 3, 10, 15, 11, 34, 344, DateTimeKind.Local).AddTicks(5411) });

            migrationBuilder.UpdateData(
                table: "StudentsExams",
                keyColumn: "Id",
                keyValue: "se-2",
                columns: new[] { "CreatedAt", "ExamStartTime" },
                values: new object[] { new DateTime(2024, 3, 10, 17, 11, 34, 344, DateTimeKind.Local).AddTicks(5416), new DateTime(2024, 3, 10, 14, 11, 34, 344, DateTimeKind.Local).AddTicks(5418) });

            migrationBuilder.UpdateData(
                table: "StudentsExams",
                keyColumn: "Id",
                keyValue: "se-3",
                columns: new[] { "CreatedAt", "ExamStartTime" },
                values: new object[] { new DateTime(2024, 3, 10, 17, 11, 34, 344, DateTimeKind.Local).AddTicks(5421), new DateTime(2024, 3, 10, 13, 11, 34, 344, DateTimeKind.Local).AddTicks(5423) });

            migrationBuilder.UpdateData(
                table: "StudentsExams",
                keyColumn: "Id",
                keyValue: "se-4",
                columns: new[] { "CreatedAt", "ExamStartTime" },
                values: new object[] { new DateTime(2024, 3, 10, 17, 11, 34, 344, DateTimeKind.Local).AddTicks(5426), new DateTime(2024, 3, 10, 12, 11, 34, 344, DateTimeKind.Local).AddTicks(5427) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "a-1",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 17, 11, 34, 344, DateTimeKind.Local).AddTicks(5451));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "s-1",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 17, 11, 34, 344, DateTimeKind.Local).AddTicks(5464));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "s-2",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 17, 11, 34, 344, DateTimeKind.Local).AddTicks(5467));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "t-1",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 17, 11, 34, 344, DateTimeKind.Local).AddTicks(5460));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-1",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 17, 2, 30, 132, DateTimeKind.Local).AddTicks(6176));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-2",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 17, 2, 30, 132, DateTimeKind.Local).AddTicks(6237));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-21",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 17, 2, 30, 132, DateTimeKind.Local).AddTicks(6256));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-22",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 17, 2, 30, 132, DateTimeKind.Local).AddTicks(6260));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-23",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 17, 2, 30, 132, DateTimeKind.Local).AddTicks(6263));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-24",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 17, 2, 30, 132, DateTimeKind.Local).AddTicks(6266));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-3",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 17, 2, 30, 132, DateTimeKind.Local).AddTicks(6240));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-31",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 17, 2, 30, 132, DateTimeKind.Local).AddTicks(6268));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-32",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 17, 2, 30, 132, DateTimeKind.Local).AddTicks(6271));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-33",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 17, 2, 30, 132, DateTimeKind.Local).AddTicks(6274));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-34",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 17, 2, 30, 132, DateTimeKind.Local).AddTicks(6277));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-4",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 17, 2, 30, 132, DateTimeKind.Local).AddTicks(6243));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: "c-1",
                columns: new[] { "CourseEndingDate", "CourseStartingDate", "CreatedAt" },
                values: new object[] { new DateTime(2024, 6, 10, 17, 2, 30, 132, DateTimeKind.Local).AddTicks(6438), new DateTime(2024, 3, 10, 17, 2, 30, 132, DateTimeKind.Local).AddTicks(6437), new DateTime(2024, 3, 10, 17, 2, 30, 132, DateTimeKind.Local).AddTicks(6430) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: "c-2",
                columns: new[] { "CourseEndingDate", "CourseStartingDate", "CreatedAt" },
                values: new object[] { new DateTime(2024, 6, 10, 17, 2, 30, 132, DateTimeKind.Local).AddTicks(6448), new DateTime(2024, 3, 10, 17, 2, 30, 132, DateTimeKind.Local).AddTicks(6446), new DateTime(2024, 3, 10, 17, 2, 30, 132, DateTimeKind.Local).AddTicks(6444) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: "c-3",
                columns: new[] { "CourseEndingDate", "CourseStartingDate", "CreatedAt" },
                values: new object[] { new DateTime(2024, 6, 10, 17, 2, 30, 132, DateTimeKind.Local).AddTicks(6454), new DateTime(2024, 3, 10, 17, 2, 30, 132, DateTimeKind.Local).AddTicks(6453), new DateTime(2024, 3, 10, 17, 2, 30, 132, DateTimeKind.Local).AddTicks(6451) });

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: "e-1",
                columns: new[] { "CreatedAt", "StartExamDateTime" },
                values: new object[] { new DateTime(2024, 3, 10, 17, 2, 30, 132, DateTimeKind.Local).AddTicks(6486), new DateTime(2024, 3, 17, 17, 2, 30, 132, DateTimeKind.Local).AddTicks(6491) });

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: "e-2",
                columns: new[] { "CreatedAt", "StartExamDateTime" },
                values: new object[] { new DateTime(2024, 3, 10, 17, 2, 30, 132, DateTimeKind.Local).AddTicks(6496), new DateTime(2024, 3, 24, 17, 2, 30, 132, DateTimeKind.Local).AddTicks(6499) });

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: "e-3",
                columns: new[] { "CreatedAt", "StartExamDateTime" },
                values: new object[] { new DateTime(2024, 3, 10, 17, 2, 30, 132, DateTimeKind.Local).AddTicks(6503), new DateTime(2024, 3, 31, 17, 2, 30, 132, DateTimeKind.Local).AddTicks(6505) });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-1",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 17, 2, 30, 132, DateTimeKind.Local).AddTicks(6535));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-2",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 17, 2, 30, 132, DateTimeKind.Local).AddTicks(6541));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-3",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 17, 2, 30, 132, DateTimeKind.Local).AddTicks(6549));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-4",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 17, 2, 30, 132, DateTimeKind.Local).AddTicks(6554));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-5",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 17, 2, 30, 132, DateTimeKind.Local).AddTicks(6558));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-6",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 17, 2, 30, 132, DateTimeKind.Local).AddTicks(6563));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-7",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 17, 2, 30, 132, DateTimeKind.Local).AddTicks(6567));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-8",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 17, 2, 30, 132, DateTimeKind.Local).AddTicks(6572));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-9",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 17, 2, 30, 132, DateTimeKind.Local).AddTicks(6576));

            migrationBuilder.UpdateData(
                table: "StudentsExams",
                keyColumn: "Id",
                keyValue: "se-1",
                columns: new[] { "CreatedAt", "ExamStartTime" },
                values: new object[] { new DateTime(2024, 3, 10, 17, 2, 30, 132, DateTimeKind.Local).AddTicks(6671), new DateTime(2024, 3, 10, 15, 2, 30, 132, DateTimeKind.Local).AddTicks(6678) });

            migrationBuilder.UpdateData(
                table: "StudentsExams",
                keyColumn: "Id",
                keyValue: "se-2",
                columns: new[] { "CreatedAt", "ExamStartTime" },
                values: new object[] { new DateTime(2024, 3, 10, 17, 2, 30, 132, DateTimeKind.Local).AddTicks(6683), new DateTime(2024, 3, 10, 14, 2, 30, 132, DateTimeKind.Local).AddTicks(6686) });

            migrationBuilder.UpdateData(
                table: "StudentsExams",
                keyColumn: "Id",
                keyValue: "se-3",
                columns: new[] { "CreatedAt", "ExamStartTime" },
                values: new object[] { new DateTime(2024, 3, 10, 17, 2, 30, 132, DateTimeKind.Local).AddTicks(6688), new DateTime(2024, 3, 10, 13, 2, 30, 132, DateTimeKind.Local).AddTicks(6690) });

            migrationBuilder.UpdateData(
                table: "StudentsExams",
                keyColumn: "Id",
                keyValue: "se-4",
                columns: new[] { "CreatedAt", "ExamStartTime" },
                values: new object[] { new DateTime(2024, 3, 10, 17, 2, 30, 132, DateTimeKind.Local).AddTicks(6693), new DateTime(2024, 3, 10, 12, 2, 30, 132, DateTimeKind.Local).AddTicks(6695) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "a-1",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 17, 2, 30, 132, DateTimeKind.Local).AddTicks(6729));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "s-1",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 17, 2, 30, 132, DateTimeKind.Local).AddTicks(6743));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "s-2",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 17, 2, 30, 132, DateTimeKind.Local).AddTicks(6748));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "t-1",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 17, 2, 30, 132, DateTimeKind.Local).AddTicks(6739));
        }
    }
}
