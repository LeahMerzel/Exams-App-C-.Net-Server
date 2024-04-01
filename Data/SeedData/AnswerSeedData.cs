using Exams_App_C__.Net_Server.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Exams_App_C__.Net_Server.Data.SeedData
{
    public static class AnswerSeedData
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Answer>().HasData(
                new Answer { Id = "a-101", AnswerNumber = 1, AnswerDescription = "Paris", IsCorrect = false, QuestionId = "q-1" },
                new Answer { Id = "a-2", AnswerNumber = 2, AnswerDescription = "London", IsCorrect = true, QuestionId = "q-1" },
                new Answer { Id = "a-3", AnswerNumber = 3, AnswerDescription = "Berlin", IsCorrect = false, QuestionId = "q-1" },
                new Answer { Id = "a-4", AnswerNumber = 4, AnswerDescription = "Rome", IsCorrect = false, QuestionId = "q-1" },

                new Answer { Id = "a-21", AnswerNumber = 1, AnswerDescription = "Paris", IsCorrect = false, QuestionId = "q-2" },
                new Answer { Id = "a-22", AnswerNumber = 2, AnswerDescription = "London", IsCorrect = false, QuestionId = "q-2" },
                new Answer { Id = "a-23", AnswerNumber = 3, AnswerDescription = "Berlin", IsCorrect = true, QuestionId = "q-2" },
                new Answer { Id = "a-24", AnswerNumber = 4, AnswerDescription = "Rome", IsCorrect = false, QuestionId = "q-2" },

                new Answer { Id = "a-31", AnswerNumber = 1, AnswerDescription = "Paris", IsCorrect = false, QuestionId = "q-3" },
                new Answer { Id = "a-32", AnswerNumber = 2, AnswerDescription = "London", IsCorrect = false, QuestionId = "q-3" },
                new Answer { Id = "a-33", AnswerNumber = 3, AnswerDescription = "Berlin", IsCorrect = false, QuestionId = "q-3" },
                new Answer { Id = "a-34", AnswerNumber = 4, AnswerDescription = "Rome", IsCorrect = true, QuestionId = "q-3" },

            // Answers for Question q-4
            new Answer { Id = "a-41", AnswerNumber = 1, AnswerDescription = "Paris", IsCorrect = true, QuestionId = "q-4" },
            new Answer { Id = "a-42", AnswerNumber = 2, AnswerDescription = "London", IsCorrect = false, QuestionId = "q-4" },
            new Answer { Id = "a-43", AnswerNumber = 3, AnswerDescription = "Berlin", IsCorrect = false, QuestionId = "q-4" },
            new Answer { Id = "a-44", AnswerNumber = 4, AnswerDescription = "Rome", IsCorrect = false, QuestionId = "q-4" },

            // Answers for Question q-5
            new Answer { Id = "a-51", AnswerNumber = 1, AnswerDescription = "Paris", IsCorrect = true, QuestionId = "q-5" },
            new Answer { Id = "a-52", AnswerNumber = 2, AnswerDescription = "London", IsCorrect = false, QuestionId = "q-5" },
            new Answer { Id = "a-53", AnswerNumber = 3, AnswerDescription = "Berlin", IsCorrect = false, QuestionId = "q-5" },
            new Answer { Id = "a-54", AnswerNumber = 4, AnswerDescription = "Rome", IsCorrect = false, QuestionId = "q-5" },

            // Answers for Question q-6
            new Answer { Id = "a-61", AnswerNumber = 1, AnswerDescription = "Paris", IsCorrect = true, QuestionId = "q-6" },
            new Answer { Id = "a-62", AnswerNumber = 2, AnswerDescription = "London", IsCorrect = false, QuestionId = "q-6" },
            new Answer { Id = "a-63", AnswerNumber = 3, AnswerDescription = "Berlin", IsCorrect = false, QuestionId = "q-6" },
            new Answer { Id = "a-64", AnswerNumber = 4, AnswerDescription = "Rome", IsCorrect = false, QuestionId = "q-6" },

            // Answers for Question q-7
            new Answer { Id = "a-71", AnswerNumber = 1, AnswerDescription = "Pacific Ocean", IsCorrect = true, QuestionId = "q-7" },
            new Answer { Id = "a-72", AnswerNumber = 2, AnswerDescription = "Atlantic Ocean", IsCorrect = false, QuestionId = "q-7" },
            new Answer { Id = "a-73", AnswerNumber = 3, AnswerDescription = "Indian Ocean", IsCorrect = false, QuestionId = "q-7" },
            new Answer { Id = "a-74", AnswerNumber = 4, AnswerDescription = "Arctic Ocean", IsCorrect = false, QuestionId = "q-7" },

            // Answers for Question q-8
            new Answer { Id = "a-81", AnswerNumber = 1, AnswerDescription = "Mercury", IsCorrect = true, QuestionId = "q-8" },
            new Answer { Id = "a-82", AnswerNumber = 2, AnswerDescription = "Atlantic Ocean", IsCorrect = false, QuestionId = "q-8" },
            new Answer { Id = "a-83", AnswerNumber = 3, AnswerDescription = "Indian Ocean", IsCorrect = false, QuestionId = "q-8" },
            new Answer { Id = "a-84", AnswerNumber = 4, AnswerDescription = "Arctic Ocean", IsCorrect = false, QuestionId = "q-8" },

            // Answers for Question q-9
            new Answer { Id = "a-91", AnswerNumber = 1, AnswerDescription = "Mercury", IsCorrect = true, QuestionId = "q-9" },
            new Answer { Id = "a-92", AnswerNumber = 2, AnswerDescription = "Atlantic Ocean", IsCorrect = false, QuestionId = "q-9" },
            new Answer { Id = "a-93", AnswerNumber = 3, AnswerDescription = "Indian Ocean", IsCorrect = false, QuestionId = "q-9" },
            new Answer { Id = "a-94", AnswerNumber = 4, AnswerDescription = "Arctic Ocean", IsCorrect = false, QuestionId = "q-9" }
            );
        }
    }
}
