using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Exams_App_C__.Net_Server.Migrations
{
    /// <inheritdoc />
    public partial class v3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-1",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 22, 14, 45, 771, DateTimeKind.Local).AddTicks(3223));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-2",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 22, 14, 45, 771, DateTimeKind.Local).AddTicks(3286));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-21",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 22, 14, 45, 771, DateTimeKind.Local).AddTicks(3306));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-22",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 22, 14, 45, 771, DateTimeKind.Local).AddTicks(3310));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-23",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 22, 14, 45, 771, DateTimeKind.Local).AddTicks(3312));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-24",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 22, 14, 45, 771, DateTimeKind.Local).AddTicks(3315));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-3",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 22, 14, 45, 771, DateTimeKind.Local).AddTicks(3290));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-31",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 22, 14, 45, 771, DateTimeKind.Local).AddTicks(3318));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-32",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 22, 14, 45, 771, DateTimeKind.Local).AddTicks(3320));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-33",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 22, 14, 45, 771, DateTimeKind.Local).AddTicks(3323));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-34",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 22, 14, 45, 771, DateTimeKind.Local).AddTicks(3326));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-4",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 22, 14, 45, 771, DateTimeKind.Local).AddTicks(3293));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: "c-1",
                columns: new[] { "CourseEndingDate", "CourseStartingDate", "CreatedAt" },
                values: new object[] { new DateTime(2024, 6, 13, 22, 14, 45, 771, DateTimeKind.Local).AddTicks(3485), new DateTime(2024, 3, 13, 22, 14, 45, 771, DateTimeKind.Local).AddTicks(3484), new DateTime(2024, 3, 13, 22, 14, 45, 771, DateTimeKind.Local).AddTicks(3476) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: "c-2",
                columns: new[] { "CourseEndingDate", "CourseStartingDate", "CreatedAt" },
                values: new object[] { new DateTime(2024, 6, 13, 22, 14, 45, 771, DateTimeKind.Local).AddTicks(3495), new DateTime(2024, 3, 13, 22, 14, 45, 771, DateTimeKind.Local).AddTicks(3493), new DateTime(2024, 3, 13, 22, 14, 45, 771, DateTimeKind.Local).AddTicks(3491) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: "c-3",
                columns: new[] { "CourseEndingDate", "CourseStartingDate", "CreatedAt" },
                values: new object[] { new DateTime(2024, 6, 13, 22, 14, 45, 771, DateTimeKind.Local).AddTicks(3501), new DateTime(2024, 3, 13, 22, 14, 45, 771, DateTimeKind.Local).AddTicks(3500), new DateTime(2024, 3, 13, 22, 14, 45, 771, DateTimeKind.Local).AddTicks(3498) });

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: "e-1",
                columns: new[] { "CreatedAt", "StartExamDateTime" },
                values: new object[] { new DateTime(2024, 3, 13, 22, 14, 45, 771, DateTimeKind.Local).AddTicks(3527), new DateTime(2024, 3, 20, 22, 14, 45, 771, DateTimeKind.Local).AddTicks(3532) });

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: "e-2",
                columns: new[] { "CreatedAt", "StartExamDateTime" },
                values: new object[] { new DateTime(2024, 3, 13, 22, 14, 45, 771, DateTimeKind.Local).AddTicks(3537), new DateTime(2024, 3, 27, 22, 14, 45, 771, DateTimeKind.Local).AddTicks(3539) });

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: "e-3",
                columns: new[] { "CreatedAt", "StartExamDateTime" },
                values: new object[] { new DateTime(2024, 3, 13, 22, 14, 45, 771, DateTimeKind.Local).AddTicks(3542), new DateTime(2024, 4, 3, 22, 14, 45, 771, DateTimeKind.Local).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-1",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 22, 14, 45, 771, DateTimeKind.Local).AddTicks(3576));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-2",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 22, 14, 45, 771, DateTimeKind.Local).AddTicks(3581));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-3",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 22, 14, 45, 771, DateTimeKind.Local).AddTicks(3636));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-4",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 22, 14, 45, 771, DateTimeKind.Local).AddTicks(3640));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-5",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 22, 14, 45, 771, DateTimeKind.Local).AddTicks(3644));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-6",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 22, 14, 45, 771, DateTimeKind.Local).AddTicks(3649));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-7",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 22, 14, 45, 771, DateTimeKind.Local).AddTicks(3654));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-8",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 22, 14, 45, 771, DateTimeKind.Local).AddTicks(3658));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-9",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 22, 14, 45, 771, DateTimeKind.Local).AddTicks(3663));

            migrationBuilder.UpdateData(
                table: "StudentsExams",
                keyColumn: "Id",
                keyValue: "se-1",
                columns: new[] { "CreatedAt", "ExamStartTime" },
                values: new object[] { new DateTime(2024, 3, 13, 22, 14, 45, 771, DateTimeKind.Local).AddTicks(3694), new DateTime(2024, 3, 13, 20, 14, 45, 771, DateTimeKind.Local).AddTicks(3705) });

            migrationBuilder.UpdateData(
                table: "StudentsExams",
                keyColumn: "Id",
                keyValue: "se-2",
                columns: new[] { "CreatedAt", "ExamStartTime" },
                values: new object[] { new DateTime(2024, 3, 13, 22, 14, 45, 771, DateTimeKind.Local).AddTicks(3710), new DateTime(2024, 3, 13, 19, 14, 45, 771, DateTimeKind.Local).AddTicks(3712) });

            migrationBuilder.UpdateData(
                table: "StudentsExams",
                keyColumn: "Id",
                keyValue: "se-3",
                columns: new[] { "CreatedAt", "ExamStartTime" },
                values: new object[] { new DateTime(2024, 3, 13, 22, 14, 45, 771, DateTimeKind.Local).AddTicks(3715), new DateTime(2024, 3, 13, 18, 14, 45, 771, DateTimeKind.Local).AddTicks(3717) });

            migrationBuilder.UpdateData(
                table: "StudentsExams",
                keyColumn: "Id",
                keyValue: "se-4",
                columns: new[] { "CreatedAt", "ExamStartTime" },
                values: new object[] { new DateTime(2024, 3, 13, 22, 14, 45, 771, DateTimeKind.Local).AddTicks(3719), new DateTime(2024, 3, 13, 17, 14, 45, 771, DateTimeKind.Local).AddTicks(3722) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "a-1",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 22, 14, 45, 771, DateTimeKind.Local).AddTicks(3748));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "s-1",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 22, 14, 45, 771, DateTimeKind.Local).AddTicks(3759));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "s-2",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 22, 14, 45, 771, DateTimeKind.Local).AddTicks(3764));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "t-1",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 22, 14, 45, 771, DateTimeKind.Local).AddTicks(3755));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
