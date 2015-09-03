using UnityEngine;
using System.Collections;

public class MouseScript : MonoBehaviour {
	

	public Camera mainCamera;

	public GameObject dart;

	public bool showCursor = false;
	// Use this for initialization
	void Start () {
		Cursor.visible = showCursor;
	}
	
	// Update is called once per frame
	void Update () {
		//Set the position of the target to the mouss position!
		this.transform.position = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 0);


	 }

}
