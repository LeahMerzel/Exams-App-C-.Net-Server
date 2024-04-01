using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Cryptography;
using System.Text;
using System.Text.Json.Serialization;

namespace Exams_App_C__.Net_Server.Data.Models
{
    public class User
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public string? UserName { get; set; }
        public string PasswordHash { get; set; }
        public string Email { get; set; }
        public string? FullName { get; set; }
        public string? UserRole { get; set; }
        [ForeignKey("CourseId")]
        public string? CourseId {  get; set; }
        public virtual IList<Exam>? TeachersExams { get; set; } = new List<Exam>();
        public virtual IList<StudentExam>? StudentsTakenExams { get; set; } = new List<StudentExam>();
        public float? StudentGradeAvg { get; set; }

        public void HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] hashedBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                PasswordHash = Convert.ToBase64String(hashedBytes);
            }
        }

    }
}