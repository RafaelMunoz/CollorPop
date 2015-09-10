using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class NumberManager : MonoBehaviour {

	public List <int> numbers = new List<int>();
	private AutoGenerationManager numsToMatch;
	private bool incrimentScore;
	public int numbersMatched;

	private bool firstSpot = false;
	private bool secSpot = false;
	private bool thirSpot = false;
	private bool fourSpot = false;
	private bool fifSpot = false;
	// Use this for initialization
	void Start () {
		numbersMatched = 0;
		numsToMatch = GetComponent<AutoGenerationManager> ();

		firstSpot = false;
		secSpot = false;
		thirSpot = false;
		fourSpot = false;
		fifSpot = false;
	}
	
	// Update is called once per frame
	void Update () {
		//CheckMatches ();
		Debug.Log (numbersMatched);
	}

	public void CheckMatches(){

		if(numbers.Contains(numsToMatch.firstNumber)){
			numsToMatch.first.color = Color.green;
			if(!firstSpot)
			{
				numbersMatched++;
				firstSpot = true;
			}
		}
		if(numbers.Contains(numsToMatch.secondNumber)){
			numsToMatch.second.color = Color.green;
			if(!secSpot)
			{
				numbersMatched++;
				secSpot = true;
			}
		}
		if(numbers.Contains(numsToMatch.thirdNumber)){
			numsToMatch.third.color = Color.green;
			if(!thirSpot)
			{
				numbersMatched++;
				thirSpot = true;
			}
		}
		if(numbers.Contains(numsToMatch.fourthNumber)){
			numsToMatch.fourth.color = Color.green;
			if(!fourSpot)
			{
				numbersMatched++;
				fourSpot = true;	
			}
		}
		if(numbers.Contains(numsToMatch.fifthNumber)){
			numsToMatch.fifth.color = Color.green;
			if(!fifSpot)
			{
				numbersMatched++;
				fifSpot = true;
			}
		}
	}

}
