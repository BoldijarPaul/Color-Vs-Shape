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

	/* converts a x*x array to one 2d array */
	public static  Sprite[,] SpriteArrayToSprite2DArray(Sprite[] array)
	{
		int size = (int)Mathf.Sqrt (array.Length);
		Sprite[,] array2d=new Sprite[size,size];
		int index = 0;
		for (int i=0; i<size; i++) 
		{
			for(int j=0; j<size; j++)
			{
				array2d[i,j]=array[index++];
			}
		}
		return array2d;
	}

}

