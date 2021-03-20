using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractPatternCaseStudy
{
    public class FurnitureOrder : Order
    {
        public FurnitureOrder(Channel channel) : base(Product.Furniture, channel)
        {
            processOrder();
        }
        public override void processOrder()
        {
            Console.WriteLine(productType.ToString() + " order is placed through " + channel.ToString());
        }
    }
}
