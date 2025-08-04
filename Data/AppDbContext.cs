using FinalProjectControllers.Models;
using Microsoft.EntityFrameworkCore;

namespace FinalProjectControllers.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<TeamMember> TeamMembers { get; set; }
        public DbSet<Hobby> Hobbies { get; set; }
        public DbSet<BreakfastFood> BreakfastFoods { get; set; }
        public DbSet<Pets> Pets { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<TeamMember>().HasData(
                new TeamMember
                {
                    Id = 1,
                    FullName = "Will Leveridge",
                    Birthdate = new DateTime(1983, 8, 15),
                    CollegeProgram = "Business IT",
                    YearInProgram = "Senior"
                }
            );

            modelBuilder.Entity<Hobby>().HasData(
                new Hobby
                {
                    Id = 1,
                    Name = "Hiking",
                    Description = "Exploring nature",
                    SkillLevel = "Intermediate",
                    WeeklyHours = 5
                }
            );

            modelBuilder.Entity<BreakfastFood>().HasData(
                new BreakfastFood
                {
                    Id = 1,
                    Name = "Omelet",
                    Calories = 250,
                    IsVegetarian = true,
                    FavoriteTopping = "Cheddar Cheese"
                }
            );

            modelBuilder.Entity<Pets>().HasData(
                new Pets
                {
                    Id = 1,
                    Name = "Tootsie",
                    Type = "English Bulldog",
                    Age = 4,
                    IsVaccinated = true
                }
            );
        }
    }
}