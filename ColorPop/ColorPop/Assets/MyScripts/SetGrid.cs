using UnityEngine;
using System.Collections;

public class SetGrid : MonoBehaviour {

	public GameObject balloons;

	public GameObject NumberPlaceHolder;

	public Transform refrenceBallon;
	public int Width = 10;
	public int Height = 10;
	public int Xspacing = 4;
	public int Yspacing = 4;
	//public int blockWidth; 
	//http://docs.unity3d.com/Manual/InstantiatingPrefabs.html
	private GameObject [,] grid = new GameObject[10,10];

	
	
	
	void Awake () 
	{
		for (int x = 0; x < Width; x++)
		{
			for (int y = 0; y < Height; y++)
			{
				GameObject gridPiece = (GameObject)Instantiate(balloons);
				//gridPiece.transform.position = new Vector3(gridPiece.transform.position.x +x*spacing,
				   //                                        gridPiece.transform.position.y +y*spacing, 40);
				gridPiece.transform.position = new Vector3(refrenceBallon.transform.position.x +x*Xspacing,
				                                           refrenceBallon.transform.position.y +y*Yspacing, 40);
				grid[x,y] = gridPiece;
			}
		}


	}



}
