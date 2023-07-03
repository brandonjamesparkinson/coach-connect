using coach_connect_api.Models;
using Microsoft.EntityFrameworkCore;

namespace coach_connect_api.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<Client> Clients { get; set; }
        public DbSet<Coach> Coaches { get; set; }
        public DbSet<DietPlan> DietPlans { get; set; }
        public DbSet<Exercise> Exercises { get; set; }
        public DbSet<Meal> Meals { get; set; }
        public DbSet<WorkoutPlan> WorkoutPlans { get; set; }
    }
}
