using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{

	class Program
	{
		static void Main(string[] args)
		{
			PlayerBuilder newplayer;
			Shop shop = new Shop();

			 newplayer=new JugadorFit();
			shop.Create(newplayer);
			newplayer.Player.Show();

			newplayer = new JugadorRobot();
			shop.Create(newplayer);
			newplayer.Player.Show();

			newplayer = new JugadorGordo();
			shop.Create(newplayer);
			newplayer.Player.Show();

			Console.ReadLine();
			

		}
	}
}
