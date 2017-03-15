using System.ComponentModel.DataAnnotations;

namespace DeadliftBuddy.Web.Models
{
    public class Exercise
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Description { get; set; }
    }
}