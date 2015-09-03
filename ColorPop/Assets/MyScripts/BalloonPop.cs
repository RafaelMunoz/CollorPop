using UnityEngine;
using System.Collections;

public class BalloonPop : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnMouseDown()
	{
		GameObject splatter1 = GameObject.FindGameObjectWithTag("p" + Random.Range(1, 16));
		GameObject splatter2 = GameObject.FindGameObjectWithTag("p" + Random.Range(1, 16)); 
		GameObject splatter3 = GameObject.FindGameObjectWithTag("p" + Random.Range(1, 16)); 
		GameObject splatter4 = GameObject.FindGameObjectWithTag("p" + Random.Range(1, 16)); 




		splatter1.GetComponent<Renderer>().enabled = true;
		splatter2.GetComponent<Renderer>().enabled = true;
		splatter3.GetComponent<Renderer>().enabled = true;
		splatter4.GetComponent<Renderer>().enabled = true;


		Destroy(this.gameObject);


		//Debug.Log("BALLOON WOULD POP");
	}



}
