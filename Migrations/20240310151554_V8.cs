using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Exams_App_C__.Net_Server.Migrations
{
    /// <inheritdoc />
    public partial class V8 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-1",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 17, 15, 54, 687, DateTimeKind.Local).AddTicks(3843));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-2",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 17, 15, 54, 687, DateTimeKind.Local).AddTicks(3900));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-21",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 17, 15, 54, 687, DateTimeKind.Local).AddTicks(3908));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-22",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 17, 15, 54, 687, DateTimeKind.Local).AddTicks(3911));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-23",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 17, 15, 54, 687, DateTimeKind.Local).AddTicks(3913));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-24",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 17, 15, 54, 687, DateTimeKind.Local).AddTicks(3916));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-3",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 17, 15, 54, 687, DateTimeKind.Local).AddTicks(3903));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-31",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 17, 15, 54, 687, DateTimeKind.Local).AddTicks(3921));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-32",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 17, 15, 54, 687, DateTimeKind.Local).AddTicks(3923));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-33",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 17, 15, 54, 687, DateTimeKind.Local).AddTicks(3926));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-34",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 17, 15, 54, 687, DateTimeKind.Local).AddTicks(3929));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-4",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 17, 15, 54, 687, DateTimeKind.Local).AddTicks(3905));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: "c-1",
                columns: new[] { "CourseEndingDate", "CourseStartingDate", "CreatedAt" },
                values: new object[] { new DateTime(2024, 6, 10, 17, 15, 54, 687, DateTimeKind.Local).AddTicks(4077), new DateTime(2024, 3, 10, 17, 15, 54, 687, DateTimeKind.Local).AddTicks(4076), new DateTime(2024, 3, 10, 17, 15, 54, 687, DateTimeKind.Local).AddTicks(4068) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: "c-2",
                columns: new[] { "CourseEndingDate", "CourseStartingDate", "CreatedAt" },
                values: new object[] { new DateTime(2024, 6, 10, 17, 15, 54, 687, DateTimeKind.Local).AddTicks(4087), new DateTime(2024, 3, 10, 17, 15, 54, 687, DateTimeKind.Local).AddTicks(4086), new DateTime(2024, 3, 10, 17, 15, 54, 687, DateTimeKind.Local).AddTicks(4084) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: "c-3",
                columns: new[] { "CourseEndingDate", "CourseStartingDate", "CreatedAt" },
                values: new object[] { new DateTime(2024, 6, 10, 17, 15, 54, 687, DateTimeKind.Local).AddTicks(4093), new DateTime(2024, 3, 10, 17, 15, 54, 687, DateTimeKind.Local).AddTicks(4092), new DateTime(2024, 3, 10, 17, 15, 54, 687, DateTimeKind.Local).AddTicks(4090) });

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: "e-1",
                columns: new[] { "CreatedAt", "StartExamDateTime" },
                values: new object[] { new DateTime(2024, 3, 10, 17, 15, 54, 687, DateTimeKind.Local).AddTicks(4119), new DateTime(2024, 3, 17, 17, 15, 54, 687, DateTimeKind.Local).AddTicks(4124) });

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: "e-2",
                columns: new[] { "CreatedAt", "StartExamDateTime" },
                values: new object[] { new DateTime(2024, 3, 10, 17, 15, 54, 687, DateTimeKind.Local).AddTicks(4131), new DateTime(2024, 3, 24, 17, 15, 54, 687, DateTimeKind.Local).AddTicks(4133) });

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: "e-3",
                columns: new[] { "CreatedAt", "StartExamDateTime" },
                values: new object[] { new DateTime(2024, 3, 10, 17, 15, 54, 687, DateTimeKind.Local).AddTicks(4136), new DateTime(2024, 3, 31, 17, 15, 54, 687, DateTimeKind.Local).AddTicks(4139) });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-1",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 17, 15, 54, 687, DateTimeKind.Local).AddTicks(4169));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-2",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 17, 15, 54, 687, DateTimeKind.Local).AddTicks(4175));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-3",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 17, 15, 54, 687, DateTimeKind.Local).AddTicks(4180));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-4",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 17, 15, 54, 687, DateTimeKind.Local).AddTicks(4184));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-5",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 17, 15, 54, 687, DateTimeKind.Local).AddTicks(4188));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-6",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 17, 15, 54, 687, DateTimeKind.Local).AddTicks(4193));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-7",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 17, 15, 54, 687, DateTimeKind.Local).AddTicks(4217));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-8",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 17, 15, 54, 687, DateTimeKind.Local).AddTicks(4222));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-9",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 17, 15, 54, 687, DateTimeKind.Local).AddTicks(4226));

            migrationBuilder.UpdateData(
                table: "StudentsExams",
                keyColumn: "Id",
                keyValue: "se-1",
                columns: new[] { "CreatedAt", "ExamStartTime" },
                values: new object[] { new DateTime(2024, 3, 10, 17, 15, 54, 687, DateTimeKind.Local).AddTicks(4271), new DateTime(2024, 3, 10, 15, 15, 54, 687, DateTimeKind.Local).AddTicks(4276) });

            migrationBuilder.UpdateData(
                table: "StudentsExams",
                keyColumn: "Id",
                keyValue: "se-2",
                columns: new[] { "CreatedAt", "ExamStartTime" },
                values: new object[] { new DateTime(2024, 3, 10, 17, 15, 54, 687, DateTimeKind.Local).AddTicks(4279), new DateTime(2024, 3, 10, 14, 15, 54, 687, DateTimeKind.Local).AddTicks(4282) });

            migrationBuilder.UpdateData(
                table: "StudentsExams",
                keyColumn: "Id",
                keyValue: "se-3",
                columns: new[] { "CreatedAt", "ExamStartTime" },
                values: new object[] { new DateTime(2024, 3, 10, 17, 15, 54, 687, DateTimeKind.Local).AddTicks(4284), new DateTime(2024, 3, 10, 13, 15, 54, 687, DateTimeKind.Local).AddTicks(4286) });

            migrationBuilder.UpdateData(
                table: "StudentsExams",
                keyColumn: "Id",
                keyValue: "se-4",
                columns: new[] { "CreatedAt", "ExamStartTime" },
                values: new object[] { new DateTime(2024, 3, 10, 17, 15, 54, 687, DateTimeKind.Local).AddTicks(4288), new DateTime(2024, 3, 10, 12, 15, 54, 687, DateTimeKind.Local).AddTicks(4290) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "a-1",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 17, 15, 54, 687, DateTimeKind.Local).AddTicks(4314));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "s-1",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 17, 15, 54, 687, DateTimeKind.Local).AddTicks(4329));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "s-2",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 17, 15, 54, 687, DateTimeKind.Local).AddTicks(4332));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "t-1",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 17, 15, 54, 687, DateTimeKind.Local).AddTicks(4325));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-1",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 17, 11, 34, 344, DateTimeKind.Local).AddTicks(4997));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-2",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 17, 11, 34, 344, DateTimeKind.Local).AddTicks(5061));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-21",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 17, 11, 34, 344, DateTimeKind.Local).AddTicks(5081));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-22",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 17, 11, 34, 344, DateTimeKind.Local).AddTicks(5084));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-23",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 17, 11, 34, 344, DateTimeKind.Local).AddTicks(5087));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-24",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 17, 11, 34, 344, DateTimeKind.Local).AddTicks(5090));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-3",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 17, 11, 34, 344, DateTimeKind.Local).AddTicks(5064));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-31",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 17, 11, 34, 344, DateTimeKind.Local).AddTicks(5092));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-32",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 17, 11, 34, 344, DateTimeKind.Local).AddTicks(5095));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-33",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 17, 11, 34, 344, DateTimeKind.Local).AddTicks(5098));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-34",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 17, 11, 34, 344, DateTimeKind.Local).AddTicks(5121));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-4",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 17, 11, 34, 344, DateTimeKind.Local).AddTicks(5067));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: "c-1",
                columns: new[] { "CourseEndingDate", "CourseStartingDate", "CreatedAt" },
                values: new object[] { new DateTime(2024, 6, 10, 17, 11, 34, 344, DateTimeKind.Local).AddTicks(5256), new DateTime(2024, 3, 10, 17, 11, 34, 344, DateTimeKind.Local).AddTicks(5255), new DateTime(2024, 3, 10, 17, 11, 34, 344, DateTimeKind.Local).AddTicks(5250) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: "c-2",
                columns: new[] { "CourseEndingDate", "CourseStartingDate", "CreatedAt" },
                values: new object[] { new DateTime(2024, 6, 10, 17, 11, 34, 344, DateTimeKind.Local).AddTicks(5266), new DateTime(2024, 3, 10, 17, 11, 34, 344, DateTimeKind.Local).AddTicks(5264), new DateTime(2024, 3, 10, 17, 11, 34, 344, DateTimeKind.Local).AddTicks(5262) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: "c-3",
                columns: new[] { "CourseEndingDate", "CourseStartingDate", "CreatedAt" },
                values: new object[] { new DateTime(2024, 6, 10, 17, 11, 34, 344, DateTimeKind.Local).AddTicks(5271), new DateTime(2024, 3, 10, 17, 11, 34, 344, DateTimeKind.Local).AddTicks(5270), new DateTime(2024, 3, 10, 17, 11, 34, 344, DateTimeKind.Local).AddTicks(5268) });

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: "e-1",
                columns: new[] { "CreatedAt", "StartExamDateTime" },
                values: new object[] { new DateTime(2024, 3, 10, 17, 11, 34, 344, DateTimeKind.Local).AddTicks(5300), new DateTime(2024, 3, 17, 17, 11, 34, 344, DateTimeKind.Local).AddTicks(5304) });

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: "e-2",
                columns: new[] { "CreatedAt", "StartExamDateTime" },
                values: new object[] { new DateTime(2024, 3, 10, 17, 11, 34, 344, DateTimeKind.Local).AddTicks(5308), new DateTime(2024, 3, 24, 17, 11, 34, 344, DateTimeKind.Local).AddTicks(5311) });

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: "e-3",
                columns: new[] { "CreatedAt", "StartExamDateTime" },
                values: new object[] { new DateTime(2024, 3, 10, 17, 11, 34, 344, DateTimeKind.Local).AddTicks(5313), new DateTime(2024, 3, 31, 17, 11, 34, 344, DateTimeKind.Local).AddTicks(5315) });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-1",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 17, 11, 34, 344, DateTimeKind.Local).AddTicks(5339));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-2",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 17, 11, 34, 344, DateTimeKind.Local).AddTicks(5344));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-3",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 17, 11, 34, 344, DateTimeKind.Local).AddTicks(5351));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-4",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 17, 11, 34, 344, DateTimeKind.Local).AddTicks(5355));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-5",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 17, 11, 34, 344, DateTimeKind.Local).AddTicks(5359));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-6",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 17, 11, 34, 344, DateTimeKind.Local).AddTicks(5363));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-7",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 17, 11, 34, 344, DateTimeKind.Local).AddTicks(5367));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-8",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 17, 11, 34, 344, DateTimeKind.Local).AddTicks(5371));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-9",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 17, 11, 34, 344, DateTimeKind.Local).AddTicks(5376));

            migrationBuilder.UpdateData(
                table: "StudentsExams",
                keyColumn: "Id",
                keyValue: "se-1",
                columns: new[] { "CreatedAt", "ExamStartTime" },
                values: new object[] { new DateTime(2024, 3, 10, 17, 11, 34, 344, DateTimeKind.Local).AddTicks(5406), new DateTime(2024, 3, 10, 15, 11, 34, 344, DateTimeKind.Local).AddTicks(5411) });

            migrationBuilder.UpdateData(
                table: "StudentsExams",
                keyColumn: "Id",
                keyValue: "se-2",
                columns: new[] { "CreatedAt", "ExamStartTime" },
                values: new object[] { new DateTime(2024, 3, 10, 17, 11, 34, 344, DateTimeKind.Local).AddTicks(5416), new DateTime(2024, 3, 10, 14, 11, 34, 344, DateTimeKind.Local).AddTicks(5418) });

            migrationBuilder.UpdateData(
                table: "StudentsExams",
                keyColumn: "Id",
                keyValue: "se-3",
                columns: new[] { "CreatedAt", "ExamStartTime" },
                values: new object[] { new DateTime(2024, 3, 10, 17, 11, 34, 344, DateTimeKind.Local).AddTicks(5421), new DateTime(2024, 3, 10, 13, 11, 34, 344, DateTimeKind.Local).AddTicks(5423) });

            migrationBuilder.UpdateData(
                table: "StudentsExams",
                keyColumn: "Id",
                keyValue: "se-4",
                columns: new[] { "CreatedAt", "ExamStartTime" },
                values: new object[] { new DateTime(2024, 3, 10, 17, 11, 34, 344, DateTimeKind.Local).AddTicks(5426), new DateTime(2024, 3, 10, 12, 11, 34, 344, DateTimeKind.Local).AddTicks(5427) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "a-1",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 17, 11, 34, 344, DateTimeKind.Local).AddTicks(5451));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "s-1",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 17, 11, 34, 344, DateTimeKind.Local).AddTicks(5464));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "s-2",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 17, 11, 34, 344, DateTimeKind.Local).AddTicks(5467));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "t-1",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 17, 11, 34, 344, DateTimeKind.Local).AddTicks(5460));
        }
    }
}
