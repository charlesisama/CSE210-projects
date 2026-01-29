using System;

using System;

class Program
{
    static void Main(string[] args)
    {
        // =========================
        // ORDER 1 (USA customer)
        // =========================
        Address addr1 = new Address(
            "123 Main Street",
            "Dallas",
            "TX",
            "USA"
        );

        Customer cust1 = new Customer("James Carter", addr1);

        Order order1 = new Order(cust1);
        order1.AddProduct(new Product("Wireless Mouse", "WM-1001", 18.99m, 2));
        order1.AddProduct(new Product("USB-C Cable", "UC-2040", 7.50m, 3));
        order1.AddProduct(new Product("Laptop Stand", "LS-7788", 25.00m, 1));

        // =========================
        // ORDER 2 (International customer)
        // =========================
        Address addr2 = new Address(
            "15 Allen Avenue",
            "Lagos",
            "Lagos",
            "Nigeria"
        );

        Customer cust2 = new Customer("Isama Charles", addr2);

        Order order2 = new Order(cust2);
        order2.AddProduct(new Product("Notebook", "NB-3321", 3.25m, 10));
        order2.AddProduct(new Product("Pen Pack", "PP-9090", 5.75m, 2));

        // =========================
        // DISPLAY RESULTS
        // =========================
        DisplayOrder(order1);
        Console.WriteLine();
        DisplayOrder(order2);
    }

    static void DisplayOrder(Order order)
    {
        Console.WriteLine("====================================");
        Console.WriteLine(order.GetPackingLabel());
        Console.WriteLine("------------------------------------");
        Console.WriteLine(order.GetShippingLabel());
        Console.WriteLine("------------------------------------");
        Console.WriteLine($"TOTAL PRICE: ${order.CalculateTotalCost():0.00}");
        Console.WriteLine("====================================");
    }
}
