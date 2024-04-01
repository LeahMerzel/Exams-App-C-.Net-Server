using Exams_App_C__.Net_Server.Data.Models;
using Microsoft.EntityFrameworkCore;
namespace Exams_App_C__.Net_Server.Data.SeedData
{
    public static class ExamSeedData
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Exam>().HasData(
            new Exam
            {
                Id = "e-1",
                ExamName = "Midterm Exam",
                TeacherName = "John Doe",
                TeacherId = "t-1",
                CourseId = "c-1",
                ExamDescription = "Description of Midterm Exam",
                StartExamDateTime = DateTime.Now.AddDays(7),
                IsOrderQuestionsRandom = true,
                ExamGradeAvg = 0.0f,
                ExamDurationInMinutes = 120
            },
            new Exam
            {
                Id = "e-2",
                ExamName = "Final Exam",
                TeacherName = "John Doe",
                TeacherId = "t-1",
                CourseId = "c-2",
                ExamDescription = "Description of Final Exam",
                StartExamDateTime = DateTime.Now.AddDays(14),
                IsOrderQuestionsRandom = true,
                ExamGradeAvg = 0.0f,
                ExamDurationInMinutes = 180
            },
            new Exam
            {
                Id = "e-3",
                ExamName = "Quiz 1",
                TeacherName = "John Doe",
                TeacherId = "t-1",
                CourseId = "c-1",
                ExamDescription = "Description of Quiz 1",
                StartExamDateTime = DateTime.Now.AddDays(21),
                IsOrderQuestionsRandom = false,
                ExamGradeAvg = 0.0f,
                ExamDurationInMinutes = 60
            }
        );
        }
    }
}
