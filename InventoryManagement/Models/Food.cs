using System;
using System.Collections.Generic;
using System.Text;

namespace InventoryManagement.Models
{
    class Food : Products
    {
        public DateTime ExpiredDate { get; private set; }

        public Food(
            int id,
            string name,
            int price,
            int stock,
            DateTime expiredDate)
            : base(id, name, price, stock)
        {
            ExpiredDate = expiredDate;
            ProductType = "Food";
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Expired Date: {ExpiredDate}");
        }
    }
}
