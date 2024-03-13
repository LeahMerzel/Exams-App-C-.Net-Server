using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Exams_App_C__.Net_Server.Migrations
{
    /// <inheritdoc />
    public partial class v8 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-2",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 23, 7, 22, 335, DateTimeKind.Local).AddTicks(3166));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-21",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 23, 7, 22, 335, DateTimeKind.Local).AddTicks(3187));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-22",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 23, 7, 22, 335, DateTimeKind.Local).AddTicks(3191));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-23",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 23, 7, 22, 335, DateTimeKind.Local).AddTicks(3194));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-24",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 23, 7, 22, 335, DateTimeKind.Local).AddTicks(3197));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-3",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 23, 7, 22, 335, DateTimeKind.Local).AddTicks(3169));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-31",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 23, 7, 22, 335, DateTimeKind.Local).AddTicks(3200));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-32",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 23, 7, 22, 335, DateTimeKind.Local).AddTicks(3203));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-33",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 23, 7, 22, 335, DateTimeKind.Local).AddTicks(3205));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-34",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 23, 7, 22, 335, DateTimeKind.Local).AddTicks(3211));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-4",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 23, 7, 22, 335, DateTimeKind.Local).AddTicks(3184));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-61",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 23, 7, 22, 335, DateTimeKind.Local).AddTicks(3094));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: "c-1",
                columns: new[] { "CourseEndingDate", "CourseStartingDate", "CreatedAt" },
                values: new object[] { new DateTime(2024, 6, 13, 23, 7, 22, 335, DateTimeKind.Local).AddTicks(3388), new DateTime(2024, 3, 13, 23, 7, 22, 335, DateTimeKind.Local).AddTicks(3386), new DateTime(2024, 3, 13, 23, 7, 22, 335, DateTimeKind.Local).AddTicks(3359) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: "c-2",
                columns: new[] { "CourseEndingDate", "CourseStartingDate", "CreatedAt" },
                values: new object[] { new DateTime(2024, 6, 13, 23, 7, 22, 335, DateTimeKind.Local).AddTicks(3401), new DateTime(2024, 3, 13, 23, 7, 22, 335, DateTimeKind.Local).AddTicks(3400), new DateTime(2024, 3, 13, 23, 7, 22, 335, DateTimeKind.Local).AddTicks(3397) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: "c-3",
                columns: new[] { "CourseEndingDate", "CourseStartingDate", "CreatedAt" },
                values: new object[] { new DateTime(2024, 6, 13, 23, 7, 22, 335, DateTimeKind.Local).AddTicks(3407), new DateTime(2024, 3, 13, 23, 7, 22, 335, DateTimeKind.Local).AddTicks(3406), new DateTime(2024, 3, 13, 23, 7, 22, 335, DateTimeKind.Local).AddTicks(3404) });

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: "e-1",
                columns: new[] { "CreatedAt", "StartExamDateTime" },
                values: new object[] { new DateTime(2024, 3, 13, 23, 7, 22, 335, DateTimeKind.Local).AddTicks(3436), new DateTime(2024, 3, 20, 23, 7, 22, 335, DateTimeKind.Local).AddTicks(3440) });

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: "e-2",
                columns: new[] { "CreatedAt", "StartExamDateTime" },
                values: new object[] { new DateTime(2024, 3, 13, 23, 7, 22, 335, DateTimeKind.Local).AddTicks(3445), new DateTime(2024, 3, 27, 23, 7, 22, 335, DateTimeKind.Local).AddTicks(3448) });

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: "e-3",
                columns: new[] { "CreatedAt", "StartExamDateTime" },
                values: new object[] { new DateTime(2024, 3, 13, 23, 7, 22, 335, DateTimeKind.Local).AddTicks(3451), new DateTime(2024, 4, 3, 23, 7, 22, 335, DateTimeKind.Local).AddTicks(3454) });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-1",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 23, 7, 22, 335, DateTimeKind.Local).AddTicks(3483));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-2",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 23, 7, 22, 335, DateTimeKind.Local).AddTicks(3491));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-3",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 23, 7, 22, 335, DateTimeKind.Local).AddTicks(3496));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-4",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 23, 7, 22, 335, DateTimeKind.Local).AddTicks(3501));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-5",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 23, 7, 22, 335, DateTimeKind.Local).AddTicks(3506));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-6",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 23, 7, 22, 335, DateTimeKind.Local).AddTicks(3510));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-7",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 23, 7, 22, 335, DateTimeKind.Local).AddTicks(3515));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-8",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 23, 7, 22, 335, DateTimeKind.Local).AddTicks(3519));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-9",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 23, 7, 22, 335, DateTimeKind.Local).AddTicks(3524));

            migrationBuilder.UpdateData(
                table: "StudentsExams",
                keyColumn: "Id",
                keyValue: "se-1",
                columns: new[] { "CreatedAt", "ExamStartTime" },
                values: new object[] { new DateTime(2024, 3, 13, 23, 7, 22, 335, DateTimeKind.Local).AddTicks(3564), new DateTime(2024, 3, 13, 21, 7, 22, 335, DateTimeKind.Local).AddTicks(3570) });

            migrationBuilder.UpdateData(
                table: "StudentsExams",
                keyColumn: "Id",
                keyValue: "se-2",
                columns: new[] { "CreatedAt", "ExamStartTime" },
                values: new object[] { new DateTime(2024, 3, 13, 23, 7, 22, 335, DateTimeKind.Local).AddTicks(3573), new DateTime(2024, 3, 13, 20, 7, 22, 335, DateTimeKind.Local).AddTicks(3576) });

            migrationBuilder.UpdateData(
                table: "StudentsExams",
                keyColumn: "Id",
                keyValue: "se-3",
                columns: new[] { "CreatedAt", "ExamStartTime" },
                values: new object[] { new DateTime(2024, 3, 13, 23, 7, 22, 335, DateTimeKind.Local).AddTicks(3579), new DateTime(2024, 3, 13, 19, 7, 22, 335, DateTimeKind.Local).AddTicks(3581) });

            migrationBuilder.UpdateData(
                table: "StudentsExams",
                keyColumn: "Id",
                keyValue: "se-4",
                columns: new[] { "CreatedAt", "ExamStartTime" },
                values: new object[] { new DateTime(2024, 3, 13, 23, 7, 22, 335, DateTimeKind.Local).AddTicks(3583), new DateTime(2024, 3, 13, 18, 7, 22, 335, DateTimeKind.Local).AddTicks(3585) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "a-1",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 23, 7, 22, 335, DateTimeKind.Local).AddTicks(3612));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "s-1",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 23, 7, 22, 335, DateTimeKind.Local).AddTicks(3627));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "s-2",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 23, 7, 22, 335, DateTimeKind.Local).AddTicks(3630));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "t-1",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 23, 7, 22, 335, DateTimeKind.Local).AddTicks(3623));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-2",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 22, 29, 57, 434, DateTimeKind.Local).AddTicks(4128));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-21",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 22, 29, 57, 434, DateTimeKind.Local).AddTicks(4137));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-22",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 22, 29, 57, 434, DateTimeKind.Local).AddTicks(4140));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-23",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 22, 29, 57, 434, DateTimeKind.Local).AddTicks(4153));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-24",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 22, 29, 57, 434, DateTimeKind.Local).AddTicks(4156));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-3",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 22, 29, 57, 434, DateTimeKind.Local).AddTicks(4131));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-31",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 22, 29, 57, 434, DateTimeKind.Local).AddTicks(4159));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-32",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 22, 29, 57, 434, DateTimeKind.Local).AddTicks(4161));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-33",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 22, 29, 57, 434, DateTimeKind.Local).AddTicks(4164));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-34",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 22, 29, 57, 434, DateTimeKind.Local).AddTicks(4166));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-4",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 22, 29, 57, 434, DateTimeKind.Local).AddTicks(4134));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-61",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 22, 29, 57, 434, DateTimeKind.Local).AddTicks(4066));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: "c-1",
                columns: new[] { "CourseEndingDate", "CourseStartingDate", "CreatedAt" },
                values: new object[] { new DateTime(2024, 6, 13, 22, 29, 57, 434, DateTimeKind.Local).AddTicks(4287), new DateTime(2024, 3, 13, 22, 29, 57, 434, DateTimeKind.Local).AddTicks(4285), new DateTime(2024, 3, 13, 22, 29, 57, 434, DateTimeKind.Local).AddTicks(4278) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: "c-2",
                columns: new[] { "CourseEndingDate", "CourseStartingDate", "CreatedAt" },
                values: new object[] { new DateTime(2024, 6, 13, 22, 29, 57, 434, DateTimeKind.Local).AddTicks(4296), new DateTime(2024, 3, 13, 22, 29, 57, 434, DateTimeKind.Local).AddTicks(4294), new DateTime(2024, 3, 13, 22, 29, 57, 434, DateTimeKind.Local).AddTicks(4292) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: "c-3",
                columns: new[] { "CourseEndingDate", "CourseStartingDate", "CreatedAt" },
                values: new object[] { new DateTime(2024, 6, 13, 22, 29, 57, 434, DateTimeKind.Local).AddTicks(4328), new DateTime(2024, 3, 13, 22, 29, 57, 434, DateTimeKind.Local).AddTicks(4327), new DateTime(2024, 3, 13, 22, 29, 57, 434, DateTimeKind.Local).AddTicks(4301) });

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: "e-1",
                columns: new[] { "CreatedAt", "StartExamDateTime" },
                values: new object[] { new DateTime(2024, 3, 13, 22, 29, 57, 434, DateTimeKind.Local).AddTicks(4352), new DateTime(2024, 3, 20, 22, 29, 57, 434, DateTimeKind.Local).AddTicks(4357) });

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: "e-2",
                columns: new[] { "CreatedAt", "StartExamDateTime" },
                values: new object[] { new DateTime(2024, 3, 13, 22, 29, 57, 434, DateTimeKind.Local).AddTicks(4364), new DateTime(2024, 3, 27, 22, 29, 57, 434, DateTimeKind.Local).AddTicks(4366) });

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: "e-3",
                columns: new[] { "CreatedAt", "StartExamDateTime" },
                values: new object[] { new DateTime(2024, 3, 13, 22, 29, 57, 434, DateTimeKind.Local).AddTicks(4369), new DateTime(2024, 4, 3, 22, 29, 57, 434, DateTimeKind.Local).AddTicks(4372) });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-1",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 22, 29, 57, 434, DateTimeKind.Local).AddTicks(4402));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-2",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 22, 29, 57, 434, DateTimeKind.Local).AddTicks(4407));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-3",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 22, 29, 57, 434, DateTimeKind.Local).AddTicks(4411));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-4",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 22, 29, 57, 434, DateTimeKind.Local).AddTicks(4416));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-5",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 22, 29, 57, 434, DateTimeKind.Local).AddTicks(4422));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-6",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 22, 29, 57, 434, DateTimeKind.Local).AddTicks(4426));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-7",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 22, 29, 57, 434, DateTimeKind.Local).AddTicks(4431));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-8",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 22, 29, 57, 434, DateTimeKind.Local).AddTicks(4435));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-9",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 22, 29, 57, 434, DateTimeKind.Local).AddTicks(4439));

            migrationBuilder.UpdateData(
                table: "StudentsExams",
                keyColumn: "Id",
                keyValue: "se-1",
                columns: new[] { "CreatedAt", "ExamStartTime" },
                values: new object[] { new DateTime(2024, 3, 13, 22, 29, 57, 434, DateTimeKind.Local).AddTicks(4466), new DateTime(2024, 3, 13, 20, 29, 57, 434, DateTimeKind.Local).AddTicks(4477) });

            migrationBuilder.UpdateData(
                table: "StudentsExams",
                keyColumn: "Id",
                keyValue: "se-2",
                columns: new[] { "CreatedAt", "ExamStartTime" },
                values: new object[] { new DateTime(2024, 3, 13, 22, 29, 57, 434, DateTimeKind.Local).AddTicks(4480), new DateTime(2024, 3, 13, 19, 29, 57, 434, DateTimeKind.Local).AddTicks(4482) });

            migrationBuilder.UpdateData(
                table: "StudentsExams",
                keyColumn: "Id",
                keyValue: "se-3",
                columns: new[] { "CreatedAt", "ExamStartTime" },
                values: new object[] { new DateTime(2024, 3, 13, 22, 29, 57, 434, DateTimeKind.Local).AddTicks(4485), new DateTime(2024, 3, 13, 18, 29, 57, 434, DateTimeKind.Local).AddTicks(4486) });

            migrationBuilder.UpdateData(
                table: "StudentsExams",
                keyColumn: "Id",
                keyValue: "se-4",
                columns: new[] { "CreatedAt", "ExamStartTime" },
                values: new object[] { new DateTime(2024, 3, 13, 22, 29, 57, 434, DateTimeKind.Local).AddTicks(4491), new DateTime(2024, 3, 13, 17, 29, 57, 434, DateTimeKind.Local).AddTicks(4493) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "a-1",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 22, 29, 57, 434, DateTimeKind.Local).AddTicks(4516));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "s-1",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 22, 29, 57, 434, DateTimeKind.Local).AddTicks(4528));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "s-2",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 22, 29, 57, 434, DateTimeKind.Local).AddTicks(4532));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "t-1",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 22, 29, 57, 434, DateTimeKind.Local).AddTicks(4524));
        }
    }
}
