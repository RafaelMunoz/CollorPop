﻿using UnityEngine;
using System.Collections;

public class DartManager : MonoBehaviour {
	private int darts;

	public ChooseGameScript chooseGameScript;
	// Use this for initialization
	void Start () {
		darts = 0;

	}
	public void SetDarts(int amountOfDarts)
	{
		darts = amountOfDarts;
	}
	// Update is called once per frame
	void Update () {
		//Debug.Log (darts);
	}
	public void SubtractDart()
	{
		darts--;
	}
	public int GetDarts(){
		return darts;
	}
}
