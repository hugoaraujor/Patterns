using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototipo
{
	public class vehiculo:ICloneable
	{
		public string Marca { get; set; }
		public int Año { get; set; }

		public object Clone()
		{
			return this.MemberwiseClone();
		}
		public void display()
		{
			Console.WriteLine("Marca vehiculo " + this.Marca + " año:" + this.Año.ToString());
		
		}
		public void getvehiculo(string marca,int año)
		{
			this.Marca = marca;
			this.Año = año;
		}
	}
	

}
