using Exams_App_C__.Net_Server.Data.DB;
using Exams_App_C__.Net_Server.Data.Models;
using Microsoft.EntityFrameworkCore;


namespace Exams_App_C__.Net_Server.Repositories
{
    public class StudentExamRepository : GenericRepository<StudentExam>
    {
        public StudentExamRepository(ExamsDbContext dbContext) : base(dbContext)
        {
        }


        public async Task<int> PushToQuestionsFailed(string studentExamId, IList<Question> failedQuestions)
        {
            if (studentExamId == null || failedQuestions == null) { return 0; }
            var studentExam = await dbContext.StudentsExams.SingleOrDefaultAsync(se => se.Id == studentExamId);
            if (studentExam == null) { return 0; }
            foreach (var question in failedQuestions)
            {
                studentExam.QuestionsFailed.Add(question);
            }
            await dbContext.SaveChangesAsync();
            return 1;
        }
        public async Task<List<Question>?> GetQuestionFailedListAsync(string studentExamId)
        {
            if (studentExamId == null) { return null; }
            var questionFailedList = await dbContext.StudentsExams
                           .Where(se => se.Id == studentExamId)
                           .SelectMany(se => se.QuestionsFailed)
                           .ToListAsync();

            return questionFailedList;
        }
    }
}
