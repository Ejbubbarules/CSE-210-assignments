using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("123 Main St", "Rexburg", "ID", "USA");
        Customer customer1 = new Customer("Ethan Finlay", address1);
        Order order1 = new Order(customer1);

        order1.AddProduct(new Product("Book", "B001", 10, 2));
        order1.AddProduct(new Product("Pen", "P002", 2, 5));

        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order1.GetTotalCost()}");

        Console.WriteLine();

        Address address2 = new Address("55 King St", "Toronto", "ON", "Canada");
        Customer customer2 = new Customer("Alex Smith", address2);
        Order order2 = new Order(customer2);

        order2.AddProduct(new Product("Laptop", "L001", 800, 1));
        order2.AddProduct(new Product("Mouse", "M002", 25, 2));

        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order2.GetTotalCost()}");
    }
}