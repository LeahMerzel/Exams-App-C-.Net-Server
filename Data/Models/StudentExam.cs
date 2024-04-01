using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Exams_App_C__.Net_Server.Data.Models
{
    public class StudentExam 
    {
        [Key]
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        [MaxLength(100)]
        public string StudentName { get; set; }
        public int Grade { get; set; }
        public List<QuestionFailed>? QuestionsFailed { get; set; }  = new List<QuestionFailed>();
        [ForeignKey("StudentId")]
        public string StudentId { get; set; }
        [ForeignKey("ExamId")]
        public string ExamId { get; set; }
        public DateTime? ExamStartTime { get; set; }
        public bool WasExamLoggedInToByStudent { get; set; }

    }
}
