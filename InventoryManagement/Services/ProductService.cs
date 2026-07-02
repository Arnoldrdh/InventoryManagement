using InventoryManagement.Models;
using InventoryManagement.Repositories;
using System;
using System.Collections.Generic;

namespace InventoryManagement.Services
{
    public class ProductService
    {
        private ProductRepository repository = new ProductRepository();
        private int nextID = 1;

        public bool AddProductElectronic(string name, int price, int stock, int warrantyMonth)
        {
            try
            {
                int productID = repository.GenerateNextID();
                Elektronic elektronic = new Elektronic(productID, name, price, stock, warrantyMonth);
                repository.Add(elektronic);
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
                int productID = repository.GenerateNextID();
                Food food = new Food(productID, name, price, stock, expiredDate);
                repository.Add(food);
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
            foreach (var item in repository.GetAll())
            {
                item.DisplayInfo();
            }
        }

        public bool ChangeProductPrice(int id, int newPrice)
        {
            foreach (var product in repository.GetAll())
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
            foreach (var product in repository.GetAll())
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
            foreach (var product in repository.GetAll())
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
            foreach (var product in repository.GetAll())
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