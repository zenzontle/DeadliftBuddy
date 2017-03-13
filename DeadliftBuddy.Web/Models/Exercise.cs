using System.ComponentModel.DataAnnotations;

namespace DeadliftBuddy.Web.Models
{
    public class Exercise
    {
        [Required]
        public string Description { get; set; }
    }
}