using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryCaseStudy
{
    public class ConcreteCarFactory :CarFactory
    {
        Car car;

        public  Car LuxuryCarFactory(Location location)
        {
            car = new LuxuryCar(CarType.LUXURY,location);
            return car;

        }


        public  Car MicroCarFactory(Location location)
        {
            car = new MicroCar(CarType.MICRO, location);
            return car;
        }


        public  Car MiniCarFactory(Location location)
        {
            car = new MiniCar(CarType.MINI, location);
            return car;
        }
    }
}
