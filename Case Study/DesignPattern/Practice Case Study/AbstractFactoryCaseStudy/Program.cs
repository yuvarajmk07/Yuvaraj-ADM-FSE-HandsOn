using System;

namespace AbstractFactoryCaseStudy
{
    class Program
    {
        static void Main(string[] args)
        {
            CarFactory carFactory = new ConcreteCarFactory();
            CarClient carClient = new CarClient(carFactory);
            carClient.BuildMicroCar(Location.USA);
            carClient.BuildMiniCar(Location.USA);
            carClient.BuildLuxuryCar(Location.USA);
            carClient.BuildMiniCar(Location.INDIA);
            carClient.BuildMicroCar(Location.INDIA);
            carClient.BuildLuxuryCar(Location.INDIA);
            carClient.BuildLuxuryCar(Location.DEFAULT);
            carClient.BuildMicroCar(Location.DEFAULT);
            carClient.BuildMiniCar(Location.DEFAULT);
            Console.ReadKey();
        }
    }
    public enum CarType
    {
        MICRO, MINI, LUXURY
    }

    public enum Location
    {
        DEFAULT, USA, INDIA
    }
}
