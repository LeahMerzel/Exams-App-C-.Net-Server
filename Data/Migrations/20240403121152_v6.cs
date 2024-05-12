using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Exams_App_C__.Net_Server.Migrations
{
    /// <inheritdoc />
    public partial class v6 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "Questions",
                type: "nvarchar(300)",
                maxLength: 300,
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
                columns: new[] { "CreatedAt", "ImageUrl" },
                values: new object[] { new DateTime(2024, 4, 3, 15, 11, 52, 362, DateTimeKind.Local).AddTicks(4084), null });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-2",
                columns: new[] { "CreatedAt", "ImageUrl" },
                values: new object[] { new DateTime(2024, 4, 3, 15, 11, 52, 362, DateTimeKind.Local).AddTicks(4090), null });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-3",
                columns: new[] { "CreatedAt", "ImageUrl" },
                values: new object[] { new DateTime(2024, 4, 3, 15, 11, 52, 362, DateTimeKind.Local).AddTicks(4096), null });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-4",
                columns: new[] { "CreatedAt", "ImageUrl" },
                values: new object[] { new DateTime(2024, 4, 3, 15, 11, 52, 362, DateTimeKind.Local).AddTicks(4101), null });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-5",
                columns: new[] { "CreatedAt", "ImageUrl" },
                values: new object[] { new DateTime(2024, 4, 3, 15, 11, 52, 362, DateTimeKind.Local).AddTicks(4107), null });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-6",
                columns: new[] { "CreatedAt", "ImageUrl" },
                values: new object[] { new DateTime(2024, 4, 3, 15, 11, 52, 362, DateTimeKind.Local).AddTicks(4111), null });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-7",
                columns: new[] { "CreatedAt", "ImageUrl" },
                values: new object[] { new DateTime(2024, 4, 3, 15, 11, 52, 362, DateTimeKind.Local).AddTicks(4115), null });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-8",
                columns: new[] { "CreatedAt", "ImageUrl" },
                values: new object[] { new DateTime(2024, 4, 3, 15, 11, 52, 362, DateTimeKind.Local).AddTicks(4121), null });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-9",
                columns: new[] { "CreatedAt", "ImageUrl" },
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "Questions");

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-101",
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 14, 27, 1, 45, DateTimeKind.Local).AddTicks(7055));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-2",
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 14, 27, 1, 45, DateTimeKind.Local).AddTicks(7123));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-21",
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 14, 27, 1, 45, DateTimeKind.Local).AddTicks(7138));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-22",
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 14, 27, 1, 45, DateTimeKind.Local).AddTicks(7143));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-23",
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 14, 27, 1, 45, DateTimeKind.Local).AddTicks(7162));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-24",
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 14, 27, 1, 45, DateTimeKind.Local).AddTicks(7168));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-3",
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 14, 27, 1, 45, DateTimeKind.Local).AddTicks(7129));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-31",
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 14, 27, 1, 45, DateTimeKind.Local).AddTicks(7172));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-32",
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 14, 27, 1, 45, DateTimeKind.Local).AddTicks(7177));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-33",
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 14, 27, 1, 45, DateTimeKind.Local).AddTicks(7182));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-34",
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 14, 27, 1, 45, DateTimeKind.Local).AddTicks(7236));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-4",
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 14, 27, 1, 45, DateTimeKind.Local).AddTicks(7134));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-41",
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 14, 27, 1, 45, DateTimeKind.Local).AddTicks(7241));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-42",
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 14, 27, 1, 45, DateTimeKind.Local).AddTicks(7246));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-43",
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 14, 27, 1, 45, DateTimeKind.Local).AddTicks(7254));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-44",
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 14, 27, 1, 45, DateTimeKind.Local).AddTicks(7259));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-51",
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 14, 27, 1, 45, DateTimeKind.Local).AddTicks(7264));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-52",
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 14, 27, 1, 45, DateTimeKind.Local).AddTicks(7268));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-53",
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 14, 27, 1, 45, DateTimeKind.Local).AddTicks(7272));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-54",
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 14, 27, 1, 45, DateTimeKind.Local).AddTicks(7277));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-61",
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 14, 27, 1, 45, DateTimeKind.Local).AddTicks(7282));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-62",
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 14, 27, 1, 45, DateTimeKind.Local).AddTicks(7286));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-63",
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 14, 27, 1, 45, DateTimeKind.Local).AddTicks(7294));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-64",
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 14, 27, 1, 45, DateTimeKind.Local).AddTicks(7299));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-71",
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 14, 27, 1, 45, DateTimeKind.Local).AddTicks(7303));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-72",
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 14, 27, 1, 45, DateTimeKind.Local).AddTicks(7308));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-73",
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 14, 27, 1, 45, DateTimeKind.Local).AddTicks(7312));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-74",
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 14, 27, 1, 45, DateTimeKind.Local).AddTicks(7316));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-81",
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 14, 27, 1, 45, DateTimeKind.Local).AddTicks(7321));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-82",
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 14, 27, 1, 45, DateTimeKind.Local).AddTicks(7325));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-83",
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 14, 27, 1, 45, DateTimeKind.Local).AddTicks(7334));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-84",
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 14, 27, 1, 45, DateTimeKind.Local).AddTicks(7338));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-91",
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 14, 27, 1, 45, DateTimeKind.Local).AddTicks(7343));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-92",
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 14, 27, 1, 45, DateTimeKind.Local).AddTicks(7347));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-93",
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 14, 27, 1, 45, DateTimeKind.Local).AddTicks(7351));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-94",
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 14, 27, 1, 45, DateTimeKind.Local).AddTicks(7356));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: "c-1",
                columns: new[] { "CourseEndingDate", "CourseStartingDate", "CreatedAt" },
                values: new object[] { new DateTime(2024, 7, 3, 14, 27, 1, 45, DateTimeKind.Local).AddTicks(7584), new DateTime(2024, 4, 3, 14, 27, 1, 45, DateTimeKind.Local).AddTicks(7581), new DateTime(2024, 4, 3, 14, 27, 1, 45, DateTimeKind.Local).AddTicks(7575) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: "c-2",
                columns: new[] { "CourseEndingDate", "CourseStartingDate", "CreatedAt" },
                values: new object[] { new DateTime(2024, 7, 3, 14, 27, 1, 45, DateTimeKind.Local).AddTicks(7602), new DateTime(2024, 4, 3, 14, 27, 1, 45, DateTimeKind.Local).AddTicks(7600), new DateTime(2024, 4, 3, 14, 27, 1, 45, DateTimeKind.Local).AddTicks(7596) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: "c-3",
                columns: new[] { "CourseEndingDate", "CourseStartingDate", "CreatedAt" },
                values: new object[] { new DateTime(2024, 7, 3, 14, 27, 1, 45, DateTimeKind.Local).AddTicks(7615), new DateTime(2024, 4, 3, 14, 27, 1, 45, DateTimeKind.Local).AddTicks(7613), new DateTime(2024, 4, 3, 14, 27, 1, 45, DateTimeKind.Local).AddTicks(7610) });

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: "e-1",
                columns: new[] { "CreatedAt", "StartExamDateTime" },
                values: new object[] { new DateTime(2024, 4, 3, 14, 27, 1, 45, DateTimeKind.Local).AddTicks(7660), new DateTime(2024, 4, 10, 14, 27, 1, 45, DateTimeKind.Local).AddTicks(7667) });

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: "e-2",
                columns: new[] { "CreatedAt", "StartExamDateTime" },
                values: new object[] { new DateTime(2024, 4, 3, 14, 27, 1, 45, DateTimeKind.Local).AddTicks(7675), new DateTime(2024, 4, 17, 14, 27, 1, 45, DateTimeKind.Local).AddTicks(7679) });

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: "e-3",
                columns: new[] { "CreatedAt", "StartExamDateTime" },
                values: new object[] { new DateTime(2024, 4, 3, 14, 27, 1, 45, DateTimeKind.Local).AddTicks(7685), new DateTime(2024, 4, 24, 14, 27, 1, 45, DateTimeKind.Local).AddTicks(7688) });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-1",
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 14, 27, 1, 45, DateTimeKind.Local).AddTicks(7733));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-2",
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 14, 27, 1, 45, DateTimeKind.Local).AddTicks(7742));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-3",
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 14, 27, 1, 45, DateTimeKind.Local).AddTicks(7750));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-4",
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 14, 27, 1, 45, DateTimeKind.Local).AddTicks(7791));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-5",
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 14, 27, 1, 45, DateTimeKind.Local).AddTicks(7803));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-6",
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 14, 27, 1, 45, DateTimeKind.Local).AddTicks(7808));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-7",
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 14, 27, 1, 45, DateTimeKind.Local).AddTicks(7813));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-8",
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 14, 27, 1, 45, DateTimeKind.Local).AddTicks(7817));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-9",
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 14, 27, 1, 45, DateTimeKind.Local).AddTicks(7822));

            migrationBuilder.UpdateData(
                table: "StudentsExams",
                keyColumn: "Id",
                keyValue: "se-1",
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 14, 27, 1, 45, DateTimeKind.Local).AddTicks(7872));

            migrationBuilder.UpdateData(
                table: "StudentsExams",
                keyColumn: "Id",
                keyValue: "se-2",
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 14, 27, 1, 45, DateTimeKind.Local).AddTicks(7882));

            migrationBuilder.UpdateData(
                table: "StudentsExams",
                keyColumn: "Id",
                keyValue: "se-3",
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 14, 27, 1, 45, DateTimeKind.Local).AddTicks(7888));

            migrationBuilder.UpdateData(
                table: "StudentsExams",
                keyColumn: "Id",
                keyValue: "se-4",
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 14, 27, 1, 45, DateTimeKind.Local).AddTicks(7897));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "a-1",
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 14, 27, 1, 45, DateTimeKind.Local).AddTicks(7937));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "s-1",
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 14, 27, 1, 45, DateTimeKind.Local).AddTicks(7951));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "s-2",
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 14, 27, 1, 45, DateTimeKind.Local).AddTicks(7958));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "t-1",
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 14, 27, 1, 45, DateTimeKind.Local).AddTicks(7945));
        }
    }
}
