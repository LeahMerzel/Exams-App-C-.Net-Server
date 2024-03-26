using Exams_App_C__.Net_Server.Core.Repositories;
using Exams_App_C__.Net_Server.Data.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Exams_App_C__.Net_Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExamController : GenericController<Exam>
    {
        private readonly ExamRepository examRepository;
        public ExamController(ExamRepository examRepository) :base(examRepository) 
        {
            this.examRepository = examRepository;
        }

        [HttpGet("{examId}/questions")]
        public async Task<ActionResult<Question>> GetExamQuestions(string examId)
        {
            var exam = await examRepository.GetAsync(examId);

            if (exam == null)
            {
                return NotFound();
            }

            var questionAnswers = await examRepository.GetExamQuestionssAsync(exam);

            return Ok(questionAnswers);
        }

        [HttpGet("{examId}/submitted-student-exams")]
        public async Task<ActionResult<StudentExam>> GetSubmittedExams(string examId)
        {
            var exam = await examRepository.GetAsync(examId);

            if (exam == null)
            {
                return NotFound();
            }

            var studentsExams = await examRepository.GetSubmittedStudentExams(exam);

            return Ok(studentsExams);
        }

        [HttpGet("average-grade/{examId}")]
        public async Task<ActionResult<int?>> GetExamGradeAvg(string examId)
        {
            var averageGrade = await examRepository.GetExamGradeAvg(examId);

            if (averageGrade.HasValue)
            {
                return Ok(averageGrade); 
            }
            else
            {
                return Ok(0);
            }
        }

        [HttpGet("{examId}/questions-answers")]
        public async Task<ActionResult<Exam>> GetExamWithQuestionsAndAnswers(string examId)
        {
            try
            {
                var exam = await examRepository.GetExamWithQuestionsAndAnswersAsync(examId);
                if (exam == null)
                {
                    return NotFound();
                }
                return exam;
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }

        [HttpPost("saveToFile")]
        public async Task<IActionResult> SaveExamToFileAsync([FromBody] Exam exam, string filePath)
        {
            try
            {
                // Check if exam and file path are provided
                if (exam == null || string.IsNullOrWhiteSpace(filePath))
                    return BadRequest("Exam object or file path is missing.");

                // Save exam to file
                await examRepository.SaveExamToFileAsync(exam, filePath);

                return Ok("Exam saved to file successfully.");
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Error saving exam to file: {ex.Message}");
            }
        }
    }
}


