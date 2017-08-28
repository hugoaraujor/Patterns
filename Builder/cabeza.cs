using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
	
	public abstract  class PlayerBuilder
	{
		public Player objjugador;
	

		public Player Player
		{
			 get {return objjugador; } 

		}

	        public abstract void SetBrazos();
		    public abstract void SetCabeza();
			public abstract void SetPiernas();
			public abstract void SetCuerpo();


		}



		
	}
