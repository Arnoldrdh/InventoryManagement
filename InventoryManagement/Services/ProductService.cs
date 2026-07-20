using InventoryManagement.Models;
using InventoryManagement.Repositories;
using System;
using System.Collections.Generic;

namespace InventoryManagement.Services
{
    public class ProductService
    {
        private IProductRepository repository;
        private int nextID = 1;

        public ProductService(IProductRepository repository)
        {
            this.repository = repository;
        }

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
            Products product = repository.FindById(id);

            if (product == null)
            {
                return false;
            }

            return product.ChangePrice(newPrice);
 
        }

        public bool IncreaseProductStock(int id, int quantity)
        {
            Products product = repository.FindById(id);

            if (product == null)
            {
                return false;
            }

            return product.IncreaseStock(quantity);
        }

        public bool DecreaseProductStock(int id, int quantity)
        {
            Products product = repository.FindById(id);

            if (product == null)
            {
                return false;
            }

            return product.DecreaseStock(quantity);
        }


        public bool ChangeProductName (int id,string newName)
        {
            Products product = repository.FindById(id);

            if (product == null)
            {
                return false;
            }

            return product.ChangeName(newName);
        }

        public bool Delete(int id)
        {

            return repository.DeleteProduct(id);

        }
    }
}