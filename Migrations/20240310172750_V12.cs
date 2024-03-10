using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Exams_App_C__.Net_Server.Migrations
{
    /// <inheritdoc />
    public partial class V12 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-1",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 19, 27, 50, 169, DateTimeKind.Local).AddTicks(649));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-2",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 19, 27, 50, 169, DateTimeKind.Local).AddTicks(732));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-21",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 19, 27, 50, 169, DateTimeKind.Local).AddTicks(750));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-22",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 19, 27, 50, 169, DateTimeKind.Local).AddTicks(752));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-23",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 19, 27, 50, 169, DateTimeKind.Local).AddTicks(755));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-24",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 19, 27, 50, 169, DateTimeKind.Local).AddTicks(758));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-3",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 19, 27, 50, 169, DateTimeKind.Local).AddTicks(735));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-31",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 19, 27, 50, 169, DateTimeKind.Local).AddTicks(760));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-32",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 19, 27, 50, 169, DateTimeKind.Local).AddTicks(763));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-33",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 19, 27, 50, 169, DateTimeKind.Local).AddTicks(765));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-34",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 19, 27, 50, 169, DateTimeKind.Local).AddTicks(768));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-4",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 19, 27, 50, 169, DateTimeKind.Local).AddTicks(738));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: "c-1",
                columns: new[] { "CourseEndingDate", "CourseStartingDate", "CreatedAt" },
                values: new object[] { new DateTime(2024, 6, 10, 19, 27, 50, 169, DateTimeKind.Local).AddTicks(909), new DateTime(2024, 3, 10, 19, 27, 50, 169, DateTimeKind.Local).AddTicks(908), new DateTime(2024, 3, 10, 19, 27, 50, 169, DateTimeKind.Local).AddTicks(902) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: "c-2",
                columns: new[] { "CourseEndingDate", "CourseStartingDate", "CreatedAt" },
                values: new object[] { new DateTime(2024, 6, 10, 19, 27, 50, 169, DateTimeKind.Local).AddTicks(918), new DateTime(2024, 3, 10, 19, 27, 50, 169, DateTimeKind.Local).AddTicks(917), new DateTime(2024, 3, 10, 19, 27, 50, 169, DateTimeKind.Local).AddTicks(915) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: "c-3",
                columns: new[] { "CourseEndingDate", "CourseStartingDate", "CreatedAt" },
                values: new object[] { new DateTime(2024, 6, 10, 19, 27, 50, 169, DateTimeKind.Local).AddTicks(924), new DateTime(2024, 3, 10, 19, 27, 50, 169, DateTimeKind.Local).AddTicks(923), new DateTime(2024, 3, 10, 19, 27, 50, 169, DateTimeKind.Local).AddTicks(921) });

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: "e-1",
                columns: new[] { "CreatedAt", "StartExamDateTime" },
                values: new object[] { new DateTime(2024, 3, 10, 19, 27, 50, 169, DateTimeKind.Local).AddTicks(948), new DateTime(2024, 3, 17, 19, 27, 50, 169, DateTimeKind.Local).AddTicks(958) });

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: "e-2",
                columns: new[] { "CreatedAt", "StartExamDateTime" },
                values: new object[] { new DateTime(2024, 3, 10, 19, 27, 50, 169, DateTimeKind.Local).AddTicks(963), new DateTime(2024, 3, 24, 19, 27, 50, 169, DateTimeKind.Local).AddTicks(965) });

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: "e-3",
                columns: new[] { "CreatedAt", "StartExamDateTime" },
                values: new object[] { new DateTime(2024, 3, 10, 19, 27, 50, 169, DateTimeKind.Local).AddTicks(968), new DateTime(2024, 3, 31, 19, 27, 50, 169, DateTimeKind.Local).AddTicks(970) });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-1",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 19, 27, 50, 169, DateTimeKind.Local).AddTicks(1016));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-2",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 19, 27, 50, 169, DateTimeKind.Local).AddTicks(1022));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-3",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 19, 27, 50, 169, DateTimeKind.Local).AddTicks(1028));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-4",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 19, 27, 50, 169, DateTimeKind.Local).AddTicks(1033));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-5",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 19, 27, 50, 169, DateTimeKind.Local).AddTicks(1037));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-6",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 19, 27, 50, 169, DateTimeKind.Local).AddTicks(1041));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-7",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 19, 27, 50, 169, DateTimeKind.Local).AddTicks(1045));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-8",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 19, 27, 50, 169, DateTimeKind.Local).AddTicks(1050));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-9",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 19, 27, 50, 169, DateTimeKind.Local).AddTicks(1054));

            migrationBuilder.UpdateData(
                table: "StudentsExams",
                keyColumn: "Id",
                keyValue: "se-1",
                columns: new[] { "CreatedAt", "ExamStartTime" },
                values: new object[] { new DateTime(2024, 3, 10, 19, 27, 50, 169, DateTimeKind.Local).AddTicks(1084), new DateTime(2024, 3, 10, 17, 27, 50, 169, DateTimeKind.Local).AddTicks(1090) });

            migrationBuilder.UpdateData(
                table: "StudentsExams",
                keyColumn: "Id",
                keyValue: "se-2",
                columns: new[] { "CreatedAt", "ExamStartTime" },
                values: new object[] { new DateTime(2024, 3, 10, 19, 27, 50, 169, DateTimeKind.Local).AddTicks(1095), new DateTime(2024, 3, 10, 16, 27, 50, 169, DateTimeKind.Local).AddTicks(1097) });

            migrationBuilder.UpdateData(
                table: "StudentsExams",
                keyColumn: "Id",
                keyValue: "se-3",
                columns: new[] { "CreatedAt", "ExamStartTime" },
                values: new object[] { new DateTime(2024, 3, 10, 19, 27, 50, 169, DateTimeKind.Local).AddTicks(1100), new DateTime(2024, 3, 10, 15, 27, 50, 169, DateTimeKind.Local).AddTicks(1101) });

            migrationBuilder.UpdateData(
                table: "StudentsExams",
                keyColumn: "Id",
                keyValue: "se-4",
                columns: new[] { "CreatedAt", "ExamStartTime" },
                values: new object[] { new DateTime(2024, 3, 10, 19, 27, 50, 169, DateTimeKind.Local).AddTicks(1104), new DateTime(2024, 3, 10, 14, 27, 50, 169, DateTimeKind.Local).AddTicks(1106) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "a-1",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 19, 27, 50, 169, DateTimeKind.Local).AddTicks(1135));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "s-1",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 19, 27, 50, 169, DateTimeKind.Local).AddTicks(1148));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "s-2",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 19, 27, 50, 169, DateTimeKind.Local).AddTicks(1153));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "t-1",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 19, 27, 50, 169, DateTimeKind.Local).AddTicks(1145));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
