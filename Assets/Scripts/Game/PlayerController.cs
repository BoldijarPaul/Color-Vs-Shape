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
	bool flag = false;
	Vector3 screenPoint;
	Vector3 offset;

	void Update()
	{
		if (Input.GetMouseButton(0))
		{
			if (!flag)
			{
				flag = true;
				screenPoint = Camera.main.WorldToScreenPoint(gameObject.transform.position);
				offset = gameObject.transform.position - Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z));
			}
			
			Vector3 curScreenPoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z);
			Vector3 curPosition = Camera.main.ScreenToWorldPoint(curScreenPoint) + offset;
			curPosition=new Vector3(curPosition.x,transform.position.y,0);
			transform.position = curPosition;
		}
		else
		{
			flag = false;
		}
	}

}
