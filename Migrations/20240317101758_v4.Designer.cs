﻿// <auto-generated />
using System;
using Exams_App_C__.Net_Server.Data.DB;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Exams_App_C__.Net_Server.Migrations
{
    [DbContext(typeof(ExamsDbContext))]
    [Migration("20240317101758_v4")]
    partial class v4
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Exams_App_C__.Net_Server.Data.Models.Answer", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("AnswerDescription")
                        .IsRequired()
                        .HasMaxLength(2000)
                        .HasColumnType("nvarchar(2000)");

                    b.Property<int>("AnswerNumber")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsCorrect")
                        .HasColumnType("bit");

                    b.Property<string>("QuestionId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("QuestionId");

                    b.ToTable("Answers");

                    b.HasData(
                        new
                        {
                            Id = "a-61",
                            AnswerDescription = "Paris",
                            AnswerNumber = 1,
                            CreatedAt = new DateTime(2024, 3, 17, 12, 17, 57, 763, DateTimeKind.Local).AddTicks(1024),
                            IsCorrect = true,
                            QuestionId = "q-1"
                        },
                        new
                        {
                            Id = "a-2",
                            AnswerDescription = "London",
                            AnswerNumber = 2,
                            CreatedAt = new DateTime(2024, 3, 17, 12, 17, 57, 763, DateTimeKind.Local).AddTicks(1091),
                            IsCorrect = false,
                            QuestionId = "q-1"
                        },
                        new
                        {
                            Id = "a-3",
                            AnswerDescription = "Berlin",
                            AnswerNumber = 3,
                            CreatedAt = new DateTime(2024, 3, 17, 12, 17, 57, 763, DateTimeKind.Local).AddTicks(1095),
                            IsCorrect = false,
                            QuestionId = "q-1"
                        },
                        new
                        {
                            Id = "a-4",
                            AnswerDescription = "Rome",
                            AnswerNumber = 4,
                            CreatedAt = new DateTime(2024, 3, 17, 12, 17, 57, 763, DateTimeKind.Local).AddTicks(1098),
                            IsCorrect = false,
                            QuestionId = "q-1"
                        },
                        new
                        {
                            Id = "a-21",
                            AnswerDescription = "Paris",
                            AnswerNumber = 1,
                            CreatedAt = new DateTime(2024, 3, 17, 12, 17, 57, 763, DateTimeKind.Local).AddTicks(1101),
                            IsCorrect = true,
                            QuestionId = "q-2"
                        },
                        new
                        {
                            Id = "a-22",
                            AnswerDescription = "London",
                            AnswerNumber = 2,
                            CreatedAt = new DateTime(2024, 3, 17, 12, 17, 57, 763, DateTimeKind.Local).AddTicks(1113),
                            IsCorrect = false,
                            QuestionId = "q-2"
                        },
                        new
                        {
                            Id = "a-23",
                            AnswerDescription = "Berlin",
                            AnswerNumber = 3,
                            CreatedAt = new DateTime(2024, 3, 17, 12, 17, 57, 763, DateTimeKind.Local).AddTicks(1116),
                            IsCorrect = false,
                            QuestionId = "q-2"
                        },
                        new
                        {
                            Id = "a-24",
                            AnswerDescription = "Rome",
                            AnswerNumber = 4,
                            CreatedAt = new DateTime(2024, 3, 17, 12, 17, 57, 763, DateTimeKind.Local).AddTicks(1119),
                            IsCorrect = false,
                            QuestionId = "q-2"
                        },
                        new
                        {
                            Id = "a-31",
                            AnswerDescription = "Paris",
                            AnswerNumber = 1,
                            CreatedAt = new DateTime(2024, 3, 17, 12, 17, 57, 763, DateTimeKind.Local).AddTicks(1122),
                            IsCorrect = true,
                            QuestionId = "q-3"
                        },
                        new
                        {
                            Id = "a-32",
                            AnswerDescription = "London",
                            AnswerNumber = 2,
                            CreatedAt = new DateTime(2024, 3, 17, 12, 17, 57, 763, DateTimeKind.Local).AddTicks(1160),
                            IsCorrect = false,
                            QuestionId = "q-3"
                        },
                        new
                        {
                            Id = "a-33",
                            AnswerDescription = "Berlin",
                            AnswerNumber = 3,
                            CreatedAt = new DateTime(2024, 3, 17, 12, 17, 57, 763, DateTimeKind.Local).AddTicks(1163),
                            IsCorrect = false,
                            QuestionId = "q-3"
                        },
                        new
                        {
                            Id = "a-34",
                            AnswerDescription = "Rome",
                            AnswerNumber = 4,
                            CreatedAt = new DateTime(2024, 3, 17, 12, 17, 57, 763, DateTimeKind.Local).AddTicks(1166),
                            IsCorrect = false,
                            QuestionId = "q-3"
                        });
                });

            modelBuilder.Entity("Exams_App_C__.Net_Server.Data.Models.Course", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("CourseDescription")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<DateTime>("CourseEndingDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("CourseName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("CourseStartingDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Courses");

                    b.HasData(
                        new
                        {
                            Id = "c-1",
                            CourseDescription = "This course provides an introduction to programming concepts using a variety of languages.",
                            CourseEndingDate = new DateTime(2024, 6, 17, 12, 17, 57, 763, DateTimeKind.Local).AddTicks(1307),
                            CourseName = "Introduction to Programming",
                            CourseStartingDate = new DateTime(2024, 3, 17, 12, 17, 57, 763, DateTimeKind.Local).AddTicks(1306),
                            CreatedAt = new DateTime(2024, 3, 17, 12, 17, 57, 763, DateTimeKind.Local).AddTicks(1300)
                        },
                        new
                        {
                            Id = "c-2",
                            CourseDescription = "This course provides an introduction to programming concepts using a variety of languages.",
                            CourseEndingDate = new DateTime(2024, 6, 17, 12, 17, 57, 763, DateTimeKind.Local).AddTicks(1320),
                            CourseName = "Introduction to Programming 2",
                            CourseStartingDate = new DateTime(2024, 3, 17, 12, 17, 57, 763, DateTimeKind.Local).AddTicks(1319),
                            CreatedAt = new DateTime(2024, 3, 17, 12, 17, 57, 763, DateTimeKind.Local).AddTicks(1317)
                        },
                        new
                        {
                            Id = "c-3",
                            CourseDescription = "This course provides an introduction to programming concepts using a variety of languages.",
                            CourseEndingDate = new DateTime(2024, 6, 17, 12, 17, 57, 763, DateTimeKind.Local).AddTicks(1326),
                            CourseName = "Introduction to Programming 3",
                            CourseStartingDate = new DateTime(2024, 3, 17, 12, 17, 57, 763, DateTimeKind.Local).AddTicks(1325),
                            CreatedAt = new DateTime(2024, 3, 17, 12, 17, 57, 763, DateTimeKind.Local).AddTicks(1323)
                        });
                });

            modelBuilder.Entity("Exams_App_C__.Net_Server.Data.Models.Exam", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("CourseId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("ExamDescription")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<int?>("ExamDurationInMinutes")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<float?>("ExamGradeAvg")
                        .HasColumnType("real");

                    b.Property<string>("ExamName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<bool?>("IsOrderQuestionsRandom")
                        .IsRequired()
                        .HasColumnType("bit");

                    b.Property<DateTime?>("StartExamDateTime")
                        .IsRequired()
                        .HasColumnType("datetime2");

                    b.Property<string>("TeacherId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("CourseId");

                    b.HasIndex("UserId");

                    b.ToTable("Exams");

                    b.HasData(
                        new
                        {
                            Id = "e-1",
                            CourseId = "c-1",
                            CreatedAt = new DateTime(2024, 3, 17, 12, 17, 57, 763, DateTimeKind.Local).AddTicks(1354),
                            ExamDescription = "Description of Midterm Exam",
                            ExamDurationInMinutes = 120,
                            ExamGradeAvg = 0f,
                            ExamName = "Midterm Exam",
                            IsOrderQuestionsRandom = true,
                            StartExamDateTime = new DateTime(2024, 3, 24, 12, 17, 57, 763, DateTimeKind.Local).AddTicks(1360),
                            TeacherId = "t-1"
                        },
                        new
                        {
                            Id = "e-2",
                            CourseId = "c-2",
                            CreatedAt = new DateTime(2024, 3, 17, 12, 17, 57, 763, DateTimeKind.Local).AddTicks(1368),
                            ExamDescription = "Description of Final Exam",
                            ExamDurationInMinutes = 180,
                            ExamGradeAvg = 0f,
                            ExamName = "Final Exam",
                            IsOrderQuestionsRandom = true,
                            StartExamDateTime = new DateTime(2024, 3, 31, 12, 17, 57, 763, DateTimeKind.Local).AddTicks(1370),
                            TeacherId = "t-1"
                        },
                        new
                        {
                            Id = "e-3",
                            CourseId = "c-1",
                            CreatedAt = new DateTime(2024, 3, 17, 12, 17, 57, 763, DateTimeKind.Local).AddTicks(1374),
                            ExamDescription = "Description of Quiz 1",
                            ExamDurationInMinutes = 60,
                            ExamGradeAvg = 0f,
                            ExamName = "Quiz 1",
                            IsOrderQuestionsRandom = false,
                            StartExamDateTime = new DateTime(2024, 4, 7, 12, 17, 57, 763, DateTimeKind.Local).AddTicks(1376),
                            TeacherId = "t-1"
                        });
                });

            modelBuilder.Entity("Exams_App_C__.Net_Server.Data.Models.Question", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("ExamId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<bool>("IsOrderAnswersRandom")
                        .HasColumnType("bit");

                    b.Property<string>("QuestionDescription")
                        .IsRequired()
                        .HasMaxLength(2000)
                        .HasColumnType("nvarchar(2000)");

                    b.Property<int>("QuestionNumber")
                        .HasColumnType("int");

                    b.Property<int>("QuestionScoring")
                        .HasColumnType("int");

                    b.Property<string>("StudentExamId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("ExamId");

                    b.HasIndex("StudentExamId");

                    b.ToTable("Questions");

                    b.HasData(
                        new
                        {
                            Id = "q-1",
                            CreatedAt = new DateTime(2024, 3, 17, 12, 17, 57, 763, DateTimeKind.Local).AddTicks(1405),
                            ExamId = "e-1",
                            IsOrderAnswersRandom = true,
                            QuestionDescription = "What is the capital of the United Kingdom?",
                            QuestionNumber = 1,
                            QuestionScoring = 1
                        },
                        new
                        {
                            Id = "q-2",
                            CreatedAt = new DateTime(2024, 3, 17, 12, 17, 57, 763, DateTimeKind.Local).AddTicks(1410),
                            ExamId = "e-1",
                            IsOrderAnswersRandom = true,
                            QuestionDescription = "What is the capital of Germany?",
                            QuestionNumber = 2,
                            QuestionScoring = 1
                        },
                        new
                        {
                            Id = "q-3",
                            CreatedAt = new DateTime(2024, 3, 17, 12, 17, 57, 763, DateTimeKind.Local).AddTicks(1415),
                            ExamId = "e-1",
                            IsOrderAnswersRandom = true,
                            QuestionDescription = "What is the capital of Italy?",
                            QuestionNumber = 3,
                            QuestionScoring = 1
                        },
                        new
                        {
                            Id = "q-4",
                            CreatedAt = new DateTime(2024, 3, 17, 12, 17, 57, 763, DateTimeKind.Local).AddTicks(1421),
                            ExamId = "e-2",
                            IsOrderAnswersRandom = true,
                            QuestionDescription = "What is the capital of the United Kingdom?",
                            QuestionNumber = 1,
                            QuestionScoring = 1
                        },
                        new
                        {
                            Id = "q-5",
                            CreatedAt = new DateTime(2024, 3, 17, 12, 17, 57, 763, DateTimeKind.Local).AddTicks(1426),
                            ExamId = "e-2",
                            IsOrderAnswersRandom = true,
                            QuestionDescription = "What is the capital of Germany?",
                            QuestionNumber = 2,
                            QuestionScoring = 1
                        },
                        new
                        {
                            Id = "q-6",
                            CreatedAt = new DateTime(2024, 3, 17, 12, 17, 57, 763, DateTimeKind.Local).AddTicks(1430),
                            ExamId = "e-2",
                            IsOrderAnswersRandom = true,
                            QuestionDescription = "What is the capital of Italy?",
                            QuestionNumber = 3,
                            QuestionScoring = 1
                        },
                        new
                        {
                            Id = "q-7",
                            CreatedAt = new DateTime(2024, 3, 17, 12, 17, 57, 763, DateTimeKind.Local).AddTicks(1434),
                            ExamId = "e-3",
                            IsOrderAnswersRandom = true,
                            QuestionDescription = "What is the largest ocean on Earth?",
                            QuestionNumber = 1,
                            QuestionScoring = 1
                        },
                        new
                        {
                            Id = "q-8",
                            CreatedAt = new DateTime(2024, 3, 17, 12, 17, 57, 763, DateTimeKind.Local).AddTicks(1438),
                            ExamId = "e-3",
                            IsOrderAnswersRandom = true,
                            QuestionDescription = "Which planet is known as the Red Planet?",
                            QuestionNumber = 2,
                            QuestionScoring = 1
                        },
                        new
                        {
                            Id = "q-9",
                            CreatedAt = new DateTime(2024, 3, 17, 12, 17, 57, 763, DateTimeKind.Local).AddTicks(1442),
                            ExamId = "e-3",
                            IsOrderAnswersRandom = true,
                            QuestionDescription = "What is the chemical symbol for water?",
                            QuestionNumber = 3,
                            QuestionScoring = 1
                        });
                });

            modelBuilder.Entity("Exams_App_C__.Net_Server.Data.Models.StudentExam", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("ExamId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("ExamStartTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("Grade")
                        .HasColumnType("int");

                    b.Property<string>("StudentId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StudentName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<bool>("WasExamLoggedInToByStudent")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("ExamId");

                    b.HasIndex("UserId");

                    b.ToTable("StudentsExams");

                    b.HasData(
                        new
                        {
                            Id = "se-1",
                            CreatedAt = new DateTime(2024, 3, 17, 12, 17, 57, 763, DateTimeKind.Local).AddTicks(1635),
                            ExamId = "e-1",
                            ExamStartTime = new DateTime(2024, 3, 17, 10, 17, 57, 763, DateTimeKind.Local).AddTicks(1649),
                            Grade = 90,
                            StudentId = "s-1",
                            StudentName = "Alice Smith",
                            WasExamLoggedInToByStudent = true
                        },
                        new
                        {
                            Id = "se-2",
                            CreatedAt = new DateTime(2024, 3, 17, 12, 17, 57, 763, DateTimeKind.Local).AddTicks(1653),
                            ExamId = "e-2",
                            ExamStartTime = new DateTime(2024, 3, 17, 9, 17, 57, 763, DateTimeKind.Local).AddTicks(1655),
                            Grade = 85,
                            StudentId = "s-2",
                            StudentName = "Alice Smith",
                            WasExamLoggedInToByStudent = true
                        },
                        new
                        {
                            Id = "se-3",
                            CreatedAt = new DateTime(2024, 3, 17, 12, 17, 57, 763, DateTimeKind.Local).AddTicks(1661),
                            ExamId = "e-3",
                            ExamStartTime = new DateTime(2024, 3, 17, 8, 17, 57, 763, DateTimeKind.Local).AddTicks(1663),
                            Grade = 95,
                            StudentId = "s-2",
                            StudentName = "Rifka Smith",
                            WasExamLoggedInToByStudent = true
                        },
                        new
                        {
                            Id = "se-4",
                            CreatedAt = new DateTime(2024, 3, 17, 12, 17, 57, 763, DateTimeKind.Local).AddTicks(1665),
                            ExamId = "e-1",
                            ExamStartTime = new DateTime(2024, 3, 17, 7, 17, 57, 763, DateTimeKind.Local).AddTicks(1667),
                            Grade = 80,
                            StudentId = "s-2",
                            StudentName = "Rifka Smith",
                            WasExamLoggedInToByStudent = true
                        });
                });

            modelBuilder.Entity("Exams_App_C__.Net_Server.Data.Models.User", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("CourseId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FullName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<float?>("StudentGradeAvg")
                        .HasColumnType("real");

                    b.Property<string>("Token")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserRole")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CourseId");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = "a-1",
                            CreatedAt = new DateTime(2024, 3, 17, 12, 17, 57, 763, DateTimeKind.Local).AddTicks(1693),
                            Email = "leahwalden4@gmail.com",
                            FullName = "The Admin",
                            PasswordHash = "adminPassw0rd!",
                            UserName = "admin",
                            UserRole = "Admin"
                        },
                        new
                        {
                            Id = "t-1",
                            CourseId = "c-1",
                            CreatedAt = new DateTime(2024, 3, 17, 12, 17, 57, 763, DateTimeKind.Local).AddTicks(1702),
                            Email = "john.doe@example.com",
                            FullName = "John Doe",
                            PasswordHash = "password1",
                            UserName = "teacher1",
                            UserRole = "Teacher"
                        },
                        new
                        {
                            Id = "s-1",
                            CourseId = "c-1",
                            CreatedAt = new DateTime(2024, 3, 17, 12, 17, 57, 763, DateTimeKind.Local).AddTicks(1706),
                            Email = "alice.smith@example.com",
                            FullName = "Alice Smith",
                            PasswordHash = "password1",
                            StudentGradeAvg = 0f,
                            UserName = "student1",
                            UserRole = "Student"
                        },
                        new
                        {
                            Id = "s-2",
                            CourseId = "c-1",
                            CreatedAt = new DateTime(2024, 3, 17, 12, 17, 57, 763, DateTimeKind.Local).AddTicks(1710),
                            Email = "rifka.smith@example.com",
                            FullName = "Rifka Smith",
                            PasswordHash = "password2",
                            StudentGradeAvg = 0f,
                            UserName = "student2",
                            UserRole = "Student"
                        });
                });

            modelBuilder.Entity("Exams_App_C__.Net_Server.Data.Models.Answer", b =>
                {
                    b.HasOne("Exams_App_C__.Net_Server.Data.Models.Question", null)
                        .WithMany("Answers")
                        .HasForeignKey("QuestionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Exams_App_C__.Net_Server.Data.Models.Exam", b =>
                {
                    b.HasOne("Exams_App_C__.Net_Server.Data.Models.Course", null)
                        .WithMany("Exams")
                        .HasForeignKey("CourseId");

                    b.HasOne("Exams_App_C__.Net_Server.Data.Models.User", null)
                        .WithMany("TeachersExams")
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("Exams_App_C__.Net_Server.Data.Models.Question", b =>
                {
                    b.HasOne("Exams_App_C__.Net_Server.Data.Models.Exam", null)
                        .WithMany("ExamQuestions")
                        .HasForeignKey("ExamId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Exams_App_C__.Net_Server.Data.Models.StudentExam", null)
                        .WithMany("QuestionsFailed")
                        .HasForeignKey("StudentExamId");
                });

            modelBuilder.Entity("Exams_App_C__.Net_Server.Data.Models.StudentExam", b =>
                {
                    b.HasOne("Exams_App_C__.Net_Server.Data.Models.Exam", null)
                        .WithMany("StudentsExams")
                        .HasForeignKey("ExamId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Exams_App_C__.Net_Server.Data.Models.User", null)
                        .WithMany("StudentsTakenExams")
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("Exams_App_C__.Net_Server.Data.Models.User", b =>
                {
                    b.HasOne("Exams_App_C__.Net_Server.Data.Models.Course", null)
                        .WithMany("Users")
                        .HasForeignKey("CourseId");
                });

            modelBuilder.Entity("Exams_App_C__.Net_Server.Data.Models.Course", b =>
                {
                    b.Navigation("Exams");

                    b.Navigation("Users");
                });

            modelBuilder.Entity("Exams_App_C__.Net_Server.Data.Models.Exam", b =>
                {
                    b.Navigation("ExamQuestions");

                    b.Navigation("StudentsExams");
                });

            modelBuilder.Entity("Exams_App_C__.Net_Server.Data.Models.Question", b =>
                {
                    b.Navigation("Answers");
                });

            modelBuilder.Entity("Exams_App_C__.Net_Server.Data.Models.StudentExam", b =>
                {
                    b.Navigation("QuestionsFailed");
                });

            modelBuilder.Entity("Exams_App_C__.Net_Server.Data.Models.User", b =>
                {
                    b.Navigation("StudentsTakenExams");

                    b.Navigation("TeachersExams");
                });
#pragma warning restore 612, 618
        }
    }
}