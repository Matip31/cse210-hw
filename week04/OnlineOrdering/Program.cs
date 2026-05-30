using System;

class Program
{
    static void Main(string[] args)
    {
        Product product1=new Product("Yerba Baldo",12345,15,2);
        Product product2=new Product("JIF Peanut Butter",12367,5,4);
        Product product3=new Product("Beef Jerky",67345,20,1);
        Product product4=new Product("Shampoo CR7",12675,25,3);
        Address address1=new Address("Av Rivera","Montevideo","Montevideo","Uruguay");
        Address address2=new Address("Main Avenue","Miami","Florida","USA");
        Customer Matias=new Customer("Matias",address1);
        Customer Lucia=new Customer("Lucia",address2);
        Order order1=new Order(Matias);
        order1.AddProduct(product1);
        order1.AddProduct(product2);
        Order order2=new Order(Lucia);
        order2.AddProduct(product3);
        order2.AddProduct(product4);
        List<Order> orders=new List<Order>();
        orders.Add(order1);
        orders.Add(order2);
        foreach(Order o in orders)
        {
            string shipping=o.GetShippingLabel();
            string packing=o.GetPackingLabel();
            int price=o.TotalCost();
            Console.WriteLine($"Packing label: {packing}");
            Console.WriteLine($"Shipping label: {shipping}");
            Console.WriteLine($"Total price of your order: ${price}");
        }



    }
}