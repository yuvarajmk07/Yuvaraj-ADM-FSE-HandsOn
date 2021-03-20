using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryHandsOn
{
    public class Client
    {
		public void Invoke()
		{

			FactoryMaker maker = new FactoryMaker();
			Factory audi = maker.getFactory("Audi");
			audi.MakeTire().TireMaker();
			audi.MakeHeadLight().HeadLightMaker();
			Factory mercedes = maker.getFactory("Mercedes");
			mercedes.MakeTire().TireMaker();
			mercedes.MakeHeadLight().HeadLightMaker();

		}

	}
}
