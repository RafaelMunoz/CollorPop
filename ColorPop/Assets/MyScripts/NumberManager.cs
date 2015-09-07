using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class NumberManager : MonoBehaviour {

	public List <int> numbers = new List<int>();
	private AutoGenerationManager numsToMatch;
	private bool incrimentScore;
	public int numbersMatched;

	// Use this for initialization
	void Start () {
		numbersMatched = 0;
		numsToMatch = GetComponent<AutoGenerationManager> ();
	}
	
	// Update is called once per frame
	void Update () {
		CheckMatches ();
		Debug.Log (numbersMatched);
	}

	void CheckMatches(){
		if(numbers.Contains(numsToMatch.firstNumber)){
			numsToMatch.first.color = Color.green;
		}
		if(numbers.Contains(numsToMatch.secondNumber)){
			numsToMatch.second.color = Color.green;
		}
		if(numbers.Contains(numsToMatch.thirdNumber)){
			numsToMatch.third.color = Color.green;
		}
		if(numbers.Contains(numsToMatch.fourthNumber)){
			numsToMatch.fourth.color = Color.green;
		}
		if(numbers.Contains(numsToMatch.fifthNumber)){
			numsToMatch.fifth.color = Color.green;
		}
	}

}
