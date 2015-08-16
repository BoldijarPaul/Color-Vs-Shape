using UnityEngine;

public class Helper
{
	/* returns the screen world width */
	public static float GetScreenWidth(Camera cam)
	{
		Vector3 upperCorner = new Vector3 (Screen.width, Screen.height, 0f);
		Vector3 targetWidth = cam.ScreenToWorldPoint (upperCorner);
		return targetWidth.x;
	}

}

