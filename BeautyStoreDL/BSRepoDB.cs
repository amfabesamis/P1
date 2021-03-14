using BeautyStore.BeautyStoreModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;

namespace BeautyStoreDL
{
    public class BSRepoDB : IBeautyStoreRepo
    {
        private readonly BeautyStoreDBContext _context;
        public BSRepoDB(BeautyStoreDBContext context)
        {
            _context = context;
        }
        public ShoppingCart AddCart(ShoppingCart newShoppingCart)
        {
            _context.ShoppingCarts.Add(newShoppingCart);
            _context.SaveChanges();
            return newShoppingCart;
        }

        public Customer AddCustomer(Customer customerName)
        {
            _context.Customers.Add(customerName);
            _context.SaveChanges();
            return customerName;
        }

        public Customer DeleteCustomer(Customer customer2BDeleted)
        {
            _context.Customers.Remove(customer2BDeleted);
            _context.SaveChanges();
            return customer2BDeleted;
        }

        public Item AddItem(Item newItem)
        {
            _context.Items.Add(newItem);
            _context.SaveChanges();
            return newItem;
        }

        public Item AddItem(int productId, int shoppingCartId, int inputValue)
        {
            //if an item already exists for that product, then just add the additional input value to the amount
            //in users cart
            if (_context.Items.FirstOrDefault(cp => cp.ShoppingCartId == shoppingCartId && cp.ProductId == productId) != null)
            {
                Item cartproduct2Update = _context.Items.FirstOrDefault(cp => cp.ShoppingCartId == shoppingCartId && cp.ProductId == productId);
                Item newCartProductVersion = new Item
                {
                    ItemsId = cartproduct2Update.ItemsId,
                    ShoppingCartId = cartproduct2Update.ShoppingCartId,
                    ProductId = cartproduct2Update.ProductId,
                    Quantity = cartproduct2Update.Quantity + inputValue
                };

                _context.Entry(cartproduct2Update).CurrentValues.SetValues(newCartProductVersion);
                _context.SaveChanges();
                _context.ChangeTracker.Clear();
                return newCartProductVersion;
            }
            else
            {
                Item cartProduct2Add = new Item
                {
                    ProductId = productId,
                    Quantity = inputValue,
                    ShoppingCartId = shoppingCartId
                };
                _context.Items.Add(cartProduct2Add);
                _context.SaveChanges();
                return cartProduct2Add;
            }
        }

        public Order AddOrder(Order order)
        {
            _context.Orders.Add(order);
            _context.SaveChanges();
            return order;
        }

        public void EmptyShoppingCart(string locationName, int customerId)
        {
            Location location = _context.Locations.First(l => l.LocationName == locationName);
            ShoppingCart cartToRemove = _context.ShoppingCarts.FirstOrDefault(c => c.CustomerId == customerId && c.LocationId == location.LocationId);
            _context.ShoppingCarts.Remove(cartToRemove);
            _context.SaveChanges();
        }

        public Customer GetCustomerByName(string name)
        {
            return _context.Customers
                .Include(c => c.ShoppingCarts)
                .ThenInclude(carts => carts.BeautyProduct)
                .Include(c => c.Orders)
                .ThenInclude(orders => orders.Items)
                .AsNoTracking()
                .FirstOrDefault(c => c.customerName == name);
        }

        public List<Customer> GetCustomers()
        {
            return _context.Customers
                .Include(c => c.ShoppingCarts)
                .ThenInclude(carts => carts.BeautyProduct)
                .Include(c => c.Orders)
                .ThenInclude(orders => orders.Items)
                .AsNoTracking()
                .Select(customer => customer)
                .ToList();
        }
//TODO!!!!
        // public List<Inventory> GetInventories(int inventoryId)
        // {
        //     return _context.Inventories
        //         .Include("BeautyProduct")
        //         .AsNoTracking()
        //         .Select(inv => inv.InventoriesId)
        //         .ToList();
        // }

        public List<Item> GetItems()
        {
            throw new NotImplementedException();
        }

        public List<Location> GetLocations()
        {
            return _context.Locations
                .AsNoTracking()
                .Select(location => location)
                .ToList();
        }

        public Manager GetManagerByID(int managerId)
        {
            throw new NotImplementedException();
        }

        public List<Manager> GetManagers()
        {
            throw new NotImplementedException();
        }

        public List<Order> GetOrders()
        {
            throw new NotImplementedException();
        }

        public BeautyProduct GetProductByID(int idNum)
        {
            throw new NotImplementedException();
        }

        public List<BeautyProduct> GetProducts()
        {
            throw new NotImplementedException();
        }

        public List<ShoppingCart> GetShoppingCarts()
        {
            throw new NotImplementedException();
        }

        public void ReplenishInventory(Inventory inventory)
        {
            throw new NotImplementedException();
        }

        public void ReplenishInventory(int productId, int locationId, int quantity)
        {
            Inventory oldInv = _context.Inventories.FirstOrDefault(lp => lp.LocationId == locationId && lp.ProductId == productId);
            Inventory updatedInv = new Inventory();
            if (quantity < 0)
            {
                updatedInv.InventoriesId = oldInv.InventoriesId;
                updatedInv.ProductId = oldInv.ProductId;
                updatedInv.LocationId = oldInv.LocationId;
                updatedInv.Quantity = oldInv.Quantity + quantity;
            }
            if (quantity >= 0)
            {
                updatedInv.InventoriesId = oldInv.InventoriesId;
                updatedInv.ProductId = oldInv.ProductId;
                updatedInv.LocationId = oldInv.LocationId;
                updatedInv.Quantity = quantity;
            }

            _context.Entry(oldInv).CurrentValues.SetValues(updatedInv);

            _context.SaveChanges();
            _context.ChangeTracker.Clear();
        }
    }
}
