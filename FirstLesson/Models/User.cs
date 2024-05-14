using System.ComponentModel.DataAnnotations;

namespace FirstLesson.Models
{
    public class User
    {
        public long userId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
    }
}
