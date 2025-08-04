using System.ComponentModel.DataAnnotations;

namespace FinalProjectControllers.Models
{
    public class BreakfastFood
    {
        public int Id { get; set; }

        [Required]
        public string? Name { get; set; }

        public string? Category { get; set; } // e.g., "Fruit", "Grain", "Protein"

        public bool IsVegetarian { get; set; }

        public int Calories { get; set; }
    }
}