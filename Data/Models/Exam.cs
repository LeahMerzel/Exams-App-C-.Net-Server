using Exams_App_C__.Net_Server.Data.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Exams_App_C__.Net_Server.Data.Models
{
    public class Exam
    {
        [Key]
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        [Required]
        [MaxLength(50)]
        public string ExamName { get; set; }
        [ForeignKey("TeacherId")]
        public string TeacherId { get; set; }
        [ForeignKey("CourseId")]
        public string CourseId { get; set; }
        [Required]
        [MaxLength(200)]
        public string? ExamDescription { get; set; }
        [Required]
        public DateTime StartExamDateTime { get; set; }
        [Required]
        public DateTime EndExamDateTime { get; set; }
        [Required]
        public bool IsOrderQuestionsRandom { get; set; }
        public virtual IList<Question>? ExamQuestions { get; set; } = new List<Question>();
        public virtual IList<StudentExam>? StudentsExams { get; set; } = new List<StudentExam>();
        public float ExamGradeAvg { get; set; }
        [Required]
        public int ExamDurationInMinutes { get; set; }

    }
}

