using Exams_App_C__.Net_Server.Data.DB;
using Exams_App_C__.Net_Server.Data.Models;
using Exams_App_C__.Net_Server.Repositories;


namespace Exams_App_C__.Net_Server.Core.Repositories
{
    public class AnswerRepository : GenericRepository<Answer>
    {
        public AnswerRepository(ExamsDbContext dbContext) : base(dbContext)
        {
        }

    }
}
