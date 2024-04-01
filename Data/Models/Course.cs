using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Exams_App_C__.Net_Server.Data.Models
{
    public class Course
    {
        [Key]
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        [MaxLength(50)]
        public string CourseName { get; set; }
        [MaxLength(200)]
        public string? CourseDescription { get; set; }
        public DateTime CourseStartingDate { get; set; }
        public DateTime? CourseEndingDate { get; set; }
        [JsonIgnore]
        public virtual IList<User>? Users { get; set; }
        public virtual IList<Exam>? Exams { get; set; }
        public Course()
        {
            Users = new List<User>();
            Exams = new List<Exam>();
        }
    }
}