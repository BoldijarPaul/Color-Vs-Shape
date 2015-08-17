using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class MainBallController : MonoBehaviour {

	public bool isPlayer=false;
	private Text textObject;
	private Text scoreObject;

	private GoalType goalType;
	 
	void Start () {


		checkIfPlayer ();

	
	}

	void OnTriggerEnter2D(Collider2D other) {
		if (isPlayer) 
		{
			/* a collision between 2 bodies started, if the main one is a player, 
			 * swap properties & delete the other one */
			updateGameState(other.gameObject);
			swapProperties(other.gameObject);
			Destroy (other.gameObject);

		}
		 
	}

	/* before this object collides with the main one */
	void updateGameState (GameObject gameObject)
	{

		ObjectProperties ownObjectProperties = (ObjectProperties)GetComponent (typeof(ObjectProperties));
		ObjectProperties hitObjectProperties = (ObjectProperties)gameObject.GetComponent (typeof(ObjectProperties));

		/* check what we need to get */
 
		if (goalType == GoalType.Color) {
			/* we need to get a item of same color */
			OnHitShape (ownObjectProperties.color == hitObjectProperties.color);
		} else {
		
			OnHitShape (ownObjectProperties.shape == hitObjectProperties.shape);
		}

	}
	void OnHitShape(bool good)
	{
		if (good) {
			goalType = (GoalType)Random.Range (0, 2);
			GameSettings.score++;
		} else {
			GameSettings.state=GameState.GameOver;
		}

		updateUI ();
	}

	/* this method will take the properties from the specified game object to this one */
	private void swapProperties(GameObject gameObject)
	{
		this.GetComponent<ObjectProperties> ().color = gameObject.GetComponent<ObjectProperties> ().color;
		this.GetComponent<ObjectProperties> ().shape = gameObject.GetComponent<ObjectProperties> ().shape;
		this.GetComponent<SpriteRenderer> ().sprite = gameObject.GetComponent<SpriteRenderer> ().sprite;
		this.GetComponent<PolygonCollider2D> ().points = gameObject.GetComponent<PolygonCollider2D> ().points;
	}
	private void updateUI()
	{
		textObject.text = goalType.ToString ();
		scoreObject.text = GameSettings.score + " P";
	}
	private void checkIfPlayer()
	{
		/*if this object is the main player, activate the trigger */
		if (isPlayer) {
			GetComponent<Collider2D> ().isTrigger = true;
			GetComponent<Rigidbody2D> ().isKinematic = true;
			textObject = GameObject.Find ("Text").GetComponent<Text> ();
			scoreObject = GameObject.Find ("Score").GetComponent<Text> ();

			goalType = (GoalType)Random.Range (0, 1);
			updateUI ();
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
			}
