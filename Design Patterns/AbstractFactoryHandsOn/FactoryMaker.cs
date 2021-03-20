using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryHandsOn
{
    public class FactoryMaker
    {
		public Factory getFactory(String factoryName)
		{
			if (factoryName.Equals("Audi"))
				return new AudiFactory();
			else if (factoryName.Equals("Mercedes"))
				return new MercedesFactory();
			else
				return null;
		}
	}
}
