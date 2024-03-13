using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Exams_App_C__.Net_Server.Migrations
{
    /// <inheritdoc />
    public partial class v5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-1",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 22, 25, 53, 442, DateTimeKind.Local).AddTicks(8047));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-2",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 22, 25, 53, 442, DateTimeKind.Local).AddTicks(8109));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-21",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 22, 25, 53, 442, DateTimeKind.Local).AddTicks(8119));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-22",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 22, 25, 53, 442, DateTimeKind.Local).AddTicks(8121));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-23",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 22, 25, 53, 442, DateTimeKind.Local).AddTicks(8125));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-24",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 22, 25, 53, 442, DateTimeKind.Local).AddTicks(8136));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-3",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 22, 25, 53, 442, DateTimeKind.Local).AddTicks(8113));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-31",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 22, 25, 53, 442, DateTimeKind.Local).AddTicks(8139));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-32",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 22, 25, 53, 442, DateTimeKind.Local).AddTicks(8142));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-33",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 22, 25, 53, 442, DateTimeKind.Local).AddTicks(8145));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-34",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 22, 25, 53, 442, DateTimeKind.Local).AddTicks(8147));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-4",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 22, 25, 53, 442, DateTimeKind.Local).AddTicks(8116));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: "c-1",
                columns: new[] { "CourseEndingDate", "CourseStartingDate", "CreatedAt" },
                values: new object[] { new DateTime(2024, 6, 13, 22, 25, 53, 442, DateTimeKind.Local).AddTicks(8273), new DateTime(2024, 3, 13, 22, 25, 53, 442, DateTimeKind.Local).AddTicks(8271), new DateTime(2024, 3, 13, 22, 25, 53, 442, DateTimeKind.Local).AddTicks(8265) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: "c-2",
                columns: new[] { "CourseEndingDate", "CourseStartingDate", "CreatedAt" },
                values: new object[] { new DateTime(2024, 6, 13, 22, 25, 53, 442, DateTimeKind.Local).AddTicks(8282), new DateTime(2024, 3, 13, 22, 25, 53, 442, DateTimeKind.Local).AddTicks(8280), new DateTime(2024, 3, 13, 22, 25, 53, 442, DateTimeKind.Local).AddTicks(8278) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: "c-3",
                columns: new[] { "CourseEndingDate", "CourseStartingDate", "CreatedAt" },
                values: new object[] { new DateTime(2024, 6, 13, 22, 25, 53, 442, DateTimeKind.Local).AddTicks(8288), new DateTime(2024, 3, 13, 22, 25, 53, 442, DateTimeKind.Local).AddTicks(8287), new DateTime(2024, 3, 13, 22, 25, 53, 442, DateTimeKind.Local).AddTicks(8285) });

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: "e-1",
                columns: new[] { "CreatedAt", "StartExamDateTime" },
                values: new object[] { new DateTime(2024, 3, 13, 22, 25, 53, 442, DateTimeKind.Local).AddTicks(8334), new DateTime(2024, 3, 20, 22, 25, 53, 442, DateTimeKind.Local).AddTicks(8339) });

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: "e-2",
                columns: new[] { "CreatedAt", "StartExamDateTime" },
                values: new object[] { new DateTime(2024, 3, 13, 22, 25, 53, 442, DateTimeKind.Local).AddTicks(8346), new DateTime(2024, 3, 27, 22, 25, 53, 442, DateTimeKind.Local).AddTicks(8348) });

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: "e-3",
                columns: new[] { "CreatedAt", "StartExamDateTime" },
                values: new object[] { new DateTime(2024, 3, 13, 22, 25, 53, 442, DateTimeKind.Local).AddTicks(8351), new DateTime(2024, 4, 3, 22, 25, 53, 442, DateTimeKind.Local).AddTicks(8353) });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-1",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 22, 25, 53, 442, DateTimeKind.Local).AddTicks(8380));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-2",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 22, 25, 53, 442, DateTimeKind.Local).AddTicks(8386));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-3",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 22, 25, 53, 442, DateTimeKind.Local).AddTicks(8390));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-4",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 22, 25, 53, 442, DateTimeKind.Local).AddTicks(8395));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-5",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 22, 25, 53, 442, DateTimeKind.Local).AddTicks(8399));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-6",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 22, 25, 53, 442, DateTimeKind.Local).AddTicks(8406));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-7",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 22, 25, 53, 442, DateTimeKind.Local).AddTicks(8410));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-8",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 22, 25, 53, 442, DateTimeKind.Local).AddTicks(8415));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-9",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 22, 25, 53, 442, DateTimeKind.Local).AddTicks(8419));

            migrationBuilder.UpdateData(
                table: "StudentsExams",
                keyColumn: "Id",
                keyValue: "se-1",
                columns: new[] { "CreatedAt", "ExamStartTime" },
                values: new object[] { new DateTime(2024, 3, 13, 22, 25, 53, 442, DateTimeKind.Local).AddTicks(8444), new DateTime(2024, 3, 13, 20, 25, 53, 442, DateTimeKind.Local).AddTicks(8454) });

            migrationBuilder.UpdateData(
                table: "StudentsExams",
                keyColumn: "Id",
                keyValue: "se-2",
                columns: new[] { "CreatedAt", "ExamStartTime" },
                values: new object[] { new DateTime(2024, 3, 13, 22, 25, 53, 442, DateTimeKind.Local).AddTicks(8457), new DateTime(2024, 3, 13, 19, 25, 53, 442, DateTimeKind.Local).AddTicks(8460) });

            migrationBuilder.UpdateData(
                table: "StudentsExams",
                keyColumn: "Id",
                keyValue: "se-3",
                columns: new[] { "CreatedAt", "ExamStartTime" },
                values: new object[] { new DateTime(2024, 3, 13, 22, 25, 53, 442, DateTimeKind.Local).AddTicks(8463), new DateTime(2024, 3, 13, 18, 25, 53, 442, DateTimeKind.Local).AddTicks(8465) });

            migrationBuilder.UpdateData(
                table: "StudentsExams",
                keyColumn: "Id",
                keyValue: "se-4",
                columns: new[] { "CreatedAt", "ExamStartTime" },
                values: new object[] { new DateTime(2024, 3, 13, 22, 25, 53, 442, DateTimeKind.Local).AddTicks(8467), new DateTime(2024, 3, 13, 17, 25, 53, 442, DateTimeKind.Local).AddTicks(8469) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "a-1",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 22, 25, 53, 442, DateTimeKind.Local).AddTicks(8493));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "s-1",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 22, 25, 53, 442, DateTimeKind.Local).AddTicks(8504));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "s-2",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 22, 25, 53, 442, DateTimeKind.Local).AddTicks(8509));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "t-1",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 22, 25, 53, 442, DateTimeKind.Local).AddTicks(8500));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-1",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 22, 22, 47, 490, DateTimeKind.Local).AddTicks(9256));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-2",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 22, 22, 47, 490, DateTimeKind.Local).AddTicks(9317));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-21",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 22, 22, 47, 490, DateTimeKind.Local).AddTicks(9336));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-22",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 22, 22, 47, 490, DateTimeKind.Local).AddTicks(9363));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-23",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 22, 22, 47, 490, DateTimeKind.Local).AddTicks(9367));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-24",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 22, 22, 47, 490, DateTimeKind.Local).AddTicks(9369));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-3",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 22, 22, 47, 490, DateTimeKind.Local).AddTicks(9320));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-31",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 22, 22, 47, 490, DateTimeKind.Local).AddTicks(9372));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-32",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 22, 22, 47, 490, DateTimeKind.Local).AddTicks(9374));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-33",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 22, 22, 47, 490, DateTimeKind.Local).AddTicks(9377));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-34",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 22, 22, 47, 490, DateTimeKind.Local).AddTicks(9381));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-4",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 22, 22, 47, 490, DateTimeKind.Local).AddTicks(9333));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: "c-1",
                columns: new[] { "CourseEndingDate", "CourseStartingDate", "CreatedAt" },
                values: new object[] { new DateTime(2024, 6, 13, 22, 22, 47, 490, DateTimeKind.Local).AddTicks(9514), new DateTime(2024, 3, 13, 22, 22, 47, 490, DateTimeKind.Local).AddTicks(9513), new DateTime(2024, 3, 13, 22, 22, 47, 490, DateTimeKind.Local).AddTicks(9507) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: "c-2",
                columns: new[] { "CourseEndingDate", "CourseStartingDate", "CreatedAt" },
                values: new object[] { new DateTime(2024, 6, 13, 22, 22, 47, 490, DateTimeKind.Local).AddTicks(9523), new DateTime(2024, 3, 13, 22, 22, 47, 490, DateTimeKind.Local).AddTicks(9522), new DateTime(2024, 3, 13, 22, 22, 47, 490, DateTimeKind.Local).AddTicks(9520) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: "c-3",
                columns: new[] { "CourseEndingDate", "CourseStartingDate", "CreatedAt" },
                values: new object[] { new DateTime(2024, 6, 13, 22, 22, 47, 490, DateTimeKind.Local).AddTicks(9529), new DateTime(2024, 3, 13, 22, 22, 47, 490, DateTimeKind.Local).AddTicks(9528), new DateTime(2024, 3, 13, 22, 22, 47, 490, DateTimeKind.Local).AddTicks(9526) });

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: "e-1",
                columns: new[] { "CreatedAt", "StartExamDateTime" },
                values: new object[] { new DateTime(2024, 3, 13, 22, 22, 47, 490, DateTimeKind.Local).AddTicks(9551), new DateTime(2024, 3, 20, 22, 22, 47, 490, DateTimeKind.Local).AddTicks(9554) });

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: "e-2",
                columns: new[] { "CreatedAt", "StartExamDateTime" },
                values: new object[] { new DateTime(2024, 3, 13, 22, 22, 47, 490, DateTimeKind.Local).AddTicks(9559), new DateTime(2024, 3, 27, 22, 22, 47, 490, DateTimeKind.Local).AddTicks(9561) });

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: "e-3",
                columns: new[] { "CreatedAt", "StartExamDateTime" },
                values: new object[] { new DateTime(2024, 3, 13, 22, 22, 47, 490, DateTimeKind.Local).AddTicks(9564), new DateTime(2024, 4, 3, 22, 22, 47, 490, DateTimeKind.Local).AddTicks(9565) });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-1",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 22, 22, 47, 490, DateTimeKind.Local).AddTicks(9595));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-2",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 22, 22, 47, 490, DateTimeKind.Local).AddTicks(9602));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-3",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 22, 22, 47, 490, DateTimeKind.Local).AddTicks(9606));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-4",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 22, 22, 47, 490, DateTimeKind.Local).AddTicks(9610));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-5",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 22, 22, 47, 490, DateTimeKind.Local).AddTicks(9614));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-6",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 22, 22, 47, 490, DateTimeKind.Local).AddTicks(9618));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-7",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 22, 22, 47, 490, DateTimeKind.Local).AddTicks(9621));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-8",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 22, 22, 47, 490, DateTimeKind.Local).AddTicks(9625));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-9",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 22, 22, 47, 490, DateTimeKind.Local).AddTicks(9629));

            migrationBuilder.UpdateData(
                table: "StudentsExams",
                keyColumn: "Id",
                keyValue: "se-1",
                columns: new[] { "CreatedAt", "ExamStartTime" },
                values: new object[] { new DateTime(2024, 3, 13, 22, 22, 47, 490, DateTimeKind.Local).AddTicks(9658), new DateTime(2024, 3, 13, 20, 22, 47, 490, DateTimeKind.Local).AddTicks(9663) });

            migrationBuilder.UpdateData(
                table: "StudentsExams",
                keyColumn: "Id",
                keyValue: "se-2",
                columns: new[] { "CreatedAt", "ExamStartTime" },
                values: new object[] { new DateTime(2024, 3, 13, 22, 22, 47, 490, DateTimeKind.Local).AddTicks(9666), new DateTime(2024, 3, 13, 19, 22, 47, 490, DateTimeKind.Local).AddTicks(9669) });

            migrationBuilder.UpdateData(
                table: "StudentsExams",
                keyColumn: "Id",
                keyValue: "se-3",
                columns: new[] { "CreatedAt", "ExamStartTime" },
                values: new object[] { new DateTime(2024, 3, 13, 22, 22, 47, 490, DateTimeKind.Local).AddTicks(9671), new DateTime(2024, 3, 13, 18, 22, 47, 490, DateTimeKind.Local).AddTicks(9673) });

            migrationBuilder.UpdateData(
                table: "StudentsExams",
                keyColumn: "Id",
                keyValue: "se-4",
                columns: new[] { "CreatedAt", "ExamStartTime" },
                values: new object[] { new DateTime(2024, 3, 13, 22, 22, 47, 490, DateTimeKind.Local).AddTicks(9675), new DateTime(2024, 3, 13, 17, 22, 47, 490, DateTimeKind.Local).AddTicks(9677) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "a-1",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 22, 22, 47, 490, DateTimeKind.Local).AddTicks(9698));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "s-1",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 22, 22, 47, 490, DateTimeKind.Local).AddTicks(9707));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "s-2",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 22, 22, 47, 490, DateTimeKind.Local).AddTicks(9723));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "t-1",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 22, 22, 47, 490, DateTimeKind.Local).AddTicks(9704));
        }
    }
}
