using Exams_App_C__.Net_Server.Core.Repositories;
using Exams_App_C__.Net_Server.Data.Models;
using Microsoft.AspNetCore.Mvc;

namespace Exams_App_C__.Net_Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourseController : GenericController<Course>
    {
        private readonly CourseRepository courseRepository;
        public CourseController(CourseRepository courseRepository) : base(courseRepository)
        {
            this.courseRepository = courseRepository;
        }

        [HttpGet("{courseId}/exams")]
        public async Task<ActionResult<Exam>> GetCourseExams(string courseId)
        {
            var courseExams = await courseRepository.GetCourseExams(courseId);

            if (courseExams == null)
            {
                return NotFound();
            }

            return Ok(courseExams);
        }

        [HttpGet("{courseId}/course-users")]
        public async Task<ActionResult<User>> GetCourseUsers(string courseId)
        {
            var courseTeachers = await courseRepository.GetCourseUsers(courseId);

            if (courseTeachers == null)
            {
                return NotFound();
            }

            return Ok(courseTeachers);
        }


        [HttpPost("add-user-to-course/{courseId},{userId}")]
        public async Task<ActionResult<Course>> AddUserToCourse(string courseId, string userId)
        {
            try
            {
                var course = await courseRepository.AddUserToCourse(courseId, userId);
                return Ok(course);
            }
            catch (ArgumentException ex)
            {
                return BadRequest(ex.Message);
            }
            catch (Exception)
            {
                return StatusCode(500, "An unexpected error occurred.");
            }
        }


        [HttpDelete("remove-user-from-course/{courseId},{userId}")]
        public async Task<IActionResult> RemoveUserFromCourse(string courseId, string userId)
        {
            try
            {
                await courseRepository.RemoveUserFromCourse(courseId, userId);
                return Ok("User removed from the course successfully.");
            }
            catch (ArgumentException ex)
            {
                return BadRequest(ex.Message);
            }
            catch (InvalidOperationException ex)
            {
                return Conflict(ex.Message);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "An unexpected error occurred.");
            }
        }

    }
}


