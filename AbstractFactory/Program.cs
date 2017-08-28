using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("----------------------For Sea---------------------");
			AbstractFactory seaFactory = AbstractFactoryProduction.GetFactory("Sea");
			IVehiclecs ivehiclecsSea = seaFactory.GetSeaVehicles("ship");
			Console.WriteLine(seaFactory.Name);
			Console.WriteLine(ivehiclecsSea.GetEngineInfo());
			IVehiclecs ivehiclecsSea1 = seaFactory.GetSeaVehicles("oil tanquer");
			Console.WriteLine(seaFactory.Name);
			Console.WriteLine(ivehiclecsSea1.GetEngineInfo());
			Console.WriteLine("----------------------For Air---------------------");
			AbstractFactory airFactory = AbstractFactoryProduction.GetFactory("air");
			IVehiclecs ivehiclecsAir = airFactory.GetAirVehicles("AirPlane");
			Console.WriteLine(airFactory.Name);
			Console.WriteLine(ivehiclecsAir.GetEngineInfo());
			IVehiclecs ivehiclecsAir1 = airFactory.GetAirVehicles("Helicopter");
			Console.WriteLine(airFactory.Name);
			Console.WriteLine(ivehiclecsAir1.GetEngineInfo());
			Console.WriteLine("----------------------For Road---------------------");
			AbstractFactory roadFactory = AbstractFactoryProduction.GetFactory("road");
			IVehiclecs ivehiclecsRoad = roadFactory.GetRoadVehicles("Car");
			Console.WriteLine(roadFactory.Name);
			Console.WriteLine(ivehiclecsRoad.GetEngineInfo());
			IVehiclecs ivehiclecsroad1= roadFactory.GetRoadVehicles("Bus");
			Console.WriteLine(roadFactory.Name);
			Console.WriteLine(ivehiclecsroad1.GetEngineInfo());
			Console.WriteLine("------------------------------------------------");
			Console.ReadLine();
		}
	}
}
