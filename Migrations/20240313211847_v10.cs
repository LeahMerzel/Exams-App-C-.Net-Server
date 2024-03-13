using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Exams_App_C__.Net_Server.Migrations
{
    /// <inheritdoc />
    public partial class v10 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
