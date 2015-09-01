using UnityEngine;
using System.Collections;

public class MouseScript : MonoBehaviour {
	

	public Camera mainCamera;
	// Use this for initialization
	void Start () {
		//Cursor.visible = false;
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 temp = Input.mousePosition;
		temp.z = 20.0f; // Set this to be the distance you want the object to be placed in front of the camera.
		temp.y += 140.0f;
		temp.x -= 350.0f;
		this.transform.position = Camera.main.ScreenToWorldPoint(temp);
		 }

}
