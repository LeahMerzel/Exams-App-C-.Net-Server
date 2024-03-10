using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Exams_App_C__.Net_Server.Migrations
{
    /// <inheritdoc />
    public partial class V2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-1",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 16, 12, 43, 250, DateTimeKind.Local).AddTicks(7056));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-2",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 16, 12, 43, 250, DateTimeKind.Local).AddTicks(7118));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-21",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 16, 12, 43, 250, DateTimeKind.Local).AddTicks(7126));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-22",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 16, 12, 43, 250, DateTimeKind.Local).AddTicks(7140));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-23",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 16, 12, 43, 250, DateTimeKind.Local).AddTicks(7143));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-24",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 16, 12, 43, 250, DateTimeKind.Local).AddTicks(7145));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-3",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 16, 12, 43, 250, DateTimeKind.Local).AddTicks(7121));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-31",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 16, 12, 43, 250, DateTimeKind.Local).AddTicks(7148));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-32",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 16, 12, 43, 250, DateTimeKind.Local).AddTicks(7150));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-33",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 16, 12, 43, 250, DateTimeKind.Local).AddTicks(7153));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-34",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 16, 12, 43, 250, DateTimeKind.Local).AddTicks(7155));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-4",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 16, 12, 43, 250, DateTimeKind.Local).AddTicks(7124));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: "c-1",
                columns: new[] { "CourseEndingDate", "CourseStartingDate", "CreatedAt" },
                values: new object[] { new DateTime(2024, 6, 10, 16, 12, 43, 250, DateTimeKind.Local).AddTicks(7293), new DateTime(2024, 3, 10, 16, 12, 43, 250, DateTimeKind.Local).AddTicks(7292), new DateTime(2024, 3, 10, 16, 12, 43, 250, DateTimeKind.Local).AddTicks(7285) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: "c-2",
                columns: new[] { "CourseEndingDate", "CourseStartingDate", "CreatedAt" },
                values: new object[] { new DateTime(2024, 6, 10, 16, 12, 43, 250, DateTimeKind.Local).AddTicks(7305), new DateTime(2024, 3, 10, 16, 12, 43, 250, DateTimeKind.Local).AddTicks(7304), new DateTime(2024, 3, 10, 16, 12, 43, 250, DateTimeKind.Local).AddTicks(7302) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: "c-3",
                columns: new[] { "CourseEndingDate", "CourseStartingDate", "CreatedAt" },
                values: new object[] { new DateTime(2024, 6, 10, 16, 12, 43, 250, DateTimeKind.Local).AddTicks(7311), new DateTime(2024, 3, 10, 16, 12, 43, 250, DateTimeKind.Local).AddTicks(7309), new DateTime(2024, 3, 10, 16, 12, 43, 250, DateTimeKind.Local).AddTicks(7308) });

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: "e-1",
                columns: new[] { "CreatedAt", "StartExamDateTime" },
                values: new object[] { new DateTime(2024, 3, 10, 16, 12, 43, 250, DateTimeKind.Local).AddTicks(7368), new DateTime(2024, 3, 17, 16, 12, 43, 250, DateTimeKind.Local).AddTicks(7374) });

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: "e-2",
                columns: new[] { "CreatedAt", "StartExamDateTime" },
                values: new object[] { new DateTime(2024, 3, 10, 16, 12, 43, 250, DateTimeKind.Local).AddTicks(7379), new DateTime(2024, 3, 24, 16, 12, 43, 250, DateTimeKind.Local).AddTicks(7382) });

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: "e-3",
                columns: new[] { "CreatedAt", "StartExamDateTime" },
                values: new object[] { new DateTime(2024, 3, 10, 16, 12, 43, 250, DateTimeKind.Local).AddTicks(7385), new DateTime(2024, 3, 31, 16, 12, 43, 250, DateTimeKind.Local).AddTicks(7386) });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-1",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 16, 12, 43, 250, DateTimeKind.Local).AddTicks(7418));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-2",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 16, 12, 43, 250, DateTimeKind.Local).AddTicks(7423));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-3",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 16, 12, 43, 250, DateTimeKind.Local).AddTicks(7428));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-4",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 16, 12, 43, 250, DateTimeKind.Local).AddTicks(7434));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-5",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 16, 12, 43, 250, DateTimeKind.Local).AddTicks(7438));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-6",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 16, 12, 43, 250, DateTimeKind.Local).AddTicks(7442));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-7",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 16, 12, 43, 250, DateTimeKind.Local).AddTicks(7447));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-8",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 16, 12, 43, 250, DateTimeKind.Local).AddTicks(7451));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-9",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 16, 12, 43, 250, DateTimeKind.Local).AddTicks(7455));

            migrationBuilder.UpdateData(
                table: "StudentsExams",
                keyColumn: "Id",
                keyValue: "se-1",
                columns: new[] { "CreatedAt", "ExamStartTime" },
                values: new object[] { new DateTime(2024, 3, 10, 16, 12, 43, 250, DateTimeKind.Local).AddTicks(7485), new DateTime(2024, 3, 10, 14, 12, 43, 250, DateTimeKind.Local).AddTicks(7490) });

            migrationBuilder.UpdateData(
                table: "StudentsExams",
                keyColumn: "Id",
                keyValue: "se-2",
                columns: new[] { "CreatedAt", "ExamStartTime" },
                values: new object[] { new DateTime(2024, 3, 10, 16, 12, 43, 250, DateTimeKind.Local).AddTicks(7493), new DateTime(2024, 3, 10, 13, 12, 43, 250, DateTimeKind.Local).AddTicks(7496) });

            migrationBuilder.UpdateData(
                table: "StudentsExams",
                keyColumn: "Id",
                keyValue: "se-3",
                columns: new[] { "CreatedAt", "ExamStartTime" },
                values: new object[] { new DateTime(2024, 3, 10, 16, 12, 43, 250, DateTimeKind.Local).AddTicks(7500), new DateTime(2024, 3, 10, 12, 12, 43, 250, DateTimeKind.Local).AddTicks(7502) });

            migrationBuilder.UpdateData(
                table: "StudentsExams",
                keyColumn: "Id",
                keyValue: "se-4",
                columns: new[] { "CreatedAt", "ExamStartTime" },
                values: new object[] { new DateTime(2024, 3, 10, 16, 12, 43, 250, DateTimeKind.Local).AddTicks(7505), new DateTime(2024, 3, 10, 11, 12, 43, 250, DateTimeKind.Local).AddTicks(7506) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "a-1",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 16, 12, 43, 250, DateTimeKind.Local).AddTicks(7530));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "s-1",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 16, 12, 43, 250, DateTimeKind.Local).AddTicks(7539));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "s-2",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 16, 12, 43, 250, DateTimeKind.Local).AddTicks(7542));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "t-1",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 16, 12, 43, 250, DateTimeKind.Local).AddTicks(7535));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-1",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 16, 2, 23, 932, DateTimeKind.Local).AddTicks(1558));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-2",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 16, 2, 23, 932, DateTimeKind.Local).AddTicks(1615));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-21",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 16, 2, 23, 932, DateTimeKind.Local).AddTicks(1624));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-22",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 16, 2, 23, 932, DateTimeKind.Local).AddTicks(1627));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-23",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 16, 2, 23, 932, DateTimeKind.Local).AddTicks(1629));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-24",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 16, 2, 23, 932, DateTimeKind.Local).AddTicks(1632));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-3",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 16, 2, 23, 932, DateTimeKind.Local).AddTicks(1618));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-31",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 16, 2, 23, 932, DateTimeKind.Local).AddTicks(1637));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-32",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 16, 2, 23, 932, DateTimeKind.Local).AddTicks(1639));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-33",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 16, 2, 23, 932, DateTimeKind.Local).AddTicks(1665));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-34",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 16, 2, 23, 932, DateTimeKind.Local).AddTicks(1668));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-4",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 16, 2, 23, 932, DateTimeKind.Local).AddTicks(1621));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: "c-1",
                columns: new[] { "CourseEndingDate", "CourseStartingDate", "CreatedAt" },
                values: new object[] { new DateTime(2024, 6, 10, 16, 2, 23, 932, DateTimeKind.Local).AddTicks(1811), new DateTime(2024, 3, 10, 16, 2, 23, 932, DateTimeKind.Local).AddTicks(1809), new DateTime(2024, 3, 10, 16, 2, 23, 932, DateTimeKind.Local).AddTicks(1804) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: "c-2",
                columns: new[] { "CourseEndingDate", "CourseStartingDate", "CreatedAt" },
                values: new object[] { new DateTime(2024, 6, 10, 16, 2, 23, 932, DateTimeKind.Local).AddTicks(1820), new DateTime(2024, 3, 10, 16, 2, 23, 932, DateTimeKind.Local).AddTicks(1819), new DateTime(2024, 3, 10, 16, 2, 23, 932, DateTimeKind.Local).AddTicks(1817) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: "c-3",
                columns: new[] { "CourseEndingDate", "CourseStartingDate", "CreatedAt" },
                values: new object[] { new DateTime(2024, 6, 10, 16, 2, 23, 932, DateTimeKind.Local).AddTicks(1826), new DateTime(2024, 3, 10, 16, 2, 23, 932, DateTimeKind.Local).AddTicks(1825), new DateTime(2024, 3, 10, 16, 2, 23, 932, DateTimeKind.Local).AddTicks(1823) });

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: "e-1",
                columns: new[] { "CreatedAt", "StartExamDateTime" },
                values: new object[] { new DateTime(2024, 3, 10, 16, 2, 23, 932, DateTimeKind.Local).AddTicks(1853), new DateTime(2024, 3, 17, 16, 2, 23, 932, DateTimeKind.Local).AddTicks(1857) });

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: "e-2",
                columns: new[] { "CreatedAt", "StartExamDateTime" },
                values: new object[] { new DateTime(2024, 3, 10, 16, 2, 23, 932, DateTimeKind.Local).AddTicks(1863), new DateTime(2024, 3, 24, 16, 2, 23, 932, DateTimeKind.Local).AddTicks(1865) });

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: "e-3",
                columns: new[] { "CreatedAt", "StartExamDateTime" },
                values: new object[] { new DateTime(2024, 3, 10, 16, 2, 23, 932, DateTimeKind.Local).AddTicks(1868), new DateTime(2024, 3, 31, 16, 2, 23, 932, DateTimeKind.Local).AddTicks(1870) });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-1",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 16, 2, 23, 932, DateTimeKind.Local).AddTicks(1893));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-2",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 16, 2, 23, 932, DateTimeKind.Local).AddTicks(1899));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-3",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 16, 2, 23, 932, DateTimeKind.Local).AddTicks(1903));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-4",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 16, 2, 23, 932, DateTimeKind.Local).AddTicks(1907));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-5",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 16, 2, 23, 932, DateTimeKind.Local).AddTicks(1911));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-6",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 16, 2, 23, 932, DateTimeKind.Local).AddTicks(1915));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-7",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 16, 2, 23, 932, DateTimeKind.Local).AddTicks(1922));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-8",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 16, 2, 23, 932, DateTimeKind.Local).AddTicks(1926));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-9",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 16, 2, 23, 932, DateTimeKind.Local).AddTicks(1930));

            migrationBuilder.UpdateData(
                table: "StudentsExams",
                keyColumn: "Id",
                keyValue: "se-1",
                columns: new[] { "CreatedAt", "ExamStartTime" },
                values: new object[] { new DateTime(2024, 3, 10, 16, 2, 23, 932, DateTimeKind.Local).AddTicks(1959), new DateTime(2024, 3, 10, 14, 2, 23, 932, DateTimeKind.Local).AddTicks(1964) });

            migrationBuilder.UpdateData(
                table: "StudentsExams",
                keyColumn: "Id",
                keyValue: "se-2",
                columns: new[] { "CreatedAt", "ExamStartTime" },
                values: new object[] { new DateTime(2024, 3, 10, 16, 2, 23, 932, DateTimeKind.Local).AddTicks(1967), new DateTime(2024, 3, 10, 13, 2, 23, 932, DateTimeKind.Local).AddTicks(1969) });

            migrationBuilder.UpdateData(
                table: "StudentsExams",
                keyColumn: "Id",
                keyValue: "se-3",
                columns: new[] { "CreatedAt", "ExamStartTime" },
                values: new object[] { new DateTime(2024, 3, 10, 16, 2, 23, 932, DateTimeKind.Local).AddTicks(1971), new DateTime(2024, 3, 10, 12, 2, 23, 932, DateTimeKind.Local).AddTicks(1973) });

            migrationBuilder.UpdateData(
                table: "StudentsExams",
                keyColumn: "Id",
                keyValue: "se-4",
                columns: new[] { "CreatedAt", "ExamStartTime" },
                values: new object[] { new DateTime(2024, 3, 10, 16, 2, 23, 932, DateTimeKind.Local).AddTicks(1975), new DateTime(2024, 3, 10, 11, 2, 23, 932, DateTimeKind.Local).AddTicks(1977) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "a-1",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 16, 2, 23, 932, DateTimeKind.Local).AddTicks(1998));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "s-1",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 16, 2, 23, 932, DateTimeKind.Local).AddTicks(2009));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "s-2",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 16, 2, 23, 932, DateTimeKind.Local).AddTicks(2012));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "t-1",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 16, 2, 23, 932, DateTimeKind.Local).AddTicks(2006));
        }
    }
}
