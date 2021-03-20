using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryCaseStudy
{
    public class CarClient
    {
        CarFactory carFactory;
        Car car;

        public CarClient(CarFactory carFactory)
        {
            this.carFactory = carFactory;
        }

        public Car BuildLuxuryCar(Location location)
        {
            car = carFactory.LuxuryCarFactory(location);
            return car;

        }


        public  Car BuildMicroCar(Location location)
        {

            car = carFactory.MicroCarFactory(location);
            return car;

        }


        public  Car BuildMiniCar(Location location)
        {
            car = carFactory.MiniCarFactory(location);
            return car;

        }
    }

}
