using UnityEngine;
using System.Collections;

public class MouseScript : MonoBehaviour {
	

	public Camera mainCamera;
	public bool ShowCursor = false;
	// Use this for initialization
	void Start () {
		Cursor.visible = ShowCursor;
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 temp = Input.mousePosition;
		temp.z = 20.0f; // Set this to be the distance you want the object to be placed in front of the camera.
		temp.y += 120.0f;
		temp.x -= 250.0f;
		this.transform.localPosition = Camera.main.ScreenToWorldPoint(temp);
		 }

}
