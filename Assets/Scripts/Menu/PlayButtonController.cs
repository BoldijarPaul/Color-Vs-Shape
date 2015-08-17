using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PlayButtonController : MonoBehaviour {

	// Use this for initialization
	void Start () {
		GetComponent<Button> ().onClick.AddListener (() => OnButtonClick ());
	}

	void OnButtonClick ()
	{
			Application.LoadLevel ("GameScene");

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
