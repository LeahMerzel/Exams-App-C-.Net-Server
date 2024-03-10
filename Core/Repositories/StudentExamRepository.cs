using Exams_App_C__.Net_Server.Data.DB;
using Exams_App_C__.Net_Server.Data.Models;


namespace Exams_App_C__.Net_Server.Repositories
{
    public class StudentExamRepository : GenericRepository<StudentExam>
    {
        public StudentExamRepository(ExamsDbContext dbContext) : base(dbContext)
        {
        }

    }
}
