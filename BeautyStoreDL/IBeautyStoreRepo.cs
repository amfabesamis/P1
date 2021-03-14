using System;
using System.Collections.Generic;
using System.Text;
using BeautyStore.BeautyStoreModels;

namespace BeautyStoreDL
{
    public interface IBeautyStoreRepo
    {
        List<Customer> GetCustomers();
        Customer AddCustomer(Customer customerName);
        Customer GetCustomerByName(string name);
        Customer DeleteCustomer(Customer customer2BDeleted);
        Order AddOrder(Order order);
        List<Order> GetOrders();
        List<Item> GetItems();
        Item AddItem(Item newItem);
        Item AddItem(int productId, int shoppingCartId, int inputValue);
        List<Location> GetLocations();
        List<BeautyProduct> GetProducts();
        BeautyProduct GetProductByID(int idNum);
        List<Inventory> GetInventories();
        ShoppingCart AddCart(ShoppingCart newShoppingCart);
        List<ShoppingCart> GetShoppingCarts();
        void EmptyShoppingCart(string locationName, int customerId);
        void ReplenishInventory(Inventory inventory);
        void ReplenishInventory(int productId, int locationId, int quantity)
        List<Manager> GetManagers();
        Manager GetManagerByID(int managerId);
    }
}
