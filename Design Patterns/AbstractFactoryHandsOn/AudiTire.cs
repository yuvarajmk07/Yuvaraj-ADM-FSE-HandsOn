using System;
using System.Collections.Generic;
using System.Text;
namespace AbstractFactoryHandsOn
{
    public class AudiTire : Tire
    {
        public override void TireMaker()
        {
            Console.WriteLine("Tire Made for Audi");
            
        }

    }
}
