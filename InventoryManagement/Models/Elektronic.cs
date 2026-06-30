using System;
using System.Collections.Generic;
using System.Text;

namespace InventoryManagement.Models
{
    class Elektronic : Products
    {
        public int WarrantyMonth { get; private set; }

        public Elektronic(
            int id,
            string name,
            int price,
            int stock,
            int warrantyMonth)
            : base(id, name, price, stock)
        {
            WarrantyMonth = warrantyMonth;
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Warranty : {WarrantyMonth} Month");
        }
            
    }
}
