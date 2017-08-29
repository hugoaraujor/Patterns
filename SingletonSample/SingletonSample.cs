using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonSample
{
	public class SingletonSample
	{
        private static SingletonSample instance;
		private static readonly object swlock = new object();

		private SingletonSample()
		{

		}
		

		public void DisplayMessage()
		{
			Console.WriteLine("This is the SingleTon Sample Program");
		}
	
		public static SingletonSample Instance
		{

 		get
          {
				lock (swlock)
				{
					if (instance == null)
					{
						instance = new SingletonSample();
					}
					return instance;
				}
			}

		}
	}
	
	
}
