using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class BalloonPop : MonoBehaviour {

	private int i;
	public GameObject number1;

	private NumberManager numMan;

	void Start(){
		i = 0;
		numMan = GameObject.Find ("ScriptHolder").GetComponent<NumberManager> ();
	}
	//public GameObject instantiatedObj;
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


		int randomNumber = Random.Range(1,20);
		GameObject Number = Resources.Load(randomNumber.ToString(), typeof (GameObject)) as GameObject;
		numMan.numbers.Add (randomNumber);
		if (Number != null) {
			Instantiate (Number, new Vector3 (this.transform.position.x, this.transform.position.y, 40), Quaternion.identity);
		}
		SwitchBalloon(false);

	}
	

	private void SwitchBalloon(bool on)
	{
		if(!on)
		{
			GetComponentInChildren<Renderer>().enabled = false;
			GetComponent<Collider>().enabled = false;
		}else
		{
			GetComponentInChildren<Renderer>().enabled = true;
			GetComponent<Collider>().enabled = true;
		}
	}
}
