using Exams_App_C__.Net_Server.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace Exams_App_C__.Net_Server.Data.SeedData
{
    public static class QuestionSeedData
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Question>().HasData(
        // Questions for Midterm Exam (e-2)
        new Question
        {
            Id = "q-1",
            CreatedAt = DateTime.Now,
            QuestionNumber = 1,
            QuestionDescription = "What is the capital of the United Kingdom?",
            IsOrderAnswersRandom = true,
            QuestionScoring = 1,
            ExamId = "e-1"
        },
        new Question
        {
            Id = "q-2",
            CreatedAt = DateTime.Now,
            QuestionNumber = 2,
            QuestionDescription = "What is the capital of Germany?",
            IsOrderAnswersRandom = true,
            QuestionScoring = 1,
            ExamId = "e-1"
        },
        new Question
        {
            Id = "q-3",
            CreatedAt = DateTime.Now,
            QuestionNumber = 3,
            QuestionDescription = "What is the capital of Italy?",
            IsOrderAnswersRandom = true,
            QuestionScoring = 1,
            ExamId = "e-1"
        },
        // Questions for Midterm Exam (e-2)
        new Question
        {
            Id = "q-4",
            CreatedAt = DateTime.Now,
            QuestionNumber = 1,
            QuestionDescription = "What is the capital of the United Kingdom?",
            IsOrderAnswersRandom = true,
            QuestionScoring = 1,
            ExamId = "e-2"
        },
        new Question
        {
            Id = "q-5",
            CreatedAt = DateTime.Now,
            QuestionNumber = 2,
            QuestionDescription = "What is the capital of Germany?",
            IsOrderAnswersRandom = true,
            QuestionScoring = 1,
            ExamId = "e-2"
        },
        new Question
        {
            Id = "q-6",
            CreatedAt = DateTime.Now,
            QuestionNumber = 3,
            QuestionDescription = "What is the capital of Italy?",
            IsOrderAnswersRandom = true,
            QuestionScoring = 1,
            ExamId = "e-2"
        },

        // Questions for Final Exam (e-3)
        new Question
        {
            Id = "q-7",
            CreatedAt = DateTime.Now,
            QuestionNumber = 1,
            QuestionDescription = "What is the largest ocean on Earth?",
            IsOrderAnswersRandom = true,
            QuestionScoring = 1,
            ExamId = "e-3"
        },
        new Question
        {
            Id = "q-8",
            CreatedAt = DateTime.Now,
            QuestionNumber = 2,
            QuestionDescription = "Which planet is known as the Red Planet?",
            IsOrderAnswersRandom = true,
            QuestionScoring = 1,
            ExamId = "e-3"
        },
        new Question
        {
            Id = "q-9",
            CreatedAt = DateTime.Now,
            QuestionNumber = 3,
            QuestionDescription = "What is the chemical symbol for water?",
            IsOrderAnswersRandom = true,
            QuestionScoring = 1,
            ExamId = "e-3"
        }
    );
        }
    }
}
