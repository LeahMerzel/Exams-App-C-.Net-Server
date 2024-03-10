using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Exams_App_C__.Net_Server.Data.Models
{
    public class StudentExam 
    {
        [Key]
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        [Required]
        [MaxLength(100)]
        public string StudentName { get; set; }
        public int Grade { get; set; }
        public virtual IList<Question>? QuestionsFailed { get; set; } 
        [ForeignKey("StudentId")]
        public string StudentId { get; set; }
        [ForeignKey("ExamId")]
        public string ExamId { get; set; }
        public DateTime ExamStartTime { get; set; }
        public bool WasExamLoggedInToByStudent { get; set; }
        public StudentExam()
        {
            QuestionsFailed = new List<Question>();
        }

    }
}
