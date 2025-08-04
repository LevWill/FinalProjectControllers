using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace FinalProjectControllers.Models
{
    public class Hobby
    {
        public int Id { get; set; }

        [Required]
        public string? Name { get; set; }

        public string? Description { get; set; }

        public int? SkillLevel { get; set; } // 1–10 scale, optional
    }
}