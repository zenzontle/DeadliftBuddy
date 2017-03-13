using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DeadliftBuddy.Web.Models
{
    public class Routine
    {
        [Required]
        public string Name { get; set; }
        public virtual List<Exercise> Exercises { get; set; }
    }
}