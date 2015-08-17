using UnityEngine;
using UnityEngine.UI;

public class GameSettings {

	public static GameState state = GameState.Playing;
	public static int score=0;



	private static UnityEngine.Color VISIBLE_COLOR=new UnityEngine.Color(0.196f,0.196f,0.1960f,1);
	private static UnityEngine.Color INVISIBLE_COLOR=new UnityEngine.Color(0.196f,0.196f,0.1960f,0);
	public static void Restart()
	{
		score = 0;
		state = GameState.Playing;
		GameObject.Find ("GameOverText").GetComponent<Text> ().color = INVISIBLE_COLOR;
		GameObject.Find ("RestartText").GetComponent<Text> ().color = INVISIBLE_COLOR;
		GameObject.Find ("BackText").GetComponent<Text> ().color = INVISIBLE_COLOR;
	}

	public static void GameOver()
	{
		state = GameState.GameOver;
		GameObject.Find ("GameOverText").GetComponent<Text> ().color = VISIBLE_COLOR;
		GameObject.Find ("RestartText").GetComponent<Text> ().color = VISIBLE_COLOR;
		GameObject.Find ("BackText").GetComponent<Text> ().color = VISIBLE_COLOR;
	}



}
