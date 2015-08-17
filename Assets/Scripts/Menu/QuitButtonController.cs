using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class QuitButtonController : MonoBehaviour {

	// Use this for initialization
	void Start () {
		GetComponent<Button> ().onClick.AddListener (() => OnButtonClick ());
	}

	void OnButtonClick ()
	{
	 
			Application.Quit();
		 
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
