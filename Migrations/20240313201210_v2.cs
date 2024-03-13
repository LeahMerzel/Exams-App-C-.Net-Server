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
            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-1",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 22, 12, 10, 392, DateTimeKind.Local).AddTicks(8472));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-2",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 22, 12, 10, 392, DateTimeKind.Local).AddTicks(8549));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-21",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 22, 12, 10, 392, DateTimeKind.Local).AddTicks(8557));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-22",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 22, 12, 10, 392, DateTimeKind.Local).AddTicks(8560));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-23",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 22, 12, 10, 392, DateTimeKind.Local).AddTicks(8562));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-24",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 22, 12, 10, 392, DateTimeKind.Local).AddTicks(8565));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-3",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 22, 12, 10, 392, DateTimeKind.Local).AddTicks(8552));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-31",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 22, 12, 10, 392, DateTimeKind.Local).AddTicks(8569));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-32",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 22, 12, 10, 392, DateTimeKind.Local).AddTicks(8572));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-33",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 22, 12, 10, 392, DateTimeKind.Local).AddTicks(8575));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-34",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 22, 12, 10, 392, DateTimeKind.Local).AddTicks(8577));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-4",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 22, 12, 10, 392, DateTimeKind.Local).AddTicks(8555));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: "c-1",
                columns: new[] { "CourseEndingDate", "CourseStartingDate", "CreatedAt" },
                values: new object[] { new DateTime(2024, 6, 13, 22, 12, 10, 392, DateTimeKind.Local).AddTicks(8720), new DateTime(2024, 3, 13, 22, 12, 10, 392, DateTimeKind.Local).AddTicks(8719), new DateTime(2024, 3, 13, 22, 12, 10, 392, DateTimeKind.Local).AddTicks(8713) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: "c-2",
                columns: new[] { "CourseEndingDate", "CourseStartingDate", "CreatedAt" },
                values: new object[] { new DateTime(2024, 6, 13, 22, 12, 10, 392, DateTimeKind.Local).AddTicks(8729), new DateTime(2024, 3, 13, 22, 12, 10, 392, DateTimeKind.Local).AddTicks(8728), new DateTime(2024, 3, 13, 22, 12, 10, 392, DateTimeKind.Local).AddTicks(8726) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: "c-3",
                columns: new[] { "CourseEndingDate", "CourseStartingDate", "CreatedAt" },
                values: new object[] { new DateTime(2024, 6, 13, 22, 12, 10, 392, DateTimeKind.Local).AddTicks(8734), new DateTime(2024, 3, 13, 22, 12, 10, 392, DateTimeKind.Local).AddTicks(8733), new DateTime(2024, 3, 13, 22, 12, 10, 392, DateTimeKind.Local).AddTicks(8732) });

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: "e-1",
                columns: new[] { "CreatedAt", "StartExamDateTime" },
                values: new object[] { new DateTime(2024, 3, 13, 22, 12, 10, 392, DateTimeKind.Local).AddTicks(8763), new DateTime(2024, 3, 20, 22, 12, 10, 392, DateTimeKind.Local).AddTicks(8768) });

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: "e-2",
                columns: new[] { "CreatedAt", "StartExamDateTime" },
                values: new object[] { new DateTime(2024, 3, 13, 22, 12, 10, 392, DateTimeKind.Local).AddTicks(8775), new DateTime(2024, 3, 27, 22, 12, 10, 392, DateTimeKind.Local).AddTicks(8778) });

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: "e-3",
                columns: new[] { "CreatedAt", "StartExamDateTime" },
                values: new object[] { new DateTime(2024, 3, 13, 22, 12, 10, 392, DateTimeKind.Local).AddTicks(8781), new DateTime(2024, 4, 3, 22, 12, 10, 392, DateTimeKind.Local).AddTicks(8783) });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-1",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 22, 12, 10, 392, DateTimeKind.Local).AddTicks(8810));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-2",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 22, 12, 10, 392, DateTimeKind.Local).AddTicks(8815));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-3",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 22, 12, 10, 392, DateTimeKind.Local).AddTicks(8820));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-4",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 22, 12, 10, 392, DateTimeKind.Local).AddTicks(8824));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-5",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 22, 12, 10, 392, DateTimeKind.Local).AddTicks(8828));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-6",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 22, 12, 10, 392, DateTimeKind.Local).AddTicks(8832));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-7",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 22, 12, 10, 392, DateTimeKind.Local).AddTicks(8839));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-8",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 22, 12, 10, 392, DateTimeKind.Local).AddTicks(8843));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-9",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 22, 12, 10, 392, DateTimeKind.Local).AddTicks(8847));

            migrationBuilder.UpdateData(
                table: "StudentsExams",
                keyColumn: "Id",
                keyValue: "se-1",
                columns: new[] { "CreatedAt", "ExamStartTime" },
                values: new object[] { new DateTime(2024, 3, 13, 22, 12, 10, 392, DateTimeKind.Local).AddTicks(8874), new DateTime(2024, 3, 13, 20, 12, 10, 392, DateTimeKind.Local).AddTicks(8880) });

            migrationBuilder.UpdateData(
                table: "StudentsExams",
                keyColumn: "Id",
                keyValue: "se-2",
                columns: new[] { "CreatedAt", "ExamStartTime" },
                values: new object[] { new DateTime(2024, 3, 13, 22, 12, 10, 392, DateTimeKind.Local).AddTicks(8883), new DateTime(2024, 3, 13, 19, 12, 10, 392, DateTimeKind.Local).AddTicks(8885) });

            migrationBuilder.UpdateData(
                table: "StudentsExams",
                keyColumn: "Id",
                keyValue: "se-3",
                columns: new[] { "CreatedAt", "ExamStartTime" },
                values: new object[] { new DateTime(2024, 3, 13, 22, 12, 10, 392, DateTimeKind.Local).AddTicks(8887), new DateTime(2024, 3, 13, 18, 12, 10, 392, DateTimeKind.Local).AddTicks(8889) });

            migrationBuilder.UpdateData(
                table: "StudentsExams",
                keyColumn: "Id",
                keyValue: "se-4",
                columns: new[] { "CreatedAt", "ExamStartTime" },
                values: new object[] { new DateTime(2024, 3, 13, 22, 12, 10, 392, DateTimeKind.Local).AddTicks(8891), new DateTime(2024, 3, 13, 17, 12, 10, 392, DateTimeKind.Local).AddTicks(8893) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "a-1",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 22, 12, 10, 392, DateTimeKind.Local).AddTicks(8919));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "s-1",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 22, 12, 10, 392, DateTimeKind.Local).AddTicks(8950));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "s-2",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 22, 12, 10, 392, DateTimeKind.Local).AddTicks(8954));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "t-1",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 22, 12, 10, 392, DateTimeKind.Local).AddTicks(8946));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-1",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 22, 5, 52, 838, DateTimeKind.Local).AddTicks(2306));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-2",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 22, 5, 52, 838, DateTimeKind.Local).AddTicks(2371));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-21",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 22, 5, 52, 838, DateTimeKind.Local).AddTicks(2380));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-22",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 22, 5, 52, 838, DateTimeKind.Local).AddTicks(2382));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-23",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 22, 5, 52, 838, DateTimeKind.Local).AddTicks(2385));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-24",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 22, 5, 52, 838, DateTimeKind.Local).AddTicks(2409));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-3",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 22, 5, 52, 838, DateTimeKind.Local).AddTicks(2374));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-31",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 22, 5, 52, 838, DateTimeKind.Local).AddTicks(2411));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-32",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 22, 5, 52, 838, DateTimeKind.Local).AddTicks(2414));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-33",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 22, 5, 52, 838, DateTimeKind.Local).AddTicks(2416));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-34",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 22, 5, 52, 838, DateTimeKind.Local).AddTicks(2419));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-4",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 22, 5, 52, 838, DateTimeKind.Local).AddTicks(2377));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: "c-1",
                columns: new[] { "CourseEndingDate", "CourseStartingDate", "CreatedAt" },
                values: new object[] { new DateTime(2024, 6, 13, 22, 5, 52, 838, DateTimeKind.Local).AddTicks(2576), new DateTime(2024, 3, 13, 22, 5, 52, 838, DateTimeKind.Local).AddTicks(2574), new DateTime(2024, 3, 13, 22, 5, 52, 838, DateTimeKind.Local).AddTicks(2567) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: "c-2",
                columns: new[] { "CourseEndingDate", "CourseStartingDate", "CreatedAt" },
                values: new object[] { new DateTime(2024, 6, 13, 22, 5, 52, 838, DateTimeKind.Local).AddTicks(2585), new DateTime(2024, 3, 13, 22, 5, 52, 838, DateTimeKind.Local).AddTicks(2583), new DateTime(2024, 3, 13, 22, 5, 52, 838, DateTimeKind.Local).AddTicks(2581) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: "c-3",
                columns: new[] { "CourseEndingDate", "CourseStartingDate", "CreatedAt" },
                values: new object[] { new DateTime(2024, 6, 13, 22, 5, 52, 838, DateTimeKind.Local).AddTicks(2590), new DateTime(2024, 3, 13, 22, 5, 52, 838, DateTimeKind.Local).AddTicks(2589), new DateTime(2024, 3, 13, 22, 5, 52, 838, DateTimeKind.Local).AddTicks(2587) });

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: "e-1",
                columns: new[] { "CreatedAt", "StartExamDateTime" },
                values: new object[] { new DateTime(2024, 3, 13, 22, 5, 52, 838, DateTimeKind.Local).AddTicks(2618), new DateTime(2024, 3, 20, 22, 5, 52, 838, DateTimeKind.Local).AddTicks(2622) });

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: "e-2",
                columns: new[] { "CreatedAt", "StartExamDateTime" },
                values: new object[] { new DateTime(2024, 3, 13, 22, 5, 52, 838, DateTimeKind.Local).AddTicks(2628), new DateTime(2024, 3, 27, 22, 5, 52, 838, DateTimeKind.Local).AddTicks(2630) });

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: "e-3",
                columns: new[] { "CreatedAt", "StartExamDateTime" },
                values: new object[] { new DateTime(2024, 3, 13, 22, 5, 52, 838, DateTimeKind.Local).AddTicks(2633), new DateTime(2024, 4, 3, 22, 5, 52, 838, DateTimeKind.Local).AddTicks(2635) });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-1",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 22, 5, 52, 838, DateTimeKind.Local).AddTicks(2662));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-2",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 22, 5, 52, 838, DateTimeKind.Local).AddTicks(2667));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-3",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 22, 5, 52, 838, DateTimeKind.Local).AddTicks(2672));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-4",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 22, 5, 52, 838, DateTimeKind.Local).AddTicks(2676));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-5",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 22, 5, 52, 838, DateTimeKind.Local).AddTicks(2680));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-6",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 22, 5, 52, 838, DateTimeKind.Local).AddTicks(2686));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-7",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 22, 5, 52, 838, DateTimeKind.Local).AddTicks(2690));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-8",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 22, 5, 52, 838, DateTimeKind.Local).AddTicks(2694));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-9",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 22, 5, 52, 838, DateTimeKind.Local).AddTicks(2698));

            migrationBuilder.UpdateData(
                table: "StudentsExams",
                keyColumn: "Id",
                keyValue: "se-1",
                columns: new[] { "CreatedAt", "ExamStartTime" },
                values: new object[] { new DateTime(2024, 3, 13, 22, 5, 52, 838, DateTimeKind.Local).AddTicks(2727), new DateTime(2024, 3, 13, 20, 5, 52, 838, DateTimeKind.Local).AddTicks(2733) });

            migrationBuilder.UpdateData(
                table: "StudentsExams",
                keyColumn: "Id",
                keyValue: "se-2",
                columns: new[] { "CreatedAt", "ExamStartTime" },
                values: new object[] { new DateTime(2024, 3, 13, 22, 5, 52, 838, DateTimeKind.Local).AddTicks(2735), new DateTime(2024, 3, 13, 19, 5, 52, 838, DateTimeKind.Local).AddTicks(2738) });

            migrationBuilder.UpdateData(
                table: "StudentsExams",
                keyColumn: "Id",
                keyValue: "se-3",
                columns: new[] { "CreatedAt", "ExamStartTime" },
                values: new object[] { new DateTime(2024, 3, 13, 22, 5, 52, 838, DateTimeKind.Local).AddTicks(2756), new DateTime(2024, 3, 13, 18, 5, 52, 838, DateTimeKind.Local).AddTicks(2758) });

            migrationBuilder.UpdateData(
                table: "StudentsExams",
                keyColumn: "Id",
                keyValue: "se-4",
                columns: new[] { "CreatedAt", "ExamStartTime" },
                values: new object[] { new DateTime(2024, 3, 13, 22, 5, 52, 838, DateTimeKind.Local).AddTicks(2761), new DateTime(2024, 3, 13, 17, 5, 52, 838, DateTimeKind.Local).AddTicks(2763) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "a-1",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 22, 5, 52, 838, DateTimeKind.Local).AddTicks(2793));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "s-1",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 22, 5, 52, 838, DateTimeKind.Local).AddTicks(2806));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "s-2",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 22, 5, 52, 838, DateTimeKind.Local).AddTicks(2810));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "t-1",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 22, 5, 52, 838, DateTimeKind.Local).AddTicks(2802));
        }
    }
}
