using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Exams_App_C__.Net_Server.Data.Models
{
    public class Question
    {
        [Key]
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        [Required]
        public int QuestionNumber { get; set; }
        [Required]
        [MaxLength(2000)]
        public string? QuestionDescription { get; set; }
        public bool IsImage { get; set; }
        public virtual IList<Answer>? Answers { get; set; } = new List<Answer>();
        [Required]
        public bool IsOrderAnswersRandom { get; set; }
        [Required]
        [MaxLength(3)]
        public int QuestionScoring { get; set; }
        [ForeignKey("ExamId")]
        public string ExamId { get; set; }

    }
        
}
