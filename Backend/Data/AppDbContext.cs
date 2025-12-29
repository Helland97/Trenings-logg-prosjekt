using Microsoft.EntityFrameworkCore;
using Trenings_logg_prosjekt.Backend.Models;

namespace Trenings_logg_prosjekt.Backend.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }

    public DbSet<Workout> Workouts => Set<Workout>();
}
