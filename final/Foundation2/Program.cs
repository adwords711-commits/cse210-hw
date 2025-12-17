using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("711 Crums Church Rd", "Berryville", "VA", 22611, "USA");
        Customer customer1 = new Customer("Jorge Gonzales", address1);

        Address address2 = new Address("44366 Premier Plaza", "Ashburn", "VA", 20147, "USA");
        Customer customer2 = new Customer("Jessilyn Larsen", address2); 
       

        
        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Temple Robe", "TR001", 50.0, 1));
        order1.AddProduct(new Product("Temple Apron", "TA001", 25.0, 2));
        order1.AddProduct(new Product("Book of Mormon", "BM001", 15, 1));

        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Temple Belt", "TBE001", 30.0, 1));
        order2.AddProduct(new Product("Temple Sash", "TS001", 40.0, 2));
        order2.AddProduct(new Product("Temple Robe Hood", "TRH001", 25, 1));

        Console.WriteLine("Order 1:");
        Console.WriteLine();
        Console.WriteLine(order1.PackingLabel());
        Console.WriteLine(order1.ShippingLabel());
        Console.WriteLine();
        Console.WriteLine($"Total Price: ${order1.TotalCost()}\n");

        Console.WriteLine("Order 2:");
        Console.WriteLine();
        Console.WriteLine(order2.PackingLabel());
        Console.WriteLine(order2.ShippingLabel());
        Console.WriteLine();
        Console.WriteLine($"Total Price: ${order2.TotalCost()}\n");

    }
}