using UnityEngine;
using System.Collections;

public class MouseScript : MonoBehaviour {
	

	public Camera mainCamera;

	public bool showCursor = false;
	// Use this for initialization
	void Start () {
		Cursor.visible = showCursor;
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 temp = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 0);
		//temp.z = 20.0f; // Set this to be the distance you want the object to be placed in front of the camera.
		//temp.y += 140.0f;
		//temp.x -= 350.0f;
		//this.transform.position = Camera.main.ScreenToWorldPoint(temp);
		//transform.position = Camera.main.ScreenToViewportPoint(temp);
		this.transform.position = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 0);
		 }

}
