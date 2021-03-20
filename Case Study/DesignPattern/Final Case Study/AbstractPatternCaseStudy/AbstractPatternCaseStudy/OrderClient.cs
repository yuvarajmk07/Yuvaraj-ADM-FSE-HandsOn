using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractPatternCaseStudy
{
    public class OrderClient
    {
        OrderFactory orderFactory;
        Order order;

        public OrderClient(OrderFactory orderFactory)
        {
            this.orderFactory= orderFactory;
        }

        public Order OrderItem(Product product,Channel channel)
        {
            switch (product)
            {
                case Product.ElectronicProducts:
                    order = orderFactory.ElectronicFactory(channel);
                    break;
                case Product.Furniture:
                    order = orderFactory.FurnitureFactory(channel);
                    break;
                case Product.Toys:
                    order = orderFactory.ToysFactory(channel);
                    break;
                
            }
            return order;
            
        }
    }
}
