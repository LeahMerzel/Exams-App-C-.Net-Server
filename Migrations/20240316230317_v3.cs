using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Exams_App_C__.Net_Server.Migrations
{
    /// <inheritdoc />
    public partial class v3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-2",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 17, 0, 49, 5, 24, DateTimeKind.Local).AddTicks(2697));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-21",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 17, 0, 49, 5, 24, DateTimeKind.Local).AddTicks(2707));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-22",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 17, 0, 49, 5, 24, DateTimeKind.Local).AddTicks(2710));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-23",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 17, 0, 49, 5, 24, DateTimeKind.Local).AddTicks(2720));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-24",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 17, 0, 49, 5, 24, DateTimeKind.Local).AddTicks(2723));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-3",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 17, 0, 49, 5, 24, DateTimeKind.Local).AddTicks(2700));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-31",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 17, 0, 49, 5, 24, DateTimeKind.Local).AddTicks(2765));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-32",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 17, 0, 49, 5, 24, DateTimeKind.Local).AddTicks(2768));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-33",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 17, 0, 49, 5, 24, DateTimeKind.Local).AddTicks(2772));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-34",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 17, 0, 49, 5, 24, DateTimeKind.Local).AddTicks(2774));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-4",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 17, 0, 49, 5, 24, DateTimeKind.Local).AddTicks(2704));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-61",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 17, 0, 49, 5, 24, DateTimeKind.Local).AddTicks(2637));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: "c-1",
                columns: new[] { "CourseEndingDate", "CourseStartingDate", "CreatedAt" },
                values: new object[] { new DateTime(2024, 6, 17, 0, 49, 5, 24, DateTimeKind.Local).AddTicks(2921), new DateTime(2024, 3, 17, 0, 49, 5, 24, DateTimeKind.Local).AddTicks(2919), new DateTime(2024, 3, 17, 0, 49, 5, 24, DateTimeKind.Local).AddTicks(2913) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: "c-2",
                columns: new[] { "CourseEndingDate", "CourseStartingDate", "CreatedAt" },
                values: new object[] { new DateTime(2024, 6, 17, 0, 49, 5, 24, DateTimeKind.Local).AddTicks(2932), new DateTime(2024, 3, 17, 0, 49, 5, 24, DateTimeKind.Local).AddTicks(2931), new DateTime(2024, 3, 17, 0, 49, 5, 24, DateTimeKind.Local).AddTicks(2929) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: "c-3",
                columns: new[] { "CourseEndingDate", "CourseStartingDate", "CreatedAt" },
                values: new object[] { new DateTime(2024, 6, 17, 0, 49, 5, 24, DateTimeKind.Local).AddTicks(2941), new DateTime(2024, 3, 17, 0, 49, 5, 24, DateTimeKind.Local).AddTicks(2939), new DateTime(2024, 3, 17, 0, 49, 5, 24, DateTimeKind.Local).AddTicks(2938) });

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: "e-1",
                columns: new[] { "CreatedAt", "StartExamDateTime" },
                values: new object[] { new DateTime(2024, 3, 17, 0, 49, 5, 24, DateTimeKind.Local).AddTicks(2966), new DateTime(2024, 3, 24, 0, 49, 5, 24, DateTimeKind.Local).AddTicks(2969) });

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: "e-2",
                columns: new[] { "CreatedAt", "StartExamDateTime" },
                values: new object[] { new DateTime(2024, 3, 17, 0, 49, 5, 24, DateTimeKind.Local).AddTicks(2977), new DateTime(2024, 3, 31, 0, 49, 5, 24, DateTimeKind.Local).AddTicks(2980) });

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: "e-3",
                columns: new[] { "CreatedAt", "StartExamDateTime" },
                values: new object[] { new DateTime(2024, 3, 17, 0, 49, 5, 24, DateTimeKind.Local).AddTicks(2984), new DateTime(2024, 4, 7, 0, 49, 5, 24, DateTimeKind.Local).AddTicks(2985) });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-1",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 17, 0, 49, 5, 24, DateTimeKind.Local).AddTicks(3013));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-2",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 17, 0, 49, 5, 24, DateTimeKind.Local).AddTicks(3018));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-3",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 17, 0, 49, 5, 24, DateTimeKind.Local).AddTicks(3023));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-4",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 17, 0, 49, 5, 24, DateTimeKind.Local).AddTicks(3027));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-5",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 17, 0, 49, 5, 24, DateTimeKind.Local).AddTicks(3034));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-6",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 17, 0, 49, 5, 24, DateTimeKind.Local).AddTicks(3038));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-7",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 17, 0, 49, 5, 24, DateTimeKind.Local).AddTicks(3043));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-8",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 17, 0, 49, 5, 24, DateTimeKind.Local).AddTicks(3047));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-9",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 17, 0, 49, 5, 24, DateTimeKind.Local).AddTicks(3051));

            migrationBuilder.UpdateData(
                table: "StudentsExams",
                keyColumn: "Id",
                keyValue: "se-1",
                columns: new[] { "CreatedAt", "ExamStartTime" },
                values: new object[] { new DateTime(2024, 3, 17, 0, 49, 5, 24, DateTimeKind.Local).AddTicks(3082), new DateTime(2024, 3, 16, 22, 49, 5, 24, DateTimeKind.Local).AddTicks(3088) });

            migrationBuilder.UpdateData(
                table: "StudentsExams",
                keyColumn: "Id",
                keyValue: "se-2",
                columns: new[] { "CreatedAt", "ExamStartTime" },
                values: new object[] { new DateTime(2024, 3, 17, 0, 49, 5, 24, DateTimeKind.Local).AddTicks(3091), new DateTime(2024, 3, 16, 21, 49, 5, 24, DateTimeKind.Local).AddTicks(3093) });

            migrationBuilder.UpdateData(
                table: "StudentsExams",
                keyColumn: "Id",
                keyValue: "se-3",
                columns: new[] { "CreatedAt", "ExamStartTime" },
                values: new object[] { new DateTime(2024, 3, 17, 0, 49, 5, 24, DateTimeKind.Local).AddTicks(3096), new DateTime(2024, 3, 16, 20, 49, 5, 24, DateTimeKind.Local).AddTicks(3098) });

            migrationBuilder.UpdateData(
                table: "StudentsExams",
                keyColumn: "Id",
                keyValue: "se-4",
                columns: new[] { "CreatedAt", "ExamStartTime" },
                values: new object[] { new DateTime(2024, 3, 17, 0, 49, 5, 24, DateTimeKind.Local).AddTicks(3102), new DateTime(2024, 3, 16, 19, 49, 5, 24, DateTimeKind.Local).AddTicks(3104) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "a-1",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 17, 0, 49, 5, 24, DateTimeKind.Local).AddTicks(3128));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "s-1",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 17, 0, 49, 5, 24, DateTimeKind.Local).AddTicks(3137));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "s-2",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 17, 0, 49, 5, 24, DateTimeKind.Local).AddTicks(3141));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "t-1",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 17, 0, 49, 5, 24, DateTimeKind.Local).AddTicks(3134));
        }
    }
}
