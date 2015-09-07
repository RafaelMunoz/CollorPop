using UnityEngine;
using System.Collections;

public class BalloonPop : MonoBehaviour {


	public GameObject number1;

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



		GameObject Number = Resources.Load("num1", typeof (GameObject)) as GameObject;

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
