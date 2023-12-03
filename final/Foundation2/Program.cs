using System;

public class Program
{
    public static void Main()
    {
        var product1 = new Product("Women's Winter Hat", 1, 10.99m, 1);
        var product2 = new Product("Kid's Snow Boots", 2, 40.00m, 1);
        var product3 = new Product("Kid's Winter Coat", 3, 100.00m, 2);
        var address1 = new Address("4058 Calico Drive", "Clarendon Hills", "Illinois", "USA");
        var customer1 = new Customer("Amelia Sinatra", address1);
        var order1 = new Order(new List<Product> { product1, product2, product3}, customer1);

        Console.WriteLine("Order 1");
        Console.WriteLine("Packing Label:");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine("Total Cost: $" + order1.GetTotalCost());
        Console.WriteLine("------------------------");
        var product4 = new Product("Autumn Coat", 4, 59.99m, 1);
        var product5 = new Product("Hoodie", 5, 15.99m, 3);
        var address2 = new Address("202 Baker St", "London", "Greater London", "UK");
        var customer2 = new Customer("Elena Smith", address2);
        var order2 = new Order(new List<Product> { product4, product5 }, customer2);

        Console.WriteLine("\nOrder 2");
        Console.WriteLine("Packing Label:");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine("Total Cost: $" + order2.GetTotalCost());
        Console.WriteLine("------------------------");

        var product6 = new Product("Socks", 6, 4.99m, 5);
        var product7 = new Product("Winter Gloves", 7, 18.99m, 2);
        var address3 = new Address("3650 Derry Rd", "Malton", "Ontario", "Canada");
        var customer3 = new Customer("Candice Olson", address3);
        var order3 = new Order(new List<Product> { product6, product7 }, customer3);
        Console.WriteLine("\nOrder 3");
        Console.WriteLine("Packing Label:");
        Console.WriteLine(order3.GetPackingLabel());
        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order3.GetShippingLabel());
        Console.WriteLine("Total Cost: $" + order3.GetTotalCost());
        Console.WriteLine("------------------------");


    }
}