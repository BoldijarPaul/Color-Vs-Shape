using UnityEngine;
using System.Collections;

public class MainBallController : MonoBehaviour {

	public bool isPlayer=false;

	void Start () {
		checkIfPlayer ();

	
	}

	void OnTriggerEnter2D(Collider2D other) {
		Debug.Log ("enter");
		//Destroy (other);
	}

	private void checkIfPlayer()
	{
		/*if this object is the main player, activate the trigger */
		if(isPlayer)
		{
			GetComponent<Collider2D>().isTrigger=true;
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
