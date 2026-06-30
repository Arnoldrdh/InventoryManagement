using InventoryManagement.Models;
using System;
using System.Collections.Generic;

namespace InventoryManagement.Services
{
    public class ProductService
    {
        private List<Products> products = new List<Products>();
        private int nextID = 1;

        public bool AddProductElectronic(string name, int price, int stock, int warrantyMonth)
        {
            try
            {
                Elektronic elektronic = new Elektronic(nextID++, name, price, stock, warrantyMonth);
                products.Add(elektronic);
                return true;
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        public bool AddProductFood(string name, int price, int stock, DateTime expiredDate)
        {
            try
            {
                Food food = new Food(nextID++, name, price, stock, expiredDate);
                products.Add(food);
                return true;
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        public void ShowProduct()
        {
            foreach (var item in products)
            {
                item.DisplayInfo();
            }
        }

        public bool ChangeProductPrice(int id, int newPrice)
        {
            foreach (var product in products)
            {
                if (product.ProductId == id)
                {
                    return product.ChangePrice(newPrice);
                }
            }

            return false;
        }

        public bool IncreaseProductStock(int id, int quantity)
        {
            foreach (var product in products)
            {
                if (product.ProductId == id)
                {
                    return product.IncreaseStock(quantity);
                }
            }

            return false;
        }

        public bool DecreaseProductStock(int id, int quantity)
        {
            foreach (var product in products)
            {
                if (product.ProductId == id)
                {
                    return product.DecreaseStock(quantity);
                }
            }

            return false;
        }


        public bool ChangeProductName (int id,string newName)
        {
            foreach (var product in products)
            {
                if (product.ProductId == id)
                {
                    return product.ChangeName(newName);
                }
            }

            return false;
        }
    }
}