using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterPattern
{
    public class BugattiVeyron : Movable, CarPrice
    {
        public double getSpeed()
        {
            return 268;
        }
        public double getCarPrice()
        {
            return 54000.00;
        }
    }
}
