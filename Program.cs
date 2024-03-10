
using Exams_App_C__.Net_Server.Core.Repositories;
using Exams_App_C__.Net_Server.Data.DB;
using Exams_App_C__.Net_Server.Interfaces;
using Exams_App_C__.Net_Server.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Exams_App_C__.Net_Server
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddControllers();
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            builder.Services.AddSwaggerGen();
            builder.Services.AddScoped<AnswerRepository>();
            builder.Services.AddScoped<CourseRepository>();
            builder.Services.AddScoped<ExamRepository>();
            builder.Services.AddScoped<QuestionRepository>();
            builder.Services.AddScoped<StudentExamRepository>();
            builder.Services.AddScoped<UserRepository>();
            builder.Services.AddScoped<AuthRepository>();
            builder.Services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));

            builder.Services.AddDbContext<ExamsDbContext>(options =>
                options.UseSqlServer(builder.Configuration.GetConnectionString("project")));

            //CORS
            builder.Services.AddCors(options => options.AddPolicy(
             "myPolicy", c => c.AllowAnyHeader().AllowAnyMethod().WithOrigins())
 );

            builder.Services.AddControllers();
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();
            app.UseCors("myPolicy");

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
