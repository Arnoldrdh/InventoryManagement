using InventoryManagement.Models;
using InventoryManagement.Services;

namespace MainEntry
{
    class Program
    {
        static void Main(string[] args)
        {
            bool programFlag = true;
            ProductService productService = new ProductService();

            Elektronic Laptop = new Elektronic(1, "Asus VivoBook", 14000000, 3, 6);

            Laptop.DisplayInfo();

            //while (programFlag)
            //{
            //    Console.WriteLine("===== Inventory =====");
            //    Console.WriteLine("1. Add Product");
            //    Console.WriteLine("2. Show Product");
            //    Console.WriteLine("3. Change Product Price");
            //    Console.WriteLine("4. Increase Stock");
            //    Console.WriteLine("5. Decrease Stock");
            //    Console.WriteLine("6. Change Product Name");
            //    Console.WriteLine("7. Exit");

            //    Console.Write("Choose Menu: ");
            //    int userChoice = Convert.ToInt32(Console.ReadLine());

            //    if (userChoice == 1)
            //    {
            //        Console.Write("Product Name : ");
            //        string name = Console.ReadLine();

            //        Console.Write("Product Price : ");
            //        int price = Convert.ToInt32(Console.ReadLine());

            //        Console.Write("Product Stock : ");
            //        int stock = Convert.ToInt32(Console.ReadLine());

            //        bool success = productService.AddProduct(name, price, stock);

            //        if (success)
            //            Console.WriteLine("Product added successfully.");
            //        else
            //            Console.WriteLine("Failed to add product.");
            //    }
            //    else if (userChoice == 2)
            //    {
            //        productService.ShowProduct();
            //    }
            //    else if (userChoice == 3)
            //    {
            //        Console.Write("Product ID : ");
            //        int id = Convert.ToInt32(Console.ReadLine());

            //        Console.Write("New Price : ");
            //        int newPrice = Convert.ToInt32(Console.ReadLine());

            //        bool success = productService.ChangeProductPrice(id, newPrice);

            //        if (success)
            //            Console.WriteLine("Price updated successfully.");
            //        else
            //            Console.WriteLine("Failed to update price.");
            //    }
            //    else if (userChoice == 4)
            //    {
            //        Console.Write("Product ID : ");
            //        int id = Convert.ToInt32(Console.ReadLine());

            //        Console.Write("Quantity : ");
            //        int quantity = Convert.ToInt32(Console.ReadLine());

            //        bool success = productService.IncreaseProductStock(id, quantity);

            //        if (success)
            //            Console.WriteLine("Stock updated successfully.");
            //        else
            //            Console.WriteLine("Failed to update stock.");
            //    }
            //    else if (userChoice == 5)
            //    {
            //        Console.Write("Product ID : ");
            //        int id = Convert.ToInt32(Console.ReadLine());

            //        Console.Write("Quantity : ");
            //        int quantity = Convert.ToInt32(Console.ReadLine());

            //        bool success = productService.DecreaseProductStock(id, quantity);

            //        if (success)
            //            Console.WriteLine("Stock updated successfully.");
            //        else
            //            Console.WriteLine("Stock is insufficient or input is invalid.");
            //    }
            //    else if (userChoice == 6)
            //    {
            //        Console.Write("Product ID : ");
            //        int id = Convert.ToInt32(Console.ReadLine());

            //        Console.Write("New Name : ");
            //        string newName = Console.ReadLine();

            //        bool success = productService.ChangeProductName(id, newName);

            //        if (success)
            //            Console.WriteLine("Product name updated successfully.");
            //        else
            //            Console.WriteLine("Failed to update product name.");
            //    }
            //    else if (userChoice == 7)
            //    {
            //        programFlag = false;
            //        Console.WriteLine("Thank You");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Choice not valid.");
            //    }

            //    Console.WriteLine();
            //}


        }
    }
}