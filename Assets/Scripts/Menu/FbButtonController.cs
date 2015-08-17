using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class FbButtonController : MonoBehaviour {

	// Use this for initialization
	void Start () {
		GetComponent<Button> ().onClick.AddListener (() => OnButtonClick ());
	}

	void OnButtonClick ()
	{
		if (GameSettings.state == GameState.GameOver) {
			/* if we are not playing anymore and clicked this button, restart game */
			Application.OpenURL("https://www.facebook.com/fainosagstudio");
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
