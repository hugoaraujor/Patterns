namespace AbstractFactory
{
	class Helicopter : IVehiclecs
	{
		public string GetEngineInfo()
		{
			return "Lycoming 0-360 four-cylinder,carbureter";
		}
	}
}