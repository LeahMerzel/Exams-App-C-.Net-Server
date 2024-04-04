using Exams_App_C__.Net_Server.Core.Repositories;
using Exams_App_C__.Net_Server.Data.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.IO;
using System.Threading.Tasks;

namespace Exams_App_C__.Net_Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QuestionController : GenericController<Question>
    {
        private readonly QuestionRepository questionRepository;
        public QuestionController(QuestionRepository questionRepository) : base(questionRepository)
        {
            this.questionRepository = questionRepository;
        }

        [HttpGet("{questionId}/answers")]
        public async Task<ActionResult<Answer>> GetQuestionAnswers(string questionId)
        {
            var question = await questionRepository.GetAsync(questionId);

            if (question == null)
            {
                return NotFound();
            }

            var questionAnswers = await questionRepository.GetQuestionAnswersAsync(question);

            return Ok(questionAnswers);
        }

        [HttpPost("{questionId}/image")]
        public async Task<ActionResult<string>> UploadImageToQuestion(string questionId, [FromForm] IFormFile imageFile)
        {
            try
            {
                // Check if the image file is provided
                if (imageFile == null || imageFile.Length == 0)
                {
                    return BadRequest("Image file is required.");
                }

                // Read the image data into a byte array
                using (var memoryStream = new MemoryStream())
                {
                    await imageFile.CopyToAsync(memoryStream);
                    byte[] imageData = memoryStream.ToArray();

                    // Get the content type of the image
                    string contentType = imageFile.ContentType;

                    // Construct the URL of the uploaded image
                    string imageUrl = $"https://yourdomain.com/images/{questionId}";

                    // Call the repository method to add the image to the question
                    string uploadedImageUrl = await questionRepository.AddImageToQuestion(questionId, imageData, contentType, imageUrl);

                    // Return the URL of the uploaded image with a 201 Created response
                    return CreatedAtAction(nameof(UploadImageToQuestion), new { questionId }, uploadedImageUrl);
                }
            }
            catch (ArgumentException ex)
            {
                return NotFound(ex.Message);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, $"An error occurred: {ex.Message}");
            }
        }

    }
}
