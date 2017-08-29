using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonSample
{
	class Program
	{
		static void Main(string[] args)
		{
			SingletonSample singleton = SingletonSample.Instance;
			singleton.DisplayMessage();
			Console.ReadLine();

		}
	}
}
