using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BeautyStore.BeautyStoreModels
{
    public class Inventory
    {
        [Key]
        public int InventoriesId { get; set; }
        public int Quantity { get; set; }
        public int LocationId { get; set; }
        public int ProductId { get; set; }
        public Location Location { get; set; }
        public ICollection<BeautyProduct> BeautyProducts { get; set; }
    }
}
