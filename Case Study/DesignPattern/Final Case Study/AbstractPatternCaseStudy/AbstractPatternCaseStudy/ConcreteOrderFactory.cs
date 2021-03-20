using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractPatternCaseStudy
{
    public class ConcreteOrderFactory : OrderFactory
    {
        Order order;

        public Order ElectronicFactory(Channel channel)
        {
            order = new ElectronicOrder(channel);
            return order;
        }



        public Order FurnitureFactory(Channel channel)
        {
            order = new FurnitureOrder(channel);
            return order;
        }


        public Order ToysFactory(Channel channel)
        {
            order = new ToysOrder(channel);
            return order;
        }
    }
}
