using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Exams_App_C__.Net_Server.Migrations
{
    /// <inheritdoc />
    public partial class V11 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-1",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 19, 23, 4, 363, DateTimeKind.Local).AddTicks(4285));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-2",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 19, 23, 4, 363, DateTimeKind.Local).AddTicks(4352));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-21",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 19, 23, 4, 363, DateTimeKind.Local).AddTicks(4374));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-22",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 19, 23, 4, 363, DateTimeKind.Local).AddTicks(4377));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-23",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 19, 23, 4, 363, DateTimeKind.Local).AddTicks(4379));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-24",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 19, 23, 4, 363, DateTimeKind.Local).AddTicks(4382));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-3",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 19, 23, 4, 363, DateTimeKind.Local).AddTicks(4368));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-31",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 19, 23, 4, 363, DateTimeKind.Local).AddTicks(4384));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-32",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 19, 23, 4, 363, DateTimeKind.Local).AddTicks(4386));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-33",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 19, 23, 4, 363, DateTimeKind.Local).AddTicks(4391));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-34",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 19, 23, 4, 363, DateTimeKind.Local).AddTicks(4394));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-4",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 19, 23, 4, 363, DateTimeKind.Local).AddTicks(4371));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: "c-1",
                columns: new[] { "CourseEndingDate", "CourseStartingDate", "CreatedAt" },
                values: new object[] { new DateTime(2024, 6, 10, 19, 23, 4, 363, DateTimeKind.Local).AddTicks(4522), new DateTime(2024, 3, 10, 19, 23, 4, 363, DateTimeKind.Local).AddTicks(4521), new DateTime(2024, 3, 10, 19, 23, 4, 363, DateTimeKind.Local).AddTicks(4515) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: "c-2",
                columns: new[] { "CourseEndingDate", "CourseStartingDate", "CreatedAt" },
                values: new object[] { new DateTime(2024, 6, 10, 19, 23, 4, 363, DateTimeKind.Local).AddTicks(4531), new DateTime(2024, 3, 10, 19, 23, 4, 363, DateTimeKind.Local).AddTicks(4530), new DateTime(2024, 3, 10, 19, 23, 4, 363, DateTimeKind.Local).AddTicks(4528) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: "c-3",
                columns: new[] { "CourseEndingDate", "CourseStartingDate", "CreatedAt" },
                values: new object[] { new DateTime(2024, 6, 10, 19, 23, 4, 363, DateTimeKind.Local).AddTicks(4538), new DateTime(2024, 3, 10, 19, 23, 4, 363, DateTimeKind.Local).AddTicks(4536), new DateTime(2024, 3, 10, 19, 23, 4, 363, DateTimeKind.Local).AddTicks(4534) });

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: "e-1",
                columns: new[] { "CreatedAt", "StartExamDateTime" },
                values: new object[] { new DateTime(2024, 3, 10, 19, 23, 4, 363, DateTimeKind.Local).AddTicks(4563), new DateTime(2024, 3, 17, 19, 23, 4, 363, DateTimeKind.Local).AddTicks(4569) });

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: "e-2",
                columns: new[] { "CreatedAt", "StartExamDateTime" },
                values: new object[] { new DateTime(2024, 3, 10, 19, 23, 4, 363, DateTimeKind.Local).AddTicks(4576), new DateTime(2024, 3, 24, 19, 23, 4, 363, DateTimeKind.Local).AddTicks(4578) });

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: "e-3",
                columns: new[] { "CreatedAt", "StartExamDateTime" },
                values: new object[] { new DateTime(2024, 3, 10, 19, 23, 4, 363, DateTimeKind.Local).AddTicks(4581), new DateTime(2024, 3, 31, 19, 23, 4, 363, DateTimeKind.Local).AddTicks(4583) });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-1",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 19, 23, 4, 363, DateTimeKind.Local).AddTicks(4611));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-2",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 19, 23, 4, 363, DateTimeKind.Local).AddTicks(4616));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-3",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 19, 23, 4, 363, DateTimeKind.Local).AddTicks(4621));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-4",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 19, 23, 4, 363, DateTimeKind.Local).AddTicks(4625));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-5",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 19, 23, 4, 363, DateTimeKind.Local).AddTicks(4629));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-6",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 19, 23, 4, 363, DateTimeKind.Local).AddTicks(4634));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-7",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 19, 23, 4, 363, DateTimeKind.Local).AddTicks(4638));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-8",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 19, 23, 4, 363, DateTimeKind.Local).AddTicks(4641));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-9",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 19, 23, 4, 363, DateTimeKind.Local).AddTicks(4647));

            migrationBuilder.UpdateData(
                table: "StudentsExams",
                keyColumn: "Id",
                keyValue: "se-1",
                columns: new[] { "CreatedAt", "ExamStartTime" },
                values: new object[] { new DateTime(2024, 3, 10, 19, 23, 4, 363, DateTimeKind.Local).AddTicks(4676), new DateTime(2024, 3, 10, 17, 23, 4, 363, DateTimeKind.Local).AddTicks(4681) });

            migrationBuilder.UpdateData(
                table: "StudentsExams",
                keyColumn: "Id",
                keyValue: "se-2",
                columns: new[] { "CreatedAt", "ExamStartTime" },
                values: new object[] { new DateTime(2024, 3, 10, 19, 23, 4, 363, DateTimeKind.Local).AddTicks(4684), new DateTime(2024, 3, 10, 16, 23, 4, 363, DateTimeKind.Local).AddTicks(4686) });

            migrationBuilder.UpdateData(
                table: "StudentsExams",
                keyColumn: "Id",
                keyValue: "se-3",
                columns: new[] { "CreatedAt", "ExamStartTime" },
                values: new object[] { new DateTime(2024, 3, 10, 19, 23, 4, 363, DateTimeKind.Local).AddTicks(4718), new DateTime(2024, 3, 10, 15, 23, 4, 363, DateTimeKind.Local).AddTicks(4720) });

            migrationBuilder.UpdateData(
                table: "StudentsExams",
                keyColumn: "Id",
                keyValue: "se-4",
                columns: new[] { "CreatedAt", "ExamStartTime" },
                values: new object[] { new DateTime(2024, 3, 10, 19, 23, 4, 363, DateTimeKind.Local).AddTicks(4723), new DateTime(2024, 3, 10, 14, 23, 4, 363, DateTimeKind.Local).AddTicks(4724) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "a-1",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 19, 23, 4, 363, DateTimeKind.Local).AddTicks(4749));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "s-1",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 19, 23, 4, 363, DateTimeKind.Local).AddTicks(4763));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "s-2",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 19, 23, 4, 363, DateTimeKind.Local).AddTicks(4768));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "t-1",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 19, 23, 4, 363, DateTimeKind.Local).AddTicks(4759));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-1",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 17, 36, 41, 89, DateTimeKind.Local).AddTicks(9331));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-2",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 17, 36, 41, 89, DateTimeKind.Local).AddTicks(9405));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-21",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 17, 36, 41, 89, DateTimeKind.Local).AddTicks(9420));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-22",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 17, 36, 41, 89, DateTimeKind.Local).AddTicks(9494));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-23",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 17, 36, 41, 89, DateTimeKind.Local).AddTicks(9516));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-24",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 17, 36, 41, 89, DateTimeKind.Local).AddTicks(9521));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-3",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 17, 36, 41, 89, DateTimeKind.Local).AddTicks(9410));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-31",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 17, 36, 41, 89, DateTimeKind.Local).AddTicks(9525));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-32",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 17, 36, 41, 89, DateTimeKind.Local).AddTicks(9664));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-33",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 17, 36, 41, 89, DateTimeKind.Local).AddTicks(9669));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-34",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 17, 36, 41, 89, DateTimeKind.Local).AddTicks(9674));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-4",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 17, 36, 41, 89, DateTimeKind.Local).AddTicks(9415));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: "c-1",
                columns: new[] { "CourseEndingDate", "CourseStartingDate", "CreatedAt" },
                values: new object[] { new DateTime(2024, 6, 10, 17, 36, 41, 89, DateTimeKind.Local).AddTicks(9983), new DateTime(2024, 3, 10, 17, 36, 41, 89, DateTimeKind.Local).AddTicks(9981), new DateTime(2024, 3, 10, 17, 36, 41, 89, DateTimeKind.Local).AddTicks(9969) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: "c-2",
                columns: new[] { "CourseEndingDate", "CourseStartingDate", "CreatedAt" },
                values: new object[] { new DateTime(2024, 6, 10, 17, 36, 41, 90, DateTimeKind.Local).AddTicks(3), new DateTime(2024, 3, 10, 17, 36, 41, 90, DateTimeKind.Local).AddTicks(1), new DateTime(2024, 3, 10, 17, 36, 41, 89, DateTimeKind.Local).AddTicks(9998) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: "c-3",
                columns: new[] { "CourseEndingDate", "CourseStartingDate", "CreatedAt" },
                values: new object[] { new DateTime(2024, 6, 10, 17, 36, 41, 90, DateTimeKind.Local).AddTicks(18), new DateTime(2024, 3, 10, 17, 36, 41, 90, DateTimeKind.Local).AddTicks(16), new DateTime(2024, 3, 10, 17, 36, 41, 90, DateTimeKind.Local).AddTicks(12) });

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: "e-1",
                columns: new[] { "CreatedAt", "StartExamDateTime" },
                values: new object[] { new DateTime(2024, 3, 10, 17, 36, 41, 90, DateTimeKind.Local).AddTicks(59), new DateTime(2024, 3, 17, 17, 36, 41, 90, DateTimeKind.Local).AddTicks(72) });

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: "e-2",
                columns: new[] { "CreatedAt", "StartExamDateTime" },
                values: new object[] { new DateTime(2024, 3, 10, 17, 36, 41, 90, DateTimeKind.Local).AddTicks(83), new DateTime(2024, 3, 24, 17, 36, 41, 90, DateTimeKind.Local).AddTicks(87) });

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: "e-3",
                columns: new[] { "CreatedAt", "StartExamDateTime" },
                values: new object[] { new DateTime(2024, 3, 10, 17, 36, 41, 90, DateTimeKind.Local).AddTicks(92), new DateTime(2024, 3, 31, 17, 36, 41, 90, DateTimeKind.Local).AddTicks(95) });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-1",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 17, 36, 41, 90, DateTimeKind.Local).AddTicks(136));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-2",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 17, 36, 41, 90, DateTimeKind.Local).AddTicks(145));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-3",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 17, 36, 41, 90, DateTimeKind.Local).AddTicks(151));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-4",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 17, 36, 41, 90, DateTimeKind.Local).AddTicks(159));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-5",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 17, 36, 41, 90, DateTimeKind.Local).AddTicks(170));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-6",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 17, 36, 41, 90, DateTimeKind.Local).AddTicks(178));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-7",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 17, 36, 41, 90, DateTimeKind.Local).AddTicks(186));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-8",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 17, 36, 41, 90, DateTimeKind.Local).AddTicks(193));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-9",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 17, 36, 41, 90, DateTimeKind.Local).AddTicks(200));

            migrationBuilder.UpdateData(
                table: "StudentsExams",
                keyColumn: "Id",
                keyValue: "se-1",
                columns: new[] { "CreatedAt", "ExamStartTime" },
                values: new object[] { new DateTime(2024, 3, 10, 17, 36, 41, 90, DateTimeKind.Local).AddTicks(254), new DateTime(2024, 3, 10, 15, 36, 41, 90, DateTimeKind.Local).AddTicks(264) });

            migrationBuilder.UpdateData(
                table: "StudentsExams",
                keyColumn: "Id",
                keyValue: "se-2",
                columns: new[] { "CreatedAt", "ExamStartTime" },
                values: new object[] { new DateTime(2024, 3, 10, 17, 36, 41, 90, DateTimeKind.Local).AddTicks(269), new DateTime(2024, 3, 10, 14, 36, 41, 90, DateTimeKind.Local).AddTicks(273) });

            migrationBuilder.UpdateData(
                table: "StudentsExams",
                keyColumn: "Id",
                keyValue: "se-3",
                columns: new[] { "CreatedAt", "ExamStartTime" },
                values: new object[] { new DateTime(2024, 3, 10, 17, 36, 41, 90, DateTimeKind.Local).AddTicks(277), new DateTime(2024, 3, 10, 13, 36, 41, 90, DateTimeKind.Local).AddTicks(280) });

            migrationBuilder.UpdateData(
                table: "StudentsExams",
                keyColumn: "Id",
                keyValue: "se-4",
                columns: new[] { "CreatedAt", "ExamStartTime" },
                values: new object[] { new DateTime(2024, 3, 10, 17, 36, 41, 90, DateTimeKind.Local).AddTicks(287), new DateTime(2024, 3, 10, 12, 36, 41, 90, DateTimeKind.Local).AddTicks(305) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "a-1",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 17, 36, 41, 90, DateTimeKind.Local).AddTicks(501));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "s-1",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 17, 36, 41, 90, DateTimeKind.Local).AddTicks(563));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "s-2",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 17, 36, 41, 90, DateTimeKind.Local).AddTicks(571));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "t-1",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 17, 36, 41, 90, DateTimeKind.Local).AddTicks(517));
        }
    }
}
