using Exams_App_C__.Net_Server.Data.DB;
using Exams_App_C__.Net_Server.Data.Models;
using Exams_App_C__.Net_Server.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Exams_App_C__.Net_Server.Core.Repositories
{
    public class ExamRepository : GenericRepository<Exam>
    {
        public ExamRepository(ExamsDbContext dbContext) : base(dbContext)
        {
        }
        public async Task<List<Question>> GetExamQuestionssAsync(Exam exam)
        {
            var examQuestionsList = await dbContext.Questions
                           .Where(q => q.ExamId == exam.Id)
                           .ToListAsync();

            return examQuestionsList;
        }
        public async Task<List<StudentExam>> GetSubmittedStudentExams(Exam exam)
        {
            var submittedExamsList = await dbContext.StudentsExams
                .Where(st => st.ExamId == exam.Id)
                .ToListAsync();

            return submittedExamsList;
        }


    }
}
