using System.ComponentModel.DataAnnotations;

namespace FinalProjectControllers.Models
{
    public class BreakfastFood
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int Calories { get; set; }
        public bool IsVegetarian { get; set; }
        public string? FavoriteTopping { get; set; }
    }
}