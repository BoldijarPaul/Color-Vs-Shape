using UnityEngine;
using System.Collections;

public class MainBallController : MonoBehaviour {

	public bool isPlayer=false;

	void Start () {
		checkIfPlayer ();

	
	}

	void OnTriggerEnter2D(Collider2D other) {
		if (isPlayer) 
		{
			/* a collision between 2 bodies started, if the main one is a player, 
			 * swap properties & delete the other one */
			swapProperties(other.gameObject);
			Destroy (other.gameObject);
		}
		 
	}

	/* this method will take the properties from the specified game object to this one */
	private void swapProperties(GameObject gameObject)
	{
		this.GetComponent<SpriteRenderer> ().sprite = gameObject.GetComponent<SpriteRenderer> ().sprite;
		this.GetComponent<PolygonCollider2D> ().points = gameObject.GetComponent<PolygonCollider2D> ().points;
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
