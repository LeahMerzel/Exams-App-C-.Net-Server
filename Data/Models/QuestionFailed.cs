using System.ComponentModel.DataAnnotations.Schema;

namespace Exams_App_C__.Net_Server.Data.Models
{
    public class QuestionFailed
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public int QuestionNumber { get; set; }
        public string QuestionDescription { get; set; }
        public int CorrectAnswerNumber { get; set; }
        public string CorrectAnswerDescription { get; set; }
        public int ChosenWrongAnswerNumber { get; set; }
        public string ChosenWrongAnswerDescription { get; set; }
        public int QuestionScoring { get; set; }
        [ForeignKey("StudentExamId")]
        public string StudentExamId { get; set; }


    }
}
