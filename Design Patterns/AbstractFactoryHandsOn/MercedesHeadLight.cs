using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryHandsOn
{
    public class MercedesHeadLight : HeadLight
    {
        public override void HeadLightMaker()
        {
            Console.WriteLine("HeadLight Made For Mercedes");
            
        }
    }
}
