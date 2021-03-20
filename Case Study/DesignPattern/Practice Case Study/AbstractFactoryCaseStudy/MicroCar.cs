using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryCaseStudy
{
   public class MicroCar : Car
    {
        public MicroCar(CarType carType, Location location) : base(CarType.MICRO, location)
        {
            Construct();
        }
        public override void Construct()
        {
            Console.WriteLine("Connecting to Micro Car");
            Console.WriteLine(base.ToString());
        }
    }
}
