using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Exams_App_C__.Net_Server.Data.Models
{
    public class Answer
    {
        [Key]
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public int AnswerNumber { get; set; }
        [MaxLength(2000)]
        public string AnswerDescription { get; set; }
        public bool IsCorrect { get; set; }
        [ForeignKey("QuestionId")]
        public string QuestionId { get; set; }


    }
}
