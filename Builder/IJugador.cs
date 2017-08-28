namespace Builder
{
	public interface IJugador
	{
		void SetCabeza();
		void SetCuerpo();
		void SetBrazos();
		void SetPiernas();
		
	
		Player Jugador { get; }
	}
}
