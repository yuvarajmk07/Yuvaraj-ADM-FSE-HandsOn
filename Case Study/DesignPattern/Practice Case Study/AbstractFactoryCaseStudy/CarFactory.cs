using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryCaseStudy
{
    public interface CarFactory
    {
        public  Car LuxuryCarFactory(Location location);
        public  Car MicroCarFactory(Location location);
        public  Car MiniCarFactory(Location location);
    }
}
