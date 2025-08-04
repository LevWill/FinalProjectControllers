using FinalProjectControllers.Models;
using Microsoft.EntityFrameworkCore;


namespace FinalProjectControllers.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<TeamMember> TeamMembers { get; set; }
        public DbSet<Hobby> Hobbies { get; set; }
        public DbSet<BreakfastFood> BreakfastFoods { get; set; }
        public DbSet<Pets> Pets { get; set; }
    }
}