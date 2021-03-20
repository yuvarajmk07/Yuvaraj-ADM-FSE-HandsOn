using System;

namespace AdapterPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Movable bugattiVeyronMovable = new BugattiVeyron();
            MovableAdapter movableAdapter = new MovableAdapterImpl(bugattiVeyronMovable);
            CarPrice bugattiVeyronCarPrice = new BugattiVeyron();
            CarPriceAdapter carPriceAdapter = new CarPriceAdapterImpl(bugattiVeyronCarPrice);
            Console.WriteLine("Converted Price from USD to EURO: " + carPriceAdapter.getCarPrice());
            Console.WriteLine("Converted Speed from MPH TO KMPH: " + movableAdapter.getSpeed());
        }
    }
}
