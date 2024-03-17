using Exams_App_C__.Net_Server.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Exams_App_C__.Net_Server.Data.SeedData
{
    public static class CourseSeedData
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Course>().HasData(
                new Course
                {
                    Id = "c-1",
                    CourseName = "Introduction to Programming",
                    CourseDescription = "This course provides an introduction to programming concepts using a variety of languages.",
                    CourseStartingDate = DateTime.Now,
                    CourseEndingDate = DateTime.Now.AddMonths(3)
                },
                new Course
                {
                    Id = "c-2",
                    CourseName = "Introduction to Programming 2",
                    CourseDescription = "This course provides an introduction to programming concepts using a variety of languages.",
                    CourseStartingDate = DateTime.Now,
                    CourseEndingDate = DateTime.Now.AddMonths(3)
                },
                new Course
                {
                    Id = "c-3",
                    CourseName = "Introduction to Programming 3",
                    CourseDescription = "This course provides an introduction to programming concepts using a variety of languages.",
                    CourseStartingDate = DateTime.Now,
                    CourseEndingDate = DateTime.Now.AddMonths(3)
                }
            );
        }
    }
}
