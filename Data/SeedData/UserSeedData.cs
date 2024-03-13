using Exams_App_C__.Net_Server.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Exams_App_C__.Net_Server.Data.SeedData
{
    public static class UserSeedData
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(
                new User
                {
                    Id= "a-1",
                    UserName = "admin",
                    PasswordHash = "adminPassw0rd!",
                    FullName = "The Admin",
                    Email = "leahwalden4@gmail.com",
                    UserRole = "Admin"
                },
                new User
                {
                    Id = "t-1",
                    UserName = "teacher1",
                    PasswordHash = "password1",
                    FullName = "John Doe",
                    Email = "john.doe@example.com",
                    UserRole = "Teacher",
                    CourseId = "c-1"
                },
                new User
                {
                    Id = "s-1",
                    UserName = "student1",
                    PasswordHash = "password1",
                    FullName = "Alice Smith",
                    Email = "alice.smith@example.com",
                    UserRole = "Student",
                    StudentGradeAvg = 0.0f,
                    CourseId = "c-1"
                },
                new User
                {
                    Id = "s-2",
                    UserName = "student2",
                    PasswordHash = "password2",
                    FullName = "Rifka Smith",
                    Email = "rifka.smith@example.com",
                    UserRole = "Student",
                    StudentGradeAvg = 0.0f,
                    CourseId = "c-1"
                });
        }
    }
}
