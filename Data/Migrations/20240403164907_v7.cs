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
            migrationBuilder.DropColumn(
                name: "IsImage",
                table: "Questions");

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-101",
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 19, 49, 6, 583, DateTimeKind.Local).AddTicks(1796));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-2",
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 19, 49, 6, 583, DateTimeKind.Local).AddTicks(1862));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-21",
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 19, 49, 6, 583, DateTimeKind.Local).AddTicks(1873));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-22",
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 19, 49, 6, 583, DateTimeKind.Local).AddTicks(1889));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-23",
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 19, 49, 6, 583, DateTimeKind.Local).AddTicks(1892));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-24",
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 19, 49, 6, 583, DateTimeKind.Local).AddTicks(1895));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-3",
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 19, 49, 6, 583, DateTimeKind.Local).AddTicks(1866));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-31",
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 19, 49, 6, 583, DateTimeKind.Local).AddTicks(1898));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-32",
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 19, 49, 6, 583, DateTimeKind.Local).AddTicks(1902));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-33",
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 19, 49, 6, 583, DateTimeKind.Local).AddTicks(1905));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-34",
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 19, 49, 6, 583, DateTimeKind.Local).AddTicks(1908));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-4",
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 19, 49, 6, 583, DateTimeKind.Local).AddTicks(1870));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-41",
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 19, 49, 6, 583, DateTimeKind.Local).AddTicks(1911));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-42",
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 19, 49, 6, 583, DateTimeKind.Local).AddTicks(1916));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-43",
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 19, 49, 6, 583, DateTimeKind.Local).AddTicks(1920));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-44",
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 19, 49, 6, 583, DateTimeKind.Local).AddTicks(1923));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-51",
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 19, 49, 6, 583, DateTimeKind.Local).AddTicks(1926));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-52",
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 19, 49, 6, 583, DateTimeKind.Local).AddTicks(1929));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-53",
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 19, 49, 6, 583, DateTimeKind.Local).AddTicks(1931));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-54",
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 19, 49, 6, 583, DateTimeKind.Local).AddTicks(1934));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-61",
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 19, 49, 6, 583, DateTimeKind.Local).AddTicks(1938));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-62",
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 19, 49, 6, 583, DateTimeKind.Local).AddTicks(1943));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-63",
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 19, 49, 6, 583, DateTimeKind.Local).AddTicks(1947));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-64",
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 19, 49, 6, 583, DateTimeKind.Local).AddTicks(1950));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-71",
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 19, 49, 6, 583, DateTimeKind.Local).AddTicks(1953));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-72",
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 19, 49, 6, 583, DateTimeKind.Local).AddTicks(1956));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-73",
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 19, 49, 6, 583, DateTimeKind.Local).AddTicks(1959));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-74",
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 19, 49, 6, 583, DateTimeKind.Local).AddTicks(1962));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-81",
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 19, 49, 6, 583, DateTimeKind.Local).AddTicks(1965));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-82",
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 19, 49, 6, 583, DateTimeKind.Local).AddTicks(1971));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-83",
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 19, 49, 6, 583, DateTimeKind.Local).AddTicks(1974));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-84",
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 19, 49, 6, 583, DateTimeKind.Local).AddTicks(1977));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-91",
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 19, 49, 6, 583, DateTimeKind.Local).AddTicks(1980));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-92",
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 19, 49, 6, 583, DateTimeKind.Local).AddTicks(1983));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-93",
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 19, 49, 6, 583, DateTimeKind.Local).AddTicks(1987));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-94",
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 19, 49, 6, 583, DateTimeKind.Local).AddTicks(1990));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: "c-1",
                columns: new[] { "CourseEndingDate", "CourseStartingDate", "CreatedAt" },
                values: new object[] { new DateTime(2024, 7, 3, 19, 49, 6, 583, DateTimeKind.Local).AddTicks(2216), new DateTime(2024, 4, 3, 19, 49, 6, 583, DateTimeKind.Local).AddTicks(2214), new DateTime(2024, 4, 3, 19, 49, 6, 583, DateTimeKind.Local).AddTicks(2204) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: "c-2",
                columns: new[] { "CourseEndingDate", "CourseStartingDate", "CreatedAt" },
                values: new object[] { new DateTime(2024, 7, 3, 19, 49, 6, 583, DateTimeKind.Local).AddTicks(2231), new DateTime(2024, 4, 3, 19, 49, 6, 583, DateTimeKind.Local).AddTicks(2230), new DateTime(2024, 4, 3, 19, 49, 6, 583, DateTimeKind.Local).AddTicks(2228) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: "c-3",
                columns: new[] { "CourseEndingDate", "CourseStartingDate", "CreatedAt" },
                values: new object[] { new DateTime(2024, 7, 3, 19, 49, 6, 583, DateTimeKind.Local).AddTicks(2238), new DateTime(2024, 4, 3, 19, 49, 6, 583, DateTimeKind.Local).AddTicks(2236), new DateTime(2024, 4, 3, 19, 49, 6, 583, DateTimeKind.Local).AddTicks(2235) });

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: "e-1",
                columns: new[] { "CreatedAt", "StartExamDateTime" },
                values: new object[] { new DateTime(2024, 4, 3, 19, 49, 6, 583, DateTimeKind.Local).AddTicks(2268), new DateTime(2024, 4, 10, 19, 49, 6, 583, DateTimeKind.Local).AddTicks(2274) });

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: "e-2",
                columns: new[] { "CreatedAt", "StartExamDateTime" },
                values: new object[] { new DateTime(2024, 4, 3, 19, 49, 6, 583, DateTimeKind.Local).AddTicks(2280), new DateTime(2024, 4, 17, 19, 49, 6, 583, DateTimeKind.Local).AddTicks(2283) });

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: "e-3",
                columns: new[] { "CreatedAt", "StartExamDateTime" },
                values: new object[] { new DateTime(2024, 4, 3, 19, 49, 6, 583, DateTimeKind.Local).AddTicks(2287), new DateTime(2024, 4, 24, 19, 49, 6, 583, DateTimeKind.Local).AddTicks(2290) });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-1",
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 19, 49, 6, 583, DateTimeKind.Local).AddTicks(2318));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-2",
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 19, 49, 6, 583, DateTimeKind.Local).AddTicks(2325));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-3",
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 19, 49, 6, 583, DateTimeKind.Local).AddTicks(2331));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-4",
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 19, 49, 6, 583, DateTimeKind.Local).AddTicks(2339));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-5",
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 19, 49, 6, 583, DateTimeKind.Local).AddTicks(2344));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-6",
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 19, 49, 6, 583, DateTimeKind.Local).AddTicks(2347));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-7",
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 19, 49, 6, 583, DateTimeKind.Local).AddTicks(2351));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-8",
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 19, 49, 6, 583, DateTimeKind.Local).AddTicks(2355));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-9",
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 19, 49, 6, 583, DateTimeKind.Local).AddTicks(2358));

            migrationBuilder.UpdateData(
                table: "StudentsExams",
                keyColumn: "Id",
                keyValue: "se-1",
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 19, 49, 6, 583, DateTimeKind.Local).AddTicks(2390));

            migrationBuilder.UpdateData(
                table: "StudentsExams",
                keyColumn: "Id",
                keyValue: "se-2",
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 19, 49, 6, 583, DateTimeKind.Local).AddTicks(2398));

            migrationBuilder.UpdateData(
                table: "StudentsExams",
                keyColumn: "Id",
                keyValue: "se-3",
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 19, 49, 6, 583, DateTimeKind.Local).AddTicks(2405));

            migrationBuilder.UpdateData(
                table: "StudentsExams",
                keyColumn: "Id",
                keyValue: "se-4",
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 19, 49, 6, 583, DateTimeKind.Local).AddTicks(2408));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "a-1",
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 19, 49, 6, 583, DateTimeKind.Local).AddTicks(2438));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "s-1",
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 19, 49, 6, 583, DateTimeKind.Local).AddTicks(2449));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "s-2",
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 19, 49, 6, 583, DateTimeKind.Local).AddTicks(2477));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "t-1",
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 19, 49, 6, 583, DateTimeKind.Local).AddTicks(2445));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsImage",
                table: "Questions",
                type: "bit",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-101",
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 15, 11, 52, 362, DateTimeKind.Local).AddTicks(3520));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-2",
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 15, 11, 52, 362, DateTimeKind.Local).AddTicks(3604));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-21",
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 15, 11, 52, 362, DateTimeKind.Local).AddTicks(3617));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-22",
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 15, 11, 52, 362, DateTimeKind.Local).AddTicks(3621));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-23",
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 15, 11, 52, 362, DateTimeKind.Local).AddTicks(3625));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-24",
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 15, 11, 52, 362, DateTimeKind.Local).AddTicks(3629));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-3",
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 15, 11, 52, 362, DateTimeKind.Local).AddTicks(3609));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-31",
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 15, 11, 52, 362, DateTimeKind.Local).AddTicks(3633));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-32",
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 15, 11, 52, 362, DateTimeKind.Local).AddTicks(3640));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-33",
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 15, 11, 52, 362, DateTimeKind.Local).AddTicks(3644));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-34",
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 15, 11, 52, 362, DateTimeKind.Local).AddTicks(3647));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-4",
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 15, 11, 52, 362, DateTimeKind.Local).AddTicks(3613));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-41",
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 15, 11, 52, 362, DateTimeKind.Local).AddTicks(3651));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-42",
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 15, 11, 52, 362, DateTimeKind.Local).AddTicks(3655));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-43",
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 15, 11, 52, 362, DateTimeKind.Local).AddTicks(3659));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-44",
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 15, 11, 52, 362, DateTimeKind.Local).AddTicks(3663));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-51",
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 15, 11, 52, 362, DateTimeKind.Local).AddTicks(3667));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-52",
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 15, 11, 52, 362, DateTimeKind.Local).AddTicks(3673));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-53",
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 15, 11, 52, 362, DateTimeKind.Local).AddTicks(3676));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-54",
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 15, 11, 52, 362, DateTimeKind.Local).AddTicks(3680));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-61",
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 15, 11, 52, 362, DateTimeKind.Local).AddTicks(3683));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-62",
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 15, 11, 52, 362, DateTimeKind.Local).AddTicks(3686));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-63",
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 15, 11, 52, 362, DateTimeKind.Local).AddTicks(3690));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-64",
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 15, 11, 52, 362, DateTimeKind.Local).AddTicks(3693));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-71",
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 15, 11, 52, 362, DateTimeKind.Local).AddTicks(3696));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-72",
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 15, 11, 52, 362, DateTimeKind.Local).AddTicks(3702));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-73",
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 15, 11, 52, 362, DateTimeKind.Local).AddTicks(3706));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-74",
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 15, 11, 52, 362, DateTimeKind.Local).AddTicks(3709));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-81",
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 15, 11, 52, 362, DateTimeKind.Local).AddTicks(3712));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-82",
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 15, 11, 52, 362, DateTimeKind.Local).AddTicks(3715));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-83",
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 15, 11, 52, 362, DateTimeKind.Local).AddTicks(3719));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-84",
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 15, 11, 52, 362, DateTimeKind.Local).AddTicks(3722));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-91",
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 15, 11, 52, 362, DateTimeKind.Local).AddTicks(3725));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-92",
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 15, 11, 52, 362, DateTimeKind.Local).AddTicks(3731));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-93",
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 15, 11, 52, 362, DateTimeKind.Local).AddTicks(3735));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-94",
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 15, 11, 52, 362, DateTimeKind.Local).AddTicks(3738));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: "c-1",
                columns: new[] { "CourseEndingDate", "CourseStartingDate", "CreatedAt" },
                values: new object[] { new DateTime(2024, 7, 3, 15, 11, 52, 362, DateTimeKind.Local).AddTicks(3967), new DateTime(2024, 4, 3, 15, 11, 52, 362, DateTimeKind.Local).AddTicks(3966), new DateTime(2024, 4, 3, 15, 11, 52, 362, DateTimeKind.Local).AddTicks(3956) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: "c-2",
                columns: new[] { "CourseEndingDate", "CourseStartingDate", "CreatedAt" },
                values: new object[] { new DateTime(2024, 7, 3, 15, 11, 52, 362, DateTimeKind.Local).AddTicks(3981), new DateTime(2024, 4, 3, 15, 11, 52, 362, DateTimeKind.Local).AddTicks(3980), new DateTime(2024, 4, 3, 15, 11, 52, 362, DateTimeKind.Local).AddTicks(3977) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: "c-3",
                columns: new[] { "CourseEndingDate", "CourseStartingDate", "CreatedAt" },
                values: new object[] { new DateTime(2024, 7, 3, 15, 11, 52, 362, DateTimeKind.Local).AddTicks(3988), new DateTime(2024, 4, 3, 15, 11, 52, 362, DateTimeKind.Local).AddTicks(3987), new DateTime(2024, 4, 3, 15, 11, 52, 362, DateTimeKind.Local).AddTicks(3985) });

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: "e-1",
                columns: new[] { "CreatedAt", "StartExamDateTime" },
                values: new object[] { new DateTime(2024, 4, 3, 15, 11, 52, 362, DateTimeKind.Local).AddTicks(4022), new DateTime(2024, 4, 10, 15, 11, 52, 362, DateTimeKind.Local).AddTicks(4028) });

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: "e-2",
                columns: new[] { "CreatedAt", "StartExamDateTime" },
                values: new object[] { new DateTime(2024, 4, 3, 15, 11, 52, 362, DateTimeKind.Local).AddTicks(4035), new DateTime(2024, 4, 17, 15, 11, 52, 362, DateTimeKind.Local).AddTicks(4038) });

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: "e-3",
                columns: new[] { "CreatedAt", "StartExamDateTime" },
                values: new object[] { new DateTime(2024, 4, 3, 15, 11, 52, 362, DateTimeKind.Local).AddTicks(4045), new DateTime(2024, 4, 24, 15, 11, 52, 362, DateTimeKind.Local).AddTicks(4047) });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-1",
                columns: new[] { "CreatedAt", "IsImage" },
                values: new object[] { new DateTime(2024, 4, 3, 15, 11, 52, 362, DateTimeKind.Local).AddTicks(4084), null });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-2",
                columns: new[] { "CreatedAt", "IsImage" },
                values: new object[] { new DateTime(2024, 4, 3, 15, 11, 52, 362, DateTimeKind.Local).AddTicks(4090), null });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-3",
                columns: new[] { "CreatedAt", "IsImage" },
                values: new object[] { new DateTime(2024, 4, 3, 15, 11, 52, 362, DateTimeKind.Local).AddTicks(4096), null });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-4",
                columns: new[] { "CreatedAt", "IsImage" },
                values: new object[] { new DateTime(2024, 4, 3, 15, 11, 52, 362, DateTimeKind.Local).AddTicks(4101), null });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-5",
                columns: new[] { "CreatedAt", "IsImage" },
                values: new object[] { new DateTime(2024, 4, 3, 15, 11, 52, 362, DateTimeKind.Local).AddTicks(4107), null });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-6",
                columns: new[] { "CreatedAt", "IsImage" },
                values: new object[] { new DateTime(2024, 4, 3, 15, 11, 52, 362, DateTimeKind.Local).AddTicks(4111), null });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-7",
                columns: new[] { "CreatedAt", "IsImage" },
                values: new object[] { new DateTime(2024, 4, 3, 15, 11, 52, 362, DateTimeKind.Local).AddTicks(4115), null });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-8",
                columns: new[] { "CreatedAt", "IsImage" },
                values: new object[] { new DateTime(2024, 4, 3, 15, 11, 52, 362, DateTimeKind.Local).AddTicks(4121), null });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-9",
                columns: new[] { "CreatedAt", "IsImage" },
                values: new object[] { new DateTime(2024, 4, 3, 15, 11, 52, 362, DateTimeKind.Local).AddTicks(4125), null });

            migrationBuilder.UpdateData(
                table: "StudentsExams",
                keyColumn: "Id",
                keyValue: "se-1",
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 15, 11, 52, 362, DateTimeKind.Local).AddTicks(4161));

            migrationBuilder.UpdateData(
                table: "StudentsExams",
                keyColumn: "Id",
                keyValue: "se-2",
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 15, 11, 52, 362, DateTimeKind.Local).AddTicks(4168));

            migrationBuilder.UpdateData(
                table: "StudentsExams",
                keyColumn: "Id",
                keyValue: "se-3",
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 15, 11, 52, 362, DateTimeKind.Local).AddTicks(4172));

            migrationBuilder.UpdateData(
                table: "StudentsExams",
                keyColumn: "Id",
                keyValue: "se-4",
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 15, 11, 52, 362, DateTimeKind.Local).AddTicks(4175));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "a-1",
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 15, 11, 52, 362, DateTimeKind.Local).AddTicks(4211));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "s-1",
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 15, 11, 52, 362, DateTimeKind.Local).AddTicks(4224));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "s-2",
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 15, 11, 52, 362, DateTimeKind.Local).AddTicks(4229));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "t-1",
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 15, 11, 52, 362, DateTimeKind.Local).AddTicks(4217));
        }
    }
}
