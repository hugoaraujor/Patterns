using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
	abstract class AbstractFactory
	{
		private string name;

		public string Name
		{
			get
			{
				return this.name;
			}
			set
			{
				this.name = value;
			}
		}
		public abstract IVehiclecs GetSeaVehicles(String Type);
		public abstract IVehiclecs GetAirVehicles(String Type);
		public abstract IVehiclecs GetRoadVehicles(String Type);
	}
}

