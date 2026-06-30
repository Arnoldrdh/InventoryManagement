
namespace InventoryManagement.Models
{
    public abstract class Products
    {
        public int ProductId { get; protected set; }
        public string ProductName { get; protected set; }
        public int ProductPrice { get; protected set; }
        public int ProductStock { get; protected set; }

        public Products(int id, string name, int price, int stock)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException("Product name cannot be empty.");

            if (price < 0)
                throw new ArgumentException("Price cannot be negative.");

            if (stock < 0)
                throw new ArgumentException("Stock cannot be negative.");

            ProductId = id;
            ProductName = name;
            ProductPrice = price;
            ProductStock = stock;
        }

        public bool ChangePrice(int newPrice)
        {
            if (newPrice < 0)
                return false;

            ProductPrice = newPrice;
            return true;
        }

        public bool IncreaseStock(int quantity)
        {
            if (quantity < 0)
                return false;

            ProductStock += quantity;
            return true;
        }

        public bool DecreaseStock(int quantity)
        {
            if (quantity < 0)
                return false;

            if (ProductStock < quantity)
                return false;

            ProductStock -= quantity;
            return true;
        }

        public bool ChangeName(string newName)
        {
            if (string.IsNullOrWhiteSpace(newName))
                return false;

            ProductName = newName;
            return true;
        }

        public virtual void DisplayInfo()
        {
            Console.WriteLine("===== Product =====");
            Console.WriteLine($"ID    : {ProductId}");
            Console.WriteLine($"Name  : {ProductName}");
            Console.WriteLine($"Price : Rp {ProductPrice:N0}");
            Console.WriteLine($"Stock : {ProductStock}");
            Console.WriteLine();
        }
    }

}