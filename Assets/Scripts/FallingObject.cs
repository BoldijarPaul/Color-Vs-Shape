using UnityEngine;
using System.Collections;

public class FallingObject : MonoBehaviour {


	public Camera cam;
	/* the shapes */
	public GameObject[] objects;

	void Start()
	{
		/* initialize camera if null */
		if (cam == null) 
		{
			cam=Camera.main;
		}
		StartCoroutine (Spawn ());
	}

	IEnumerator Spawn()
	{
		while (true) {
			Debug.Log("Created");
			/* set up the position of the new object*/
			float screenWidth = Helper.GetScreenWidth (cam);
			float x = Random.Range (-screenWidth, screenWidth);
			Vector3 position = new Vector3 (x, transform.position.y, 0);

			/* set up the game object and rotation */
			GameObject randomGameObject = objects [Random.Range (0, objects.Length - 1)];
			Quaternion rotation = Quaternion.identity;

			/* spawn the game object*/
			Instantiate (randomGameObject, position, rotation);

			/* wait some time and return to the while loop */
			yield return new WaitForSeconds(2);
		}

	}

	 

	 

	 
}
