﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Exams_App_C__.Net_Server.Migrations
{
    /// <inheritdoc />
    public partial class v1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Courses",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CourseName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CourseDescription = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    CourseStartingDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CourseEndingDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Courses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserRole = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CourseId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    StudentGradeAvg = table.Column<float>(type: "real", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Users_Courses_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Courses",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Exams",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ExamName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    TeacherName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TeacherId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CourseId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ExamDescription = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    StartExamDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsOrderQuestionsRandom = table.Column<bool>(type: "bit", nullable: true),
                    ExamGradeAvg = table.Column<float>(type: "real", nullable: true),
                    ExamDurationInMinutes = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Exams", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Exams_Courses_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Courses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Exams_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Questions",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    QuestionNumber = table.Column<int>(type: "int", nullable: false),
                    QuestionDescription = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: false),
                    IsImage = table.Column<bool>(type: "bit", nullable: true),
                    CorrectAnswerDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsOrderAnswersRandom = table.Column<bool>(type: "bit", nullable: true),
                    QuestionScoring = table.Column<int>(type: "int", nullable: false),
                    ExamId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Questions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Questions_Exams_ExamId",
                        column: x => x.ExamId,
                        principalTable: "Exams",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "StudentsExams",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    StudentName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Grade = table.Column<int>(type: "int", nullable: false),
                    QuestionsFailed = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StudentId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ExamId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ExamStartTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    WasExamLoggedInToByStudent = table.Column<bool>(type: "bit", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentsExams", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StudentsExams_Exams_ExamId",
                        column: x => x.ExamId,
                        principalTable: "Exams",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StudentsExams_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Answers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AnswerNumber = table.Column<int>(type: "int", nullable: false),
                    AnswerDescription = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: false),
                    IsCorrect = table.Column<bool>(type: "bit", nullable: false),
                    QuestionId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Answers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Answers_Questions_QuestionId",
                        column: x => x.QuestionId,
                        principalTable: "Questions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "CourseDescription", "CourseEndingDate", "CourseName", "CourseStartingDate", "CreatedAt" },
                values: new object[,]
                {
                    { "c-1", "This course provides an introduction to programming concepts using a variety of languages.", new DateTime(2024, 6, 30, 11, 53, 53, 125, DateTimeKind.Local).AddTicks(2334), "Introduction to Programming", new DateTime(2024, 3, 31, 11, 53, 53, 125, DateTimeKind.Local).AddTicks(2332), new DateTime(2024, 3, 31, 11, 53, 53, 125, DateTimeKind.Local).AddTicks(2326) },
                    { "c-2", "This course provides an introduction to programming concepts using a variety of languages.", new DateTime(2024, 6, 30, 11, 53, 53, 125, DateTimeKind.Local).AddTicks(2346), "Introduction to Programming 2", new DateTime(2024, 3, 31, 11, 53, 53, 125, DateTimeKind.Local).AddTicks(2345), new DateTime(2024, 3, 31, 11, 53, 53, 125, DateTimeKind.Local).AddTicks(2343) },
                    { "c-3", "This course provides an introduction to programming concepts using a variety of languages.", new DateTime(2024, 6, 30, 11, 53, 53, 125, DateTimeKind.Local).AddTicks(2352), "Introduction to Programming 3", new DateTime(2024, 3, 31, 11, 53, 53, 125, DateTimeKind.Local).AddTicks(2350), new DateTime(2024, 3, 31, 11, 53, 53, 125, DateTimeKind.Local).AddTicks(2349) }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CourseId", "CreatedAt", "Email", "FullName", "PasswordHash", "StudentGradeAvg", "UserName", "UserRole" },
                values: new object[] { "a-1", null, new DateTime(2024, 3, 31, 11, 53, 53, 125, DateTimeKind.Local).AddTicks(2541), "leahwalden4@gmail.com", "The Admin", "adminPassw0rd!", null, "admin", "Admin" });

            migrationBuilder.InsertData(
                table: "Exams",
                columns: new[] { "Id", "CourseId", "CreatedAt", "ExamDescription", "ExamDurationInMinutes", "ExamGradeAvg", "ExamName", "IsOrderQuestionsRandom", "StartExamDateTime", "TeacherId", "TeacherName", "UserId" },
                values: new object[,]
                {
                    { "e-1", "c-1", new DateTime(2024, 3, 31, 11, 53, 53, 125, DateTimeKind.Local).AddTicks(2376), "Description of Midterm Exam", 120, 0f, "Midterm Exam", true, new DateTime(2024, 4, 7, 11, 53, 53, 125, DateTimeKind.Local).AddTicks(2381), "t-1", "John Doe", null },
                    { "e-2", "c-2", new DateTime(2024, 3, 31, 11, 53, 53, 125, DateTimeKind.Local).AddTicks(2387), "Description of Final Exam", 180, 0f, "Final Exam", true, new DateTime(2024, 4, 14, 11, 53, 53, 125, DateTimeKind.Local).AddTicks(2389), "t-1", "John Doe", null },
                    { "e-3", "c-1", new DateTime(2024, 3, 31, 11, 53, 53, 125, DateTimeKind.Local).AddTicks(2394), "Description of Quiz 1", 60, 0f, "Quiz 1", false, new DateTime(2024, 4, 21, 11, 53, 53, 125, DateTimeKind.Local).AddTicks(2396), "t-1", "John Doe", null }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CourseId", "CreatedAt", "Email", "FullName", "PasswordHash", "StudentGradeAvg", "UserName", "UserRole" },
                values: new object[,]
                {
                    { "s-1", "c-1", new DateTime(2024, 3, 31, 11, 53, 53, 125, DateTimeKind.Local).AddTicks(2552), "alice.smith@example.com", "Alice Smith", "password1", 0f, "student1", "Student" },
                    { "s-2", "c-1", new DateTime(2024, 3, 31, 11, 53, 53, 125, DateTimeKind.Local).AddTicks(2555), "rifka.smith@example.com", "Rifka Smith", "password2", 0f, "student2", "Student" },
                    { "t-1", "c-1", new DateTime(2024, 3, 31, 11, 53, 53, 125, DateTimeKind.Local).AddTicks(2545), "john.doe@example.com", "John Doe", "password1", null, "teacher1", "Teacher" }
                });

            migrationBuilder.InsertData(
                table: "Questions",
                columns: new[] { "Id", "CorrectAnswerDescription", "CreatedAt", "ExamId", "IsImage", "IsOrderAnswersRandom", "QuestionDescription", "QuestionNumber", "QuestionScoring" },
                values: new object[,]
                {
                    { "q-1", null, new DateTime(2024, 3, 31, 11, 53, 53, 125, DateTimeKind.Local).AddTicks(2421), "e-1", null, true, "What is the capital of the United Kingdom?", 1, 1 },
                    { "q-2", null, new DateTime(2024, 3, 31, 11, 53, 53, 125, DateTimeKind.Local).AddTicks(2426), "e-1", null, true, "What is the capital of Germany?", 2, 1 },
                    { "q-3", null, new DateTime(2024, 3, 31, 11, 53, 53, 125, DateTimeKind.Local).AddTicks(2431), "e-1", null, true, "What is the capital of Italy?", 3, 1 },
                    { "q-4", null, new DateTime(2024, 3, 31, 11, 53, 53, 125, DateTimeKind.Local).AddTicks(2435), "e-2", null, true, "What is the capital of the United Kingdom?", 1, 1 },
                    { "q-5", null, new DateTime(2024, 3, 31, 11, 53, 53, 125, DateTimeKind.Local).AddTicks(2439), "e-2", null, true, "What is the capital of Germany?", 2, 1 },
                    { "q-6", null, new DateTime(2024, 3, 31, 11, 53, 53, 125, DateTimeKind.Local).AddTicks(2442), "e-2", null, true, "What is the capital of Italy?", 3, 1 },
                    { "q-7", null, new DateTime(2024, 3, 31, 11, 53, 53, 125, DateTimeKind.Local).AddTicks(2445), "e-3", null, true, "What is the largest ocean on Earth?", 1, 1 },
                    { "q-8", null, new DateTime(2024, 3, 31, 11, 53, 53, 125, DateTimeKind.Local).AddTicks(2476), "e-3", null, true, "Which planet is known as the Red Planet?", 2, 1 },
                    { "q-9", null, new DateTime(2024, 3, 31, 11, 53, 53, 125, DateTimeKind.Local).AddTicks(2480), "e-3", null, true, "What is the chemical symbol for water?", 3, 1 }
                });

            migrationBuilder.InsertData(
                table: "StudentsExams",
                columns: new[] { "Id", "CreatedAt", "ExamId", "ExamStartTime", "Grade", "QuestionsFailed", "StudentId", "StudentName", "UserId", "WasExamLoggedInToByStudent" },
                values: new object[,]
                {
                    { "se-1", new DateTime(2024, 3, 31, 11, 53, 53, 125, DateTimeKind.Local).AddTicks(2508), "e-1", null, 90, null, "s-1", "Alice Smith", null, true },
                    { "se-2", new DateTime(2024, 3, 31, 11, 53, 53, 125, DateTimeKind.Local).AddTicks(2513), "e-2", null, 85, null, "s-2", "Alice Smith", null, true },
                    { "se-3", new DateTime(2024, 3, 31, 11, 53, 53, 125, DateTimeKind.Local).AddTicks(2516), "e-3", null, 95, null, "s-2", "Rifka Smith", null, true },
                    { "se-4", new DateTime(2024, 3, 31, 11, 53, 53, 125, DateTimeKind.Local).AddTicks(2519), "e-1", null, 80, null, "s-2", "Rifka Smith", null, true }
                });

            migrationBuilder.InsertData(
                table: "Answers",
                columns: new[] { "Id", "AnswerDescription", "AnswerNumber", "CreatedAt", "IsCorrect", "QuestionId" },
                values: new object[,]
                {
                    { "a-101", "Paris", 1, new DateTime(2024, 3, 31, 11, 53, 53, 125, DateTimeKind.Local).AddTicks(1981), false, "q-1" },
                    { "a-2", "London", 2, new DateTime(2024, 3, 31, 11, 53, 53, 125, DateTimeKind.Local).AddTicks(2050), true, "q-1" },
                    { "a-21", "Paris", 1, new DateTime(2024, 3, 31, 11, 53, 53, 125, DateTimeKind.Local).AddTicks(2062), false, "q-2" },
                    { "a-22", "London", 2, new DateTime(2024, 3, 31, 11, 53, 53, 125, DateTimeKind.Local).AddTicks(2064), false, "q-2" },
                    { "a-23", "Berlin", 3, new DateTime(2024, 3, 31, 11, 53, 53, 125, DateTimeKind.Local).AddTicks(2068), true, "q-2" },
                    { "a-24", "Rome", 4, new DateTime(2024, 3, 31, 11, 53, 53, 125, DateTimeKind.Local).AddTicks(2070), false, "q-2" },
                    { "a-3", "Berlin", 3, new DateTime(2024, 3, 31, 11, 53, 53, 125, DateTimeKind.Local).AddTicks(2054), false, "q-1" },
                    { "a-31", "Paris", 1, new DateTime(2024, 3, 31, 11, 53, 53, 125, DateTimeKind.Local).AddTicks(2073), false, "q-3" },
                    { "a-32", "London", 2, new DateTime(2024, 3, 31, 11, 53, 53, 125, DateTimeKind.Local).AddTicks(2078), false, "q-3" },
                    { "a-33", "Berlin", 3, new DateTime(2024, 3, 31, 11, 53, 53, 125, DateTimeKind.Local).AddTicks(2081), false, "q-3" },
                    { "a-34", "Rome", 4, new DateTime(2024, 3, 31, 11, 53, 53, 125, DateTimeKind.Local).AddTicks(2084), true, "q-3" },
                    { "a-4", "Rome", 4, new DateTime(2024, 3, 31, 11, 53, 53, 125, DateTimeKind.Local).AddTicks(2059), false, "q-1" },
                    { "a-41", "Paris", 1, new DateTime(2024, 3, 31, 11, 53, 53, 125, DateTimeKind.Local).AddTicks(2086), true, "q-4" },
                    { "a-42", "London", 2, new DateTime(2024, 3, 31, 11, 53, 53, 125, DateTimeKind.Local).AddTicks(2089), false, "q-4" },
                    { "a-43", "Berlin", 3, new DateTime(2024, 3, 31, 11, 53, 53, 125, DateTimeKind.Local).AddTicks(2091), false, "q-4" },
                    { "a-44", "Rome", 4, new DateTime(2024, 3, 31, 11, 53, 53, 125, DateTimeKind.Local).AddTicks(2094), false, "q-4" },
                    { "a-51", "Paris", 1, new DateTime(2024, 3, 31, 11, 53, 53, 125, DateTimeKind.Local).AddTicks(2154), true, "q-5" },
                    { "a-52", "London", 2, new DateTime(2024, 3, 31, 11, 53, 53, 125, DateTimeKind.Local).AddTicks(2160), false, "q-5" },
                    { "a-53", "Berlin", 3, new DateTime(2024, 3, 31, 11, 53, 53, 125, DateTimeKind.Local).AddTicks(2162), false, "q-5" },
                    { "a-54", "Rome", 4, new DateTime(2024, 3, 31, 11, 53, 53, 125, DateTimeKind.Local).AddTicks(2165), false, "q-5" },
                    { "a-61", "Paris", 1, new DateTime(2024, 3, 31, 11, 53, 53, 125, DateTimeKind.Local).AddTicks(2167), true, "q-6" },
                    { "a-62", "London", 2, new DateTime(2024, 3, 31, 11, 53, 53, 125, DateTimeKind.Local).AddTicks(2170), false, "q-6" },
                    { "a-63", "Berlin", 3, new DateTime(2024, 3, 31, 11, 53, 53, 125, DateTimeKind.Local).AddTicks(2172), false, "q-6" },
                    { "a-64", "Rome", 4, new DateTime(2024, 3, 31, 11, 53, 53, 125, DateTimeKind.Local).AddTicks(2175), false, "q-6" },
                    { "a-71", "Pacific Ocean", 1, new DateTime(2024, 3, 31, 11, 53, 53, 125, DateTimeKind.Local).AddTicks(2177), true, "q-7" },
                    { "a-72", "Atlantic Ocean", 2, new DateTime(2024, 3, 31, 11, 53, 53, 125, DateTimeKind.Local).AddTicks(2181), false, "q-7" },
                    { "a-73", "Indian Ocean", 3, new DateTime(2024, 3, 31, 11, 53, 53, 125, DateTimeKind.Local).AddTicks(2184), false, "q-7" },
                    { "a-74", "Arctic Ocean", 4, new DateTime(2024, 3, 31, 11, 53, 53, 125, DateTimeKind.Local).AddTicks(2186), false, "q-7" },
                    { "a-81", "Mercury", 1, new DateTime(2024, 3, 31, 11, 53, 53, 125, DateTimeKind.Local).AddTicks(2188), true, "q-8" },
                    { "a-82", "Atlantic Ocean", 2, new DateTime(2024, 3, 31, 11, 53, 53, 125, DateTimeKind.Local).AddTicks(2191), false, "q-8" },
                    { "a-83", "Indian Ocean", 3, new DateTime(2024, 3, 31, 11, 53, 53, 125, DateTimeKind.Local).AddTicks(2193), false, "q-8" },
                    { "a-84", "Arctic Ocean", 4, new DateTime(2024, 3, 31, 11, 53, 53, 125, DateTimeKind.Local).AddTicks(2196), false, "q-8" },
                    { "a-91", "Mercury", 1, new DateTime(2024, 3, 31, 11, 53, 53, 125, DateTimeKind.Local).AddTicks(2198), true, "q-9" },
                    { "a-92", "Atlantic Ocean", 2, new DateTime(2024, 3, 31, 11, 53, 53, 125, DateTimeKind.Local).AddTicks(2203), false, "q-9" },
                    { "a-93", "Indian Ocean", 3, new DateTime(2024, 3, 31, 11, 53, 53, 125, DateTimeKind.Local).AddTicks(2205), false, "q-9" },
                    { "a-94", "Arctic Ocean", 4, new DateTime(2024, 3, 31, 11, 53, 53, 125, DateTimeKind.Local).AddTicks(2207), false, "q-9" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Answers_QuestionId",
                table: "Answers",
                column: "QuestionId");

            migrationBuilder.CreateIndex(
                name: "IX_Exams_CourseId",
                table: "Exams",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_Exams_UserId",
                table: "Exams",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Questions_ExamId",
                table: "Questions",
                column: "ExamId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentsExams_ExamId",
                table: "StudentsExams",
                column: "ExamId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentsExams_UserId",
                table: "StudentsExams",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_CourseId",
                table: "Users",
                column: "CourseId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Answers");

            migrationBuilder.DropTable(
                name: "StudentsExams");

            migrationBuilder.DropTable(
                name: "Questions");

            migrationBuilder.DropTable(
                name: "Exams");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Courses");
        }
    }
}
