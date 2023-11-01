using System.ComponentModel.DataAnnotations;

namespace mvc.Models
{
    public class Employee
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(50,ErrorMessage ="Name can not exceed 50 characters")]
        public string Name { get; set; }

        [Required]
        [RegularExpression(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$",ErrorMessage ="Invalid Email format")]
        public string Email { get; set; }
        [Required]
        public Dept? Department { get; set; }

        public string? PhotoPath { get; set; }
    }
}
