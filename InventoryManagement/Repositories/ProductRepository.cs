using InventoryManagement.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace InventoryManagement.Repositories
{
    public class ProductRepository
    {
        private const string FilePath = "product.json";
        private List<Products> products = new List<Products>();

        private void SaveToFile()
        {

        }

        public void Add(Products product)
        {
            products.Add(product);
            SaveToFile();
        }

        public List<Products> GetAll()
        {
            return products;
        }
    }


}
