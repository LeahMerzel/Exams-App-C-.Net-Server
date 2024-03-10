using Exams_App_C__.Net_Server.Data.Models;
using Exams_App_C__.Net_Server.Repositories;
using Microsoft.AspNetCore.Mvc;

[Route("api/[controller]")]
[ApiController]
public class StudentExamController : GenericController<StudentExam>
{
    public StudentExamController(StudentExamRepository studentExamRepository) : base(studentExamRepository)
    {
    }


}
