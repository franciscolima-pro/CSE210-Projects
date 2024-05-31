using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("179 Main St", "Springfield", "IL", "USA");
        Address address2 = new Address("428 São Sebastião", "Belém", "PB", "BRA");

        Customer customer1 = new Customer("Jhon Snow", address1);
        Customer customer2 = new Customer("Luiz Lima", address2);

        Product product1 = new Product("X-Product", "XRTG9", 33, 122);
        Product product2 = new Product("Y-Product", "W4578", 121, 58);
        Product product3 = new Product("Z-Product", "ZMKLF", 357, 156);

        Order order1 = new Order(customer1);
        order1.addProduct(product1);
        order1.addProduct(product2);

        Order order2 = new Order(customer2);
        order2.addProduct(product2);
        order2.addProduct(product3);

        DisplayOrderDetails(order1);
        DisplayOrderDetails(order2);

        static void DisplayOrderDetails(Order order)
        {
            Console.WriteLine(order.getPackingLabel());
            Console.WriteLine(order.getShippingLabel());
            Console.WriteLine($"Total Cost: {order.getTotalCost()}");

        }
    }
}