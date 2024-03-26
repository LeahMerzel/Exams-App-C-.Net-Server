using Exams_App_C__.Net_Server.Data.DB;
using Exams_App_C__.Net_Server.Data.Models;
using Exams_App_C__.Net_Server.Repositories;
using Microsoft.EntityFrameworkCore;


namespace Exams_App_C__.Net_Server.Core.Repositories
{
    public class UserRepository : GenericRepository<User>
    {
        public UserRepository(ExamsDbContext dbContext) : base(dbContext)
        {
        }
        public async Task<List<Exam>?> GetTeacherExams(string teacherId)
        {
            if (teacherId == null) { return null; }
            var teacherExams = await dbContext.Exams
                           .Where(e => e.TeacherId == teacherId)
                           .ToListAsync();

            return teacherExams;
        }
        public async Task<List<StudentExam>?> GetStudentSubmittedExams(string studentId)
        {
            if (studentId == null) { return null; }
            var studentSubmittedExams = await dbContext.StudentsExams
                           .Where(se => se.StudentId == studentId)
                           .ToListAsync();

            return studentSubmittedExams;
        }


    }
}
