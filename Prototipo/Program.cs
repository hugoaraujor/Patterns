using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prototipo;
namespace Prototipo
{

	class Program
	{
		public static void ManejaVehiculos()
		{
			vehiculo vehiculoa = new vehiculo();
			vehiculoa.getvehiculo("mitsubishi", 1990);
			Console.WriteLine("vehiculob es igual al a");
			vehiculoa.display();
		
			vehiculo vehiculob = (vehiculo)vehiculoa.Clone();
			Console.WriteLine("Despues de la clonacion");
			Console.WriteLine("vehiculo b");
			vehiculoa.display();
			vehiculob.display();

			vehiculob.Marca = "Ford";
			Console.WriteLine("Cambio marca del vehiculo b");
			vehiculoa.display();
			vehiculob.display();

			
			
		}

		static void Main(string[] args)
		{
		     ManejaVehiculos();
			Console.ReadLine();
		}
	}
}
