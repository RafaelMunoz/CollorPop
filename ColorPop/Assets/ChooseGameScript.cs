using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class ChooseGameScript : MonoBehaviour {

	private int amntOfDarts;

	public Button addDartsBttn;
	public Button subtractDartsBttn;
	public Text amntDartsTxt;
	// Use this for initialization
	void Start () {
		amntOfDarts = 1;
	}
	
	// Update is called once per frame
	void Update () {
		amntDartsTxt.text = amntOfDarts.ToString();
		if(amntOfDarts <= 1){
			subtractDartsBttn.interactable = false;
		}else{
			subtractDartsBttn.interactable = true;
		}
		if(amntOfDarts >= 10){
			addDartsBttn.interactable = false;
		}else{
			addDartsBttn.interactable = true;
		}
	}

	public void AddDarts()
	{
		amntOfDarts++;
	}
	public void SubtractDarts()
	{
		amntOfDarts--;
	}
}
