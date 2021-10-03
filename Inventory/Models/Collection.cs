using System.Collections.Generic;

namespace Inventory.Models
{
    public class Collection
    {
        public Collection()
        {
            this.Collectables = new HashSet<Collectible>();
        }

        public int CollectionId { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Collectible> Collectables { get; set; }
    }
}