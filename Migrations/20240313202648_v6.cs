using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Exams_App_C__.Net_Server.Migrations
{
    /// <inheritdoc />
    public partial class v6 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-1");

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-2",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 22, 26, 48, 584, DateTimeKind.Local).AddTicks(8024));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-21",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 22, 26, 48, 584, DateTimeKind.Local).AddTicks(8032));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-22",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 22, 26, 48, 584, DateTimeKind.Local).AddTicks(8045));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-23",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 22, 26, 48, 584, DateTimeKind.Local).AddTicks(8048));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-24",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 22, 26, 48, 584, DateTimeKind.Local).AddTicks(8050));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-3",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 22, 26, 48, 584, DateTimeKind.Local).AddTicks(8027));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-31",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 22, 26, 48, 584, DateTimeKind.Local).AddTicks(8053));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-32",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 22, 26, 48, 584, DateTimeKind.Local).AddTicks(8055));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-33",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 22, 26, 48, 584, DateTimeKind.Local).AddTicks(8058));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-34",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 22, 26, 48, 584, DateTimeKind.Local).AddTicks(8061));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-4",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 22, 26, 48, 584, DateTimeKind.Local).AddTicks(8030));

            migrationBuilder.InsertData(
                table: "Answers",
                columns: new[] { "Id", "AnswerDescription", "AnswerNumber", "CreatedAt", "IsCorrect", "QuestionId" },
                values: new object[] { "a-61", "Paris", 1, new DateTime(2024, 3, 13, 22, 26, 48, 584, DateTimeKind.Local).AddTicks(7967), true, "q-1" });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: "c-1",
                columns: new[] { "CourseEndingDate", "CourseStartingDate", "CreatedAt" },
                values: new object[] { new DateTime(2024, 6, 13, 22, 26, 48, 584, DateTimeKind.Local).AddTicks(8197), new DateTime(2024, 3, 13, 22, 26, 48, 584, DateTimeKind.Local).AddTicks(8196), new DateTime(2024, 3, 13, 22, 26, 48, 584, DateTimeKind.Local).AddTicks(8190) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: "c-2",
                columns: new[] { "CourseEndingDate", "CourseStartingDate", "CreatedAt" },
                values: new object[] { new DateTime(2024, 6, 13, 22, 26, 48, 584, DateTimeKind.Local).AddTicks(8209), new DateTime(2024, 3, 13, 22, 26, 48, 584, DateTimeKind.Local).AddTicks(8207), new DateTime(2024, 3, 13, 22, 26, 48, 584, DateTimeKind.Local).AddTicks(8206) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: "c-3",
                columns: new[] { "CourseEndingDate", "CourseStartingDate", "CreatedAt" },
                values: new object[] { new DateTime(2024, 6, 13, 22, 26, 48, 584, DateTimeKind.Local).AddTicks(8214), new DateTime(2024, 3, 13, 22, 26, 48, 584, DateTimeKind.Local).AddTicks(8213), new DateTime(2024, 3, 13, 22, 26, 48, 584, DateTimeKind.Local).AddTicks(8211) });

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: "e-1",
                columns: new[] { "CreatedAt", "StartExamDateTime" },
                values: new object[] { new DateTime(2024, 3, 13, 22, 26, 48, 584, DateTimeKind.Local).AddTicks(8239), new DateTime(2024, 3, 20, 22, 26, 48, 584, DateTimeKind.Local).AddTicks(8243) });

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: "e-2",
                columns: new[] { "CreatedAt", "StartExamDateTime" },
                values: new object[] { new DateTime(2024, 3, 13, 22, 26, 48, 584, DateTimeKind.Local).AddTicks(8248), new DateTime(2024, 3, 27, 22, 26, 48, 584, DateTimeKind.Local).AddTicks(8250) });

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: "e-3",
                columns: new[] { "CreatedAt", "StartExamDateTime" },
                values: new object[] { new DateTime(2024, 3, 13, 22, 26, 48, 584, DateTimeKind.Local).AddTicks(8253), new DateTime(2024, 4, 3, 22, 26, 48, 584, DateTimeKind.Local).AddTicks(8255) });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-1",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 22, 26, 48, 584, DateTimeKind.Local).AddTicks(8283));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-2",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 22, 26, 48, 584, DateTimeKind.Local).AddTicks(8288));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-3",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 22, 26, 48, 584, DateTimeKind.Local).AddTicks(8293));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-4",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 22, 26, 48, 584, DateTimeKind.Local).AddTicks(8298));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-5",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 22, 26, 48, 584, DateTimeKind.Local).AddTicks(8302));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-6",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 22, 26, 48, 584, DateTimeKind.Local).AddTicks(8306));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-7",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 22, 26, 48, 584, DateTimeKind.Local).AddTicks(8310));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-8",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 22, 26, 48, 584, DateTimeKind.Local).AddTicks(8314));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-9",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 22, 26, 48, 584, DateTimeKind.Local).AddTicks(8318));

            migrationBuilder.UpdateData(
                table: "StudentsExams",
                keyColumn: "Id",
                keyValue: "se-1",
                columns: new[] { "CreatedAt", "ExamStartTime" },
                values: new object[] { new DateTime(2024, 3, 13, 22, 26, 48, 584, DateTimeKind.Local).AddTicks(8343), new DateTime(2024, 3, 13, 20, 26, 48, 584, DateTimeKind.Local).AddTicks(8348) });

            migrationBuilder.UpdateData(
                table: "StudentsExams",
                keyColumn: "Id",
                keyValue: "se-2",
                columns: new[] { "CreatedAt", "ExamStartTime" },
                values: new object[] { new DateTime(2024, 3, 13, 22, 26, 48, 584, DateTimeKind.Local).AddTicks(8351), new DateTime(2024, 3, 13, 19, 26, 48, 584, DateTimeKind.Local).AddTicks(8353) });

            migrationBuilder.UpdateData(
                table: "StudentsExams",
                keyColumn: "Id",
                keyValue: "se-3",
                columns: new[] { "CreatedAt", "ExamStartTime" },
                values: new object[] { new DateTime(2024, 3, 13, 22, 26, 48, 584, DateTimeKind.Local).AddTicks(8358), new DateTime(2024, 3, 13, 18, 26, 48, 584, DateTimeKind.Local).AddTicks(8359) });

            migrationBuilder.UpdateData(
                table: "StudentsExams",
                keyColumn: "Id",
                keyValue: "se-4",
                columns: new[] { "CreatedAt", "ExamStartTime" },
                values: new object[] { new DateTime(2024, 3, 13, 22, 26, 48, 584, DateTimeKind.Local).AddTicks(8362), new DateTime(2024, 3, 13, 17, 26, 48, 584, DateTimeKind.Local).AddTicks(8363) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "a-1",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 22, 26, 48, 584, DateTimeKind.Local).AddTicks(8385));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "s-1",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 22, 26, 48, 584, DateTimeKind.Local).AddTicks(8396));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "s-2",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 22, 26, 48, 584, DateTimeKind.Local).AddTicks(8400));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "t-1",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 22, 26, 48, 584, DateTimeKind.Local).AddTicks(8393));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-61");

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

            migrationBuilder.InsertData(
                table: "Answers",
                columns: new[] { "Id", "AnswerDescription", "AnswerNumber", "CreatedAt", "IsCorrect", "QuestionId" },
                values: new object[] { "a-1", "Paris", 1, new DateTime(2024, 3, 13, 22, 25, 53, 442, DateTimeKind.Local).AddTicks(8047), true, "q-1" });

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
    }
}
