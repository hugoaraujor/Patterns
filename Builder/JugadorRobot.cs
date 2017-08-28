namespace Builder
{
	public class JugadorRobot : PlayerBuilder
	{
		
		public JugadorRobot()
		{

			objjugador = new Player("Robot");
			
		}

		public override void SetBrazos()
		{
			objjugador.setBrazos(objjugador.brazosmecanicos());
		}

		public override void SetCabeza()
		{
			objjugador.setCabeza(objjugador.cabezaconantenas());
		}

		public override void SetCuerpo()
		{
			objjugador.setCuerpo(objjugador.cuerpometalico());
		}

		public override void SetPiernas()
		{
			objjugador.setPiernas(objjugador.piesconbotas());
		}
	}
}
