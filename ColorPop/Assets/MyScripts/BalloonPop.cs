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
		//GameObject splatter1 = GameObject.FindGameObjectWithTag("p1");

		/*splatter1.GetComponent<Renderer>().enabled = true;
		splatter2.GetComponent<Renderer>().enabled = true;
		splatter3.GetComponent<Renderer>().enabled = true;
		splatter4.GetComponent<Renderer>().enabled = true;
		*/

		StartCoroutine (OrderPops (splatter1, splatter2, splatter3, splatter4));

		Destroy(this.gameObject);


		//Debug.Log("BALLOON WOULD POP");
	}
	IEnumerator OrderPops(GameObject s1,GameObject s2, GameObject s3, GameObject s4){
		s1.GetComponent<Renderer>().enabled = true;
		//yield return new WaitForSeconds (1);
		s2.GetComponent<Renderer>().enabled = true;
		//yield return new WaitForSeconds (.2f);
		s3.GetComponent<Renderer>().enabled = true;
		//yield return new WaitForSeconds (.2f);
		s4.GetComponent<Renderer>().enabled = true;
		yield return 0;
	}


}
