using Exams_App_C__.Net_Server.Data.Models;
using Exams_App_C__.Net_Server.Data.SeedData;
using Microsoft.EntityFrameworkCore;

namespace Exams_App_C__.Net_Server.Data.DB
{
    public class ExamsDbContext : DbContext
    {
        public ExamsDbContext(DbContextOptions<ExamsDbContext> options)
            : base(options)
        {
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Answer> Answers { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<Exam> Exams { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<StudentExam> StudentsExams { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            AnswerSeedData.Seed(modelBuilder);
            CourseSeedData.Seed(modelBuilder);
            ExamSeedData.Seed(modelBuilder);
            QuestionSeedData.Seed(modelBuilder);
            StudentExamSeedData.Seed(modelBuilder);
            UserSeedData.Seed(modelBuilder);

        }
    }
}
