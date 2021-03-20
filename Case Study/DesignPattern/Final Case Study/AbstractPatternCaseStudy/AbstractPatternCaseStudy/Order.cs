using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractPatternCaseStudy
{
    public abstract class Order
    {
        public Order(Product productType, Channel channel)
        {
            this.productType= productType;
            this.channel = channel;

        }
        public Channel channel { get; set; }
        public Product productType { get; set; }
        public abstract void processOrder();
    }
}
