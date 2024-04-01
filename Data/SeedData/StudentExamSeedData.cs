using Exams_App_C__.Net_Server.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Exams_App_C__.Net_Server.Data.SeedData
{
        public static class StudentExamSeedData
        {
            public static void Seed(ModelBuilder modelBuilder)
            {
                modelBuilder.Entity<StudentExam>().HasData(
               new StudentExam
               {
                   Id = "se-1",
                   StudentName = "Alice Smith",
                   Grade = 90,
                   StudentId = "s-1",
                   ExamId = "e-1",
                   WasExamLoggedInToByStudent = true
               },
                new StudentExam
                {
                    Id = "se-2",
                    StudentName = "Alice Smith",
                    Grade = 85,
                    StudentId = "s-2",
                    ExamId = "e-2",
                    WasExamLoggedInToByStudent = true
                },
                new StudentExam
                {
                    Id = "se-3",
                    StudentName = "Rifka Smith",
                    Grade = 95,
                    StudentId = "s-2",
                    ExamId = "e-3",
                    WasExamLoggedInToByStudent = true
                },
                new StudentExam
                {
                    Id = "se-4",
                    StudentName = "Rifka Smith",
                    Grade = 80,
                    StudentId = "s-2",
                    ExamId = "e-1",
                    WasExamLoggedInToByStudent = true
                }
            );
        }
    }
}
