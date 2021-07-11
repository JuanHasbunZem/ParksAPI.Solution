using Microsoft.EntityFrameworkCore;

namespace ParksAPI.Models
{
  public class ParksAPIContext : DbContext
  {
    public ParksAPIContext(DbContextOptions<ParksAPIContext> options) : base(options)
    {
    }
    public DbSet<Park> Parks { get; set; }

    //Seeded Data
    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<Park>()
        .HasData(
            new Park{ParkId = 1, ParkName = "Beaver Creek", ParkLocation = "Oregon", ParkType = "State Park"},
            new Park{ParkId = 2, ParkName = "Prineville Reservior", ParkLocation = "Oregon", ParkType = "State Park"},
            new Park{ParkId = 3, ParkName = "Willamette Mission", ParkLocation = "Oregon", ParkType = "State Park"},
            new Park{ParkId = 4, ParkName = "Crater Lake", ParkLocation = "Oregon", ParkType = "National Park"},
            new Park{ParkId = 5, ParkName = "Death Valley", ParkLocation = "California", ParkType = "National Park"}
        );
    }
  }
}