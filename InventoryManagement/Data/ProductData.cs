using System;


namespace InventoryManagement.Data
{
    public class ProductData
    {
        public int ProductID { get; set; }

        public string ProductName { get; set; }

        public int ProductPrice { get; set; }

        public int ProductStock { get; set; }

        public string ProductType { get; set; }

        public int? WarrantyMonth { get; set; }

        public DateTime? ExpiredDate { get; set; }
    }
}
