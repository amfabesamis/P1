using System;
using System.Collections.Generic;
using System.Text;

namespace BeautyStore.BeautyStoreModels
{
    public class ShoppingCart
    {
        public int ShoppingCartId { get; set; }
        public int CustomerId { get; set; }
        public int LocationId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public Customer Customer { get; set; }
        public Location Location { get; set; }
        public ICollection<Item> Items { get; set; }
        public ICollection<BeautyProduct> BeautyProduct { get; set; }
    }
}
