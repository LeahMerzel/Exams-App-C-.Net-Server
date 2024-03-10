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


    }
}


