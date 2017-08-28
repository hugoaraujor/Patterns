using System;

namespace AbstractFactory
{    class SeaVehicleFactory : AbstractFactory
	{
		public override IVehiclecs GetSeaVehicles(string Type)
		{
			IVehiclecs ivehiclecs = null;
			if (Type.ToLower().Equals("ship"))
			{
				ivehiclecs = new Ship();
			}
			else if (Type.ToLower().Equals("oil tanquer"))
			{
				ivehiclecs = new OilTanquer();
			}
			this.Name = Type;
			return ivehiclecs;
	    }
		public override IVehiclecs GetAirVehicles(string Type)
		{
			return null;
		}
		public override IVehiclecs GetRoadVehicles(string Type)
		{
			return null;
		}


	}
}