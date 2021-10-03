using Microsoft.EntityFrameworkCore;

namespace Inventory.Models
{
  public class InventoryContext : DbContext
  {
    public DbSet<Collection> Collections { get; set; }
    public DbSet<Collectible> Collectables { get; set; }
   

    public InventoryContext(DbContextOptions options) : base(options) { }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      optionsBuilder.UseLazyLoadingProxies();
    }
  }
}