using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Exams_App_C__.Net_Server.Migrations
{
    /// <inheritdoc />
    public partial class v11 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-2",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 23, 21, 34, 394, DateTimeKind.Local).AddTicks(3948));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-21",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 23, 21, 34, 394, DateTimeKind.Local).AddTicks(3957));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-22",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 23, 21, 34, 394, DateTimeKind.Local).AddTicks(3970));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-23",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 23, 21, 34, 394, DateTimeKind.Local).AddTicks(3973));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-24",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 23, 21, 34, 394, DateTimeKind.Local).AddTicks(3975));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-3",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 23, 21, 34, 394, DateTimeKind.Local).AddTicks(3952));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-31",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 23, 21, 34, 394, DateTimeKind.Local).AddTicks(3978));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-32",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 23, 21, 34, 394, DateTimeKind.Local).AddTicks(3980));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-33",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 23, 21, 34, 394, DateTimeKind.Local).AddTicks(3983));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-34",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 23, 21, 34, 394, DateTimeKind.Local).AddTicks(3985));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-4",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 23, 21, 34, 394, DateTimeKind.Local).AddTicks(3954));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-61",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 23, 21, 34, 394, DateTimeKind.Local).AddTicks(3886));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: "c-1",
                columns: new[] { "CourseEndingDate", "CourseStartingDate", "CreatedAt" },
                values: new object[] { new DateTime(2024, 6, 13, 23, 21, 34, 394, DateTimeKind.Local).AddTicks(4114), new DateTime(2024, 3, 13, 23, 21, 34, 394, DateTimeKind.Local).AddTicks(4113), new DateTime(2024, 3, 13, 23, 21, 34, 394, DateTimeKind.Local).AddTicks(4108) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: "c-2",
                columns: new[] { "CourseEndingDate", "CourseStartingDate", "CreatedAt" },
                values: new object[] { new DateTime(2024, 6, 13, 23, 21, 34, 394, DateTimeKind.Local).AddTicks(4126), new DateTime(2024, 3, 13, 23, 21, 34, 394, DateTimeKind.Local).AddTicks(4125), new DateTime(2024, 3, 13, 23, 21, 34, 394, DateTimeKind.Local).AddTicks(4123) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: "c-3",
                columns: new[] { "CourseEndingDate", "CourseStartingDate", "CreatedAt" },
                values: new object[] { new DateTime(2024, 6, 13, 23, 21, 34, 394, DateTimeKind.Local).AddTicks(4131), new DateTime(2024, 3, 13, 23, 21, 34, 394, DateTimeKind.Local).AddTicks(4130), new DateTime(2024, 3, 13, 23, 21, 34, 394, DateTimeKind.Local).AddTicks(4129) });

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: "e-1",
                columns: new[] { "CreatedAt", "StartExamDateTime" },
                values: new object[] { new DateTime(2024, 3, 13, 23, 21, 34, 394, DateTimeKind.Local).AddTicks(4154), new DateTime(2024, 3, 20, 23, 21, 34, 394, DateTimeKind.Local).AddTicks(4158) });

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: "e-2",
                columns: new[] { "CreatedAt", "StartExamDateTime" },
                values: new object[] { new DateTime(2024, 3, 13, 23, 21, 34, 394, DateTimeKind.Local).AddTicks(4162), new DateTime(2024, 3, 27, 23, 21, 34, 394, DateTimeKind.Local).AddTicks(4164) });

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: "e-3",
                columns: new[] { "CreatedAt", "StartExamDateTime" },
                values: new object[] { new DateTime(2024, 3, 13, 23, 21, 34, 394, DateTimeKind.Local).AddTicks(4167), new DateTime(2024, 4, 3, 23, 21, 34, 394, DateTimeKind.Local).AddTicks(4169) });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-1",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 23, 21, 34, 394, DateTimeKind.Local).AddTicks(4195));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-2",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 23, 21, 34, 394, DateTimeKind.Local).AddTicks(4201));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-3",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 23, 21, 34, 394, DateTimeKind.Local).AddTicks(4205));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-4",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 23, 21, 34, 394, DateTimeKind.Local).AddTicks(4211));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-5",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 23, 21, 34, 394, DateTimeKind.Local).AddTicks(4215));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-6",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 23, 21, 34, 394, DateTimeKind.Local).AddTicks(4219));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-7",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 23, 21, 34, 394, DateTimeKind.Local).AddTicks(4222));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-8",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 23, 21, 34, 394, DateTimeKind.Local).AddTicks(4226));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-9",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 23, 21, 34, 394, DateTimeKind.Local).AddTicks(4230));

            migrationBuilder.UpdateData(
                table: "StudentsExams",
                keyColumn: "Id",
                keyValue: "se-1",
                columns: new[] { "CreatedAt", "ExamStartTime" },
                values: new object[] { new DateTime(2024, 3, 13, 23, 21, 34, 394, DateTimeKind.Local).AddTicks(4255), new DateTime(2024, 3, 13, 21, 21, 34, 394, DateTimeKind.Local).AddTicks(4261) });

            migrationBuilder.UpdateData(
                table: "StudentsExams",
                keyColumn: "Id",
                keyValue: "se-2",
                columns: new[] { "CreatedAt", "ExamStartTime" },
                values: new object[] { new DateTime(2024, 3, 13, 23, 21, 34, 394, DateTimeKind.Local).AddTicks(4263), new DateTime(2024, 3, 13, 20, 21, 34, 394, DateTimeKind.Local).AddTicks(4265) });

            migrationBuilder.UpdateData(
                table: "StudentsExams",
                keyColumn: "Id",
                keyValue: "se-3",
                columns: new[] { "CreatedAt", "ExamStartTime" },
                values: new object[] { new DateTime(2024, 3, 13, 23, 21, 34, 394, DateTimeKind.Local).AddTicks(4269), new DateTime(2024, 3, 13, 19, 21, 34, 394, DateTimeKind.Local).AddTicks(4271) });

            migrationBuilder.UpdateData(
                table: "StudentsExams",
                keyColumn: "Id",
                keyValue: "se-4",
                columns: new[] { "CreatedAt", "ExamStartTime" },
                values: new object[] { new DateTime(2024, 3, 13, 23, 21, 34, 394, DateTimeKind.Local).AddTicks(4273), new DateTime(2024, 3, 13, 18, 21, 34, 394, DateTimeKind.Local).AddTicks(4275) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "a-1",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 23, 21, 34, 394, DateTimeKind.Local).AddTicks(4324));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "s-1",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 23, 21, 34, 394, DateTimeKind.Local).AddTicks(4334));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "s-2",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 23, 21, 34, 394, DateTimeKind.Local).AddTicks(4338));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "t-1",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 23, 21, 34, 394, DateTimeKind.Local).AddTicks(4331));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-2",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 23, 18, 47, 20, DateTimeKind.Local).AddTicks(9136));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-21",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 23, 18, 47, 20, DateTimeKind.Local).AddTicks(9145));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-22",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 23, 18, 47, 20, DateTimeKind.Local).AddTicks(9147));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-23",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 23, 18, 47, 20, DateTimeKind.Local).AddTicks(9150));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-24",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 23, 18, 47, 20, DateTimeKind.Local).AddTicks(9153));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-3",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 23, 18, 47, 20, DateTimeKind.Local).AddTicks(9139));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-31",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 23, 18, 47, 20, DateTimeKind.Local).AddTicks(9156));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-32",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 23, 18, 47, 20, DateTimeKind.Local).AddTicks(9161));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-33",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 23, 18, 47, 20, DateTimeKind.Local).AddTicks(9163));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-34",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 23, 18, 47, 20, DateTimeKind.Local).AddTicks(9166));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-4",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 23, 18, 47, 20, DateTimeKind.Local).AddTicks(9142));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-61",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 23, 18, 47, 20, DateTimeKind.Local).AddTicks(9064));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: "c-1",
                columns: new[] { "CourseEndingDate", "CourseStartingDate", "CreatedAt" },
                values: new object[] { new DateTime(2024, 6, 13, 23, 18, 47, 20, DateTimeKind.Local).AddTicks(9289), new DateTime(2024, 3, 13, 23, 18, 47, 20, DateTimeKind.Local).AddTicks(9287), new DateTime(2024, 3, 13, 23, 18, 47, 20, DateTimeKind.Local).AddTicks(9283) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: "c-2",
                columns: new[] { "CourseEndingDate", "CourseStartingDate", "CreatedAt" },
                values: new object[] { new DateTime(2024, 6, 13, 23, 18, 47, 20, DateTimeKind.Local).AddTicks(9299), new DateTime(2024, 3, 13, 23, 18, 47, 20, DateTimeKind.Local).AddTicks(9297), new DateTime(2024, 3, 13, 23, 18, 47, 20, DateTimeKind.Local).AddTicks(9295) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: "c-3",
                columns: new[] { "CourseEndingDate", "CourseStartingDate", "CreatedAt" },
                values: new object[] { new DateTime(2024, 6, 13, 23, 18, 47, 20, DateTimeKind.Local).AddTicks(9304), new DateTime(2024, 3, 13, 23, 18, 47, 20, DateTimeKind.Local).AddTicks(9303), new DateTime(2024, 3, 13, 23, 18, 47, 20, DateTimeKind.Local).AddTicks(9301) });

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: "e-1",
                columns: new[] { "CreatedAt", "StartExamDateTime" },
                values: new object[] { new DateTime(2024, 3, 13, 23, 18, 47, 20, DateTimeKind.Local).AddTicks(9332), new DateTime(2024, 3, 20, 23, 18, 47, 20, DateTimeKind.Local).AddTicks(9336) });

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: "e-2",
                columns: new[] { "CreatedAt", "StartExamDateTime" },
                values: new object[] { new DateTime(2024, 3, 13, 23, 18, 47, 20, DateTimeKind.Local).AddTicks(9342), new DateTime(2024, 3, 27, 23, 18, 47, 20, DateTimeKind.Local).AddTicks(9344) });

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: "e-3",
                columns: new[] { "CreatedAt", "StartExamDateTime" },
                values: new object[] { new DateTime(2024, 3, 13, 23, 18, 47, 20, DateTimeKind.Local).AddTicks(9349), new DateTime(2024, 4, 3, 23, 18, 47, 20, DateTimeKind.Local).AddTicks(9351) });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-1",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 23, 18, 47, 20, DateTimeKind.Local).AddTicks(9377));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-2",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 23, 18, 47, 20, DateTimeKind.Local).AddTicks(9382));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-3",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 23, 18, 47, 20, DateTimeKind.Local).AddTicks(9387));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-4",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 23, 18, 47, 20, DateTimeKind.Local).AddTicks(9392));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-5",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 23, 18, 47, 20, DateTimeKind.Local).AddTicks(9396));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-6",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 23, 18, 47, 20, DateTimeKind.Local).AddTicks(9400));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-7",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 23, 18, 47, 20, DateTimeKind.Local).AddTicks(9404));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-8",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 23, 18, 47, 20, DateTimeKind.Local).AddTicks(9411));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-9",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 23, 18, 47, 20, DateTimeKind.Local).AddTicks(9415));

            migrationBuilder.UpdateData(
                table: "StudentsExams",
                keyColumn: "Id",
                keyValue: "se-1",
                columns: new[] { "CreatedAt", "ExamStartTime" },
                values: new object[] { new DateTime(2024, 3, 13, 23, 18, 47, 20, DateTimeKind.Local).AddTicks(9472), new DateTime(2024, 3, 13, 21, 18, 47, 20, DateTimeKind.Local).AddTicks(9479) });

            migrationBuilder.UpdateData(
                table: "StudentsExams",
                keyColumn: "Id",
                keyValue: "se-2",
                columns: new[] { "CreatedAt", "ExamStartTime" },
                values: new object[] { new DateTime(2024, 3, 13, 23, 18, 47, 20, DateTimeKind.Local).AddTicks(9485), new DateTime(2024, 3, 13, 20, 18, 47, 20, DateTimeKind.Local).AddTicks(9487) });

            migrationBuilder.UpdateData(
                table: "StudentsExams",
                keyColumn: "Id",
                keyValue: "se-3",
                columns: new[] { "CreatedAt", "ExamStartTime" },
                values: new object[] { new DateTime(2024, 3, 13, 23, 18, 47, 20, DateTimeKind.Local).AddTicks(9489), new DateTime(2024, 3, 13, 19, 18, 47, 20, DateTimeKind.Local).AddTicks(9491) });

            migrationBuilder.UpdateData(
                table: "StudentsExams",
                keyColumn: "Id",
                keyValue: "se-4",
                columns: new[] { "CreatedAt", "ExamStartTime" },
                values: new object[] { new DateTime(2024, 3, 13, 23, 18, 47, 20, DateTimeKind.Local).AddTicks(9494), new DateTime(2024, 3, 13, 18, 18, 47, 20, DateTimeKind.Local).AddTicks(9496) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "a-1",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 23, 18, 47, 20, DateTimeKind.Local).AddTicks(9521));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "s-1",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 23, 18, 47, 20, DateTimeKind.Local).AddTicks(9533));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "s-2",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 23, 18, 47, 20, DateTimeKind.Local).AddTicks(9538));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "t-1",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 23, 18, 47, 20, DateTimeKind.Local).AddTicks(9528));
        }
    }
}
