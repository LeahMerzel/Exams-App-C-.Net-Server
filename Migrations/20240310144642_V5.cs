using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Exams_App_C__.Net_Server.Migrations
{
    /// <inheritdoc />
    public partial class V5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-1",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 16, 46, 42, 654, DateTimeKind.Local).AddTicks(1142));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-2",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 16, 46, 42, 654, DateTimeKind.Local).AddTicks(1201));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-21",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 16, 46, 42, 654, DateTimeKind.Local).AddTicks(1246));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-22",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 16, 46, 42, 654, DateTimeKind.Local).AddTicks(1248));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-23",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 16, 46, 42, 654, DateTimeKind.Local).AddTicks(1251));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-24",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 16, 46, 42, 654, DateTimeKind.Local).AddTicks(1253));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-3",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 16, 46, 42, 654, DateTimeKind.Local).AddTicks(1239));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-31",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 16, 46, 42, 654, DateTimeKind.Local).AddTicks(1256));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-32",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 16, 46, 42, 654, DateTimeKind.Local).AddTicks(1258));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-33",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 16, 46, 42, 654, DateTimeKind.Local).AddTicks(1263));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-34",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 16, 46, 42, 654, DateTimeKind.Local).AddTicks(1266));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-4",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 16, 46, 42, 654, DateTimeKind.Local).AddTicks(1243));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: "c-1",
                columns: new[] { "CourseEndingDate", "CourseStartingDate", "CreatedAt" },
                values: new object[] { new DateTime(2024, 6, 10, 16, 46, 42, 654, DateTimeKind.Local).AddTicks(1391), new DateTime(2024, 3, 10, 16, 46, 42, 654, DateTimeKind.Local).AddTicks(1390), new DateTime(2024, 3, 10, 16, 46, 42, 654, DateTimeKind.Local).AddTicks(1384) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: "c-2",
                columns: new[] { "CourseEndingDate", "CourseStartingDate", "CreatedAt" },
                values: new object[] { new DateTime(2024, 6, 10, 16, 46, 42, 654, DateTimeKind.Local).AddTicks(1401), new DateTime(2024, 3, 10, 16, 46, 42, 654, DateTimeKind.Local).AddTicks(1400), new DateTime(2024, 3, 10, 16, 46, 42, 654, DateTimeKind.Local).AddTicks(1397) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: "c-3",
                columns: new[] { "CourseEndingDate", "CourseStartingDate", "CreatedAt" },
                values: new object[] { new DateTime(2024, 6, 10, 16, 46, 42, 654, DateTimeKind.Local).AddTicks(1407), new DateTime(2024, 3, 10, 16, 46, 42, 654, DateTimeKind.Local).AddTicks(1406), new DateTime(2024, 3, 10, 16, 46, 42, 654, DateTimeKind.Local).AddTicks(1404) });

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: "e-1",
                columns: new[] { "CreatedAt", "StartExamDateTime" },
                values: new object[] { new DateTime(2024, 3, 10, 16, 46, 42, 654, DateTimeKind.Local).AddTicks(1433), new DateTime(2024, 3, 17, 16, 46, 42, 654, DateTimeKind.Local).AddTicks(1439) });

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: "e-2",
                columns: new[] { "CreatedAt", "StartExamDateTime" },
                values: new object[] { new DateTime(2024, 3, 10, 16, 46, 42, 654, DateTimeKind.Local).AddTicks(1446), new DateTime(2024, 3, 24, 16, 46, 42, 654, DateTimeKind.Local).AddTicks(1448) });

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: "e-3",
                columns: new[] { "CreatedAt", "StartExamDateTime" },
                values: new object[] { new DateTime(2024, 3, 10, 16, 46, 42, 654, DateTimeKind.Local).AddTicks(1451), new DateTime(2024, 3, 31, 16, 46, 42, 654, DateTimeKind.Local).AddTicks(1452) });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-1",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 16, 46, 42, 654, DateTimeKind.Local).AddTicks(1480));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-2",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 16, 46, 42, 654, DateTimeKind.Local).AddTicks(1485));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-3",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 16, 46, 42, 654, DateTimeKind.Local).AddTicks(1490));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-4",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 16, 46, 42, 654, DateTimeKind.Local).AddTicks(1495));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-5",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 16, 46, 42, 654, DateTimeKind.Local).AddTicks(1499));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-6",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 16, 46, 42, 654, DateTimeKind.Local).AddTicks(1503));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-7",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 16, 46, 42, 654, DateTimeKind.Local).AddTicks(1508));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-8",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 16, 46, 42, 654, DateTimeKind.Local).AddTicks(1512));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-9",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 16, 46, 42, 654, DateTimeKind.Local).AddTicks(1518));

            migrationBuilder.UpdateData(
                table: "StudentsExams",
                keyColumn: "Id",
                keyValue: "se-1",
                columns: new[] { "CreatedAt", "ExamStartTime" },
                values: new object[] { new DateTime(2024, 3, 10, 16, 46, 42, 654, DateTimeKind.Local).AddTicks(1547), new DateTime(2024, 3, 10, 14, 46, 42, 654, DateTimeKind.Local).AddTicks(1553) });

            migrationBuilder.UpdateData(
                table: "StudentsExams",
                keyColumn: "Id",
                keyValue: "se-2",
                columns: new[] { "CreatedAt", "ExamStartTime" },
                values: new object[] { new DateTime(2024, 3, 10, 16, 46, 42, 654, DateTimeKind.Local).AddTicks(1556), new DateTime(2024, 3, 10, 13, 46, 42, 654, DateTimeKind.Local).AddTicks(1558) });

            migrationBuilder.UpdateData(
                table: "StudentsExams",
                keyColumn: "Id",
                keyValue: "se-3",
                columns: new[] { "CreatedAt", "ExamStartTime" },
                values: new object[] { new DateTime(2024, 3, 10, 16, 46, 42, 654, DateTimeKind.Local).AddTicks(1561), new DateTime(2024, 3, 10, 12, 46, 42, 654, DateTimeKind.Local).AddTicks(1563) });

            migrationBuilder.UpdateData(
                table: "StudentsExams",
                keyColumn: "Id",
                keyValue: "se-4",
                columns: new[] { "CreatedAt", "ExamStartTime" },
                values: new object[] { new DateTime(2024, 3, 10, 16, 46, 42, 654, DateTimeKind.Local).AddTicks(1565), new DateTime(2024, 3, 10, 11, 46, 42, 654, DateTimeKind.Local).AddTicks(1567) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "a-1",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 16, 46, 42, 654, DateTimeKind.Local).AddTicks(1592));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "s-1",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 16, 46, 42, 654, DateTimeKind.Local).AddTicks(1623));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "s-2",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 16, 46, 42, 654, DateTimeKind.Local).AddTicks(1629));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "t-1",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 16, 46, 42, 654, DateTimeKind.Local).AddTicks(1620));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-1",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 16, 43, 39, 573, DateTimeKind.Local).AddTicks(5677));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-2",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 16, 43, 39, 573, DateTimeKind.Local).AddTicks(5742));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-21",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 16, 43, 39, 573, DateTimeKind.Local).AddTicks(5764));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-22",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 16, 43, 39, 573, DateTimeKind.Local).AddTicks(5767));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-23",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 16, 43, 39, 573, DateTimeKind.Local).AddTicks(5770));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-24",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 16, 43, 39, 573, DateTimeKind.Local).AddTicks(5773));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-3",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 16, 43, 39, 573, DateTimeKind.Local).AddTicks(5758));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-31",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 16, 43, 39, 573, DateTimeKind.Local).AddTicks(5775));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-32",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 16, 43, 39, 573, DateTimeKind.Local).AddTicks(5778));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-33",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 16, 43, 39, 573, DateTimeKind.Local).AddTicks(5783));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-34",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 16, 43, 39, 573, DateTimeKind.Local).AddTicks(5786));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-4",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 16, 43, 39, 573, DateTimeKind.Local).AddTicks(5761));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: "c-1",
                columns: new[] { "CourseEndingDate", "CourseStartingDate", "CreatedAt" },
                values: new object[] { new DateTime(2024, 6, 10, 16, 43, 39, 573, DateTimeKind.Local).AddTicks(5951), new DateTime(2024, 3, 10, 16, 43, 39, 573, DateTimeKind.Local).AddTicks(5950), new DateTime(2024, 3, 10, 16, 43, 39, 573, DateTimeKind.Local).AddTicks(5941) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: "c-2",
                columns: new[] { "CourseEndingDate", "CourseStartingDate", "CreatedAt" },
                values: new object[] { new DateTime(2024, 6, 10, 16, 43, 39, 573, DateTimeKind.Local).AddTicks(5962), new DateTime(2024, 3, 10, 16, 43, 39, 573, DateTimeKind.Local).AddTicks(5961), new DateTime(2024, 3, 10, 16, 43, 39, 573, DateTimeKind.Local).AddTicks(5958) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: "c-3",
                columns: new[] { "CourseEndingDate", "CourseStartingDate", "CreatedAt" },
                values: new object[] { new DateTime(2024, 6, 10, 16, 43, 39, 573, DateTimeKind.Local).AddTicks(5969), new DateTime(2024, 3, 10, 16, 43, 39, 573, DateTimeKind.Local).AddTicks(5967), new DateTime(2024, 3, 10, 16, 43, 39, 573, DateTimeKind.Local).AddTicks(5966) });

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: "e-1",
                columns: new[] { "CreatedAt", "StartExamDateTime" },
                values: new object[] { new DateTime(2024, 3, 10, 16, 43, 39, 573, DateTimeKind.Local).AddTicks(6003), new DateTime(2024, 3, 17, 16, 43, 39, 573, DateTimeKind.Local).AddTicks(6008) });

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: "e-2",
                columns: new[] { "CreatedAt", "StartExamDateTime" },
                values: new object[] { new DateTime(2024, 3, 10, 16, 43, 39, 573, DateTimeKind.Local).AddTicks(6013), new DateTime(2024, 3, 24, 16, 43, 39, 573, DateTimeKind.Local).AddTicks(6016) });

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: "e-3",
                columns: new[] { "CreatedAt", "StartExamDateTime" },
                values: new object[] { new DateTime(2024, 3, 10, 16, 43, 39, 573, DateTimeKind.Local).AddTicks(6019), new DateTime(2024, 3, 31, 16, 43, 39, 573, DateTimeKind.Local).AddTicks(6021) });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-1",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 16, 43, 39, 573, DateTimeKind.Local).AddTicks(6054));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-2",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 16, 43, 39, 573, DateTimeKind.Local).AddTicks(6059));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-3",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 16, 43, 39, 573, DateTimeKind.Local).AddTicks(6064));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-4",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 16, 43, 39, 573, DateTimeKind.Local).AddTicks(6068));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-5",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 16, 43, 39, 573, DateTimeKind.Local).AddTicks(6073));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-6",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 16, 43, 39, 573, DateTimeKind.Local).AddTicks(6077));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-7",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 16, 43, 39, 573, DateTimeKind.Local).AddTicks(6082));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-8",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 16, 43, 39, 573, DateTimeKind.Local).AddTicks(6086));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-9",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 16, 43, 39, 573, DateTimeKind.Local).AddTicks(6093));

            migrationBuilder.UpdateData(
                table: "StudentsExams",
                keyColumn: "Id",
                keyValue: "se-1",
                columns: new[] { "CreatedAt", "ExamStartTime" },
                values: new object[] { new DateTime(2024, 3, 10, 16, 43, 39, 573, DateTimeKind.Local).AddTicks(6127), new DateTime(2024, 3, 10, 14, 43, 39, 573, DateTimeKind.Local).AddTicks(6133) });

            migrationBuilder.UpdateData(
                table: "StudentsExams",
                keyColumn: "Id",
                keyValue: "se-2",
                columns: new[] { "CreatedAt", "ExamStartTime" },
                values: new object[] { new DateTime(2024, 3, 10, 16, 43, 39, 573, DateTimeKind.Local).AddTicks(6137), new DateTime(2024, 3, 10, 13, 43, 39, 573, DateTimeKind.Local).AddTicks(6169) });

            migrationBuilder.UpdateData(
                table: "StudentsExams",
                keyColumn: "Id",
                keyValue: "se-3",
                columns: new[] { "CreatedAt", "ExamStartTime" },
                values: new object[] { new DateTime(2024, 3, 10, 16, 43, 39, 573, DateTimeKind.Local).AddTicks(6172), new DateTime(2024, 3, 10, 12, 43, 39, 573, DateTimeKind.Local).AddTicks(6175) });

            migrationBuilder.UpdateData(
                table: "StudentsExams",
                keyColumn: "Id",
                keyValue: "se-4",
                columns: new[] { "CreatedAt", "ExamStartTime" },
                values: new object[] { new DateTime(2024, 3, 10, 16, 43, 39, 573, DateTimeKind.Local).AddTicks(6177), new DateTime(2024, 3, 10, 11, 43, 39, 573, DateTimeKind.Local).AddTicks(6179) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "a-1",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 16, 43, 39, 573, DateTimeKind.Local).AddTicks(6211));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "s-1",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 16, 43, 39, 573, DateTimeKind.Local).AddTicks(6224));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "s-2",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 16, 43, 39, 573, DateTimeKind.Local).AddTicks(6230));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "t-1",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 16, 43, 39, 573, DateTimeKind.Local).AddTicks(6220));
        }
    }
}
