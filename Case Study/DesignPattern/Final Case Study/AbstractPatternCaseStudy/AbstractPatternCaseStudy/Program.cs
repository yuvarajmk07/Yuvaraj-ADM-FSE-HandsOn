using System;

namespace AbstractPatternCaseStudy
{
    class Program
    {
        static void Main(string[] args)
        {
            OrderFactory orderFactory = new ConcreteOrderFactory();
            OrderClient orderClient = new OrderClient(orderFactory);
            orderClient.OrderItem(Product.ElectronicProducts,Channel.ECommerceWebsite);
            Console.WriteLine();
            orderClient.OrderItem(Product.Furniture, Channel.TeleCallerAgents);
            Console.WriteLine();
            orderClient.OrderItem(Product.Toys, Channel.ECommerceWebsite);
            Console.WriteLine();
            orderClient.OrderItem(Product.ElectronicProducts, Channel.TeleCallerAgents);
            Console.WriteLine();
            orderClient.OrderItem(Product.Toys, Channel.TeleCallerAgents);
            Console.ReadKey();
        }

        
    }
    public enum Product { 
        ElectronicProducts,Toys,Furniture
    }
    public enum Channel {
        ECommerceWebsite,TeleCallerAgents
    }


}
