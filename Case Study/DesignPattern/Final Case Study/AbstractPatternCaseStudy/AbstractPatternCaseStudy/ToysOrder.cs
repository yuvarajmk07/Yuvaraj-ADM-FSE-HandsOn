using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractPatternCaseStudy
{
    public class ToysOrder : Order
    {
        public ToysOrder(Channel channel) : base(Product.Toys, channel)
        {
            processOrder();
        }
        public override void processOrder()
        {
            Console.WriteLine(productType.ToString() + " order is placed through " + channel.ToString());
        }
    }
}
