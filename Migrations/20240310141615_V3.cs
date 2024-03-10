using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Exams_App_C__.Net_Server.Migrations
{
    /// <inheritdoc />
    public partial class V3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "UserName",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<float>(
                name: "StudentGradeAvg",
                table: "Users",
                type: "real",
                nullable: true,
                oldClrType: typeof(float),
                oldType: "real");

            migrationBuilder.AlterColumn<string>(
                name: "PasswordHash",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Users",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

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
                columns: new[] { "CreatedAt", "StudentGradeAvg" },
                values: new object[] { new DateTime(2024, 3, 10, 16, 16, 14, 867, DateTimeKind.Local).AddTicks(6062), null });

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
                columns: new[] { "CreatedAt", "StudentGradeAvg" },
                values: new object[] { new DateTime(2024, 3, 10, 16, 16, 14, 867, DateTimeKind.Local).AddTicks(6070), null });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "UserName",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<float>(
                name: "StudentGradeAvg",
                table: "Users",
                type: "real",
                nullable: false,
                defaultValue: 0f,
                oldClrType: typeof(float),
                oldType: "real",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PasswordHash",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Users",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-1",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 16, 12, 43, 250, DateTimeKind.Local).AddTicks(7056));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-2",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 16, 12, 43, 250, DateTimeKind.Local).AddTicks(7118));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-21",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 16, 12, 43, 250, DateTimeKind.Local).AddTicks(7126));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-22",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 16, 12, 43, 250, DateTimeKind.Local).AddTicks(7140));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-23",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 16, 12, 43, 250, DateTimeKind.Local).AddTicks(7143));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-24",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 16, 12, 43, 250, DateTimeKind.Local).AddTicks(7145));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-3",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 16, 12, 43, 250, DateTimeKind.Local).AddTicks(7121));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-31",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 16, 12, 43, 250, DateTimeKind.Local).AddTicks(7148));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-32",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 16, 12, 43, 250, DateTimeKind.Local).AddTicks(7150));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-33",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 16, 12, 43, 250, DateTimeKind.Local).AddTicks(7153));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-34",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 16, 12, 43, 250, DateTimeKind.Local).AddTicks(7155));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-4",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 16, 12, 43, 250, DateTimeKind.Local).AddTicks(7124));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: "c-1",
                columns: new[] { "CourseEndingDate", "CourseStartingDate", "CreatedAt" },
                values: new object[] { new DateTime(2024, 6, 10, 16, 12, 43, 250, DateTimeKind.Local).AddTicks(7293), new DateTime(2024, 3, 10, 16, 12, 43, 250, DateTimeKind.Local).AddTicks(7292), new DateTime(2024, 3, 10, 16, 12, 43, 250, DateTimeKind.Local).AddTicks(7285) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: "c-2",
                columns: new[] { "CourseEndingDate", "CourseStartingDate", "CreatedAt" },
                values: new object[] { new DateTime(2024, 6, 10, 16, 12, 43, 250, DateTimeKind.Local).AddTicks(7305), new DateTime(2024, 3, 10, 16, 12, 43, 250, DateTimeKind.Local).AddTicks(7304), new DateTime(2024, 3, 10, 16, 12, 43, 250, DateTimeKind.Local).AddTicks(7302) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: "c-3",
                columns: new[] { "CourseEndingDate", "CourseStartingDate", "CreatedAt" },
                values: new object[] { new DateTime(2024, 6, 10, 16, 12, 43, 250, DateTimeKind.Local).AddTicks(7311), new DateTime(2024, 3, 10, 16, 12, 43, 250, DateTimeKind.Local).AddTicks(7309), new DateTime(2024, 3, 10, 16, 12, 43, 250, DateTimeKind.Local).AddTicks(7308) });

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: "e-1",
                columns: new[] { "CreatedAt", "StartExamDateTime" },
                values: new object[] { new DateTime(2024, 3, 10, 16, 12, 43, 250, DateTimeKind.Local).AddTicks(7368), new DateTime(2024, 3, 17, 16, 12, 43, 250, DateTimeKind.Local).AddTicks(7374) });

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: "e-2",
                columns: new[] { "CreatedAt", "StartExamDateTime" },
                values: new object[] { new DateTime(2024, 3, 10, 16, 12, 43, 250, DateTimeKind.Local).AddTicks(7379), new DateTime(2024, 3, 24, 16, 12, 43, 250, DateTimeKind.Local).AddTicks(7382) });

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: "e-3",
                columns: new[] { "CreatedAt", "StartExamDateTime" },
                values: new object[] { new DateTime(2024, 3, 10, 16, 12, 43, 250, DateTimeKind.Local).AddTicks(7385), new DateTime(2024, 3, 31, 16, 12, 43, 250, DateTimeKind.Local).AddTicks(7386) });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-1",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 16, 12, 43, 250, DateTimeKind.Local).AddTicks(7418));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-2",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 16, 12, 43, 250, DateTimeKind.Local).AddTicks(7423));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-3",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 16, 12, 43, 250, DateTimeKind.Local).AddTicks(7428));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-4",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 16, 12, 43, 250, DateTimeKind.Local).AddTicks(7434));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-5",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 16, 12, 43, 250, DateTimeKind.Local).AddTicks(7438));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-6",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 16, 12, 43, 250, DateTimeKind.Local).AddTicks(7442));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-7",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 16, 12, 43, 250, DateTimeKind.Local).AddTicks(7447));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-8",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 16, 12, 43, 250, DateTimeKind.Local).AddTicks(7451));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-9",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 16, 12, 43, 250, DateTimeKind.Local).AddTicks(7455));

            migrationBuilder.UpdateData(
                table: "StudentsExams",
                keyColumn: "Id",
                keyValue: "se-1",
                columns: new[] { "CreatedAt", "ExamStartTime" },
                values: new object[] { new DateTime(2024, 3, 10, 16, 12, 43, 250, DateTimeKind.Local).AddTicks(7485), new DateTime(2024, 3, 10, 14, 12, 43, 250, DateTimeKind.Local).AddTicks(7490) });

            migrationBuilder.UpdateData(
                table: "StudentsExams",
                keyColumn: "Id",
                keyValue: "se-2",
                columns: new[] { "CreatedAt", "ExamStartTime" },
                values: new object[] { new DateTime(2024, 3, 10, 16, 12, 43, 250, DateTimeKind.Local).AddTicks(7493), new DateTime(2024, 3, 10, 13, 12, 43, 250, DateTimeKind.Local).AddTicks(7496) });

            migrationBuilder.UpdateData(
                table: "StudentsExams",
                keyColumn: "Id",
                keyValue: "se-3",
                columns: new[] { "CreatedAt", "ExamStartTime" },
                values: new object[] { new DateTime(2024, 3, 10, 16, 12, 43, 250, DateTimeKind.Local).AddTicks(7500), new DateTime(2024, 3, 10, 12, 12, 43, 250, DateTimeKind.Local).AddTicks(7502) });

            migrationBuilder.UpdateData(
                table: "StudentsExams",
                keyColumn: "Id",
                keyValue: "se-4",
                columns: new[] { "CreatedAt", "ExamStartTime" },
                values: new object[] { new DateTime(2024, 3, 10, 16, 12, 43, 250, DateTimeKind.Local).AddTicks(7505), new DateTime(2024, 3, 10, 11, 12, 43, 250, DateTimeKind.Local).AddTicks(7506) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "a-1",
                columns: new[] { "CreatedAt", "StudentGradeAvg" },
                values: new object[] { new DateTime(2024, 3, 10, 16, 12, 43, 250, DateTimeKind.Local).AddTicks(7530), 0f });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "s-1",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 16, 12, 43, 250, DateTimeKind.Local).AddTicks(7539));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "s-2",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 16, 12, 43, 250, DateTimeKind.Local).AddTicks(7542));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "t-1",
                columns: new[] { "CreatedAt", "StudentGradeAvg" },
                values: new object[] { new DateTime(2024, 3, 10, 16, 12, 43, 250, DateTimeKind.Local).AddTicks(7535), 0f });
        }
    }
}
