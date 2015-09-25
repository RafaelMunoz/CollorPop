using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;


public class TicketManager : MonoBehaviour {
	private int tickets;
	public List<Button> tix = new List<Button>();

	public ChooseGameScript gameManager;
	// Use this for initialization
	void Start () {
		tickets = 0;

	}
	void Update()
	{
		CheckTickets();
	}
	private void CheckTickets()
	{
		for(int i = 0; i < this.GetTix(); i++)
		{
			tix[i].interactable = true;
		}
	}
	public void SetTix(int tix)
	{
		tickets = tix;
	}
	public int GetTix()
	{
		return tickets;
	}
}
