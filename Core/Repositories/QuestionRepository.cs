using Exams_App_C__.Net_Server.Data.DB;
using Exams_App_C__.Net_Server.Data.Models;
using Exams_App_C__.Net_Server.Repositories;
using Microsoft.EntityFrameworkCore;


namespace Exams_App_C__.Net_Server.Core.Repositories
{
    public class QuestionRepository : GenericRepository<Question>
    {
        public QuestionRepository(ExamsDbContext dbContext) : base(dbContext)
        {
        }
        public async Task<List<Answer>> GetQuestionAnswersAsync(Question question)
        {
            var questionAnswersList = await dbContext.Answers
                           .Where(a => a.QuestionId == question.Id)
                           .ToListAsync();

            return questionAnswersList;
        }

    }
}
