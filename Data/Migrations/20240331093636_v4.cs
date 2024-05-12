using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Exams_App_C__.Net_Server.Migrations
{
    /// <inheritdoc />
    public partial class v4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "QuestionsFailed",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "QuestionScoring",
                table: "QuestionsFailed",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-101",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 31, 12, 36, 36, 220, DateTimeKind.Local).AddTicks(2070));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-2",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 31, 12, 36, 36, 220, DateTimeKind.Local).AddTicks(2130));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-21",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 31, 12, 36, 36, 220, DateTimeKind.Local).AddTicks(2138));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-22",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 31, 12, 36, 36, 220, DateTimeKind.Local).AddTicks(2152));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-23",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 31, 12, 36, 36, 220, DateTimeKind.Local).AddTicks(2154));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-24",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 31, 12, 36, 36, 220, DateTimeKind.Local).AddTicks(2157));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-3",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 31, 12, 36, 36, 220, DateTimeKind.Local).AddTicks(2133));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-31",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 31, 12, 36, 36, 220, DateTimeKind.Local).AddTicks(2160));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-32",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 31, 12, 36, 36, 220, DateTimeKind.Local).AddTicks(2163));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-33",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 31, 12, 36, 36, 220, DateTimeKind.Local).AddTicks(2165));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-34",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 31, 12, 36, 36, 220, DateTimeKind.Local).AddTicks(2168));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-4",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 31, 12, 36, 36, 220, DateTimeKind.Local).AddTicks(2136));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-41",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 31, 12, 36, 36, 220, DateTimeKind.Local).AddTicks(2170));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-42",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 31, 12, 36, 36, 220, DateTimeKind.Local).AddTicks(2175));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-43",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 31, 12, 36, 36, 220, DateTimeKind.Local).AddTicks(2178));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-44",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 31, 12, 36, 36, 220, DateTimeKind.Local).AddTicks(2180));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-51",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 31, 12, 36, 36, 220, DateTimeKind.Local).AddTicks(2182));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-52",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 31, 12, 36, 36, 220, DateTimeKind.Local).AddTicks(2185));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-53",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 31, 12, 36, 36, 220, DateTimeKind.Local).AddTicks(2187));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-54",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 31, 12, 36, 36, 220, DateTimeKind.Local).AddTicks(2190));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-61",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 31, 12, 36, 36, 220, DateTimeKind.Local).AddTicks(2193));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-62",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 31, 12, 36, 36, 220, DateTimeKind.Local).AddTicks(2197));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-63",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 31, 12, 36, 36, 220, DateTimeKind.Local).AddTicks(2199));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-64",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 31, 12, 36, 36, 220, DateTimeKind.Local).AddTicks(2202));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-71",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 31, 12, 36, 36, 220, DateTimeKind.Local).AddTicks(2204));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-72",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 31, 12, 36, 36, 220, DateTimeKind.Local).AddTicks(2206));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-73",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 31, 12, 36, 36, 220, DateTimeKind.Local).AddTicks(2209));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-74",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 31, 12, 36, 36, 220, DateTimeKind.Local).AddTicks(2211));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-81",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 31, 12, 36, 36, 220, DateTimeKind.Local).AddTicks(2214));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-82",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 31, 12, 36, 36, 220, DateTimeKind.Local).AddTicks(2218));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-83",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 31, 12, 36, 36, 220, DateTimeKind.Local).AddTicks(2221));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-84",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 31, 12, 36, 36, 220, DateTimeKind.Local).AddTicks(2223));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-91",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 31, 12, 36, 36, 220, DateTimeKind.Local).AddTicks(2226));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-92",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 31, 12, 36, 36, 220, DateTimeKind.Local).AddTicks(2228));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-93",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 31, 12, 36, 36, 220, DateTimeKind.Local).AddTicks(2231));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-94",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 31, 12, 36, 36, 220, DateTimeKind.Local).AddTicks(2233));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: "c-1",
                columns: new[] { "CourseEndingDate", "CourseStartingDate", "CreatedAt" },
                values: new object[] { new DateTime(2024, 6, 30, 12, 36, 36, 220, DateTimeKind.Local).AddTicks(2406), new DateTime(2024, 3, 31, 12, 36, 36, 220, DateTimeKind.Local).AddTicks(2404), new DateTime(2024, 3, 31, 12, 36, 36, 220, DateTimeKind.Local).AddTicks(2400) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: "c-2",
                columns: new[] { "CourseEndingDate", "CourseStartingDate", "CreatedAt" },
                values: new object[] { new DateTime(2024, 6, 30, 12, 36, 36, 220, DateTimeKind.Local).AddTicks(2425), new DateTime(2024, 3, 31, 12, 36, 36, 220, DateTimeKind.Local).AddTicks(2424), new DateTime(2024, 3, 31, 12, 36, 36, 220, DateTimeKind.Local).AddTicks(2422) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: "c-3",
                columns: new[] { "CourseEndingDate", "CourseStartingDate", "CreatedAt" },
                values: new object[] { new DateTime(2024, 6, 30, 12, 36, 36, 220, DateTimeKind.Local).AddTicks(2431), new DateTime(2024, 3, 31, 12, 36, 36, 220, DateTimeKind.Local).AddTicks(2429), new DateTime(2024, 3, 31, 12, 36, 36, 220, DateTimeKind.Local).AddTicks(2428) });

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: "e-1",
                columns: new[] { "CreatedAt", "StartExamDateTime" },
                values: new object[] { new DateTime(2024, 3, 31, 12, 36, 36, 220, DateTimeKind.Local).AddTicks(2458), new DateTime(2024, 4, 7, 12, 36, 36, 220, DateTimeKind.Local).AddTicks(2464) });

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: "e-2",
                columns: new[] { "CreatedAt", "StartExamDateTime" },
                values: new object[] { new DateTime(2024, 3, 31, 12, 36, 36, 220, DateTimeKind.Local).AddTicks(2470), new DateTime(2024, 4, 14, 12, 36, 36, 220, DateTimeKind.Local).AddTicks(2472) });

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: "e-3",
                columns: new[] { "CreatedAt", "StartExamDateTime" },
                values: new object[] { new DateTime(2024, 3, 31, 12, 36, 36, 220, DateTimeKind.Local).AddTicks(2475), new DateTime(2024, 4, 21, 12, 36, 36, 220, DateTimeKind.Local).AddTicks(2477) });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-1",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 31, 12, 36, 36, 220, DateTimeKind.Local).AddTicks(2500));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-2",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 31, 12, 36, 36, 220, DateTimeKind.Local).AddTicks(2505));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-3",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 31, 12, 36, 36, 220, DateTimeKind.Local).AddTicks(2509));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-4",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 31, 12, 36, 36, 220, DateTimeKind.Local).AddTicks(2515));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-5",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 31, 12, 36, 36, 220, DateTimeKind.Local).AddTicks(2519));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-6",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 31, 12, 36, 36, 220, DateTimeKind.Local).AddTicks(2522));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-7",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 31, 12, 36, 36, 220, DateTimeKind.Local).AddTicks(2524));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-8",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 31, 12, 36, 36, 220, DateTimeKind.Local).AddTicks(2527));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-9",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 31, 12, 36, 36, 220, DateTimeKind.Local).AddTicks(2530));

            migrationBuilder.UpdateData(
                table: "StudentsExams",
                keyColumn: "Id",
                keyValue: "se-1",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 31, 12, 36, 36, 220, DateTimeKind.Local).AddTicks(2557));

            migrationBuilder.UpdateData(
                table: "StudentsExams",
                keyColumn: "Id",
                keyValue: "se-2",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 31, 12, 36, 36, 220, DateTimeKind.Local).AddTicks(2564));

            migrationBuilder.UpdateData(
                table: "StudentsExams",
                keyColumn: "Id",
                keyValue: "se-3",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 31, 12, 36, 36, 220, DateTimeKind.Local).AddTicks(2569));

            migrationBuilder.UpdateData(
                table: "StudentsExams",
                keyColumn: "Id",
                keyValue: "se-4",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 31, 12, 36, 36, 220, DateTimeKind.Local).AddTicks(2572));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "a-1",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 31, 12, 36, 36, 220, DateTimeKind.Local).AddTicks(2593));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "s-1",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 31, 12, 36, 36, 220, DateTimeKind.Local).AddTicks(2600));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "s-2",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 31, 12, 36, 36, 220, DateTimeKind.Local).AddTicks(2604));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "t-1",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 31, 12, 36, 36, 220, DateTimeKind.Local).AddTicks(2597));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "QuestionsFailed");

            migrationBuilder.DropColumn(
                name: "QuestionScoring",
                table: "QuestionsFailed");

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-101",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 31, 12, 30, 34, 667, DateTimeKind.Local).AddTicks(3642));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-2",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 31, 12, 30, 34, 667, DateTimeKind.Local).AddTicks(3703));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-21",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 31, 12, 30, 34, 667, DateTimeKind.Local).AddTicks(3723));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-22",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 31, 12, 30, 34, 667, DateTimeKind.Local).AddTicks(3726));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-23",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 31, 12, 30, 34, 667, DateTimeKind.Local).AddTicks(3729));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-24",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 31, 12, 30, 34, 667, DateTimeKind.Local).AddTicks(3733));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-3",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 31, 12, 30, 34, 667, DateTimeKind.Local).AddTicks(3706));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-31",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 31, 12, 30, 34, 667, DateTimeKind.Local).AddTicks(3736));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-32",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 31, 12, 30, 34, 667, DateTimeKind.Local).AddTicks(3738));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-33",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 31, 12, 30, 34, 667, DateTimeKind.Local).AddTicks(3741));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-34",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 31, 12, 30, 34, 667, DateTimeKind.Local).AddTicks(3747));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-4",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 31, 12, 30, 34, 667, DateTimeKind.Local).AddTicks(3720));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-41",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 31, 12, 30, 34, 667, DateTimeKind.Local).AddTicks(3750));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-42",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 31, 12, 30, 34, 667, DateTimeKind.Local).AddTicks(3752));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-43",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 31, 12, 30, 34, 667, DateTimeKind.Local).AddTicks(3755));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-44",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 31, 12, 30, 34, 667, DateTimeKind.Local).AddTicks(3758));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-51",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 31, 12, 30, 34, 667, DateTimeKind.Local).AddTicks(3761));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-52",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 31, 12, 30, 34, 667, DateTimeKind.Local).AddTicks(3764));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-53",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 31, 12, 30, 34, 667, DateTimeKind.Local).AddTicks(3767));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-54",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 31, 12, 30, 34, 667, DateTimeKind.Local).AddTicks(3772));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-61",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 31, 12, 30, 34, 667, DateTimeKind.Local).AddTicks(3775));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-62",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 31, 12, 30, 34, 667, DateTimeKind.Local).AddTicks(3777));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-63",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 31, 12, 30, 34, 667, DateTimeKind.Local).AddTicks(3780));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-64",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 31, 12, 30, 34, 667, DateTimeKind.Local).AddTicks(3783));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-71",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 31, 12, 30, 34, 667, DateTimeKind.Local).AddTicks(3786));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-72",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 31, 12, 30, 34, 667, DateTimeKind.Local).AddTicks(3788));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-73",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 31, 12, 30, 34, 667, DateTimeKind.Local).AddTicks(3791));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-74",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 31, 12, 30, 34, 667, DateTimeKind.Local).AddTicks(3795));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-81",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 31, 12, 30, 34, 667, DateTimeKind.Local).AddTicks(3798));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-82",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 31, 12, 30, 34, 667, DateTimeKind.Local).AddTicks(3801));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-83",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 31, 12, 30, 34, 667, DateTimeKind.Local).AddTicks(3803));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-84",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 31, 12, 30, 34, 667, DateTimeKind.Local).AddTicks(3805));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-91",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 31, 12, 30, 34, 667, DateTimeKind.Local).AddTicks(3808));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-92",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 31, 12, 30, 34, 667, DateTimeKind.Local).AddTicks(3810));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-93",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 31, 12, 30, 34, 667, DateTimeKind.Local).AddTicks(3813));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-94",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 31, 12, 30, 34, 667, DateTimeKind.Local).AddTicks(3817));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: "c-1",
                columns: new[] { "CourseEndingDate", "CourseStartingDate", "CreatedAt" },
                values: new object[] { new DateTime(2024, 6, 30, 12, 30, 34, 667, DateTimeKind.Local).AddTicks(4000), new DateTime(2024, 3, 31, 12, 30, 34, 667, DateTimeKind.Local).AddTicks(3998), new DateTime(2024, 3, 31, 12, 30, 34, 667, DateTimeKind.Local).AddTicks(3993) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: "c-2",
                columns: new[] { "CourseEndingDate", "CourseStartingDate", "CreatedAt" },
                values: new object[] { new DateTime(2024, 6, 30, 12, 30, 34, 667, DateTimeKind.Local).AddTicks(4012), new DateTime(2024, 3, 31, 12, 30, 34, 667, DateTimeKind.Local).AddTicks(4011), new DateTime(2024, 3, 31, 12, 30, 34, 667, DateTimeKind.Local).AddTicks(4009) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: "c-3",
                columns: new[] { "CourseEndingDate", "CourseStartingDate", "CreatedAt" },
                values: new object[] { new DateTime(2024, 6, 30, 12, 30, 34, 667, DateTimeKind.Local).AddTicks(4018), new DateTime(2024, 3, 31, 12, 30, 34, 667, DateTimeKind.Local).AddTicks(4017), new DateTime(2024, 3, 31, 12, 30, 34, 667, DateTimeKind.Local).AddTicks(4015) });

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: "e-1",
                columns: new[] { "CreatedAt", "StartExamDateTime" },
                values: new object[] { new DateTime(2024, 3, 31, 12, 30, 34, 667, DateTimeKind.Local).AddTicks(4048), new DateTime(2024, 4, 7, 12, 30, 34, 667, DateTimeKind.Local).AddTicks(4053) });

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: "e-2",
                columns: new[] { "CreatedAt", "StartExamDateTime" },
                values: new object[] { new DateTime(2024, 3, 31, 12, 30, 34, 667, DateTimeKind.Local).AddTicks(4058), new DateTime(2024, 4, 14, 12, 30, 34, 667, DateTimeKind.Local).AddTicks(4060) });

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: "e-3",
                columns: new[] { "CreatedAt", "StartExamDateTime" },
                values: new object[] { new DateTime(2024, 3, 31, 12, 30, 34, 667, DateTimeKind.Local).AddTicks(4063), new DateTime(2024, 4, 21, 12, 30, 34, 667, DateTimeKind.Local).AddTicks(4065) });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-1",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 31, 12, 30, 34, 667, DateTimeKind.Local).AddTicks(4091));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-2",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 31, 12, 30, 34, 667, DateTimeKind.Local).AddTicks(4098));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-3",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 31, 12, 30, 34, 667, DateTimeKind.Local).AddTicks(4103));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-4",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 31, 12, 30, 34, 667, DateTimeKind.Local).AddTicks(4107));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-5",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 31, 12, 30, 34, 667, DateTimeKind.Local).AddTicks(4111));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-6",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 31, 12, 30, 34, 667, DateTimeKind.Local).AddTicks(4114));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-7",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 31, 12, 30, 34, 667, DateTimeKind.Local).AddTicks(4117));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-8",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 31, 12, 30, 34, 667, DateTimeKind.Local).AddTicks(4120));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-9",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 31, 12, 30, 34, 667, DateTimeKind.Local).AddTicks(4123));

            migrationBuilder.UpdateData(
                table: "StudentsExams",
                keyColumn: "Id",
                keyValue: "se-1",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 31, 12, 30, 34, 667, DateTimeKind.Local).AddTicks(4156));

            migrationBuilder.UpdateData(
                table: "StudentsExams",
                keyColumn: "Id",
                keyValue: "se-2",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 31, 12, 30, 34, 667, DateTimeKind.Local).AddTicks(4163));

            migrationBuilder.UpdateData(
                table: "StudentsExams",
                keyColumn: "Id",
                keyValue: "se-3",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 31, 12, 30, 34, 667, DateTimeKind.Local).AddTicks(4166));

            migrationBuilder.UpdateData(
                table: "StudentsExams",
                keyColumn: "Id",
                keyValue: "se-4",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 31, 12, 30, 34, 667, DateTimeKind.Local).AddTicks(4169));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "a-1",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 31, 12, 30, 34, 667, DateTimeKind.Local).AddTicks(4192));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "s-1",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 31, 12, 30, 34, 667, DateTimeKind.Local).AddTicks(4199));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "s-2",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 31, 12, 30, 34, 667, DateTimeKind.Local).AddTicks(4226));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "t-1",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 31, 12, 30, 34, 667, DateTimeKind.Local).AddTicks(4196));
        }
    }
}
