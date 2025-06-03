using System;

class Program
{
    static void Main(string[] args)
    {
        // Orden 1: Cliente nacional
        Address address1 = new Address("Av. Busch 123", "Santa Cruz", "SC", "Bolivia");
        Customer customer1 = new Customer("Ricardo Sanjines", address1);

        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Filamento PLA Rojo 1kg", "F001", 150, 1));
        order1.AddProduct(new Product("Pieza personalizada soporte celular", "P101", 35, 2));

        Console.WriteLine("=== ORDEN 1 ===");
        Console.WriteLine("Packing Label:");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Price: Bs. {order1.GetTotalCost()}\n");

        // Orden 2: Cliente internacional
        Address address2 = new Address("742 Evergreen Terrace", "Springfield", "IL", "USA");
        Customer customer2 = new Customer("Homer Simpson", address2);

        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Filamento PETG Negro 1kg", "F002", 180, 2));
        order2.AddProduct(new Product("Soporte pared impreso", "P205", 50, 1));

        Console.WriteLine("=== ORDEN 2 ===");
        Console.WriteLine("Packing Label:");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Price: Bs. {order2.GetTotalCost()}\n");
    }
}
