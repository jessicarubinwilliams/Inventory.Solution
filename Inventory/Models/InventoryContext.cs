using Microsoft.EntityFrameworkCore;

namespace Inventory.Models
{
  public class InventoryContext : DbContext
  {
    public DbSet<Collectible> Collectables { get; set; }

    public InventoryContext(DbContextOptions options) : base(options) { }
  }
}