﻿using System;
using System.Collections.Generic;
using System.Text;
using BeautyStore.BeautyStoreModels;

namespace BeautyStoreBL
{
    public interface IBeautyStoreBL
    {
        List<Customer> GetCustomers();
        void AddCustomer(Customer custName);
        Customer GetCustomerByName(string name);
        Customer DeleteCustomer(Customer customer2BDeleted);
        void AddOrder(Order order);
        List<Order> GetOrders();
        List<Location> GetLocations();
        List<BeautyProduct> GetBeautyProducts();
        BeautyProduct GetBeautyProductByID(int idNum);
        List<Item> GetItems();
        Item AddItem(Item newItem);
        Item AddItem(int productId, int shoppingCartId, int inputValue);
        List<Inventory> GetInventories();
        ShoppingCart AddShoppingCart(ShoppingCart newShoppingCart);
        List<ShoppingCart> GetShoppingCarts();
        void EmptyCart(string locationName, int customerId);
        void ReplenishInventory(Inventory inventory);
        void ReplenishInventory(int productId, int locationId, int quantity);
        List<Manager> GetManagers();
        Manager GetManagerByID(int managerId);
    }
}
