using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryHandsOn
{
    public class AudiFactory : Factory
    {
        public override Tire MakeTire()
        {
            return new AudiTire();
        }
        public override HeadLight MakeHeadLight()
        {
            return new AudiHeadLight();
        }
    }
}
