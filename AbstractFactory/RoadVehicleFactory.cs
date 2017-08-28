namespace AbstractFactory
{
	 class RoadVehicleFactory : AbstractFactory
	{
		public override IVehiclecs GetSeaVehicles(string Type)
		{
			return null;
		}
		public override IVehiclecs GetAirVehicles(string Type)
		{
			return null;
		}
		public override IVehiclecs GetRoadVehicles(string Type)
		{
			IVehiclecs ivehiclecs = null;
			if (Type.ToLower().Equals("car"))
			{
				ivehiclecs = new Car();
			}
			else if (Type.ToLower().Equals("bus"))
			{
				ivehiclecs = new Bus();
			}
			this.Name = Type;
			return ivehiclecs;
		}
	}
}