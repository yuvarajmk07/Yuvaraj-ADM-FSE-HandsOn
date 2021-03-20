using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryHandsOn
{
    public class MercedesFactory :Factory
    {
        public override Tire MakeTire()
        {
            return new MercedesTire();
        }
        public override HeadLight MakeHeadLight()
        {
            return new MercedesHeadLight();
        }

    }
}
