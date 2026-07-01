using InventoryManagement.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using System.IO;
using InventoryManagement.Data;

namespace InventoryManagement.Repositories
{
    public class ProductRepository
    {
        private const string FilePath = "product.json";
        private List<Products> products = new List<Products>();
        
        public ProductRepository()
        {
            LoadFromFile();
        }

        public Products MapToProduct(ProductData productData)
        {
            if (productData.ProductType == "Elektronic")
            {
                return new Elektronic(
                    productData.ProductID,
                    productData.ProductName,
                    productData.ProductPrice,
                    productData.ProductStock,
                    productData.WarrantyMonth.Value
                );
            }
            else if (productData.ProductType == "Food")
            {
                return new Food(
                    productData.ProductID,
                    productData.ProductName,
                    productData.ProductPrice,
                    productData.ProductStock,
                    productData.ExpiredDate.Value
                );
            }

            throw new Exception("Unknown Product Type");
        }

        public ProductData MapToProductData(Products product)
        {
            ProductData productData = new ProductData();

            //Mapping
            productData.ProductID = product.ProductId;
            productData.ProductName = product.ProductName;
            productData.ProductStock = product.ProductStock;
            productData.ProductPrice = product.ProductPrice;
            productData.ProductType = product.ProductType;

            if(product is Elektronic elektronic)
            {
                productData.WarrantyMonth = elektronic.WarrantyMonth;
            }

            else if (product is Food food)
            {
                productData.ExpiredDate = food.ExpiredDate;
            }

           
            return productData;

        }
        private void SaveToFile()
        {
            List<ProductData> productDataList = new List<ProductData>();
            foreach (var product in products)
            {
                productDataList.Add(MapToProductData(product));
            }

            string json = JsonSerializer.Serialize(productDataList);
            File.WriteAllText(FilePath, json);

        }

        private void LoadFromFile()
        {
            if (!File.Exists(FilePath))
            {
                return;
            }

            string json = File.ReadAllText(FilePath);

            List<ProductData>? productDatas =
                JsonSerializer.Deserialize<List<ProductData>>(json);

            if (productDatas == null)
            {
                return;
            }

            foreach (var productData in productDatas)
            {
                products.Add(MapToProduct(productData));
            }
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
