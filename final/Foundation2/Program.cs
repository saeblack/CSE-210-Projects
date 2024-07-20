using System;
using OnlineOrderingSystem;

class Program
{
    static void Main(string[] args)
    {
        _Address _address1 = new _Address("123 Main St", "Anytown", "CA", "USA");
        _Address _address2 = new _Address("456 Elm St", "Othertown", "ON", "Canada");

        Customer _customer1 = new Customer("John Doe", _address1);
        Customer _customer2 = new Customer("Jane Smith", _address2);

        Product _product1 = new Product("Laptop", "LAP123", 999.99m, 1);
        Product _product2 = new Product("Mouse", "MOU456", 25.99m, 2);
        Product _product3 = new Product("Keyboard", "KEY789", 49.99m, 1);
        Product _product4 = new Product("Monitor", "MON012", 199.99m, 2);

        _Order _order1 = new _Order(_customer1);
        _order1.AddProduct(_product1);
        _order1.AddProduct(_product2);
        _order1.AddProduct(_product3);

        _Order _order2 = new _Order(_customer2);
        _order2.AddProduct(_product2);
        _order2.AddProduct(_product4);

        DisplayOrderDetails(_order1);
        DisplayOrderDetails(_order2);
    }

    static void DisplayOrderDetails(_Order _order)
    {
        Console.WriteLine($"Order {_order.GetHashCode()} Total Cost:");
        Console.WriteLine($"Packing Label:8765rt4");
        Console.WriteLine($"{_order.GetPackingLabel()}");
        Console.WriteLine($"Shipping Label:kju7890rt");
        Console.WriteLine($"{_order.GetShippingLabel()}");
        Console.WriteLine($"Total Cost: {_order.GetTotalCost():C}");
        Console.WriteLine();
    }
}
