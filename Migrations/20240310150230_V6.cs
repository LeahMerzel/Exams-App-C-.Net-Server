using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Exams_App_C__.Net_Server.Migrations
{
    /// <inheritdoc />
    public partial class V6 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
