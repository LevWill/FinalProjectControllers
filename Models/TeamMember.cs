using System.ComponentModel.DataAnnotations;

namespace FinalProjectControllers.Models
{
    public class TeamMember
    {
        public int Id { get; set; }

        [Required]
        public string? FullName { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime Birthdate { get; set; }

        [Required]
        public string? CollegeProgram { get; set; }

        [Required]
        public string? YearInProgram { get; set; } // Freshman, Sophomore, etc.

        // You can add additional properties if needed
        public string? FavoriteColor { get; set; }
        public string? Hometown { get; set; }
    }
}