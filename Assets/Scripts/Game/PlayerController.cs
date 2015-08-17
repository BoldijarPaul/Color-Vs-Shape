using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {
	/* this class will move the player on touch */

	private float maxWidth;
	// Use this for initialization
	void Start () {
		Vector3 upperCorner = new Vector3 (Screen.width, Screen.height, 0f);
		Vector3 targetWidth = Camera.main.ScreenToWorldPoint (upperCorner);
		maxWidth = targetWidth.x;
	}
	
	// Update is called once per frame

	private float lastX=0;
	private bool lastXFound=false;
	void FixedUpdate () 
	{
		Vector3 rawPosition = Camera.main.ScreenToWorldPoint (Input.mousePosition);
		Vector3 targetPosition = new Vector3 (Mathf.Clamp(rawPosition.x,-maxWidth,maxWidth), transform.position.y, 0);
		GetComponent<Rigidbody2D> ().MovePosition (targetPosition);
	}
}
