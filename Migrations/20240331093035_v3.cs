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
            migrationBuilder.DropColumn(
                name: "QuestionsFailed",
                table: "StudentsExams");

            migrationBuilder.CreateTable(
                name: "QuestionsFailed",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    QuestionNumber = table.Column<int>(type: "int", nullable: false),
                    QuestionDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CorrectAnswerNumber = table.Column<int>(type: "int", nullable: false),
                    CorrectAnswerDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ChosenWrongAnswerNumber = table.Column<int>(type: "int", nullable: false),
                    ChosenWrongAnswerDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StudentExamId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QuestionsFailed", x => x.Id);
                    table.ForeignKey(
                        name: "FK_QuestionsFailed_StudentsExams_StudentExamId",
                        column: x => x.StudentExamId,
                        principalTable: "StudentsExams",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_QuestionsFailed_StudentExamId",
                table: "QuestionsFailed",
                column: "StudentExamId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "QuestionsFailed");

            migrationBuilder.AddColumn<string>(
                name: "QuestionsFailed",
                table: "StudentsExams",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-101",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 31, 12, 1, 22, 178, DateTimeKind.Local).AddTicks(7669));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-2",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 31, 12, 1, 22, 178, DateTimeKind.Local).AddTicks(7732));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-21",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 31, 12, 1, 22, 178, DateTimeKind.Local).AddTicks(7752));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-22",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 31, 12, 1, 22, 178, DateTimeKind.Local).AddTicks(7755));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-23",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 31, 12, 1, 22, 178, DateTimeKind.Local).AddTicks(7757));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-24",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 31, 12, 1, 22, 178, DateTimeKind.Local).AddTicks(7790));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-3",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 31, 12, 1, 22, 178, DateTimeKind.Local).AddTicks(7746));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-31",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 31, 12, 1, 22, 178, DateTimeKind.Local).AddTicks(7793));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-32",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 31, 12, 1, 22, 178, DateTimeKind.Local).AddTicks(7795));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-33",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 31, 12, 1, 22, 178, DateTimeKind.Local).AddTicks(7800));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-34",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 31, 12, 1, 22, 178, DateTimeKind.Local).AddTicks(7802));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-4",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 31, 12, 1, 22, 178, DateTimeKind.Local).AddTicks(7750));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-41",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 31, 12, 1, 22, 178, DateTimeKind.Local).AddTicks(7805));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-42",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 31, 12, 1, 22, 178, DateTimeKind.Local).AddTicks(7807));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-43",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 31, 12, 1, 22, 178, DateTimeKind.Local).AddTicks(7809));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-44",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 31, 12, 1, 22, 178, DateTimeKind.Local).AddTicks(7812));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-51",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 31, 12, 1, 22, 178, DateTimeKind.Local).AddTicks(7815));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-52",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 31, 12, 1, 22, 178, DateTimeKind.Local).AddTicks(7817));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-53",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 31, 12, 1, 22, 178, DateTimeKind.Local).AddTicks(7821));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-54",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 31, 12, 1, 22, 178, DateTimeKind.Local).AddTicks(7824));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-61",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 31, 12, 1, 22, 178, DateTimeKind.Local).AddTicks(7826));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-62",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 31, 12, 1, 22, 178, DateTimeKind.Local).AddTicks(7829));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-63",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 31, 12, 1, 22, 178, DateTimeKind.Local).AddTicks(7831));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-64",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 31, 12, 1, 22, 178, DateTimeKind.Local).AddTicks(7834));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-71",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 31, 12, 1, 22, 178, DateTimeKind.Local).AddTicks(7836));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-72",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 31, 12, 1, 22, 178, DateTimeKind.Local).AddTicks(7839));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-73",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 31, 12, 1, 22, 178, DateTimeKind.Local).AddTicks(7843));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-74",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 31, 12, 1, 22, 178, DateTimeKind.Local).AddTicks(7845));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-81",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 31, 12, 1, 22, 178, DateTimeKind.Local).AddTicks(7848));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-82",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 31, 12, 1, 22, 178, DateTimeKind.Local).AddTicks(7850));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-83",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 31, 12, 1, 22, 178, DateTimeKind.Local).AddTicks(7853));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-84",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 31, 12, 1, 22, 178, DateTimeKind.Local).AddTicks(7855));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-91",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 31, 12, 1, 22, 178, DateTimeKind.Local).AddTicks(7857));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-92",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 31, 12, 1, 22, 178, DateTimeKind.Local).AddTicks(7860));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-93",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 31, 12, 1, 22, 178, DateTimeKind.Local).AddTicks(7864));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: "a-94",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 31, 12, 1, 22, 178, DateTimeKind.Local).AddTicks(7867));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: "c-1",
                columns: new[] { "CourseEndingDate", "CourseStartingDate", "CreatedAt" },
                values: new object[] { new DateTime(2024, 6, 30, 12, 1, 22, 178, DateTimeKind.Local).AddTicks(7996), new DateTime(2024, 3, 31, 12, 1, 22, 178, DateTimeKind.Local).AddTicks(7995), new DateTime(2024, 3, 31, 12, 1, 22, 178, DateTimeKind.Local).AddTicks(7989) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: "c-2",
                columns: new[] { "CourseEndingDate", "CourseStartingDate", "CreatedAt" },
                values: new object[] { new DateTime(2024, 6, 30, 12, 1, 22, 178, DateTimeKind.Local).AddTicks(8010), new DateTime(2024, 3, 31, 12, 1, 22, 178, DateTimeKind.Local).AddTicks(8009), new DateTime(2024, 3, 31, 12, 1, 22, 178, DateTimeKind.Local).AddTicks(8007) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: "c-3",
                columns: new[] { "CourseEndingDate", "CourseStartingDate", "CreatedAt" },
                values: new object[] { new DateTime(2024, 6, 30, 12, 1, 22, 178, DateTimeKind.Local).AddTicks(8016), new DateTime(2024, 3, 31, 12, 1, 22, 178, DateTimeKind.Local).AddTicks(8014), new DateTime(2024, 3, 31, 12, 1, 22, 178, DateTimeKind.Local).AddTicks(8013) });

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: "e-1",
                columns: new[] { "CreatedAt", "StartExamDateTime" },
                values: new object[] { new DateTime(2024, 3, 31, 12, 1, 22, 178, DateTimeKind.Local).AddTicks(8044), new DateTime(2024, 4, 7, 12, 1, 22, 178, DateTimeKind.Local).AddTicks(8050) });

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: "e-2",
                columns: new[] { "CreatedAt", "StartExamDateTime" },
                values: new object[] { new DateTime(2024, 3, 31, 12, 1, 22, 178, DateTimeKind.Local).AddTicks(8057), new DateTime(2024, 4, 14, 12, 1, 22, 178, DateTimeKind.Local).AddTicks(8059) });

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: "e-3",
                columns: new[] { "CreatedAt", "StartExamDateTime" },
                values: new object[] { new DateTime(2024, 3, 31, 12, 1, 22, 178, DateTimeKind.Local).AddTicks(8062), new DateTime(2024, 4, 21, 12, 1, 22, 178, DateTimeKind.Local).AddTicks(8064) });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-1",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 31, 12, 1, 22, 178, DateTimeKind.Local).AddTicks(8109));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-2",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 31, 12, 1, 22, 178, DateTimeKind.Local).AddTicks(8115));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-3",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 31, 12, 1, 22, 178, DateTimeKind.Local).AddTicks(8119));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-4",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 31, 12, 1, 22, 178, DateTimeKind.Local).AddTicks(8124));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-5",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 31, 12, 1, 22, 178, DateTimeKind.Local).AddTicks(8128));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-6",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 31, 12, 1, 22, 178, DateTimeKind.Local).AddTicks(8131));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-7",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 31, 12, 1, 22, 178, DateTimeKind.Local).AddTicks(8134));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-8",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 31, 12, 1, 22, 178, DateTimeKind.Local).AddTicks(8137));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: "q-9",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 31, 12, 1, 22, 178, DateTimeKind.Local).AddTicks(8142));

            migrationBuilder.UpdateData(
                table: "StudentsExams",
                keyColumn: "Id",
                keyValue: "se-1",
                columns: new[] { "CreatedAt", "QuestionsFailed" },
                values: new object[] { new DateTime(2024, 3, 31, 12, 1, 22, 178, DateTimeKind.Local).AddTicks(8167), null });

            migrationBuilder.UpdateData(
                table: "StudentsExams",
                keyColumn: "Id",
                keyValue: "se-2",
                columns: new[] { "CreatedAt", "QuestionsFailed" },
                values: new object[] { new DateTime(2024, 3, 31, 12, 1, 22, 178, DateTimeKind.Local).AddTicks(8173), null });

            migrationBuilder.UpdateData(
                table: "StudentsExams",
                keyColumn: "Id",
                keyValue: "se-3",
                columns: new[] { "CreatedAt", "QuestionsFailed" },
                values: new object[] { new DateTime(2024, 3, 31, 12, 1, 22, 178, DateTimeKind.Local).AddTicks(8176), null });

            migrationBuilder.UpdateData(
                table: "StudentsExams",
                keyColumn: "Id",
                keyValue: "se-4",
                columns: new[] { "CreatedAt", "QuestionsFailed" },
                values: new object[] { new DateTime(2024, 3, 31, 12, 1, 22, 178, DateTimeKind.Local).AddTicks(8179), null });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "a-1",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 31, 12, 1, 22, 178, DateTimeKind.Local).AddTicks(8201));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "s-1",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 31, 12, 1, 22, 178, DateTimeKind.Local).AddTicks(8209));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "s-2",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 31, 12, 1, 22, 178, DateTimeKind.Local).AddTicks(8215));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "t-1",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 31, 12, 1, 22, 178, DateTimeKind.Local).AddTicks(8205));
        }
    }
}
