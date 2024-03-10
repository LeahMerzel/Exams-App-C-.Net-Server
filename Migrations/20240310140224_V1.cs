using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Exams_App_C__.Net_Server.Migrations
{
    /// <inheritdoc />
    public partial class V1 : Migration
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
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserRole = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Token = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StudentGradeAvg = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CourseUser",
                columns: table => new
                {
                    CoursesId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UsersId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CourseUser", x => new { x.CoursesId, x.UsersId });
                    table.ForeignKey(
                        name: "FK_CourseUser_Courses_CoursesId",
                        column: x => x.CoursesId,
                        principalTable: "Courses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CourseUser_Users_UsersId",
                        column: x => x.UsersId,
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
                    { "c-1", "a-1", "This course provides an introduction to programming concepts using a variety of languages.", new DateTime(2024, 6, 10, 16, 2, 23, 932, DateTimeKind.Local).AddTicks(1811), "Introduction to Programming", new DateTime(2024, 3, 10, 16, 2, 23, 932, DateTimeKind.Local).AddTicks(1809), new DateTime(2024, 3, 10, 16, 2, 23, 932, DateTimeKind.Local).AddTicks(1804) },
                    { "c-2", "a-1", "This course provides an introduction to programming concepts using a variety of languages.", new DateTime(2024, 6, 10, 16, 2, 23, 932, DateTimeKind.Local).AddTicks(1820), "Introduction to Programming 2", new DateTime(2024, 3, 10, 16, 2, 23, 932, DateTimeKind.Local).AddTicks(1819), new DateTime(2024, 3, 10, 16, 2, 23, 932, DateTimeKind.Local).AddTicks(1817) },
                    { "c-3", "a-1", "This course provides an introduction to programming concepts using a variety of languages.", new DateTime(2024, 6, 10, 16, 2, 23, 932, DateTimeKind.Local).AddTicks(1826), "Introduction to Programming 3", new DateTime(2024, 3, 10, 16, 2, 23, 932, DateTimeKind.Local).AddTicks(1825), new DateTime(2024, 3, 10, 16, 2, 23, 932, DateTimeKind.Local).AddTicks(1823) }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedAt", "Email", "FullName", "PasswordHash", "StudentGradeAvg", "Token", "UserName", "UserRole" },
                values: new object[,]
                {
                    { "a-1", new DateTime(2024, 3, 10, 16, 2, 23, 932, DateTimeKind.Local).AddTicks(1998), "leahwalden4@gmail.com", "The Admin", "adminPassw0rd!", 0f, null, "admin", "Admin" },
                    { "s-1", new DateTime(2024, 3, 10, 16, 2, 23, 932, DateTimeKind.Local).AddTicks(2009), "alice.smith@example.com", "Alice Smith", "password1", 0f, null, "student1", "Student" },
                    { "s-2", new DateTime(2024, 3, 10, 16, 2, 23, 932, DateTimeKind.Local).AddTicks(2012), "rifka.smith@example.com", "Rifka Smith", "password2", 0f, null, "student2", "Student" },
                    { "t-1", new DateTime(2024, 3, 10, 16, 2, 23, 932, DateTimeKind.Local).AddTicks(2006), "john.doe@example.com", "John Doe", "password1", 0f, null, "teacher1", "Teacher" }
                });

            migrationBuilder.InsertData(
                table: "Exams",
                columns: new[] { "Id", "CourseId", "CreatedAt", "EndExamDateTime", "ExamDescription", "ExamDurationInMinutes", "ExamGradeAvg", "ExamName", "IsOrderQuestionsRandom", "StartExamDateTime", "TeacherId", "UserId" },
                values: new object[,]
                {
                    { "e-1", "c-1", new DateTime(2024, 3, 10, 16, 2, 23, 932, DateTimeKind.Local).AddTicks(1853), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description of Midterm Exam", 120, 0f, "Midterm Exam", true, new DateTime(2024, 3, 17, 16, 2, 23, 932, DateTimeKind.Local).AddTicks(1857), "t-1", null },
                    { "e-2", "c-2", new DateTime(2024, 3, 10, 16, 2, 23, 932, DateTimeKind.Local).AddTicks(1863), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description of Final Exam", 180, 0f, "Final Exam", true, new DateTime(2024, 3, 24, 16, 2, 23, 932, DateTimeKind.Local).AddTicks(1865), "t-1", null },
                    { "e-3", "c-1", new DateTime(2024, 3, 10, 16, 2, 23, 932, DateTimeKind.Local).AddTicks(1868), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description of Quiz 1", 60, 0f, "Quiz 1", false, new DateTime(2024, 3, 31, 16, 2, 23, 932, DateTimeKind.Local).AddTicks(1870), "t-1", null }
                });

            migrationBuilder.InsertData(
                table: "Questions",
                columns: new[] { "Id", "CreatedAt", "ExamId", "IsImage", "IsOrderAnswersRandom", "QuestionDescription", "QuestionNumber", "QuestionScoring", "StudentExamId" },
                values: new object[,]
                {
                    { "q-1", new DateTime(2024, 3, 10, 16, 2, 23, 932, DateTimeKind.Local).AddTicks(1893), "e-1", false, true, "What is the capital of the United Kingdom?", 1, 1, null },
                    { "q-2", new DateTime(2024, 3, 10, 16, 2, 23, 932, DateTimeKind.Local).AddTicks(1899), "e-1", false, true, "What is the capital of Germany?", 2, 1, null },
                    { "q-3", new DateTime(2024, 3, 10, 16, 2, 23, 932, DateTimeKind.Local).AddTicks(1903), "e-1", false, true, "What is the capital of Italy?", 3, 1, null },
                    { "q-4", new DateTime(2024, 3, 10, 16, 2, 23, 932, DateTimeKind.Local).AddTicks(1907), "e-2", false, true, "What is the capital of the United Kingdom?", 1, 1, null },
                    { "q-5", new DateTime(2024, 3, 10, 16, 2, 23, 932, DateTimeKind.Local).AddTicks(1911), "e-2", false, true, "What is the capital of Germany?", 2, 1, null },
                    { "q-6", new DateTime(2024, 3, 10, 16, 2, 23, 932, DateTimeKind.Local).AddTicks(1915), "e-2", false, true, "What is the capital of Italy?", 3, 1, null },
                    { "q-7", new DateTime(2024, 3, 10, 16, 2, 23, 932, DateTimeKind.Local).AddTicks(1922), "e-3", false, true, "What is the largest ocean on Earth?", 1, 1, null },
                    { "q-8", new DateTime(2024, 3, 10, 16, 2, 23, 932, DateTimeKind.Local).AddTicks(1926), "e-3", false, true, "Which planet is known as the Red Planet?", 2, 1, null },
                    { "q-9", new DateTime(2024, 3, 10, 16, 2, 23, 932, DateTimeKind.Local).AddTicks(1930), "e-3", false, true, "What is the chemical symbol for water?", 3, 1, null }
                });

            migrationBuilder.InsertData(
                table: "StudentsExams",
                columns: new[] { "Id", "CreatedAt", "ExamId", "ExamStartTime", "Grade", "StudentId", "StudentName", "UserId", "WasExamLoggedInToByStudent" },
                values: new object[,]
                {
                    { "se-1", new DateTime(2024, 3, 10, 16, 2, 23, 932, DateTimeKind.Local).AddTicks(1959), "e-1", new DateTime(2024, 3, 10, 14, 2, 23, 932, DateTimeKind.Local).AddTicks(1964), 90, "s-1", "Alice Smith", null, true },
                    { "se-2", new DateTime(2024, 3, 10, 16, 2, 23, 932, DateTimeKind.Local).AddTicks(1967), "e-2", new DateTime(2024, 3, 10, 13, 2, 23, 932, DateTimeKind.Local).AddTicks(1969), 85, "s-2", "Alice Smith", null, true },
                    { "se-3", new DateTime(2024, 3, 10, 16, 2, 23, 932, DateTimeKind.Local).AddTicks(1971), "e-3", new DateTime(2024, 3, 10, 12, 2, 23, 932, DateTimeKind.Local).AddTicks(1973), 95, "s-2", "Rifka Smith", null, true },
                    { "se-4", new DateTime(2024, 3, 10, 16, 2, 23, 932, DateTimeKind.Local).AddTicks(1975), "e-1", new DateTime(2024, 3, 10, 11, 2, 23, 932, DateTimeKind.Local).AddTicks(1977), 80, "s-2", "Rifka Smith", null, true }
                });

            migrationBuilder.InsertData(
                table: "Answers",
                columns: new[] { "Id", "AnswerDescription", "AnswerNumber", "CreatedAt", "IsCorrect", "QuestionId" },
                values: new object[,]
                {
                    { "a-1", "Paris", 1, new DateTime(2024, 3, 10, 16, 2, 23, 932, DateTimeKind.Local).AddTicks(1558), true, "q-1" },
                    { "a-2", "London", 2, new DateTime(2024, 3, 10, 16, 2, 23, 932, DateTimeKind.Local).AddTicks(1615), false, "q-1" },
                    { "a-21", "Paris", 1, new DateTime(2024, 3, 10, 16, 2, 23, 932, DateTimeKind.Local).AddTicks(1624), true, "q-2" },
                    { "a-22", "London", 2, new DateTime(2024, 3, 10, 16, 2, 23, 932, DateTimeKind.Local).AddTicks(1627), false, "q-2" },
                    { "a-23", "Berlin", 3, new DateTime(2024, 3, 10, 16, 2, 23, 932, DateTimeKind.Local).AddTicks(1629), false, "q-2" },
                    { "a-24", "Rome", 4, new DateTime(2024, 3, 10, 16, 2, 23, 932, DateTimeKind.Local).AddTicks(1632), false, "q-2" },
                    { "a-3", "Berlin", 3, new DateTime(2024, 3, 10, 16, 2, 23, 932, DateTimeKind.Local).AddTicks(1618), false, "q-1" },
                    { "a-31", "Paris", 1, new DateTime(2024, 3, 10, 16, 2, 23, 932, DateTimeKind.Local).AddTicks(1637), true, "q-3" },
                    { "a-32", "London", 2, new DateTime(2024, 3, 10, 16, 2, 23, 932, DateTimeKind.Local).AddTicks(1639), false, "q-3" },
                    { "a-33", "Berlin", 3, new DateTime(2024, 3, 10, 16, 2, 23, 932, DateTimeKind.Local).AddTicks(1665), false, "q-3" },
                    { "a-34", "Rome", 4, new DateTime(2024, 3, 10, 16, 2, 23, 932, DateTimeKind.Local).AddTicks(1668), false, "q-3" },
                    { "a-4", "Rome", 4, new DateTime(2024, 3, 10, 16, 2, 23, 932, DateTimeKind.Local).AddTicks(1621), false, "q-1" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Answers_QuestionId",
                table: "Answers",
                column: "QuestionId");

            migrationBuilder.CreateIndex(
                name: "IX_CourseUser_UsersId",
                table: "CourseUser",
                column: "UsersId");

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
                name: "CourseUser");

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
