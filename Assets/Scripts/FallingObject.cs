using UnityEngine;
using System.Collections;

public class FallingObject : MonoBehaviour {


	public Camera cam;
	/* the shapes */
	public GameObject[] objects;
	public float rotationLimit;

	public Sprite[,] sprites;

	void Start()
	{
		/* initialize camera if null */
		if (cam == null) {
			cam = Camera.main;
		}
		/* load sprites*/
		sprites = Helper.SpriteArrayToSprite2DArray(Resources.LoadAll<Sprite> ("shapes"));
		StartCoroutine (Spawn ());
	}

	IEnumerator Spawn()
	{
		while (true) {
			/* set up the position of the new object*/
			float screenWidth = Helper.GetScreenWidth (cam);
			float x = Random.Range (-screenWidth, screenWidth);
			Vector3 position = new Vector3 (x, transform.position.y, 0);

			/* set up the game object and rotation */
			GameObject randomGameObject = objects [Random.Range (0, objects.Length - 1)];
			Quaternion rotation = Quaternion.identity;
			 
			/* spawn the game object*/
			GameObject newGameObject = (GameObject)Instantiate (randomGameObject, position, rotation);
			/* set body rotation */
			newGameObject.GetComponent<Rigidbody2D> ().angularVelocity = Random.Range (-rotationLimit, rotationLimit);
			/* set properties */
			ObjectProperties objectProperties = (ObjectProperties)newGameObject.GetComponent (typeof(ObjectProperties));
			int colorIndex = Random.Range (0, (int)Mathf.Sqrt (sprites.Length) - 1);
			int shapeIndex = (int)objectProperties.shape;
			objectProperties.color=(Color)colorIndex;
	

	
			/* set the right sprite */
			newGameObject.GetComponent<SpriteRenderer> ().sprite = sprites [colorIndex,shapeIndex];

			/* wait some time and return to the while loop */

			if(GameSettings.state==GameState.GameOver)
			{
				/* we no longer want to spawn , game is over */
				StopCoroutine(Spawn ());
			}
			yield return new WaitForSeconds (2);
		}

	}

	 

	 

	 
}
