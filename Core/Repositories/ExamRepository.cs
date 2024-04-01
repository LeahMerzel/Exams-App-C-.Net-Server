using Exams_App_C__.Net_Server.Data.DB;
using Exams_App_C__.Net_Server.Data.Models;
using Exams_App_C__.Net_Server.Repositories;
using Microsoft.EntityFrameworkCore;
using System.Text.Json;

namespace Exams_App_C__.Net_Server.Core.Repositories
{
    public class ExamRepository : GenericRepository<Exam>
    {
        public ExamRepository(ExamsDbContext dbContext) : base(dbContext)
        {
        }
        public async Task<List<Question>?> GetExamQuestionssAsync(Exam exam)
        {
            if (exam == null) { return null; }
            var examQuestionsList = await dbContext.Questions
                           .Where(q => q.ExamId == exam.Id)
                           .ToListAsync();

            return examQuestionsList;
        }
        public async Task<List<StudentExam>?> GetSubmittedStudentExams(Exam exam)
        {
            if (exam == null) { return null; }
            var submittedExamsList = await dbContext.StudentsExams
                .Where(st => st.ExamId == exam.Id)
                .ToListAsync();

            return submittedExamsList;
        }

        public async Task<int?> GetExamGradeAvg(string examId)
        {
            if (examId == null) { return null; }
            var examGrades = await dbContext.StudentsExams
                .Where(s => s.ExamId == examId)
                .Select(s => s.Grade)
                .ToListAsync();

            if (examGrades.Any())
            {
                double? averageGrade = examGrades.Average();
                return (int?)averageGrade;
            }
            else
            {
                return null;
            }
        }

        public async Task<Exam?> GetExamWithQuestionsAndAnswersAsync(string examId)
        {
            if (examId == null) { return null; }

            try
            {
                var exam = await dbContext.Exams
                    .Include(e => e.ExamQuestions)
                    .ThenInclude(q => q.Answers)
                    .FirstOrDefaultAsync(e => e.Id == examId);

                return exam;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error retrieving exam with questions and answers: {ex.Message}");
                throw;
            }
        }

        public async Task<Exam?> UpdateExamWithQuestionsAndAnswersAsync(Exam exam)
        {
            try
            {
                // Update the exam entity
                dbContext.Entry(exam).State = EntityState.Modified;

                // Iterate over each exam question
                foreach (var question in exam.ExamQuestions)
                {
                    dbContext.Entry(question).State = EntityState.Modified;

                    foreach (var answer in question.Answers)
                    {
                        dbContext.Entry(answer).State = EntityState.Modified;
                    }
                }

                await dbContext.SaveChangesAsync();

                return exam;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error updating exam with questions and answers: {ex.Message}");
                throw;
            }
        }

        public async Task<bool> DeleteExamWithQuestionsAndAnswersAsync(string examId)
        {
            try
            {
                var exam = await dbContext.Exams
                    .Include(e => e.ExamQuestions)
                    .ThenInclude(q => q.Answers)
                    .FirstOrDefaultAsync(e => e.Id == examId);

                if (exam == null)
                    return false;

                dbContext.Exams.Remove(exam);
                await dbContext.SaveChangesAsync();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error deleting exam with questions and answers: {ex.Message}");
                throw;
            }
        }


        public async Task SaveExamToFileAsync(Exam exam, string filePath)
        {
            try
            {
                // Serialize the exam object to JSON
                string jsonString = JsonSerializer.Serialize(exam);

                // Write the JSON string to a file
                await File.WriteAllTextAsync(filePath, jsonString);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error saving exam to file: {ex.Message}");
                throw;
            }
        }

    }
}
