using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Exams_App_C__.Net_Server.Migrations
{
    /// <inheritdoc />
    public partial class V13 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-1",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 19, 30, 18, 249, DateTimeKind.Local).AddTicks(5305));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-2",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 19, 30, 18, 249, DateTimeKind.Local).AddTicks(5369));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-21",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 19, 30, 18, 249, DateTimeKind.Local).AddTicks(5378));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-22",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 19, 30, 18, 249, DateTimeKind.Local).AddTicks(5394));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-23",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 19, 30, 18, 249, DateTimeKind.Local).AddTicks(5397));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-24",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 19, 30, 18, 249, DateTimeKind.Local).AddTicks(5399));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-3",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 19, 30, 18, 249, DateTimeKind.Local).AddTicks(5373));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-31",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 19, 30, 18, 249, DateTimeKind.Local).AddTicks(5402));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-32",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 19, 30, 18, 249, DateTimeKind.Local).AddTicks(5405));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-33",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 19, 30, 18, 249, DateTimeKind.Local).AddTicks(5407));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-34",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 19, 30, 18, 249, DateTimeKind.Local).AddTicks(5409));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-4",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 19, 30, 18, 249, DateTimeKind.Local).AddTicks(5376));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: "c-1",
                columns: new[] { "CourseEndingDate", "CourseStartingDate", "CreatedAt" },
                values: new object[] { new DateTime(2024, 6, 10, 19, 30, 18, 249, DateTimeKind.Local).AddTicks(5570), new DateTime(2024, 3, 10, 19, 30, 18, 249, DateTimeKind.Local).AddTicks(5569), new DateTime(2024, 3, 10, 19, 30, 18, 249, DateTimeKind.Local).AddTicks(5535) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: "c-2",
                columns: new[] { "CourseEndingDate", "CourseStartingDate", "CreatedAt" },
                values: new object[] { new DateTime(2024, 6, 10, 19, 30, 18, 249, DateTimeKind.Local).AddTicks(5583), new DateTime(2024, 3, 10, 19, 30, 18, 249, DateTimeKind.Local).AddTicks(5581), new DateTime(2024, 3, 10, 19, 30, 18, 249, DateTimeKind.Local).AddTicks(5579) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: "c-3",
                columns: new[] { "CourseEndingDate", "CourseStartingDate", "CreatedAt" },
                values: new object[] { new DateTime(2024, 6, 10, 19, 30, 18, 249, DateTimeKind.Local).AddTicks(5588), new DateTime(2024, 3, 10, 19, 30, 18, 249, DateTimeKind.Local).AddTicks(5587), new DateTime(2024, 3, 10, 19, 30, 18, 249, DateTimeKind.Local).AddTicks(5585) });

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: "e-1",
                columns: new[] { "CreatedAt", "StartExamDateTime" },
                values: new object[] { new DateTime(2024, 3, 10, 19, 30, 18, 249, DateTimeKind.Local).AddTicks(5613), new DateTime(2024, 3, 17, 19, 30, 18, 249, DateTimeKind.Local).AddTicks(5618) });

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: "e-2",
                columns: new[] { "CreatedAt", "StartExamDateTime" },
                values: new object[] { new DateTime(2024, 3, 10, 19, 30, 18, 249, DateTimeKind.Local).AddTicks(5623), new DateTime(2024, 3, 24, 19, 30, 18, 249, DateTimeKind.Local).AddTicks(5625) });

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: "e-3",
                columns: new[] { "CreatedAt", "StartExamDateTime" },
                values: new object[] { new DateTime(2024, 3, 10, 19, 30, 18, 249, DateTimeKind.Local).AddTicks(5628), new DateTime(2024, 3, 31, 19, 30, 18, 249, DateTimeKind.Local).AddTicks(5630) });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-1",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 19, 30, 18, 249, DateTimeKind.Local).AddTicks(5653));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-2",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 19, 30, 18, 249, DateTimeKind.Local).AddTicks(5659));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-3",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 19, 30, 18, 249, DateTimeKind.Local).AddTicks(5663));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-4",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 19, 30, 18, 249, DateTimeKind.Local).AddTicks(5669));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-5",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 19, 30, 18, 249, DateTimeKind.Local).AddTicks(5673));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-6",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 19, 30, 18, 249, DateTimeKind.Local).AddTicks(5677));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-7",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 19, 30, 18, 249, DateTimeKind.Local).AddTicks(5681));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-8",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 19, 30, 18, 249, DateTimeKind.Local).AddTicks(5685));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-9",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 19, 30, 18, 249, DateTimeKind.Local).AddTicks(5690));

            migrationBuilder.UpdateData(
                table: "StudentsExams",
                keyColumn: "Id",
                keyValue: "se-1",
                columns: new[] { "CreatedAt", "ExamStartTime" },
                values: new object[] { new DateTime(2024, 3, 10, 19, 30, 18, 249, DateTimeKind.Local).AddTicks(5726), new DateTime(2024, 3, 10, 17, 30, 18, 249, DateTimeKind.Local).AddTicks(5732) });

            migrationBuilder.UpdateData(
                table: "StudentsExams",
                keyColumn: "Id",
                keyValue: "se-2",
                columns: new[] { "CreatedAt", "ExamStartTime" },
                values: new object[] { new DateTime(2024, 3, 10, 19, 30, 18, 249, DateTimeKind.Local).AddTicks(5735), new DateTime(2024, 3, 10, 16, 30, 18, 249, DateTimeKind.Local).AddTicks(5737) });

            migrationBuilder.UpdateData(
                table: "StudentsExams",
                keyColumn: "Id",
                keyValue: "se-3",
                columns: new[] { "CreatedAt", "ExamStartTime" },
                values: new object[] { new DateTime(2024, 3, 10, 19, 30, 18, 249, DateTimeKind.Local).AddTicks(5742), new DateTime(2024, 3, 10, 15, 30, 18, 249, DateTimeKind.Local).AddTicks(5743) });

            migrationBuilder.UpdateData(
                table: "StudentsExams",
                keyColumn: "Id",
                keyValue: "se-4",
                columns: new[] { "CreatedAt", "ExamStartTime" },
                values: new object[] { new DateTime(2024, 3, 10, 19, 30, 18, 249, DateTimeKind.Local).AddTicks(5746), new DateTime(2024, 3, 10, 14, 30, 18, 249, DateTimeKind.Local).AddTicks(5748) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "a-1",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 19, 30, 18, 249, DateTimeKind.Local).AddTicks(5772));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "s-1",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 19, 30, 18, 249, DateTimeKind.Local).AddTicks(5784));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "s-2",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 19, 30, 18, 249, DateTimeKind.Local).AddTicks(5788));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "t-1",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 19, 30, 18, 249, DateTimeKind.Local).AddTicks(5781));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-1",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 19, 27, 50, 169, DateTimeKind.Local).AddTicks(649));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-2",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 19, 27, 50, 169, DateTimeKind.Local).AddTicks(732));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-21",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 19, 27, 50, 169, DateTimeKind.Local).AddTicks(750));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-22",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 19, 27, 50, 169, DateTimeKind.Local).AddTicks(752));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-23",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 19, 27, 50, 169, DateTimeKind.Local).AddTicks(755));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-24",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 19, 27, 50, 169, DateTimeKind.Local).AddTicks(758));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-3",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 19, 27, 50, 169, DateTimeKind.Local).AddTicks(735));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-31",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 19, 27, 50, 169, DateTimeKind.Local).AddTicks(760));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-32",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 19, 27, 50, 169, DateTimeKind.Local).AddTicks(763));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-33",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 19, 27, 50, 169, DateTimeKind.Local).AddTicks(765));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-34",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 19, 27, 50, 169, DateTimeKind.Local).AddTicks(768));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-4",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 19, 27, 50, 169, DateTimeKind.Local).AddTicks(738));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: "c-1",
                columns: new[] { "CourseEndingDate", "CourseStartingDate", "CreatedAt" },
                values: new object[] { new DateTime(2024, 6, 10, 19, 27, 50, 169, DateTimeKind.Local).AddTicks(909), new DateTime(2024, 3, 10, 19, 27, 50, 169, DateTimeKind.Local).AddTicks(908), new DateTime(2024, 3, 10, 19, 27, 50, 169, DateTimeKind.Local).AddTicks(902) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: "c-2",
                columns: new[] { "CourseEndingDate", "CourseStartingDate", "CreatedAt" },
                values: new object[] { new DateTime(2024, 6, 10, 19, 27, 50, 169, DateTimeKind.Local).AddTicks(918), new DateTime(2024, 3, 10, 19, 27, 50, 169, DateTimeKind.Local).AddTicks(917), new DateTime(2024, 3, 10, 19, 27, 50, 169, DateTimeKind.Local).AddTicks(915) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: "c-3",
                columns: new[] { "CourseEndingDate", "CourseStartingDate", "CreatedAt" },
                values: new object[] { new DateTime(2024, 6, 10, 19, 27, 50, 169, DateTimeKind.Local).AddTicks(924), new DateTime(2024, 3, 10, 19, 27, 50, 169, DateTimeKind.Local).AddTicks(923), new DateTime(2024, 3, 10, 19, 27, 50, 169, DateTimeKind.Local).AddTicks(921) });

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: "e-1",
                columns: new[] { "CreatedAt", "StartExamDateTime" },
                values: new object[] { new DateTime(2024, 3, 10, 19, 27, 50, 169, DateTimeKind.Local).AddTicks(948), new DateTime(2024, 3, 17, 19, 27, 50, 169, DateTimeKind.Local).AddTicks(958) });

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: "e-2",
                columns: new[] { "CreatedAt", "StartExamDateTime" },
                values: new object[] { new DateTime(2024, 3, 10, 19, 27, 50, 169, DateTimeKind.Local).AddTicks(963), new DateTime(2024, 3, 24, 19, 27, 50, 169, DateTimeKind.Local).AddTicks(965) });

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: "e-3",
                columns: new[] { "CreatedAt", "StartExamDateTime" },
                values: new object[] { new DateTime(2024, 3, 10, 19, 27, 50, 169, DateTimeKind.Local).AddTicks(968), new DateTime(2024, 3, 31, 19, 27, 50, 169, DateTimeKind.Local).AddTicks(970) });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-1",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 19, 27, 50, 169, DateTimeKind.Local).AddTicks(1016));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-2",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 19, 27, 50, 169, DateTimeKind.Local).AddTicks(1022));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-3",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 19, 27, 50, 169, DateTimeKind.Local).AddTicks(1028));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-4",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 19, 27, 50, 169, DateTimeKind.Local).AddTicks(1033));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-5",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 19, 27, 50, 169, DateTimeKind.Local).AddTicks(1037));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-6",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 19, 27, 50, 169, DateTimeKind.Local).AddTicks(1041));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-7",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 19, 27, 50, 169, DateTimeKind.Local).AddTicks(1045));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-8",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 19, 27, 50, 169, DateTimeKind.Local).AddTicks(1050));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-9",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 19, 27, 50, 169, DateTimeKind.Local).AddTicks(1054));

            migrationBuilder.UpdateData(
                table: "StudentsExams",
                keyColumn: "Id",
                keyValue: "se-1",
                columns: new[] { "CreatedAt", "ExamStartTime" },
                values: new object[] { new DateTime(2024, 3, 10, 19, 27, 50, 169, DateTimeKind.Local).AddTicks(1084), new DateTime(2024, 3, 10, 17, 27, 50, 169, DateTimeKind.Local).AddTicks(1090) });

            migrationBuilder.UpdateData(
                table: "StudentsExams",
                keyColumn: "Id",
                keyValue: "se-2",
                columns: new[] { "CreatedAt", "ExamStartTime" },
                values: new object[] { new DateTime(2024, 3, 10, 19, 27, 50, 169, DateTimeKind.Local).AddTicks(1095), new DateTime(2024, 3, 10, 16, 27, 50, 169, DateTimeKind.Local).AddTicks(1097) });

            migrationBuilder.UpdateData(
                table: "StudentsExams",
                keyColumn: "Id",
                keyValue: "se-3",
                columns: new[] { "CreatedAt", "ExamStartTime" },
                values: new object[] { new DateTime(2024, 3, 10, 19, 27, 50, 169, DateTimeKind.Local).AddTicks(1100), new DateTime(2024, 3, 10, 15, 27, 50, 169, DateTimeKind.Local).AddTicks(1101) });

            migrationBuilder.UpdateData(
                table: "StudentsExams",
                keyColumn: "Id",
                keyValue: "se-4",
                columns: new[] { "CreatedAt", "ExamStartTime" },
                values: new object[] { new DateTime(2024, 3, 10, 19, 27, 50, 169, DateTimeKind.Local).AddTicks(1104), new DateTime(2024, 3, 10, 14, 27, 50, 169, DateTimeKind.Local).AddTicks(1106) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "a-1",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 19, 27, 50, 169, DateTimeKind.Local).AddTicks(1135));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "s-1",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 19, 27, 50, 169, DateTimeKind.Local).AddTicks(1148));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "s-2",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 19, 27, 50, 169, DateTimeKind.Local).AddTicks(1153));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "t-1",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 19, 27, 50, 169, DateTimeKind.Local).AddTicks(1145));
        }
    }
}
