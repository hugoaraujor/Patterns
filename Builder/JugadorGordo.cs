namespace Builder
{
	public class JugadorGordo : PlayerBuilder
	{
		
		public JugadorGordo()
		{
			objjugador = new Player("Gordito");
		}

		public override void SetBrazos()
		{
			objjugador.setBrazos(objjugador.brazospequeños());
		}

		public override void SetCabeza()
		{
			objjugador.setCabeza(objjugador.cabezaconcasco());
		}

		public override void SetCuerpo()
		{
			objjugador.setCuerpo(objjugador.cuerpogordo());
		}

		public override void SetPiernas()
		{
			objjugador.setPiernas(objjugador.piesdescalzos());
		}
	}
}
