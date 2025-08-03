using System.ComponentModel.DataAnnotations;

namespace WebApplication2.Models
{
    public class Student
    {
        [Required]
        public string name { get; set; }
        [Required]
        public int age { get; set; }
        [Required]
        public int roll { get; set; }
        [Required]
        public string email { get; set; }
        public string phone { get; set; }   
        public string gender { get; set; }
    }
}
