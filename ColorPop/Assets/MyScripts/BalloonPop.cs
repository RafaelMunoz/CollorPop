using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class BalloonPop : MonoBehaviour {

	private int i;
	public int colors;

	public GameObject number1;
	public GameObject splatter1;
	public GameObject splatter2;

	public AudioClip popSound;
	private AudioSource source;

	private NumberManager numMan;

	void Start(){

		i = 0;
		source = GetComponent<AudioSource>();
		numMan = GameObject.Find ("ScriptHolder").GetComponent<NumberManager> ();

	}

	//public GameObject instantiatedObj;
	void OnMouseDown()
	{
		source.PlayOneShot(popSound);
		colors = Random.Range(1, 4);
		splatter(colors);

		splatter1.GetComponent<Renderer>().enabled = true;
		splatter2.GetComponent<Renderer>().enabled = true;

		int randomNumber = Random.Range(1,40);
		GameObject Number = Resources.Load(randomNumber.ToString(), typeof (GameObject)) as GameObject;
		numMan.numbers.Add (randomNumber);
		if (Number != null) {
			Instantiate (Number, new Vector3 (this.transform.position.x, this.transform.position.y, 40), Quaternion.identity);
		}
		SwitchBalloon(false);
	}

	private void splatter(int color)
	{
		switch (color)
		{
		case 4:
			splatter1 = GameObject.FindGameObjectWithTag("y" + Random.Range(1, 4));
			splatter2 = GameObject.FindGameObjectWithTag("y" + Random.Range(1, 4));
			break;
		
		case 3:
			splatter1 = GameObject.FindGameObjectWithTag("g" + Random.Range(1, 4));
			splatter2 = GameObject.FindGameObjectWithTag("g" + Random.Range(1, 4));
			break;
		case 2:
			splatter1 = GameObject.FindGameObjectWithTag("r" + Random.Range(1, 4));
			splatter2 = GameObject.FindGameObjectWithTag("r" + Random.Range(1, 4));
			break;
		case 1:
			splatter1 = GameObject.FindGameObjectWithTag("b" + Random.Range(1, 4));
			splatter2 = GameObject.FindGameObjectWithTag("b" + Random.Range(1, 4));
			break;
		}
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
