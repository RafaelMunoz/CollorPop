using UnityEngine;
using System.Collections;

public class FadeScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(this.gameObject.GetComponent<Renderer>().enabled)
		{
			this.gameObject.GetComponent<Material>().color = Color.Lerp(Color.white,Color.clear, Time.deltaTime);
		}
	}
}
