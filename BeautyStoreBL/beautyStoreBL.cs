using BeautyStore.BeautyStoreModels;
using System;
using System.Collections.Generic;
using BeautyStoreDL;

namespace BeautyStoreBL
{
    public class beautyStoreBL : IBeautyStoreBL
    {
        private IBeautyStoreRepo _repo;

        public beautyStoreBL(IBeautyStoreRepo repo)
        {
            _repo = repo;
        }

        public void AddCustomer(Customer custName)
        {
            _repo.AddCustomer(custName);
        }

        public void AddOrder(Order order)
        {
            _repo.AddOrder(order);
        }

        public Item AddItem(Item newItem)
        {
            return _repo.AddItem(newItem);
        }

        public Item AddItem(int productId, int shoppingCartId, int inputValue)
        {
            return _repo.AddItem(productId, shoppingCartId, inputValue);
        }

        public ShoppingCart AddShoppingCart(ShoppingCart newShoppingCart)
        {
            return _repo.AddCart(newShoppingCart);
        }

        public BeautyProduct GetBeautyProductByID(int idNum)
        {
            return _repo.GetProductByID(idNum);
        }

        public List<BeautyProduct> GetBeautyProducts()
        {
            return _repo.GetProducts();
        }

        public List<ShoppingCart> GetShoppingCarts()
        {
            return _repo.GetShoppingCarts();
        }

        public Customer GetCustomerByName(string name)
        {
            //TODO: CHECK FOR INPUT VALIDATION (NULL/EMPTY)
            return _repo.GetCustomerByName(name);
        }

        public List<Customer> GetCustomers()
        {
            return _repo.GetCustomers();
        }

        public List<Inventory> GetInventories()
        {
            return _repo.GetInventories();
        }

        public List<Item> GetItems()
        {
            return _repo.GetItems();
        }

        public List<Location> GetLocations()
        {
            return _repo.GetLocations();
        }

        public List<Order> GetOrders()
        {
            return _repo.GetOrders();
        }

        public void EmptyCart(string locationName, int customerId)
        {
            _repo.EmptyShoppingCart(locationName, customerId);
        }

        public void ReplenishInventory(Inventory inventory)
        {
            _repo.ReplenishInventory(inventory);
        }
        public List<Manager> GetManagers()
        {
            return _repo.GetManagers();
        }
        public Manager GetManagerByID(int managerId)
        {
            return _repo.GetManagerByID(managerId);
        }

        public Customer DeleteCustomer(Customer customer2BDeleted)
        {
            return _repo.DeleteCustomer(customer2BDeleted);
        }

        public void ReplenishInventory(int productId, int locationId, int quantity)
        {
            _repo.ReplenishInventory(productId, locationId, quantity);
        }
    }
}
