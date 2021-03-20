using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryCaseStudy
{
    public abstract class Car
    {
        public Car(CarType model,Location location)
        {
            this.CarType = model;
            this.Location = location;

        }
        public abstract void Construct();
        public CarType CarType { get; set; }
        public Location Location { get; set; }
        public override string ToString()
        {
            return "CarModel - "+CarType.ToString()+" located in "+Location.ToString();
        }
    }
}
