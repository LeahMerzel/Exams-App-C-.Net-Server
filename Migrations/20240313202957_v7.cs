using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Exams_App_C__.Net_Server.Migrations
{
    /// <inheritdoc />
    public partial class v7 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-61",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 22, 26, 48, 584, DateTimeKind.Local).AddTicks(7967));

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
    }
}
