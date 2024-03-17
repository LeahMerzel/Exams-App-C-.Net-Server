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
                    CourseEndingDate = table.Column<DateTime>(type: "datetime2", nullable: false)
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
                    TeacherId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CourseId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    ExamDescription = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    StartExamDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsOrderQuestionsRandom = table.Column<bool>(type: "bit", nullable: false),
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
                        principalColumn: "Id");
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
                    QuestionNumber = table.Column<int>(type: "int", nullable: false),
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
                    { "c-1", "This course provides an introduction to programming concepts using a variety of languages.", new DateTime(2024, 6, 16, 22, 55, 47, 694, DateTimeKind.Local).AddTicks(7813), "Introduction to Programming", new DateTime(2024, 3, 16, 22, 55, 47, 694, DateTimeKind.Local).AddTicks(7811), new DateTime(2024, 3, 16, 22, 55, 47, 694, DateTimeKind.Local).AddTicks(7804) },
                    { "c-2", "This course provides an introduction to programming concepts using a variety of languages.", new DateTime(2024, 6, 16, 22, 55, 47, 694, DateTimeKind.Local).AddTicks(7823), "Introduction to Programming 2", new DateTime(2024, 3, 16, 22, 55, 47, 694, DateTimeKind.Local).AddTicks(7822), new DateTime(2024, 3, 16, 22, 55, 47, 694, DateTimeKind.Local).AddTicks(7820) },
                    { "c-3", "This course provides an introduction to programming concepts using a variety of languages.", new DateTime(2024, 6, 16, 22, 55, 47, 694, DateTimeKind.Local).AddTicks(7829), "Introduction to Programming 3", new DateTime(2024, 3, 16, 22, 55, 47, 694, DateTimeKind.Local).AddTicks(7828), new DateTime(2024, 3, 16, 22, 55, 47, 694, DateTimeKind.Local).AddTicks(7826) }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CourseId", "CreatedAt", "Email", "FullName", "PasswordHash", "StudentGradeAvg", "Token", "UserName", "UserRole" },
                values: new object[] { "a-1", null, new DateTime(2024, 3, 16, 22, 55, 47, 694, DateTimeKind.Local).AddTicks(8101), "leahwalden4@gmail.com", "The Admin", "adminPassw0rd!", null, null, "admin", "Admin" });

            migrationBuilder.InsertData(
                table: "Exams",
                columns: new[] { "Id", "CourseId", "CreatedAt", "ExamDescription", "ExamDurationInMinutes", "ExamGradeAvg", "ExamName", "IsOrderQuestionsRandom", "StartExamDateTime", "TeacherId", "UserId" },
                values: new object[,]
                {
                    { "e-1", "c-1", new DateTime(2024, 3, 16, 22, 55, 47, 694, DateTimeKind.Local).AddTicks(7890), "Description of Midterm Exam", 120, 0f, "Midterm Exam", true, new DateTime(2024, 3, 23, 22, 55, 47, 694, DateTimeKind.Local).AddTicks(7897), "t-1", null },
                    { "e-2", "c-2", new DateTime(2024, 3, 16, 22, 55, 47, 694, DateTimeKind.Local).AddTicks(7906), "Description of Final Exam", 180, 0f, "Final Exam", true, new DateTime(2024, 3, 30, 22, 55, 47, 694, DateTimeKind.Local).AddTicks(7908), "t-1", null },
                    { "e-3", "c-1", new DateTime(2024, 3, 16, 22, 55, 47, 694, DateTimeKind.Local).AddTicks(7912), "Description of Quiz 1", 60, 0f, "Quiz 1", false, new DateTime(2024, 4, 6, 22, 55, 47, 694, DateTimeKind.Local).AddTicks(7915), "t-1", null }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CourseId", "CreatedAt", "Email", "FullName", "PasswordHash", "StudentGradeAvg", "Token", "UserName", "UserRole" },
                values: new object[,]
                {
                    { "s-1", "c-1", new DateTime(2024, 3, 16, 22, 55, 47, 694, DateTimeKind.Local).AddTicks(8111), "alice.smith@example.com", "Alice Smith", "password1", 0f, null, "student1", "Student" },
                    { "s-2", "c-1", new DateTime(2024, 3, 16, 22, 55, 47, 694, DateTimeKind.Local).AddTicks(8118), "rifka.smith@example.com", "Rifka Smith", "password2", 0f, null, "student2", "Student" },
                    { "t-1", "c-1", new DateTime(2024, 3, 16, 22, 55, 47, 694, DateTimeKind.Local).AddTicks(8107), "john.doe@example.com", "John Doe", "password1", null, null, "teacher1", "Teacher" }
                });

            migrationBuilder.InsertData(
                table: "Questions",
                columns: new[] { "Id", "CreatedAt", "ExamId", "IsImage", "IsOrderAnswersRandom", "QuestionDescription", "QuestionNumber", "QuestionScoring", "StudentExamId" },
                values: new object[,]
                {
                    { "q-1", new DateTime(2024, 3, 16, 22, 55, 47, 694, DateTimeKind.Local).AddTicks(7947), "e-1", false, true, "What is the capital of the United Kingdom?", 1, 1, null },
                    { "q-2", new DateTime(2024, 3, 16, 22, 55, 47, 694, DateTimeKind.Local).AddTicks(7952), "e-1", false, true, "What is the capital of Germany?", 2, 1, null },
                    { "q-3", new DateTime(2024, 3, 16, 22, 55, 47, 694, DateTimeKind.Local).AddTicks(7958), "e-1", false, true, "What is the capital of Italy?", 3, 1, null },
                    { "q-4", new DateTime(2024, 3, 16, 22, 55, 47, 694, DateTimeKind.Local).AddTicks(7962), "e-2", false, true, "What is the capital of the United Kingdom?", 1, 1, null },
                    { "q-5", new DateTime(2024, 3, 16, 22, 55, 47, 694, DateTimeKind.Local).AddTicks(7989), "e-2", false, true, "What is the capital of Germany?", 2, 1, null },
                    { "q-6", new DateTime(2024, 3, 16, 22, 55, 47, 694, DateTimeKind.Local).AddTicks(7995), "e-2", false, true, "What is the capital of Italy?", 3, 1, null },
                    { "q-7", new DateTime(2024, 3, 16, 22, 55, 47, 694, DateTimeKind.Local).AddTicks(8000), "e-3", false, true, "What is the largest ocean on Earth?", 1, 1, null },
                    { "q-8", new DateTime(2024, 3, 16, 22, 55, 47, 694, DateTimeKind.Local).AddTicks(8005), "e-3", false, true, "Which planet is known as the Red Planet?", 2, 1, null },
                    { "q-9", new DateTime(2024, 3, 16, 22, 55, 47, 694, DateTimeKind.Local).AddTicks(8013), "e-3", false, true, "What is the chemical symbol for water?", 3, 1, null }
                });

            migrationBuilder.InsertData(
                table: "StudentsExams",
                columns: new[] { "Id", "CreatedAt", "ExamId", "ExamStartTime", "Grade", "StudentId", "StudentName", "UserId", "WasExamLoggedInToByStudent" },
                values: new object[,]
                {
                    { "se-1", new DateTime(2024, 3, 16, 22, 55, 47, 694, DateTimeKind.Local).AddTicks(8050), "e-1", new DateTime(2024, 3, 16, 20, 55, 47, 694, DateTimeKind.Local).AddTicks(8057), 90, "s-1", "Alice Smith", null, true },
                    { "se-2", new DateTime(2024, 3, 16, 22, 55, 47, 694, DateTimeKind.Local).AddTicks(8060), "e-2", new DateTime(2024, 3, 16, 19, 55, 47, 694, DateTimeKind.Local).AddTicks(8062), 85, "s-2", "Alice Smith", null, true },
                    { "se-3", new DateTime(2024, 3, 16, 22, 55, 47, 694, DateTimeKind.Local).AddTicks(8065), "e-3", new DateTime(2024, 3, 16, 18, 55, 47, 694, DateTimeKind.Local).AddTicks(8068), 95, "s-2", "Rifka Smith", null, true },
                    { "se-4", new DateTime(2024, 3, 16, 22, 55, 47, 694, DateTimeKind.Local).AddTicks(8071), "e-1", new DateTime(2024, 3, 16, 17, 55, 47, 694, DateTimeKind.Local).AddTicks(8073), 80, "s-2", "Rifka Smith", null, true }
                });

            migrationBuilder.InsertData(
                table: "Answers",
                columns: new[] { "Id", "AnswerDescription", "AnswerNumber", "CreatedAt", "IsCorrect", "QuestionId" },
                values: new object[,]
                {
                    { "a-2", "London", 2, new DateTime(2024, 3, 16, 22, 55, 47, 694, DateTimeKind.Local).AddTicks(7599), false, "q-1" },
                    { "a-21", "Paris", 1, new DateTime(2024, 3, 16, 22, 55, 47, 694, DateTimeKind.Local).AddTicks(7625), true, "q-2" },
                    { "a-22", "London", 2, new DateTime(2024, 3, 16, 22, 55, 47, 694, DateTimeKind.Local).AddTicks(7629), false, "q-2" },
                    { "a-23", "Berlin", 3, new DateTime(2024, 3, 16, 22, 55, 47, 694, DateTimeKind.Local).AddTicks(7632), false, "q-2" },
                    { "a-24", "Rome", 4, new DateTime(2024, 3, 16, 22, 55, 47, 694, DateTimeKind.Local).AddTicks(7635), false, "q-2" },
                    { "a-3", "Berlin", 3, new DateTime(2024, 3, 16, 22, 55, 47, 694, DateTimeKind.Local).AddTicks(7618), false, "q-1" },
                    { "a-31", "Paris", 1, new DateTime(2024, 3, 16, 22, 55, 47, 694, DateTimeKind.Local).AddTicks(7638), true, "q-3" },
                    { "a-32", "London", 2, new DateTime(2024, 3, 16, 22, 55, 47, 694, DateTimeKind.Local).AddTicks(7642), false, "q-3" },
                    { "a-33", "Berlin", 3, new DateTime(2024, 3, 16, 22, 55, 47, 694, DateTimeKind.Local).AddTicks(7648), false, "q-3" },
                    { "a-34", "Rome", 4, new DateTime(2024, 3, 16, 22, 55, 47, 694, DateTimeKind.Local).AddTicks(7652), false, "q-3" },
                    { "a-4", "Rome", 4, new DateTime(2024, 3, 16, 22, 55, 47, 694, DateTimeKind.Local).AddTicks(7622), false, "q-1" },
                    { "a-61", "Paris", 1, new DateTime(2024, 3, 16, 22, 55, 47, 694, DateTimeKind.Local).AddTicks(7534), true, "q-1" }
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
                name: "Questions");

            migrationBuilder.DropTable(
                name: "StudentsExams");

            migrationBuilder.DropTable(
                name: "Exams");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Courses");
        }
    }
}
