using Exams_App_C__.Net_Server.Core.Repositories;
using Exams_App_C__.Net_Server.Data.Models;
using Microsoft.AspNetCore.Mvc;

namespace Exams_App_C__.Net_Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : GenericController<User>
    {
        private readonly UserRepository userRepository;
        public UserController(UserRepository userRepository) : base(userRepository)
        {
            this.userRepository = userRepository;
        }

        [HttpGet("{studentId}/submitted-exams")]
        public async Task<ActionResult<List<StudentExam>>> GetStudentSubmittedExams(string studentId)
        {
            var studentSubmittedExams = await userRepository.GetStudentSubmittedExams(studentId);

            if (studentSubmittedExams == null)
            {
                return NotFound();
            }

            return Ok(studentSubmittedExams);
        }


        [HttpGet("{teacherId}/teacher-exams")]
        public async Task<ActionResult<List<Exam>>> GetTeacherExams(string teacherId)
        {
            var teacherExams = await userRepository.GetTeacherExams(teacherId);

            if (teacherExams == null)
            {
                return NotFound();
            }

            return Ok(teacherExams);
        }

    }
}
