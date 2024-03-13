using Exams_App_C__.Net_Server.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Exams_App_C__.Net_Server.Data.SeedData
{
    public static class AnswerSeedData
    {
            public static void Seed(ModelBuilder modelBuilder)
            {
                modelBuilder.Entity<Answer>().HasData(
                    new Answer { Id = "a-61", AnswerNumber = 1, AnswerDescription = "Paris", IsCorrect = true, QuestionId = "q-1" },
                    new Answer { Id = "a-2", AnswerNumber = 2, AnswerDescription = "London", IsCorrect = false, QuestionId = "q-1" },
                    new Answer { Id = "a-3", AnswerNumber = 3, AnswerDescription = "Berlin", IsCorrect = false, QuestionId = "q-1" },
                    new Answer { Id = "a-4", AnswerNumber = 4, AnswerDescription = "Rome", IsCorrect = false, QuestionId = "q-1" },

                    new Answer { Id = "a-21", AnswerNumber = 1, AnswerDescription = "Paris", IsCorrect = true, QuestionId = "q-2" },
                    new Answer { Id = "a-22", AnswerNumber = 2, AnswerDescription = "London", IsCorrect = false, QuestionId = "q-2" },
                    new Answer { Id = "a-23", AnswerNumber = 3, AnswerDescription = "Berlin", IsCorrect = false, QuestionId = "q-2" },
                    new Answer { Id = "a-24", AnswerNumber = 4, AnswerDescription = "Rome", IsCorrect = false, QuestionId = "q-2" },

                    new Answer { Id = "a-31", AnswerNumber = 1, AnswerDescription = "Paris", IsCorrect = true, QuestionId = "q-3" },
                    new Answer { Id = "a-32", AnswerNumber = 2, AnswerDescription = "London", IsCorrect = false, QuestionId = "q-3" },
                    new Answer { Id = "a-33", AnswerNumber = 3, AnswerDescription = "Berlin", IsCorrect = false, QuestionId = "q-3" },
                    new Answer { Id = "a-34", AnswerNumber = 4, AnswerDescription = "Rome", IsCorrect = false, QuestionId = "q-3" }
                );
            }
    }
}
