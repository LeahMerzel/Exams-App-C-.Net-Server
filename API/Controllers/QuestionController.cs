using Exams_App_C__.Net_Server.Core.Repositories;
using Exams_App_C__.Net_Server.Data.Models;
using Microsoft.AspNetCore.Mvc;

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

    }
}


