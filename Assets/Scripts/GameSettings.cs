

public class GameSettings {

	public static GameState state = GameState.Playing;
	public static int score=0;

	public static void Restart()
	{
		score = 0;
		state = GameState.Playing;
	}



}
