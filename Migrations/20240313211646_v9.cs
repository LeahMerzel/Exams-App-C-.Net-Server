using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Exams_App_C__.Net_Server.Migrations
{
    /// <inheritdoc />
    public partial class v9 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-2",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 23, 16, 45, 708, DateTimeKind.Local).AddTicks(3665));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-21",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 23, 16, 45, 708, DateTimeKind.Local).AddTicks(3682));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-22",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 23, 16, 45, 708, DateTimeKind.Local).AddTicks(3686));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-23",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 23, 16, 45, 708, DateTimeKind.Local).AddTicks(3689));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-24",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 23, 16, 45, 708, DateTimeKind.Local).AddTicks(3692));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-3",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 23, 16, 45, 708, DateTimeKind.Local).AddTicks(3668));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-31",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 23, 16, 45, 708, DateTimeKind.Local).AddTicks(3695));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-32",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 23, 16, 45, 708, DateTimeKind.Local).AddTicks(3698));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-33",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 23, 16, 45, 708, DateTimeKind.Local).AddTicks(3728));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-34",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 23, 16, 45, 708, DateTimeKind.Local).AddTicks(3734));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-4",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 23, 16, 45, 708, DateTimeKind.Local).AddTicks(3679));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-61",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 23, 16, 45, 708, DateTimeKind.Local).AddTicks(3599));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: "c-1",
                columns: new[] { "CourseEndingDate", "CourseStartingDate", "CreatedAt" },
                values: new object[] { new DateTime(2024, 6, 13, 23, 16, 45, 708, DateTimeKind.Local).AddTicks(3874), new DateTime(2024, 3, 13, 23, 16, 45, 708, DateTimeKind.Local).AddTicks(3873), new DateTime(2024, 3, 13, 23, 16, 45, 708, DateTimeKind.Local).AddTicks(3868) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: "c-2",
                columns: new[] { "CourseEndingDate", "CourseStartingDate", "CreatedAt" },
                values: new object[] { new DateTime(2024, 6, 13, 23, 16, 45, 708, DateTimeKind.Local).AddTicks(3884), new DateTime(2024, 3, 13, 23, 16, 45, 708, DateTimeKind.Local).AddTicks(3882), new DateTime(2024, 3, 13, 23, 16, 45, 708, DateTimeKind.Local).AddTicks(3881) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: "c-3",
                columns: new[] { "CourseEndingDate", "CourseStartingDate", "CreatedAt" },
                values: new object[] { new DateTime(2024, 6, 13, 23, 16, 45, 708, DateTimeKind.Local).AddTicks(3890), new DateTime(2024, 3, 13, 23, 16, 45, 708, DateTimeKind.Local).AddTicks(3889), new DateTime(2024, 3, 13, 23, 16, 45, 708, DateTimeKind.Local).AddTicks(3887) });

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: "e-1",
                columns: new[] { "CreatedAt", "StartExamDateTime" },
                values: new object[] { new DateTime(2024, 3, 13, 23, 16, 45, 708, DateTimeKind.Local).AddTicks(3913), new DateTime(2024, 3, 20, 23, 16, 45, 708, DateTimeKind.Local).AddTicks(3921) });

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: "e-2",
                columns: new[] { "CreatedAt", "StartExamDateTime" },
                values: new object[] { new DateTime(2024, 3, 13, 23, 16, 45, 708, DateTimeKind.Local).AddTicks(3927), new DateTime(2024, 3, 27, 23, 16, 45, 708, DateTimeKind.Local).AddTicks(3929) });

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: "e-3",
                columns: new[] { "CreatedAt", "StartExamDateTime" },
                values: new object[] { new DateTime(2024, 3, 13, 23, 16, 45, 708, DateTimeKind.Local).AddTicks(3932), new DateTime(2024, 4, 3, 23, 16, 45, 708, DateTimeKind.Local).AddTicks(3934) });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-1",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 23, 16, 45, 708, DateTimeKind.Local).AddTicks(3961));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-2",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 23, 16, 45, 708, DateTimeKind.Local).AddTicks(3970));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-3",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 23, 16, 45, 708, DateTimeKind.Local).AddTicks(3974));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-4",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 23, 16, 45, 708, DateTimeKind.Local).AddTicks(3979));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-5",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 23, 16, 45, 708, DateTimeKind.Local).AddTicks(3983));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-6",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 23, 16, 45, 708, DateTimeKind.Local).AddTicks(3987));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-7",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 23, 16, 45, 708, DateTimeKind.Local).AddTicks(3991));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-8",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 23, 16, 45, 708, DateTimeKind.Local).AddTicks(3995));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-9",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 23, 16, 45, 708, DateTimeKind.Local).AddTicks(3999));

            migrationBuilder.UpdateData(
                table: "StudentsExams",
                keyColumn: "Id",
                keyValue: "se-1",
                columns: new[] { "CreatedAt", "ExamStartTime" },
                values: new object[] { new DateTime(2024, 3, 13, 23, 16, 45, 708, DateTimeKind.Local).AddTicks(4026), new DateTime(2024, 3, 13, 21, 16, 45, 708, DateTimeKind.Local).AddTicks(4032) });

            migrationBuilder.UpdateData(
                table: "StudentsExams",
                keyColumn: "Id",
                keyValue: "se-2",
                columns: new[] { "CreatedAt", "ExamStartTime" },
                values: new object[] { new DateTime(2024, 3, 13, 23, 16, 45, 708, DateTimeKind.Local).AddTicks(4035), new DateTime(2024, 3, 13, 20, 16, 45, 708, DateTimeKind.Local).AddTicks(4037) });

            migrationBuilder.UpdateData(
                table: "StudentsExams",
                keyColumn: "Id",
                keyValue: "se-3",
                columns: new[] { "CreatedAt", "ExamStartTime" },
                values: new object[] { new DateTime(2024, 3, 13, 23, 16, 45, 708, DateTimeKind.Local).AddTicks(4039), new DateTime(2024, 3, 13, 19, 16, 45, 708, DateTimeKind.Local).AddTicks(4041) });

            migrationBuilder.UpdateData(
                table: "StudentsExams",
                keyColumn: "Id",
                keyValue: "se-4",
                columns: new[] { "CreatedAt", "ExamStartTime" },
                values: new object[] { new DateTime(2024, 3, 13, 23, 16, 45, 708, DateTimeKind.Local).AddTicks(4043), new DateTime(2024, 3, 13, 18, 16, 45, 708, DateTimeKind.Local).AddTicks(4045) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "a-1",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 23, 16, 45, 708, DateTimeKind.Local).AddTicks(4070));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "s-1",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 23, 16, 45, 708, DateTimeKind.Local).AddTicks(4086));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "s-2",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 23, 16, 45, 708, DateTimeKind.Local).AddTicks(4090));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "t-1",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 23, 16, 45, 708, DateTimeKind.Local).AddTicks(4083));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
