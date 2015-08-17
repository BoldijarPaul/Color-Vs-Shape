using UnityEngine;
using UnityEngine.UI;

public class GameSettings {

	public static GameState state = GameState.Playing;
	public static int score=0;

	public static void Restart()
	{
		score = 0;
		state = GameState.Playing;
		GameObject.Find ("GameOverText").GetComponent<Text> ().text="";
	}

	public static void GameOver()
	{
		state = GameState.GameOver;
		GameObject.Find ("GameOverText").GetComponent<Text> ().text="GAME OVER!";
	}



}
