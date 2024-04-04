using Exams_App_C__.Net_Server.Data.DB;
using Exams_App_C__.Net_Server.Data.Models;
using Exams_App_C__.Net_Server.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Threading.Tasks;

namespace Exams_App_C__.Net_Server.Core.Repositories
{
    public class QuestionRepository : GenericRepository<Question>
    {
        public QuestionRepository(ExamsDbContext dbContext) : base(dbContext)
        {
        }

        public async Task<List<Answer>?> GetQuestionAnswersAsync(Question question)
        {
            if (question == null) { return null; }
            var questionAnswersList = await dbContext.Answers
                           .Where(a => a.QuestionId == question.Id)
                           .ToListAsync();

            return questionAnswersList;
        }

        public async Task<string> AddImageToQuestion(string questionId, byte[] imageData, string contentType, string imageUrl)
        {
            // Check if the question exists
            var question = await dbContext.Questions.FirstOrDefaultAsync(q => q.Id == questionId);
            if (question == null)
            {
                throw new ArgumentException("Question not found");
            }

            // Check if image data is provided
            if (imageData == null || imageData.Length == 0)
            {
                throw new ArgumentException("Image data is required");
            }

            // Update the question with image data, content type, and image URL
            question.ImageData = imageData;
            question.ContentType = contentType;
            question.ImageUrl = imageUrl; // Set the image URL
            dbContext.Questions.Update(question);
            await dbContext.SaveChangesAsync();

            // Return the URL of the uploaded image
            return imageUrl;
        }
    }
}
