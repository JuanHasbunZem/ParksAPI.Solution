using Microsoft.EntityFrameworkCore;

namespace ParksAPI.Models
{
  public class ParksAPI : DbContext
  {
    public ParksAPI(DbContextOptions<ParksAPI> options) : base(options)
    {
    }

    public DbSet<Park> Parks { get; set; }
  }
}