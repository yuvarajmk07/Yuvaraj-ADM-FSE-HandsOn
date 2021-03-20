using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterPattern
{
    public class MovableAdapterImpl : MovableAdapter
    {
        public Movable luxuryCars;

        public MovableAdapterImpl(Movable luxuryCars)
        {
            this.luxuryCars = luxuryCars;
        }
        public double getSpeed()
        {
            return ConvertMPHtoKMPH(luxuryCars.getSpeed());
        }

        public double ConvertMPHtoKMPH(double mph)
        {
            return mph * 1.60934;
        }

    }
}
