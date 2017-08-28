namespace Builder
{
	public class JugadorFit : PlayerBuilder
	{
		public JugadorFit()
		{
			objjugador = new Player("Fit Muscle");
		}

		public override void SetBrazos()
		{
			objjugador.setBrazos(objjugador.brazosmusculosos());
		}

		public override void SetCabeza()
		{
			objjugador.setCabeza(objjugador.cabezaconsombrero());
		}

		public override void SetCuerpo()
		{
			objjugador.setCuerpo(objjugador.cuerpomuyflaco());
		}

		public override void SetPiernas()
		{
			objjugador.setPiernas(objjugador.Piesconzapatos());
		}
	
	
	}
}
