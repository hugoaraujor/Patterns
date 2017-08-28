namespace AbstractFactory
{
	internal class AirVehicleFactory : AbstractFactory
	{
		
		public override IVehiclecs GetSeaVehicles(string Type)
		{
			return null;
		}
		public override IVehiclecs GetAirVehicles(string Type)
		{
			
			IVehiclecs ivehiclecs = null;
			if (Type.ToLower().Equals("airplane"))
			{
				ivehiclecs = new Airplane();
			}
			else if (Type.ToLower().Equals("helicopter"))
			{
				ivehiclecs = new Helicopter();
			}
			this.Name = Type;
			return ivehiclecs;
			
		}
		public override IVehiclecs GetRoadVehicles(string Type)
		{
			return null;
		}
	}
}
