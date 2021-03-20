using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterPattern
{
    public class CarPriceAdapterImpl : CarPriceAdapter
    {
        public CarPrice luxuryCars;

        public CarPriceAdapterImpl(CarPrice luxuryCars)
        {
            this.luxuryCars = luxuryCars;
        }
        public double getCarPrice()
        {
            return ConvertUSDtoEURO(luxuryCars.getCarPrice());
        }
        public double ConvertUSDtoEURO(double carPrice)
        {
            return carPrice * 0.8;
        }
    }
}
