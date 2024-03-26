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
                    TeacherName = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    QuestionNumber = table.Column<int>(type: "int", nullable: false),
                    QuestionDescription = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: false),
                    CorrectAnswerDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsOrderAnswersRandom = table.Column<bool>(type: "bit", nullable: true),
                    QuestionScoring = table.Column<int>(type: "int", nullable: false),
                    ExamId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    StudentExamId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Questions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Questions_Exams_ExamId",
                        column: x => x.ExamId,
                        principalTable: "Exams",
                        principalColumn: "Id");
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
                    { "c-1", "This course provides an introduction to programming concepts using a variety of languages.", new DateTime(2024, 6, 26, 13, 1, 39, 535, DateTimeKind.Local).AddTicks(7961), "Introduction to Programming", new DateTime(2024, 3, 26, 13, 1, 39, 535, DateTimeKind.Local).AddTicks(7957), new DateTime(2024, 3, 26, 13, 1, 39, 535, DateTimeKind.Local).AddTicks(7945) },
                    { "c-2", "This course provides an introduction to programming concepts using a variety of languages.", new DateTime(2024, 6, 26, 13, 1, 39, 535, DateTimeKind.Local).AddTicks(7970), "Introduction to Programming 2", new DateTime(2024, 3, 26, 13, 1, 39, 535, DateTimeKind.Local).AddTicks(7969), new DateTime(2024, 3, 26, 13, 1, 39, 535, DateTimeKind.Local).AddTicks(7967) },
                    { "c-3", "This course provides an introduction to programming concepts using a variety of languages.", new DateTime(2024, 6, 26, 13, 1, 39, 535, DateTimeKind.Local).AddTicks(7978), "Introduction to Programming 3", new DateTime(2024, 3, 26, 13, 1, 39, 535, DateTimeKind.Local).AddTicks(7977), new DateTime(2024, 3, 26, 13, 1, 39, 535, DateTimeKind.Local).AddTicks(7975) }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CourseId", "CreatedAt", "Email", "FullName", "PasswordHash", "StudentGradeAvg", "Token", "UserName", "UserRole" },
                values: new object[] { "a-1", null, new DateTime(2024, 3, 26, 13, 1, 39, 535, DateTimeKind.Local).AddTicks(8213), "leahwalden4@gmail.com", "The Admin", "adminPassw0rd!", null, null, "admin", "Admin" });

            migrationBuilder.InsertData(
                table: "Exams",
                columns: new[] { "Id", "CourseId", "CreatedAt", "ExamDescription", "ExamDurationInMinutes", "ExamGradeAvg", "ExamName", "IsOrderQuestionsRandom", "StartExamDateTime", "TeacherId", "TeacherName", "UserId" },
                values: new object[,]
                {
                    { "e-1", "c-1", new DateTime(2024, 3, 26, 13, 1, 39, 535, DateTimeKind.Local).AddTicks(8008), "Description of Midterm Exam", 120, 0f, "Midterm Exam", true, new DateTime(2024, 4, 2, 13, 1, 39, 535, DateTimeKind.Local).AddTicks(8012), "t-1", null, null },
                    { "e-2", "c-2", new DateTime(2024, 3, 26, 13, 1, 39, 535, DateTimeKind.Local).AddTicks(8018), "Description of Final Exam", 180, 0f, "Final Exam", true, new DateTime(2024, 4, 9, 13, 1, 39, 535, DateTimeKind.Local).AddTicks(8046), "t-1", null, null },
                    { "e-3", "c-1", new DateTime(2024, 3, 26, 13, 1, 39, 535, DateTimeKind.Local).AddTicks(8051), "Description of Quiz 1", 60, 0f, "Quiz 1", false, new DateTime(2024, 4, 16, 13, 1, 39, 535, DateTimeKind.Local).AddTicks(8053), "t-1", null, null }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CourseId", "CreatedAt", "Email", "FullName", "PasswordHash", "StudentGradeAvg", "Token", "UserName", "UserRole" },
                values: new object[,]
                {
                    { "s-1", "c-1", new DateTime(2024, 3, 26, 13, 1, 39, 535, DateTimeKind.Local).AddTicks(8222), "alice.smith@example.com", "Alice Smith", "password1", 0f, null, "student1", "Student" },
                    { "s-2", "c-1", new DateTime(2024, 3, 26, 13, 1, 39, 535, DateTimeKind.Local).AddTicks(8226), "rifka.smith@example.com", "Rifka Smith", "password2", 0f, null, "student2", "Student" },
                    { "t-1", "c-1", new DateTime(2024, 3, 26, 13, 1, 39, 535, DateTimeKind.Local).AddTicks(8218), "john.doe@example.com", "John Doe", "password1", null, null, "teacher1", "Teacher" }
                });

            migrationBuilder.InsertData(
                table: "Questions",
                columns: new[] { "Id", "CorrectAnswerDescription", "CreatedAt", "ExamId", "IsOrderAnswersRandom", "QuestionDescription", "QuestionNumber", "QuestionScoring", "StudentExamId" },
                values: new object[,]
                {
                    { "q-1", null, new DateTime(2024, 3, 26, 13, 1, 39, 535, DateTimeKind.Local).AddTicks(8081), "e-1", true, "What is the capital of the United Kingdom?", 1, 1, null },
                    { "q-2", null, new DateTime(2024, 3, 26, 13, 1, 39, 535, DateTimeKind.Local).AddTicks(8087), "e-1", true, "What is the capital of Germany?", 2, 1, null },
                    { "q-3", null, new DateTime(2024, 3, 26, 13, 1, 39, 535, DateTimeKind.Local).AddTicks(8093), "e-1", true, "What is the capital of Italy?", 3, 1, null },
                    { "q-4", null, new DateTime(2024, 3, 26, 13, 1, 39, 535, DateTimeKind.Local).AddTicks(8099), "e-2", true, "What is the capital of the United Kingdom?", 1, 1, null },
                    { "q-5", null, new DateTime(2024, 3, 26, 13, 1, 39, 535, DateTimeKind.Local).AddTicks(8106), "e-2", true, "What is the capital of Germany?", 2, 1, null },
                    { "q-6", null, new DateTime(2024, 3, 26, 13, 1, 39, 535, DateTimeKind.Local).AddTicks(8112), "e-2", true, "What is the capital of Italy?", 3, 1, null },
                    { "q-7", null, new DateTime(2024, 3, 26, 13, 1, 39, 535, DateTimeKind.Local).AddTicks(8117), "e-3", true, "What is the largest ocean on Earth?", 1, 1, null },
                    { "q-8", null, new DateTime(2024, 3, 26, 13, 1, 39, 535, DateTimeKind.Local).AddTicks(8122), "e-3", true, "Which planet is known as the Red Planet?", 2, 1, null },
                    { "q-9", null, new DateTime(2024, 3, 26, 13, 1, 39, 535, DateTimeKind.Local).AddTicks(8128), "e-3", true, "What is the chemical symbol for water?", 3, 1, null }
                });

            migrationBuilder.InsertData(
                table: "StudentsExams",
                columns: new[] { "Id", "CreatedAt", "ExamId", "ExamStartTime", "Grade", "StudentId", "StudentName", "UserId", "WasExamLoggedInToByStudent" },
                values: new object[,]
                {
                    { "se-1", new DateTime(2024, 3, 26, 13, 1, 39, 535, DateTimeKind.Local).AddTicks(8162), "e-1", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 90, "s-1", "Alice Smith", null, false },
                    { "se-2", new DateTime(2024, 3, 26, 13, 1, 39, 535, DateTimeKind.Local).AddTicks(8169), "e-2", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 85, "s-2", "Alice Smith", null, false },
                    { "se-3", new DateTime(2024, 3, 26, 13, 1, 39, 535, DateTimeKind.Local).AddTicks(8173), "e-3", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 95, "s-2", "Rifka Smith", null, false },
                    { "se-4", new DateTime(2024, 3, 26, 13, 1, 39, 535, DateTimeKind.Local).AddTicks(8178), "e-1", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 80, "s-2", "Rifka Smith", null, false }
                });

            migrationBuilder.InsertData(
                table: "Answers",
                columns: new[] { "Id", "AnswerDescription", "AnswerNumber", "CreatedAt", "IsCorrect", "QuestionId" },
                values: new object[,]
                {
                    { "a-101", "Paris", 1, new DateTime(2024, 3, 26, 13, 1, 39, 535, DateTimeKind.Local).AddTicks(7550), true, "q-1" },
                    { "a-2", "London", 2, new DateTime(2024, 3, 26, 13, 1, 39, 535, DateTimeKind.Local).AddTicks(7654), false, "q-1" },
                    { "a-21", "Paris", 1, new DateTime(2024, 3, 26, 13, 1, 39, 535, DateTimeKind.Local).AddTicks(7663), true, "q-2" },
                    { "a-22", "London", 2, new DateTime(2024, 3, 26, 13, 1, 39, 535, DateTimeKind.Local).AddTicks(7666), false, "q-2" },
                    { "a-23", "Berlin", 3, new DateTime(2024, 3, 26, 13, 1, 39, 535, DateTimeKind.Local).AddTicks(7686), false, "q-2" },
                    { "a-24", "Rome", 4, new DateTime(2024, 3, 26, 13, 1, 39, 535, DateTimeKind.Local).AddTicks(7689), false, "q-2" },
                    { "a-3", "Berlin", 3, new DateTime(2024, 3, 26, 13, 1, 39, 535, DateTimeKind.Local).AddTicks(7658), false, "q-1" },
                    { "a-31", "Paris", 1, new DateTime(2024, 3, 26, 13, 1, 39, 535, DateTimeKind.Local).AddTicks(7691), true, "q-3" },
                    { "a-32", "London", 2, new DateTime(2024, 3, 26, 13, 1, 39, 535, DateTimeKind.Local).AddTicks(7694), false, "q-3" },
                    { "a-33", "Berlin", 3, new DateTime(2024, 3, 26, 13, 1, 39, 535, DateTimeKind.Local).AddTicks(7697), false, "q-3" },
                    { "a-34", "Rome", 4, new DateTime(2024, 3, 26, 13, 1, 39, 535, DateTimeKind.Local).AddTicks(7699), false, "q-3" },
                    { "a-4", "Rome", 4, new DateTime(2024, 3, 26, 13, 1, 39, 535, DateTimeKind.Local).AddTicks(7661), false, "q-1" },
                    { "a-41", "Paris", 1, new DateTime(2024, 3, 26, 13, 1, 39, 535, DateTimeKind.Local).AddTicks(7702), true, "q-4" },
                    { "a-42", "London", 2, new DateTime(2024, 3, 26, 13, 1, 39, 535, DateTimeKind.Local).AddTicks(7705), false, "q-4" },
                    { "a-43", "Berlin", 3, new DateTime(2024, 3, 26, 13, 1, 39, 535, DateTimeKind.Local).AddTicks(7710), false, "q-4" },
                    { "a-44", "Rome", 4, new DateTime(2024, 3, 26, 13, 1, 39, 535, DateTimeKind.Local).AddTicks(7712), false, "q-4" },
                    { "a-51", "Paris", 1, new DateTime(2024, 3, 26, 13, 1, 39, 535, DateTimeKind.Local).AddTicks(7715), true, "q-5" },
                    { "a-52", "London", 2, new DateTime(2024, 3, 26, 13, 1, 39, 535, DateTimeKind.Local).AddTicks(7718), false, "q-5" },
                    { "a-53", "Berlin", 3, new DateTime(2024, 3, 26, 13, 1, 39, 535, DateTimeKind.Local).AddTicks(7720), false, "q-5" },
                    { "a-54", "Rome", 4, new DateTime(2024, 3, 26, 13, 1, 39, 535, DateTimeKind.Local).AddTicks(7723), false, "q-5" },
                    { "a-61", "Paris", 1, new DateTime(2024, 3, 26, 13, 1, 39, 535, DateTimeKind.Local).AddTicks(7726), true, "q-6" },
                    { "a-62", "London", 2, new DateTime(2024, 3, 26, 13, 1, 39, 535, DateTimeKind.Local).AddTicks(7729), false, "q-6" },
                    { "a-63", "Berlin", 3, new DateTime(2024, 3, 26, 13, 1, 39, 535, DateTimeKind.Local).AddTicks(7733), false, "q-6" },
                    { "a-64", "Rome", 4, new DateTime(2024, 3, 26, 13, 1, 39, 535, DateTimeKind.Local).AddTicks(7736), false, "q-6" },
                    { "a-71", "Pacific Ocean", 1, new DateTime(2024, 3, 26, 13, 1, 39, 535, DateTimeKind.Local).AddTicks(7739), true, "q-7" },
                    { "a-72", "Atlantic Ocean", 2, new DateTime(2024, 3, 26, 13, 1, 39, 535, DateTimeKind.Local).AddTicks(7741), false, "q-7" },
                    { "a-73", "Indian Ocean", 3, new DateTime(2024, 3, 26, 13, 1, 39, 535, DateTimeKind.Local).AddTicks(7744), false, "q-7" },
                    { "a-74", "Arctic Ocean", 4, new DateTime(2024, 3, 26, 13, 1, 39, 535, DateTimeKind.Local).AddTicks(7746), false, "q-7" },
                    { "a-81", "Mercury", 1, new DateTime(2024, 3, 26, 13, 1, 39, 535, DateTimeKind.Local).AddTicks(7749), true, "q-8" },
                    { "a-82", "Atlantic Ocean", 2, new DateTime(2024, 3, 26, 13, 1, 39, 535, DateTimeKind.Local).AddTicks(7752), false, "q-8" },
                    { "a-83", "Indian Ocean", 3, new DateTime(2024, 3, 26, 13, 1, 39, 535, DateTimeKind.Local).AddTicks(7756), false, "q-8" },
                    { "a-84", "Arctic Ocean", 4, new DateTime(2024, 3, 26, 13, 1, 39, 535, DateTimeKind.Local).AddTicks(7759), false, "q-8" },
                    { "a-91", "Mercury", 1, new DateTime(2024, 3, 26, 13, 1, 39, 535, DateTimeKind.Local).AddTicks(7762), true, "q-9" },
                    { "a-92", "Atlantic Ocean", 2, new DateTime(2024, 3, 26, 13, 1, 39, 535, DateTimeKind.Local).AddTicks(7765), false, "q-9" },
                    { "a-93", "Indian Ocean", 3, new DateTime(2024, 3, 26, 13, 1, 39, 535, DateTimeKind.Local).AddTicks(7767), false, "q-9" },
                    { "a-94", "Arctic Ocean", 4, new DateTime(2024, 3, 26, 13, 1, 39, 535, DateTimeKind.Local).AddTicks(7770), false, "q-9" }
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
