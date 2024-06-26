﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Exams_App_C__.Net_Server.Data.Models
{
    public class Question
    {
        [Key]
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public int QuestionNumber { get; set; }
        [MaxLength(2000)]
        public string QuestionDescription { get; set; }
        public byte[]? ImageData { get; set; }
        public string? ContentType { get; set; }

        [MaxLength(300)] 
        public string? ImageUrl { get; set; }
        public virtual IList<Answer>? Answers { get; set; } = new List<Answer>();
        public string? CorrectAnswerDescription { get; set; }
        public bool? IsOrderAnswersRandom { get; set; }
        public int QuestionScoring { get; set; }
        [ForeignKey("ExamId")]
        public string ExamId { get; set; }

    }
        
}
