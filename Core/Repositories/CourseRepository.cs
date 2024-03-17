using Exams_App_C__.Net_Server.Data.DB;
using Exams_App_C__.Net_Server.Data.Models;
using Exams_App_C__.Net_Server.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;


namespace Exams_App_C__.Net_Server.Core.Repositories
{
    public class CourseRepository : GenericRepository<Course>
    {
        public CourseRepository(ExamsDbContext dbContext) : base(dbContext)
        {
        }
        public async Task<List<Exam>> GetCourseExams(string courseId)
        {
            var courseExamsList = await dbContext.Exams
                                        .Where(e => e.CourseId == courseId)
                                        .ToListAsync();

            return courseExamsList;
        }
        public async Task<List<User>> GetCourseUsers(string courseId)
        {
            var courseUserList = await dbContext.Users
                                                .Where(u => u.CourseId == courseId)
                                                .ToListAsync();
            return courseUserList;
        }

        public async Task<Course> AddUserToCourse(string courseId, string userId)
        {
            var user = await dbContext.Users.FirstOrDefaultAsync(u => u.Id == userId);
            if (user == null)
            {
                throw new ArgumentException("User not found");
            }

            var course = await dbContext.Courses.FirstOrDefaultAsync(c => c.Id == courseId);
            if (course == null)
            {
                throw new ArgumentException("Course not found");
            }
            if (course.Users.Contains(user))
            {
                throw new Exception("User is already assigned to the course");
            }

            course.Users.Add(user);
            await dbContext.SaveChangesAsync();
            return course;
        }

        public async Task RemoveUserFromCourse(string courseId, string userId)
        {
            var userToDelete = await dbContext.Users.FirstOrDefaultAsync(u => u.Id == userId);
            if (userToDelete == null)
            {
                throw new ArgumentException("User not found", nameof(userId));
            }
            var course = await dbContext.Courses.FirstOrDefaultAsync(c => c.Id == courseId);
            if (course == null)
            {
                throw new ArgumentException("Course not found", nameof(courseId));
            }
            if (!course.Users.Contains(userToDelete))
            {
                throw new Exception("User is not assigned to the course");
            }
            course.Users.Remove(userToDelete);
            await dbContext.SaveChangesAsync();
        }


    }
}