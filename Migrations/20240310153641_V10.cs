using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Exams_App_C__.Net_Server.Migrations
{
    /// <inheritdoc />
    public partial class V10 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-1",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 17, 21, 10, 360, DateTimeKind.Local).AddTicks(7711));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-2",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 17, 21, 10, 360, DateTimeKind.Local).AddTicks(7769));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-21",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 17, 21, 10, 360, DateTimeKind.Local).AddTicks(7788));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-22",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 17, 21, 10, 360, DateTimeKind.Local).AddTicks(7791));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-23",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 17, 21, 10, 360, DateTimeKind.Local).AddTicks(7793));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-24",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 17, 21, 10, 360, DateTimeKind.Local).AddTicks(7796));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-3",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 17, 21, 10, 360, DateTimeKind.Local).AddTicks(7783));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-31",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 17, 21, 10, 360, DateTimeKind.Local).AddTicks(7798));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-32",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 17, 21, 10, 360, DateTimeKind.Local).AddTicks(7801));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-33",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 17, 21, 10, 360, DateTimeKind.Local).AddTicks(7806));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-34",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 17, 21, 10, 360, DateTimeKind.Local).AddTicks(7808));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-4",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 17, 21, 10, 360, DateTimeKind.Local).AddTicks(7786));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: "c-1",
                columns: new[] { "CourseEndingDate", "CourseStartingDate", "CreatedAt" },
                values: new object[] { new DateTime(2024, 6, 10, 17, 21, 10, 360, DateTimeKind.Local).AddTicks(7926), new DateTime(2024, 3, 10, 17, 21, 10, 360, DateTimeKind.Local).AddTicks(7924), new DateTime(2024, 3, 10, 17, 21, 10, 360, DateTimeKind.Local).AddTicks(7918) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: "c-2",
                columns: new[] { "CourseEndingDate", "CourseStartingDate", "CreatedAt" },
                values: new object[] { new DateTime(2024, 6, 10, 17, 21, 10, 360, DateTimeKind.Local).AddTicks(7935), new DateTime(2024, 3, 10, 17, 21, 10, 360, DateTimeKind.Local).AddTicks(7933), new DateTime(2024, 3, 10, 17, 21, 10, 360, DateTimeKind.Local).AddTicks(7932) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: "c-3",
                columns: new[] { "CourseEndingDate", "CourseStartingDate", "CreatedAt" },
                values: new object[] { new DateTime(2024, 6, 10, 17, 21, 10, 360, DateTimeKind.Local).AddTicks(7940), new DateTime(2024, 3, 10, 17, 21, 10, 360, DateTimeKind.Local).AddTicks(7939), new DateTime(2024, 3, 10, 17, 21, 10, 360, DateTimeKind.Local).AddTicks(7937) });

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: "e-1",
                columns: new[] { "CreatedAt", "StartExamDateTime" },
                values: new object[] { new DateTime(2024, 3, 10, 17, 21, 10, 360, DateTimeKind.Local).AddTicks(8021), new DateTime(2024, 3, 17, 17, 21, 10, 360, DateTimeKind.Local).AddTicks(8025) });

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: "e-2",
                columns: new[] { "CreatedAt", "StartExamDateTime" },
                values: new object[] { new DateTime(2024, 3, 10, 17, 21, 10, 360, DateTimeKind.Local).AddTicks(8030), new DateTime(2024, 3, 24, 17, 21, 10, 360, DateTimeKind.Local).AddTicks(8032) });

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: "e-3",
                columns: new[] { "CreatedAt", "StartExamDateTime" },
                values: new object[] { new DateTime(2024, 3, 10, 17, 21, 10, 360, DateTimeKind.Local).AddTicks(8035), new DateTime(2024, 3, 31, 17, 21, 10, 360, DateTimeKind.Local).AddTicks(8037) });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-1",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 17, 21, 10, 360, DateTimeKind.Local).AddTicks(8064));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-2",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 17, 21, 10, 360, DateTimeKind.Local).AddTicks(8070));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-3",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 17, 21, 10, 360, DateTimeKind.Local).AddTicks(8074));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-4",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 17, 21, 10, 360, DateTimeKind.Local).AddTicks(8078));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-5",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 17, 21, 10, 360, DateTimeKind.Local).AddTicks(8083));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-6",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 17, 21, 10, 360, DateTimeKind.Local).AddTicks(8087));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-7",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 17, 21, 10, 360, DateTimeKind.Local).AddTicks(8091));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-8",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 17, 21, 10, 360, DateTimeKind.Local).AddTicks(8095));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-9",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 17, 21, 10, 360, DateTimeKind.Local).AddTicks(8101));

            migrationBuilder.UpdateData(
                table: "StudentsExams",
                keyColumn: "Id",
                keyValue: "se-1",
                columns: new[] { "CreatedAt", "ExamStartTime" },
                values: new object[] { new DateTime(2024, 3, 10, 17, 21, 10, 360, DateTimeKind.Local).AddTicks(8129), new DateTime(2024, 3, 10, 15, 21, 10, 360, DateTimeKind.Local).AddTicks(8135) });

            migrationBuilder.UpdateData(
                table: "StudentsExams",
                keyColumn: "Id",
                keyValue: "se-2",
                columns: new[] { "CreatedAt", "ExamStartTime" },
                values: new object[] { new DateTime(2024, 3, 10, 17, 21, 10, 360, DateTimeKind.Local).AddTicks(8138), new DateTime(2024, 3, 10, 14, 21, 10, 360, DateTimeKind.Local).AddTicks(8140) });

            migrationBuilder.UpdateData(
                table: "StudentsExams",
                keyColumn: "Id",
                keyValue: "se-3",
                columns: new[] { "CreatedAt", "ExamStartTime" },
                values: new object[] { new DateTime(2024, 3, 10, 17, 21, 10, 360, DateTimeKind.Local).AddTicks(8143), new DateTime(2024, 3, 10, 13, 21, 10, 360, DateTimeKind.Local).AddTicks(8145) });

            migrationBuilder.UpdateData(
                table: "StudentsExams",
                keyColumn: "Id",
                keyValue: "se-4",
                columns: new[] { "CreatedAt", "ExamStartTime" },
                values: new object[] { new DateTime(2024, 3, 10, 17, 21, 10, 360, DateTimeKind.Local).AddTicks(8147), new DateTime(2024, 3, 10, 12, 21, 10, 360, DateTimeKind.Local).AddTicks(8149) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "a-1",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 17, 21, 10, 360, DateTimeKind.Local).AddTicks(8173));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "s-1",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 17, 21, 10, 360, DateTimeKind.Local).AddTicks(8185));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "s-2",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 17, 21, 10, 360, DateTimeKind.Local).AddTicks(8190));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "t-1",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 17, 21, 10, 360, DateTimeKind.Local).AddTicks(8181));
        }
    }
}
