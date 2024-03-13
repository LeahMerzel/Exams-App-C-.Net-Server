using System;
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
                    CourseDescription = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    CourseStartingDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CourseEndingDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AdminId = table.Column<string>(type: "nvarchar(max)", nullable: false)
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
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserRole = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Token = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StudentGradeAvg = table.Column<float>(type: "real", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CoursesUsers",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CourseId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.ForeignKey(
                        name: "FK_CoursesUsers_Courses_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Courses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CoursesUsers_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Exams",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ExamName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    TeacherId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CourseId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ExamDescription = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    StartExamDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndExamDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsOrderQuestionsRandom = table.Column<bool>(type: "bit", nullable: false),
                    ExamGradeAvg = table.Column<float>(type: "real", nullable: false),
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
                name: "StudentsExams",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    StudentName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Grade = table.Column<int>(type: "int", nullable: false),
                    StudentId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ExamId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ExamStartTime = table.Column<DateTime>(type: "datetime2", nullable: false),
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
                name: "Questions",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    QuestionNumber = table.Column<int>(type: "int", maxLength: 2, nullable: false),
                    QuestionDescription = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: false),
                    IsImage = table.Column<bool>(type: "bit", nullable: false),
                    IsOrderAnswersRandom = table.Column<bool>(type: "bit", nullable: false),
                    QuestionScoring = table.Column<int>(type: "int", maxLength: 3, nullable: false),
                    ExamId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    StudentExamId = table.Column<string>(type: "nvarchar(450)", nullable: true)
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
                    table.ForeignKey(
                        name: "FK_Questions_StudentsExams_StudentExamId",
                        column: x => x.StudentExamId,
                        principalTable: "StudentsExams",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Answers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AnswerNumber = table.Column<int>(type: "int", maxLength: 1, nullable: false),
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
                columns: new[] { "Id", "AdminId", "CourseDescription", "CourseEndingDate", "CourseName", "CourseStartingDate", "CreatedAt" },
                values: new object[,]
                {
                    { "c-1", "a-1", "This course provides an introduction to programming concepts using a variety of languages.", new DateTime(2024, 6, 13, 22, 5, 52, 838, DateTimeKind.Local).AddTicks(2576), "Introduction to Programming", new DateTime(2024, 3, 13, 22, 5, 52, 838, DateTimeKind.Local).AddTicks(2574), new DateTime(2024, 3, 13, 22, 5, 52, 838, DateTimeKind.Local).AddTicks(2567) },
                    { "c-2", "a-1", "This course provides an introduction to programming concepts using a variety of languages.", new DateTime(2024, 6, 13, 22, 5, 52, 838, DateTimeKind.Local).AddTicks(2585), "Introduction to Programming 2", new DateTime(2024, 3, 13, 22, 5, 52, 838, DateTimeKind.Local).AddTicks(2583), new DateTime(2024, 3, 13, 22, 5, 52, 838, DateTimeKind.Local).AddTicks(2581) },
                    { "c-3", "a-1", "This course provides an introduction to programming concepts using a variety of languages.", new DateTime(2024, 6, 13, 22, 5, 52, 838, DateTimeKind.Local).AddTicks(2590), "Introduction to Programming 3", new DateTime(2024, 3, 13, 22, 5, 52, 838, DateTimeKind.Local).AddTicks(2589), new DateTime(2024, 3, 13, 22, 5, 52, 838, DateTimeKind.Local).AddTicks(2587) }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedAt", "Email", "FullName", "PasswordHash", "StudentGradeAvg", "Token", "UserName", "UserRole" },
                values: new object[,]
                {
                    { "a-1", new DateTime(2024, 3, 13, 22, 5, 52, 838, DateTimeKind.Local).AddTicks(2793), "leahwalden4@gmail.com", "The Admin", "adminPassw0rd!", null, null, "admin", "Admin" },
                    { "s-1", new DateTime(2024, 3, 13, 22, 5, 52, 838, DateTimeKind.Local).AddTicks(2806), "alice.smith@example.com", "Alice Smith", "password1", 0f, null, "student1", "Student" },
                    { "s-2", new DateTime(2024, 3, 13, 22, 5, 52, 838, DateTimeKind.Local).AddTicks(2810), "rifka.smith@example.com", "Rifka Smith", "password2", 0f, null, "student2", "Student" },
                    { "t-1", new DateTime(2024, 3, 13, 22, 5, 52, 838, DateTimeKind.Local).AddTicks(2802), "john.doe@example.com", "John Doe", "password1", null, null, "teacher1", "Teacher" }
                });

            migrationBuilder.InsertData(
                table: "Exams",
                columns: new[] { "Id", "CourseId", "CreatedAt", "EndExamDateTime", "ExamDescription", "ExamDurationInMinutes", "ExamGradeAvg", "ExamName", "IsOrderQuestionsRandom", "StartExamDateTime", "TeacherId", "UserId" },
                values: new object[,]
                {
                    { "e-1", "c-1", new DateTime(2024, 3, 13, 22, 5, 52, 838, DateTimeKind.Local).AddTicks(2618), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description of Midterm Exam", 120, 0f, "Midterm Exam", true, new DateTime(2024, 3, 20, 22, 5, 52, 838, DateTimeKind.Local).AddTicks(2622), "t-1", null },
                    { "e-2", "c-2", new DateTime(2024, 3, 13, 22, 5, 52, 838, DateTimeKind.Local).AddTicks(2628), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description of Final Exam", 180, 0f, "Final Exam", true, new DateTime(2024, 3, 27, 22, 5, 52, 838, DateTimeKind.Local).AddTicks(2630), "t-1", null },
                    { "e-3", "c-1", new DateTime(2024, 3, 13, 22, 5, 52, 838, DateTimeKind.Local).AddTicks(2633), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description of Quiz 1", 60, 0f, "Quiz 1", false, new DateTime(2024, 4, 3, 22, 5, 52, 838, DateTimeKind.Local).AddTicks(2635), "t-1", null }
                });

            migrationBuilder.InsertData(
                table: "Questions",
                columns: new[] { "Id", "CreatedAt", "ExamId", "IsImage", "IsOrderAnswersRandom", "QuestionDescription", "QuestionNumber", "QuestionScoring", "StudentExamId" },
                values: new object[,]
                {
                    { "q-1", new DateTime(2024, 3, 13, 22, 5, 52, 838, DateTimeKind.Local).AddTicks(2662), "e-1", false, true, "What is the capital of the United Kingdom?", 1, 1, null },
                    { "q-2", new DateTime(2024, 3, 13, 22, 5, 52, 838, DateTimeKind.Local).AddTicks(2667), "e-1", false, true, "What is the capital of Germany?", 2, 1, null },
                    { "q-3", new DateTime(2024, 3, 13, 22, 5, 52, 838, DateTimeKind.Local).AddTicks(2672), "e-1", false, true, "What is the capital of Italy?", 3, 1, null },
                    { "q-4", new DateTime(2024, 3, 13, 22, 5, 52, 838, DateTimeKind.Local).AddTicks(2676), "e-2", false, true, "What is the capital of the United Kingdom?", 1, 1, null },
                    { "q-5", new DateTime(2024, 3, 13, 22, 5, 52, 838, DateTimeKind.Local).AddTicks(2680), "e-2", false, true, "What is the capital of Germany?", 2, 1, null },
                    { "q-6", new DateTime(2024, 3, 13, 22, 5, 52, 838, DateTimeKind.Local).AddTicks(2686), "e-2", false, true, "What is the capital of Italy?", 3, 1, null },
                    { "q-7", new DateTime(2024, 3, 13, 22, 5, 52, 838, DateTimeKind.Local).AddTicks(2690), "e-3", false, true, "What is the largest ocean on Earth?", 1, 1, null },
                    { "q-8", new DateTime(2024, 3, 13, 22, 5, 52, 838, DateTimeKind.Local).AddTicks(2694), "e-3", false, true, "Which planet is known as the Red Planet?", 2, 1, null },
                    { "q-9", new DateTime(2024, 3, 13, 22, 5, 52, 838, DateTimeKind.Local).AddTicks(2698), "e-3", false, true, "What is the chemical symbol for water?", 3, 1, null }
                });

            migrationBuilder.InsertData(
                table: "StudentsExams",
                columns: new[] { "Id", "CreatedAt", "ExamId", "ExamStartTime", "Grade", "StudentId", "StudentName", "UserId", "WasExamLoggedInToByStudent" },
                values: new object[,]
                {
                    { "se-1", new DateTime(2024, 3, 13, 22, 5, 52, 838, DateTimeKind.Local).AddTicks(2727), "e-1", new DateTime(2024, 3, 13, 20, 5, 52, 838, DateTimeKind.Local).AddTicks(2733), 90, "s-1", "Alice Smith", null, true },
                    { "se-2", new DateTime(2024, 3, 13, 22, 5, 52, 838, DateTimeKind.Local).AddTicks(2735), "e-2", new DateTime(2024, 3, 13, 19, 5, 52, 838, DateTimeKind.Local).AddTicks(2738), 85, "s-2", "Alice Smith", null, true },
                    { "se-3", new DateTime(2024, 3, 13, 22, 5, 52, 838, DateTimeKind.Local).AddTicks(2756), "e-3", new DateTime(2024, 3, 13, 18, 5, 52, 838, DateTimeKind.Local).AddTicks(2758), 95, "s-2", "Rifka Smith", null, true },
                    { "se-4", new DateTime(2024, 3, 13, 22, 5, 52, 838, DateTimeKind.Local).AddTicks(2761), "e-1", new DateTime(2024, 3, 13, 17, 5, 52, 838, DateTimeKind.Local).AddTicks(2763), 80, "s-2", "Rifka Smith", null, true }
                });

            migrationBuilder.InsertData(
                table: "Answers",
                columns: new[] { "Id", "AnswerDescription", "AnswerNumber", "CreatedAt", "IsCorrect", "QuestionId" },
                values: new object[,]
                {
                    { "a-1", "Paris", 1, new DateTime(2024, 3, 13, 22, 5, 52, 838, DateTimeKind.Local).AddTicks(2306), true, "q-1" },
                    { "a-2", "London", 2, new DateTime(2024, 3, 13, 22, 5, 52, 838, DateTimeKind.Local).AddTicks(2371), false, "q-1" },
                    { "a-21", "Paris", 1, new DateTime(2024, 3, 13, 22, 5, 52, 838, DateTimeKind.Local).AddTicks(2380), true, "q-2" },
                    { "a-22", "London", 2, new DateTime(2024, 3, 13, 22, 5, 52, 838, DateTimeKind.Local).AddTicks(2382), false, "q-2" },
                    { "a-23", "Berlin", 3, new DateTime(2024, 3, 13, 22, 5, 52, 838, DateTimeKind.Local).AddTicks(2385), false, "q-2" },
                    { "a-24", "Rome", 4, new DateTime(2024, 3, 13, 22, 5, 52, 838, DateTimeKind.Local).AddTicks(2409), false, "q-2" },
                    { "a-3", "Berlin", 3, new DateTime(2024, 3, 13, 22, 5, 52, 838, DateTimeKind.Local).AddTicks(2374), false, "q-1" },
                    { "a-31", "Paris", 1, new DateTime(2024, 3, 13, 22, 5, 52, 838, DateTimeKind.Local).AddTicks(2411), true, "q-3" },
                    { "a-32", "London", 2, new DateTime(2024, 3, 13, 22, 5, 52, 838, DateTimeKind.Local).AddTicks(2414), false, "q-3" },
                    { "a-33", "Berlin", 3, new DateTime(2024, 3, 13, 22, 5, 52, 838, DateTimeKind.Local).AddTicks(2416), false, "q-3" },
                    { "a-34", "Rome", 4, new DateTime(2024, 3, 13, 22, 5, 52, 838, DateTimeKind.Local).AddTicks(2419), false, "q-3" },
                    { "a-4", "Rome", 4, new DateTime(2024, 3, 13, 22, 5, 52, 838, DateTimeKind.Local).AddTicks(2377), false, "q-1" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Answers_QuestionId",
                table: "Answers",
                column: "QuestionId");

            migrationBuilder.CreateIndex(
                name: "IX_CoursesUsers_CourseId",
                table: "CoursesUsers",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_CoursesUsers_UserId",
                table: "CoursesUsers",
                column: "UserId");

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
                name: "IX_Questions_StudentExamId",
                table: "Questions",
                column: "StudentExamId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentsExams_ExamId",
                table: "StudentsExams",
                column: "ExamId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentsExams_UserId",
                table: "StudentsExams",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Answers");

            migrationBuilder.DropTable(
                name: "CoursesUsers");

            migrationBuilder.DropTable(
                name: "Questions");

            migrationBuilder.DropTable(
                name: "StudentsExams");

            migrationBuilder.DropTable(
                name: "Exams");

            migrationBuilder.DropTable(
                name: "Courses");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
