using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryHandsOn
{
    public class MercedesTire : Tire
    {
        public override void TireMaker()
        {
            Console.WriteLine("Tire Made For Mercedes");
            
        }
    }
}
