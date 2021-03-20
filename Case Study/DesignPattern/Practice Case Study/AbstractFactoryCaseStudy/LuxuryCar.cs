using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryCaseStudy
{
    public class LuxuryCar:Car
    {
        public LuxuryCar(CarType carType,Location location) : base(CarType.LUXURY, location)
        {
            Construct();
        }
        public override void Construct()
        {
            Console.WriteLine("Connecting to Luxury Car");
            Console.WriteLine(base.ToString());
        }
    }
}
