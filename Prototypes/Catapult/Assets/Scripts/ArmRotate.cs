using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArmRotate : MonoBehaviour {

	public GameManager gameManager;
	public int rotationOffset = 90;
	public bool player1;
	public bool player2;
	
	// Update is called once per frame
	void Update () {
		if (player1) {
			if (gameManager.player1Turn) {
				move ();
			}
		} 

		if(player2){
			if (gameManager.player2Turn) {
				move ();
			}
		}
	}

	void move(){
		Vector3 difference = Camera.main.ScreenToWorldPoint (Input.mousePosition) - transform.position;
		difference.Normalize ();

		float rotZ = Mathf.Atan2 (difference.y, difference.x) * Mathf.Rad2Deg;
		transform.rotation = Quaternion.Euler (0f, 0f, rotZ + rotationOffset);
	}
}
