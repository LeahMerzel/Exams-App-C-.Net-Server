﻿using Exams_App_C__.Net_Server.Data.Models;
using Microsoft.EntityFrameworkCore;
using BCrypt.Net;

namespace Exams_App_C__.Net_Server.Data.SeedData
{
    public static class UserSeedData
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(
                new User
                {
                    Id = "a-1",
                    UserName = "admin",
                    PasswordHash = BCrypt.Net.BCrypt.HashPassword("adminPassw0rd1"),
                    FullName = "The Admin",
                    Email = "leahwalden4@gmail.com",
                    UserRole = "Admin"
                },
                new User
                {
                    Id = "t-1",
                    UserName = "teacher1",
                    PasswordHash = BCrypt.Net.BCrypt.HashPassword("password1"),
                    FullName = "John Doe",
                    Email = "john.doe@example.com",
                    UserRole = "Teacher",
                    CourseId = "c-1"
                },
                new User
                {
                    Id = "s-1",
                    UserName = "student1",
                    PasswordHash = BCrypt.Net.BCrypt.HashPassword("password1"),
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
                    PasswordHash = BCrypt.Net.BCrypt.HashPassword("password2"),
                    FullName = "Rifka Smith",
                    Email = "rifka.smith@example.com",
                    UserRole = "Student",
                    StudentGradeAvg = 0.0f,
                    CourseId = "c-1"
                });
        }
    }
}
