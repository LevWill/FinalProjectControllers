using System.ComponentModel.DataAnnotations;

namespace FinalProjectControllers.Models
{
    public class Pets
    {
        public int Id { get; set; }

        [Required]
        public string? Name { get; set; }

        public string? Species { get; set; }

        public string? Breed { get; set; }

        public int? Age { get; set; }
    }
}