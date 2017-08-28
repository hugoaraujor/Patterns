using System;

namespace Builder
{
	//Clase Jugador
	public partial class Player
	{
		new Player jugador;
		public Player(string _nombre)
     	{
			this.Nombre=_nombre;
        }
		public String Nombre { get; set; }
		public String Cabeza { get; set; }
		public String Cuerpo { get; set; }
		public String Brazos { get; set; }
		public String Piernas { get; set; }

		
		public void setCabeza(String cabeza)
		{
			this.Cabeza = cabeza;
		}
		public void setCuerpo(String cuerpo)
		{
			this.Cuerpo = cuerpo;
		}
		public void setBrazos(String brazos)
		{
			this.Brazos = brazos;
		}
		public void setPiernas(String piernas)
		{
			this.Piernas = piernas;
		}
		public void Show()
		{
			Console.WriteLine("Este es el jugador construido ");
			Console.WriteLine("Nombre:" + this.Nombre);
			Console.WriteLine("Cabeza:" + this.Cabeza);
			Console.WriteLine("Cuerpo:" + this.Cuerpo);
			Console.WriteLine("Brazos:" + this.Brazos);
			Console.WriteLine("Piernas:" + this.Piernas);
			Console.WriteLine("------------------------------ ");
		}
	}
}
