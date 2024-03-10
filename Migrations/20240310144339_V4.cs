using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Exams_App_C__.Net_Server.Migrations
{
    /// <inheritdoc />
    public partial class V4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-1",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 16, 43, 39, 573, DateTimeKind.Local).AddTicks(5677));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-2",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 16, 43, 39, 573, DateTimeKind.Local).AddTicks(5742));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-21",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 16, 43, 39, 573, DateTimeKind.Local).AddTicks(5764));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-22",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 16, 43, 39, 573, DateTimeKind.Local).AddTicks(5767));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-23",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 16, 43, 39, 573, DateTimeKind.Local).AddTicks(5770));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-24",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 16, 43, 39, 573, DateTimeKind.Local).AddTicks(5773));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-3",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 16, 43, 39, 573, DateTimeKind.Local).AddTicks(5758));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-31",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 16, 43, 39, 573, DateTimeKind.Local).AddTicks(5775));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-32",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 16, 43, 39, 573, DateTimeKind.Local).AddTicks(5778));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-33",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 16, 43, 39, 573, DateTimeKind.Local).AddTicks(5783));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-34",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 16, 43, 39, 573, DateTimeKind.Local).AddTicks(5786));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-4",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 16, 43, 39, 573, DateTimeKind.Local).AddTicks(5761));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: "c-1",
                columns: new[] { "CourseEndingDate", "CourseStartingDate", "CreatedAt" },
                values: new object[] { new DateTime(2024, 6, 10, 16, 43, 39, 573, DateTimeKind.Local).AddTicks(5951), new DateTime(2024, 3, 10, 16, 43, 39, 573, DateTimeKind.Local).AddTicks(5950), new DateTime(2024, 3, 10, 16, 43, 39, 573, DateTimeKind.Local).AddTicks(5941) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: "c-2",
                columns: new[] { "CourseEndingDate", "CourseStartingDate", "CreatedAt" },
                values: new object[] { new DateTime(2024, 6, 10, 16, 43, 39, 573, DateTimeKind.Local).AddTicks(5962), new DateTime(2024, 3, 10, 16, 43, 39, 573, DateTimeKind.Local).AddTicks(5961), new DateTime(2024, 3, 10, 16, 43, 39, 573, DateTimeKind.Local).AddTicks(5958) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: "c-3",
                columns: new[] { "CourseEndingDate", "CourseStartingDate", "CreatedAt" },
                values: new object[] { new DateTime(2024, 6, 10, 16, 43, 39, 573, DateTimeKind.Local).AddTicks(5969), new DateTime(2024, 3, 10, 16, 43, 39, 573, DateTimeKind.Local).AddTicks(5967), new DateTime(2024, 3, 10, 16, 43, 39, 573, DateTimeKind.Local).AddTicks(5966) });

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: "e-1",
                columns: new[] { "CreatedAt", "StartExamDateTime" },
                values: new object[] { new DateTime(2024, 3, 10, 16, 43, 39, 573, DateTimeKind.Local).AddTicks(6003), new DateTime(2024, 3, 17, 16, 43, 39, 573, DateTimeKind.Local).AddTicks(6008) });

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: "e-2",
                columns: new[] { "CreatedAt", "StartExamDateTime" },
                values: new object[] { new DateTime(2024, 3, 10, 16, 43, 39, 573, DateTimeKind.Local).AddTicks(6013), new DateTime(2024, 3, 24, 16, 43, 39, 573, DateTimeKind.Local).AddTicks(6016) });

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: "e-3",
                columns: new[] { "CreatedAt", "StartExamDateTime" },
                values: new object[] { new DateTime(2024, 3, 10, 16, 43, 39, 573, DateTimeKind.Local).AddTicks(6019), new DateTime(2024, 3, 31, 16, 43, 39, 573, DateTimeKind.Local).AddTicks(6021) });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-1",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 16, 43, 39, 573, DateTimeKind.Local).AddTicks(6054));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-2",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 16, 43, 39, 573, DateTimeKind.Local).AddTicks(6059));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-3",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 16, 43, 39, 573, DateTimeKind.Local).AddTicks(6064));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-4",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 16, 43, 39, 573, DateTimeKind.Local).AddTicks(6068));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-5",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 16, 43, 39, 573, DateTimeKind.Local).AddTicks(6073));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-6",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 16, 43, 39, 573, DateTimeKind.Local).AddTicks(6077));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-7",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 16, 43, 39, 573, DateTimeKind.Local).AddTicks(6082));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-8",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 16, 43, 39, 573, DateTimeKind.Local).AddTicks(6086));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-9",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 16, 43, 39, 573, DateTimeKind.Local).AddTicks(6093));

            migrationBuilder.UpdateData(
                table: "StudentsExams",
                keyColumn: "Id",
                keyValue: "se-1",
                columns: new[] { "CreatedAt", "ExamStartTime" },
                values: new object[] { new DateTime(2024, 3, 10, 16, 43, 39, 573, DateTimeKind.Local).AddTicks(6127), new DateTime(2024, 3, 10, 14, 43, 39, 573, DateTimeKind.Local).AddTicks(6133) });

            migrationBuilder.UpdateData(
                table: "StudentsExams",
                keyColumn: "Id",
                keyValue: "se-2",
                columns: new[] { "CreatedAt", "ExamStartTime" },
                values: new object[] { new DateTime(2024, 3, 10, 16, 43, 39, 573, DateTimeKind.Local).AddTicks(6137), new DateTime(2024, 3, 10, 13, 43, 39, 573, DateTimeKind.Local).AddTicks(6169) });

            migrationBuilder.UpdateData(
                table: "StudentsExams",
                keyColumn: "Id",
                keyValue: "se-3",
                columns: new[] { "CreatedAt", "ExamStartTime" },
                values: new object[] { new DateTime(2024, 3, 10, 16, 43, 39, 573, DateTimeKind.Local).AddTicks(6172), new DateTime(2024, 3, 10, 12, 43, 39, 573, DateTimeKind.Local).AddTicks(6175) });

            migrationBuilder.UpdateData(
                table: "StudentsExams",
                keyColumn: "Id",
                keyValue: "se-4",
                columns: new[] { "CreatedAt", "ExamStartTime" },
                values: new object[] { new DateTime(2024, 3, 10, 16, 43, 39, 573, DateTimeKind.Local).AddTicks(6177), new DateTime(2024, 3, 10, 11, 43, 39, 573, DateTimeKind.Local).AddTicks(6179) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "a-1",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 16, 43, 39, 573, DateTimeKind.Local).AddTicks(6211));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "s-1",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 16, 43, 39, 573, DateTimeKind.Local).AddTicks(6224));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "s-2",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 16, 43, 39, 573, DateTimeKind.Local).AddTicks(6230));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "t-1",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 16, 43, 39, 573, DateTimeKind.Local).AddTicks(6220));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-1",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 16, 16, 14, 867, DateTimeKind.Local).AddTicks(5630));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-2",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 16, 16, 14, 867, DateTimeKind.Local).AddTicks(5693));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-21",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 16, 16, 14, 867, DateTimeKind.Local).AddTicks(5702));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-22",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 16, 16, 14, 867, DateTimeKind.Local).AddTicks(5704));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-23",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 16, 16, 14, 867, DateTimeKind.Local).AddTicks(5707));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-24",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 16, 16, 14, 867, DateTimeKind.Local).AddTicks(5719));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-3",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 16, 16, 14, 867, DateTimeKind.Local).AddTicks(5697));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-31",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 16, 16, 14, 867, DateTimeKind.Local).AddTicks(5722));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-32",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 16, 16, 14, 867, DateTimeKind.Local).AddTicks(5724));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-33",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 16, 16, 14, 867, DateTimeKind.Local).AddTicks(5727));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-34",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 16, 16, 14, 867, DateTimeKind.Local).AddTicks(5730));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-4",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 16, 16, 14, 867, DateTimeKind.Local).AddTicks(5699));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: "c-1",
                columns: new[] { "CourseEndingDate", "CourseStartingDate", "CreatedAt" },
                values: new object[] { new DateTime(2024, 6, 10, 16, 16, 14, 867, DateTimeKind.Local).AddTicks(5852), new DateTime(2024, 3, 10, 16, 16, 14, 867, DateTimeKind.Local).AddTicks(5851), new DateTime(2024, 3, 10, 16, 16, 14, 867, DateTimeKind.Local).AddTicks(5846) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: "c-2",
                columns: new[] { "CourseEndingDate", "CourseStartingDate", "CreatedAt" },
                values: new object[] { new DateTime(2024, 6, 10, 16, 16, 14, 867, DateTimeKind.Local).AddTicks(5862), new DateTime(2024, 3, 10, 16, 16, 14, 867, DateTimeKind.Local).AddTicks(5860), new DateTime(2024, 3, 10, 16, 16, 14, 867, DateTimeKind.Local).AddTicks(5859) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: "c-3",
                columns: new[] { "CourseEndingDate", "CourseStartingDate", "CreatedAt" },
                values: new object[] { new DateTime(2024, 6, 10, 16, 16, 14, 867, DateTimeKind.Local).AddTicks(5867), new DateTime(2024, 3, 10, 16, 16, 14, 867, DateTimeKind.Local).AddTicks(5866), new DateTime(2024, 3, 10, 16, 16, 14, 867, DateTimeKind.Local).AddTicks(5864) });

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: "e-1",
                columns: new[] { "CreatedAt", "StartExamDateTime" },
                values: new object[] { new DateTime(2024, 3, 10, 16, 16, 14, 867, DateTimeKind.Local).AddTicks(5894), new DateTime(2024, 3, 17, 16, 16, 14, 867, DateTimeKind.Local).AddTicks(5898) });

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: "e-2",
                columns: new[] { "CreatedAt", "StartExamDateTime" },
                values: new object[] { new DateTime(2024, 3, 10, 16, 16, 14, 867, DateTimeKind.Local).AddTicks(5904), new DateTime(2024, 3, 24, 16, 16, 14, 867, DateTimeKind.Local).AddTicks(5907) });

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: "e-3",
                columns: new[] { "CreatedAt", "StartExamDateTime" },
                values: new object[] { new DateTime(2024, 3, 10, 16, 16, 14, 867, DateTimeKind.Local).AddTicks(5910), new DateTime(2024, 3, 31, 16, 16, 14, 867, DateTimeKind.Local).AddTicks(5912) });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-1",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 16, 16, 14, 867, DateTimeKind.Local).AddTicks(5935));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-2",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 16, 16, 14, 867, DateTimeKind.Local).AddTicks(5940));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-3",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 16, 16, 14, 867, DateTimeKind.Local).AddTicks(5961));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-4",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 16, 16, 14, 867, DateTimeKind.Local).AddTicks(5966));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-5",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 16, 16, 14, 867, DateTimeKind.Local).AddTicks(5970));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-6",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 16, 16, 14, 867, DateTimeKind.Local).AddTicks(5976));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-7",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 16, 16, 14, 867, DateTimeKind.Local).AddTicks(5980));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-8",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 16, 16, 14, 867, DateTimeKind.Local).AddTicks(5984));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-9",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 16, 16, 14, 867, DateTimeKind.Local).AddTicks(5988));

            migrationBuilder.UpdateData(
                table: "StudentsExams",
                keyColumn: "Id",
                keyValue: "se-1",
                columns: new[] { "CreatedAt", "ExamStartTime" },
                values: new object[] { new DateTime(2024, 3, 10, 16, 16, 14, 867, DateTimeKind.Local).AddTicks(6015), new DateTime(2024, 3, 10, 14, 16, 14, 867, DateTimeKind.Local).AddTicks(6021) });

            migrationBuilder.UpdateData(
                table: "StudentsExams",
                keyColumn: "Id",
                keyValue: "se-2",
                columns: new[] { "CreatedAt", "ExamStartTime" },
                values: new object[] { new DateTime(2024, 3, 10, 16, 16, 14, 867, DateTimeKind.Local).AddTicks(6024), new DateTime(2024, 3, 10, 13, 16, 14, 867, DateTimeKind.Local).AddTicks(6026) });

            migrationBuilder.UpdateData(
                table: "StudentsExams",
                keyColumn: "Id",
                keyValue: "se-3",
                columns: new[] { "CreatedAt", "ExamStartTime" },
                values: new object[] { new DateTime(2024, 3, 10, 16, 16, 14, 867, DateTimeKind.Local).AddTicks(6029), new DateTime(2024, 3, 10, 12, 16, 14, 867, DateTimeKind.Local).AddTicks(6031) });

            migrationBuilder.UpdateData(
                table: "StudentsExams",
                keyColumn: "Id",
                keyValue: "se-4",
                columns: new[] { "CreatedAt", "ExamStartTime" },
                values: new object[] { new DateTime(2024, 3, 10, 16, 16, 14, 867, DateTimeKind.Local).AddTicks(6033), new DateTime(2024, 3, 10, 11, 16, 14, 867, DateTimeKind.Local).AddTicks(6035) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "a-1",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 16, 16, 14, 867, DateTimeKind.Local).AddTicks(6062));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "s-1",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 16, 16, 14, 867, DateTimeKind.Local).AddTicks(6074));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "s-2",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 16, 16, 14, 867, DateTimeKind.Local).AddTicks(6078));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "t-1",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 16, 16, 14, 867, DateTimeKind.Local).AddTicks(6070));
        }
    }
}
