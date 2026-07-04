using InventoryManagement.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace InventoryManagement.Repositories
{
    public interface IProductRepository
    {
        List<Products> GetAll();

        void Add(Products product);

        int GenerateNextID();
    }
}
