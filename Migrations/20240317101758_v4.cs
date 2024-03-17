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
            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-2",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 17, 12, 17, 57, 763, DateTimeKind.Local).AddTicks(1091));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-21",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 17, 12, 17, 57, 763, DateTimeKind.Local).AddTicks(1101));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-22",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 17, 12, 17, 57, 763, DateTimeKind.Local).AddTicks(1113));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-23",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 17, 12, 17, 57, 763, DateTimeKind.Local).AddTicks(1116));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-24",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 17, 12, 17, 57, 763, DateTimeKind.Local).AddTicks(1119));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-3",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 17, 12, 17, 57, 763, DateTimeKind.Local).AddTicks(1095));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-31",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 17, 12, 17, 57, 763, DateTimeKind.Local).AddTicks(1122));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-32",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 17, 12, 17, 57, 763, DateTimeKind.Local).AddTicks(1160));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-33",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 17, 12, 17, 57, 763, DateTimeKind.Local).AddTicks(1163));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-34",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 17, 12, 17, 57, 763, DateTimeKind.Local).AddTicks(1166));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-4",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 17, 12, 17, 57, 763, DateTimeKind.Local).AddTicks(1098));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-61",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 17, 12, 17, 57, 763, DateTimeKind.Local).AddTicks(1024));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: "c-1",
                columns: new[] { "CourseEndingDate", "CourseStartingDate", "CreatedAt" },
                values: new object[] { new DateTime(2024, 6, 17, 12, 17, 57, 763, DateTimeKind.Local).AddTicks(1307), new DateTime(2024, 3, 17, 12, 17, 57, 763, DateTimeKind.Local).AddTicks(1306), new DateTime(2024, 3, 17, 12, 17, 57, 763, DateTimeKind.Local).AddTicks(1300) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: "c-2",
                columns: new[] { "CourseEndingDate", "CourseStartingDate", "CreatedAt" },
                values: new object[] { new DateTime(2024, 6, 17, 12, 17, 57, 763, DateTimeKind.Local).AddTicks(1320), new DateTime(2024, 3, 17, 12, 17, 57, 763, DateTimeKind.Local).AddTicks(1319), new DateTime(2024, 3, 17, 12, 17, 57, 763, DateTimeKind.Local).AddTicks(1317) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: "c-3",
                columns: new[] { "CourseEndingDate", "CourseStartingDate", "CreatedAt" },
                values: new object[] { new DateTime(2024, 6, 17, 12, 17, 57, 763, DateTimeKind.Local).AddTicks(1326), new DateTime(2024, 3, 17, 12, 17, 57, 763, DateTimeKind.Local).AddTicks(1325), new DateTime(2024, 3, 17, 12, 17, 57, 763, DateTimeKind.Local).AddTicks(1323) });

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: "e-1",
                columns: new[] { "CreatedAt", "StartExamDateTime" },
                values: new object[] { new DateTime(2024, 3, 17, 12, 17, 57, 763, DateTimeKind.Local).AddTicks(1354), new DateTime(2024, 3, 24, 12, 17, 57, 763, DateTimeKind.Local).AddTicks(1360) });

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: "e-2",
                columns: new[] { "CreatedAt", "StartExamDateTime" },
                values: new object[] { new DateTime(2024, 3, 17, 12, 17, 57, 763, DateTimeKind.Local).AddTicks(1368), new DateTime(2024, 3, 31, 12, 17, 57, 763, DateTimeKind.Local).AddTicks(1370) });

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: "e-3",
                columns: new[] { "CreatedAt", "StartExamDateTime" },
                values: new object[] { new DateTime(2024, 3, 17, 12, 17, 57, 763, DateTimeKind.Local).AddTicks(1374), new DateTime(2024, 4, 7, 12, 17, 57, 763, DateTimeKind.Local).AddTicks(1376) });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-1",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 17, 12, 17, 57, 763, DateTimeKind.Local).AddTicks(1405));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-2",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 17, 12, 17, 57, 763, DateTimeKind.Local).AddTicks(1410));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-3",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 17, 12, 17, 57, 763, DateTimeKind.Local).AddTicks(1415));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-4",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 17, 12, 17, 57, 763, DateTimeKind.Local).AddTicks(1421));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-5",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 17, 12, 17, 57, 763, DateTimeKind.Local).AddTicks(1426));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-6",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 17, 12, 17, 57, 763, DateTimeKind.Local).AddTicks(1430));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-7",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 17, 12, 17, 57, 763, DateTimeKind.Local).AddTicks(1434));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-8",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 17, 12, 17, 57, 763, DateTimeKind.Local).AddTicks(1438));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-9",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 17, 12, 17, 57, 763, DateTimeKind.Local).AddTicks(1442));

            migrationBuilder.UpdateData(
                table: "StudentsExams",
                keyColumn: "Id",
                keyValue: "se-1",
                columns: new[] { "CreatedAt", "ExamStartTime" },
                values: new object[] { new DateTime(2024, 3, 17, 12, 17, 57, 763, DateTimeKind.Local).AddTicks(1635), new DateTime(2024, 3, 17, 10, 17, 57, 763, DateTimeKind.Local).AddTicks(1649) });

            migrationBuilder.UpdateData(
                table: "StudentsExams",
                keyColumn: "Id",
                keyValue: "se-2",
                columns: new[] { "CreatedAt", "ExamStartTime" },
                values: new object[] { new DateTime(2024, 3, 17, 12, 17, 57, 763, DateTimeKind.Local).AddTicks(1653), new DateTime(2024, 3, 17, 9, 17, 57, 763, DateTimeKind.Local).AddTicks(1655) });

            migrationBuilder.UpdateData(
                table: "StudentsExams",
                keyColumn: "Id",
                keyValue: "se-3",
                columns: new[] { "CreatedAt", "ExamStartTime" },
                values: new object[] { new DateTime(2024, 3, 17, 12, 17, 57, 763, DateTimeKind.Local).AddTicks(1661), new DateTime(2024, 3, 17, 8, 17, 57, 763, DateTimeKind.Local).AddTicks(1663) });

            migrationBuilder.UpdateData(
                table: "StudentsExams",
                keyColumn: "Id",
                keyValue: "se-4",
                columns: new[] { "CreatedAt", "ExamStartTime" },
                values: new object[] { new DateTime(2024, 3, 17, 12, 17, 57, 763, DateTimeKind.Local).AddTicks(1665), new DateTime(2024, 3, 17, 7, 17, 57, 763, DateTimeKind.Local).AddTicks(1667) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "a-1",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 17, 12, 17, 57, 763, DateTimeKind.Local).AddTicks(1693));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "s-1",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 17, 12, 17, 57, 763, DateTimeKind.Local).AddTicks(1706));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "s-2",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 17, 12, 17, 57, 763, DateTimeKind.Local).AddTicks(1710));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "t-1",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 17, 12, 17, 57, 763, DateTimeKind.Local).AddTicks(1702));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-2",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 17, 1, 3, 17, 283, DateTimeKind.Local).AddTicks(7685));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-21",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 17, 1, 3, 17, 283, DateTimeKind.Local).AddTicks(7694));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-22",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 17, 1, 3, 17, 283, DateTimeKind.Local).AddTicks(7696));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-23",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 17, 1, 3, 17, 283, DateTimeKind.Local).AddTicks(7699));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-24",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 17, 1, 3, 17, 283, DateTimeKind.Local).AddTicks(7702));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-3",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 17, 1, 3, 17, 283, DateTimeKind.Local).AddTicks(7689));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-31",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 17, 1, 3, 17, 283, DateTimeKind.Local).AddTicks(7706));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-32",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 17, 1, 3, 17, 283, DateTimeKind.Local).AddTicks(7709));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-33",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 17, 1, 3, 17, 283, DateTimeKind.Local).AddTicks(7711));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-34",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 17, 1, 3, 17, 283, DateTimeKind.Local).AddTicks(7714));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-4",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 17, 1, 3, 17, 283, DateTimeKind.Local).AddTicks(7691));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-61",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 17, 1, 3, 17, 283, DateTimeKind.Local).AddTicks(7630));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: "c-1",
                columns: new[] { "CourseEndingDate", "CourseStartingDate", "CreatedAt" },
                values: new object[] { new DateTime(2024, 6, 17, 1, 3, 17, 283, DateTimeKind.Local).AddTicks(7835), new DateTime(2024, 3, 17, 1, 3, 17, 283, DateTimeKind.Local).AddTicks(7834), new DateTime(2024, 3, 17, 1, 3, 17, 283, DateTimeKind.Local).AddTicks(7828) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: "c-2",
                columns: new[] { "CourseEndingDate", "CourseStartingDate", "CreatedAt" },
                values: new object[] { new DateTime(2024, 6, 17, 1, 3, 17, 283, DateTimeKind.Local).AddTicks(7846), new DateTime(2024, 3, 17, 1, 3, 17, 283, DateTimeKind.Local).AddTicks(7844), new DateTime(2024, 3, 17, 1, 3, 17, 283, DateTimeKind.Local).AddTicks(7843) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: "c-3",
                columns: new[] { "CourseEndingDate", "CourseStartingDate", "CreatedAt" },
                values: new object[] { new DateTime(2024, 6, 17, 1, 3, 17, 283, DateTimeKind.Local).AddTicks(7851), new DateTime(2024, 3, 17, 1, 3, 17, 283, DateTimeKind.Local).AddTicks(7850), new DateTime(2024, 3, 17, 1, 3, 17, 283, DateTimeKind.Local).AddTicks(7848) });

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: "e-1",
                columns: new[] { "CreatedAt", "StartExamDateTime" },
                values: new object[] { new DateTime(2024, 3, 17, 1, 3, 17, 283, DateTimeKind.Local).AddTicks(7876), new DateTime(2024, 3, 24, 1, 3, 17, 283, DateTimeKind.Local).AddTicks(7881) });

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: "e-2",
                columns: new[] { "CreatedAt", "StartExamDateTime" },
                values: new object[] { new DateTime(2024, 3, 17, 1, 3, 17, 283, DateTimeKind.Local).AddTicks(7891), new DateTime(2024, 3, 31, 1, 3, 17, 283, DateTimeKind.Local).AddTicks(7894) });

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: "e-3",
                columns: new[] { "CreatedAt", "StartExamDateTime" },
                values: new object[] { new DateTime(2024, 3, 17, 1, 3, 17, 283, DateTimeKind.Local).AddTicks(7897), new DateTime(2024, 4, 7, 1, 3, 17, 283, DateTimeKind.Local).AddTicks(7899) });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-1",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 17, 1, 3, 17, 283, DateTimeKind.Local).AddTicks(7925));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-2",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 17, 1, 3, 17, 283, DateTimeKind.Local).AddTicks(7929));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-3",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 17, 1, 3, 17, 283, DateTimeKind.Local).AddTicks(7962));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-4",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 17, 1, 3, 17, 283, DateTimeKind.Local).AddTicks(7966));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-5",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 17, 1, 3, 17, 283, DateTimeKind.Local).AddTicks(7970));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-6",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 17, 1, 3, 17, 283, DateTimeKind.Local).AddTicks(7974));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-7",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 17, 1, 3, 17, 283, DateTimeKind.Local).AddTicks(7980));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-8",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 17, 1, 3, 17, 283, DateTimeKind.Local).AddTicks(7984));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-9",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 17, 1, 3, 17, 283, DateTimeKind.Local).AddTicks(7987));

            migrationBuilder.UpdateData(
                table: "StudentsExams",
                keyColumn: "Id",
                keyValue: "se-1",
                columns: new[] { "CreatedAt", "ExamStartTime" },
                values: new object[] { new DateTime(2024, 3, 17, 1, 3, 17, 283, DateTimeKind.Local).AddTicks(8018), new DateTime(2024, 3, 16, 23, 3, 17, 283, DateTimeKind.Local).AddTicks(8023) });

            migrationBuilder.UpdateData(
                table: "StudentsExams",
                keyColumn: "Id",
                keyValue: "se-2",
                columns: new[] { "CreatedAt", "ExamStartTime" },
                values: new object[] { new DateTime(2024, 3, 17, 1, 3, 17, 283, DateTimeKind.Local).AddTicks(8026), new DateTime(2024, 3, 16, 22, 3, 17, 283, DateTimeKind.Local).AddTicks(8028) });

            migrationBuilder.UpdateData(
                table: "StudentsExams",
                keyColumn: "Id",
                keyValue: "se-3",
                columns: new[] { "CreatedAt", "ExamStartTime" },
                values: new object[] { new DateTime(2024, 3, 17, 1, 3, 17, 283, DateTimeKind.Local).AddTicks(8031), new DateTime(2024, 3, 16, 21, 3, 17, 283, DateTimeKind.Local).AddTicks(8033) });

            migrationBuilder.UpdateData(
                table: "StudentsExams",
                keyColumn: "Id",
                keyValue: "se-4",
                columns: new[] { "CreatedAt", "ExamStartTime" },
                values: new object[] { new DateTime(2024, 3, 17, 1, 3, 17, 283, DateTimeKind.Local).AddTicks(8035), new DateTime(2024, 3, 16, 20, 3, 17, 283, DateTimeKind.Local).AddTicks(8036) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "a-1",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 17, 1, 3, 17, 283, DateTimeKind.Local).AddTicks(8063));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "s-1",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 17, 1, 3, 17, 283, DateTimeKind.Local).AddTicks(8074));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "s-2",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 17, 1, 3, 17, 283, DateTimeKind.Local).AddTicks(8077));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "t-1",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 17, 1, 3, 17, 283, DateTimeKind.Local).AddTicks(8070));
        }
    }
}
