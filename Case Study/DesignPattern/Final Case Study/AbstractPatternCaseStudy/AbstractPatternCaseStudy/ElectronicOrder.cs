using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractPatternCaseStudy
{
    public class ElectronicOrder :Order
    {
        public ElectronicOrder(Channel channel) : base(Product.ElectronicProducts, channel)
        {
            processOrder();
        }
        public override void processOrder()
        {
            Console.WriteLine(productType.ToString() + " order is placed through " + channel.ToString());
        }
    }
}
