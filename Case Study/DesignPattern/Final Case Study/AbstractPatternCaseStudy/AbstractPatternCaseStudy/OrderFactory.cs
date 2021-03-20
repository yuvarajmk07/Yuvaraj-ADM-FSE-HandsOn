using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractPatternCaseStudy
{
    public interface OrderFactory
    {
        public  Order ElectronicFactory(Channel Channel);
        public  Order FurnitureFactory(Channel Channel);
        public  Order ToysFactory(Channel channel);
    }
}
