namespace Inventory.Models
{
  public class Collectible
  {
    public int CollectibleId { get; set; }
    public string Name { get; set; }
    public int Quantity { get; set; }

    public int CollectionId { get; set; }
    public virtual Collection Collection { get; set; }
  }
}