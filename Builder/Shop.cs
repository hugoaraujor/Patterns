using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
	class Shop
	{
		public void Create(PlayerBuilder playerBuilder)
		{
			
			playerBuilder.SetCabeza();
			playerBuilder.SetCuerpo();
			playerBuilder.SetBrazos();
			playerBuilder.SetPiernas();
			
		}
	}
}
