using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
	class AbstractFactoryProduction
	{
		public static AbstractFactory GetFactory(String Name)
		{
			AbstractFactory abstractfactory = null;
			if (Name.ToLower().Equals("sea"))
				abstractfactory = new SeaVehicleFactory();
			if (Name.ToLower().Equals("air"))
				abstractfactory = new AirVehicleFactory();
			if (Name.ToLower().Equals("road"))
				abstractfactory = new RoadVehicleFactory();

			return abstractfactory;
		}
	}
}
