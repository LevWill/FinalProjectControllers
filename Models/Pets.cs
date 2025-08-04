using System.ComponentModel.DataAnnotations;

namespace FinalProjectControllers.Models
{
    public class Pets
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Type { get; set; }
        public int Age { get; set; }
        public bool IsVaccinated { get; set; }
    }
}