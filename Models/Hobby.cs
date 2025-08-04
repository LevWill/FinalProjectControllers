using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace FinalProjectControllers.Models
{
    public class Hobby
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? SkillLevel { get; set; }
        public int WeeklyHours { get; set; }
    }
}