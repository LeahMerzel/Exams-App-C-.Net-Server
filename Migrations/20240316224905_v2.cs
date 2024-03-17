using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Exams_App_C__.Net_Server.Migrations
{
    /// <inheritdoc />
    public partial class v2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsImage",
                table: "Questions");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsImage",
                table: "Questions",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-2",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 16, 22, 55, 47, 694, DateTimeKind.Local).AddTicks(7599));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-21",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 16, 22, 55, 47, 694, DateTimeKind.Local).AddTicks(7625));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-22",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 16, 22, 55, 47, 694, DateTimeKind.Local).AddTicks(7629));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-23",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 16, 22, 55, 47, 694, DateTimeKind.Local).AddTicks(7632));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-24",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 16, 22, 55, 47, 694, DateTimeKind.Local).AddTicks(7635));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-3",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 16, 22, 55, 47, 694, DateTimeKind.Local).AddTicks(7618));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-31",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 16, 22, 55, 47, 694, DateTimeKind.Local).AddTicks(7638));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-32",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 16, 22, 55, 47, 694, DateTimeKind.Local).AddTicks(7642));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-33",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 16, 22, 55, 47, 694, DateTimeKind.Local).AddTicks(7648));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-34",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 16, 22, 55, 47, 694, DateTimeKind.Local).AddTicks(7652));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-4",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 16, 22, 55, 47, 694, DateTimeKind.Local).AddTicks(7622));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-61",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 16, 22, 55, 47, 694, DateTimeKind.Local).AddTicks(7534));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: "c-1",
                columns: new[] { "CourseEndingDate", "CourseStartingDate", "CreatedAt" },
                values: new object[] { new DateTime(2024, 6, 16, 22, 55, 47, 694, DateTimeKind.Local).AddTicks(7813), new DateTime(2024, 3, 16, 22, 55, 47, 694, DateTimeKind.Local).AddTicks(7811), new DateTime(2024, 3, 16, 22, 55, 47, 694, DateTimeKind.Local).AddTicks(7804) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: "c-2",
                columns: new[] { "CourseEndingDate", "CourseStartingDate", "CreatedAt" },
                values: new object[] { new DateTime(2024, 6, 16, 22, 55, 47, 694, DateTimeKind.Local).AddTicks(7823), new DateTime(2024, 3, 16, 22, 55, 47, 694, DateTimeKind.Local).AddTicks(7822), new DateTime(2024, 3, 16, 22, 55, 47, 694, DateTimeKind.Local).AddTicks(7820) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: "c-3",
                columns: new[] { "CourseEndingDate", "CourseStartingDate", "CreatedAt" },
                values: new object[] { new DateTime(2024, 6, 16, 22, 55, 47, 694, DateTimeKind.Local).AddTicks(7829), new DateTime(2024, 3, 16, 22, 55, 47, 694, DateTimeKind.Local).AddTicks(7828), new DateTime(2024, 3, 16, 22, 55, 47, 694, DateTimeKind.Local).AddTicks(7826) });

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: "e-1",
                columns: new[] { "CreatedAt", "StartExamDateTime" },
                values: new object[] { new DateTime(2024, 3, 16, 22, 55, 47, 694, DateTimeKind.Local).AddTicks(7890), new DateTime(2024, 3, 23, 22, 55, 47, 694, DateTimeKind.Local).AddTicks(7897) });

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: "e-2",
                columns: new[] { "CreatedAt", "StartExamDateTime" },
                values: new object[] { new DateTime(2024, 3, 16, 22, 55, 47, 694, DateTimeKind.Local).AddTicks(7906), new DateTime(2024, 3, 30, 22, 55, 47, 694, DateTimeKind.Local).AddTicks(7908) });

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: "e-3",
                columns: new[] { "CreatedAt", "StartExamDateTime" },
                values: new object[] { new DateTime(2024, 3, 16, 22, 55, 47, 694, DateTimeKind.Local).AddTicks(7912), new DateTime(2024, 4, 6, 22, 55, 47, 694, DateTimeKind.Local).AddTicks(7915) });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-1",
                columns: new[] { "CreatedAt", "IsImage" },
                values: new object[] { new DateTime(2024, 3, 16, 22, 55, 47, 694, DateTimeKind.Local).AddTicks(7947), false });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-2",
                columns: new[] { "CreatedAt", "IsImage" },
                values: new object[] { new DateTime(2024, 3, 16, 22, 55, 47, 694, DateTimeKind.Local).AddTicks(7952), false });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-3",
                columns: new[] { "CreatedAt", "IsImage" },
                values: new object[] { new DateTime(2024, 3, 16, 22, 55, 47, 694, DateTimeKind.Local).AddTicks(7958), false });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-4",
                columns: new[] { "CreatedAt", "IsImage" },
                values: new object[] { new DateTime(2024, 3, 16, 22, 55, 47, 694, DateTimeKind.Local).AddTicks(7962), false });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-5",
                columns: new[] { "CreatedAt", "IsImage" },
                values: new object[] { new DateTime(2024, 3, 16, 22, 55, 47, 694, DateTimeKind.Local).AddTicks(7989), false });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-6",
                columns: new[] { "CreatedAt", "IsImage" },
                values: new object[] { new DateTime(2024, 3, 16, 22, 55, 47, 694, DateTimeKind.Local).AddTicks(7995), false });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-7",
                columns: new[] { "CreatedAt", "IsImage" },
                values: new object[] { new DateTime(2024, 3, 16, 22, 55, 47, 694, DateTimeKind.Local).AddTicks(8000), false });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-8",
                columns: new[] { "CreatedAt", "IsImage" },
                values: new object[] { new DateTime(2024, 3, 16, 22, 55, 47, 694, DateTimeKind.Local).AddTicks(8005), false });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-9",
                columns: new[] { "CreatedAt", "IsImage" },
                values: new object[] { new DateTime(2024, 3, 16, 22, 55, 47, 694, DateTimeKind.Local).AddTicks(8013), false });

            migrationBuilder.UpdateData(
                table: "StudentsExams",
                keyColumn: "Id",
                keyValue: "se-1",
                columns: new[] { "CreatedAt", "ExamStartTime" },
                values: new object[] { new DateTime(2024, 3, 16, 22, 55, 47, 694, DateTimeKind.Local).AddTicks(8050), new DateTime(2024, 3, 16, 20, 55, 47, 694, DateTimeKind.Local).AddTicks(8057) });

            migrationBuilder.UpdateData(
                table: "StudentsExams",
                keyColumn: "Id",
                keyValue: "se-2",
                columns: new[] { "CreatedAt", "ExamStartTime" },
                values: new object[] { new DateTime(2024, 3, 16, 22, 55, 47, 694, DateTimeKind.Local).AddTicks(8060), new DateTime(2024, 3, 16, 19, 55, 47, 694, DateTimeKind.Local).AddTicks(8062) });

            migrationBuilder.UpdateData(
                table: "StudentsExams",
                keyColumn: "Id",
                keyValue: "se-3",
                columns: new[] { "CreatedAt", "ExamStartTime" },
                values: new object[] { new DateTime(2024, 3, 16, 22, 55, 47, 694, DateTimeKind.Local).AddTicks(8065), new DateTime(2024, 3, 16, 18, 55, 47, 694, DateTimeKind.Local).AddTicks(8068) });

            migrationBuilder.UpdateData(
                table: "StudentsExams",
                keyColumn: "Id",
                keyValue: "se-4",
                columns: new[] { "CreatedAt", "ExamStartTime" },
                values: new object[] { new DateTime(2024, 3, 16, 22, 55, 47, 694, DateTimeKind.Local).AddTicks(8071), new DateTime(2024, 3, 16, 17, 55, 47, 694, DateTimeKind.Local).AddTicks(8073) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "a-1",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 16, 22, 55, 47, 694, DateTimeKind.Local).AddTicks(8101));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "s-1",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 16, 22, 55, 47, 694, DateTimeKind.Local).AddTicks(8111));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "s-2",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 16, 22, 55, 47, 694, DateTimeKind.Local).AddTicks(8118));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "t-1",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 16, 22, 55, 47, 694, DateTimeKind.Local).AddTicks(8107));
        }
    }
}
