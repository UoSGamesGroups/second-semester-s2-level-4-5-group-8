using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

	public bool player1Turn;
	public bool player2Turn;
	public float countdownTimer;
	public Text timer;

	// Use this for initialization
	void Start () {
		player1Turn = true;
		player2Turn = false;
		countdownTimer = 10;
		StartCoroutine (countdown ());
	}
	
	// Update is called once per frame
	void Update () {
		countdownTimer -= Time.deltaTime;
		timer.text = Mathf.Round (countdownTimer).ToString ();
	}

	IEnumerator countdown(){
		yield return new WaitForSeconds (10f);
		NextTurn ();
	}

	void NextTurn(){
		player1Turn = !player1Turn;
		player2Turn = !player2Turn;
		countdownTimer = 10;
		StartCoroutine (countdown ());
	}
}
