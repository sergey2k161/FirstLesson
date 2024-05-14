using Microsoft.AspNetCore.Mvc;
using FirstLesson.Models;
using System;
namespace FirstLesson.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TaskController : ControllerBase
    {
        private static readonly string[] Names = new[]
        {
            "Sergey", "Jon", "Roman", "Maria", "Alex"
        };      
        private static readonly string[] Emails = new[]
        {
            "zxcvcx@gmail.com", "dffddss@gmail.com", "kkjjyy@gmail.com", "fsdfs@gmail.com", "poiyyt@gmail.com"
        };
        private static readonly string[] Titles = new[]
        {
            "For HR", "For Team Lead", "For RM"
        };
        private static readonly string[] Descriptions = new[]
        {
            "It's urgent", "It doesn't matter", "For the future"
        };
        private static readonly string[] Deadlines = new[]
        {
            "01.02.2025", "05.07.2027", "08.09.2024"
        };
        private static readonly string[] TaskStatuses = new[]
        {
            "New", "Progress", "Completed"
        };

        private readonly ILogger<TaskController> _logger;

        public TaskController(ILogger<TaskController> logger)
        {
            _logger = logger;
        }

        [HttpGet("users")]
        public IEnumerable<User> GetUsers()
        {
            var random = new Random();
            return Enumerable.Range(1, 5).Select(index => new User
            {
                Name = Names[random.Next(Names.Length)],
                userId = random.Next(3223231, 999999999),
                Email = Emails[random.Next(Emails.Length)]
            })
            .ToArray();
        }
        [HttpGet("tasks")]
        public IEnumerable<Tasks> GetTasks()
        {
            var random = new Random();
            return Enumerable.Range(1, 5).Select(index => new Tasks
            {
                TaskId = random.Next(3223231, 999999999),
                Title = Titles[random.Next(Titles.Length)],
                Description = Descriptions[random.Next(Descriptions.Length)],
                Deadline = DateTime.Parse(Deadlines[random.Next(Deadlines.Length)]),
                TaskStatus = TaskStatuses[random.Next(TaskStatuses.Length)],
                AssignedUser = new User
                {
                    Name = Names[random.Next(Names.Length)],
                    userId = random.Next(3223231, 999999999),
                    Email = Emails[random.Next(Emails.Length)]
                }
            })
            .ToArray();
        }
    }
}