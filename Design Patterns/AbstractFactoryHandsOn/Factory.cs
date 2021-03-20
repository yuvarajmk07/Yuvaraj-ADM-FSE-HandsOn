using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryHandsOn
{
    public abstract class Factory
    {
        public abstract Tire MakeTire();
        public abstract HeadLight MakeHeadLight();
    }
}
