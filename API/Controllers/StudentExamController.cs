using Exams_App_C__.Net_Server.Core.Repositories;
using Exams_App_C__.Net_Server.Data.Models;
using Exams_App_C__.Net_Server.Repositories;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

[Route("api/[controller]")]
[ApiController]
public class StudentExamController : GenericController<StudentExam>
{
    private readonly StudentExamRepository studentExamRepository;

    public StudentExamController(StudentExamRepository studentExamRepository) : base(studentExamRepository)
    {
        this.studentExamRepository = studentExamRepository;
    }

    [HttpPost("push-to-questions-failed/{studentExamId}")]
    public async Task<IActionResult> PushToQuestionsFailed(string studentExamId, [FromBody]List<QuestionFailed> questionsFailed)
    {
        if (string.IsNullOrEmpty(studentExamId) || questionsFailed == null)
        {
            return BadRequest("Invalid studentExamId or questions");
        }

        var result = await studentExamRepository.PushToQuestionsFailed(studentExamId, questionsFailed);

        if (result == 1)
        {
            return Ok("Questions failed successfully added to the student exam.");
        }
        else
        {
            return NotFound("Student exam not found or failed to add questions to the student exam.");
        }
    }


    [HttpGet("questions-failed/{studentExamId}")]
    public async Task<ActionResult<List<QuestionFailed>>> GetQuestionsFailed(string studentExamId)
    {
        var questionsFailed = await studentExamRepository.GetQuestionFailedListAsync(studentExamId);
        if (questionsFailed == null) { return NotFound(); }
        return Ok(questionsFailed);
    }
}
