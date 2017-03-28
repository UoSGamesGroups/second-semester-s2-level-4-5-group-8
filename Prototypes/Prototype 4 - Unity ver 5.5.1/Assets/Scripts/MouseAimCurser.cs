using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseAimCurser : MonoBehaviour {

	private Vector3 mousePosition;
	public float movespeed = 5.0f;

	// Use this for initialization
	void Start () {

		Cursor.visible = false;
		
	}
	
	// Update is called once per frame
	void Update () {
			mousePosition = Input.mousePosition;
			mousePosition = Camera.main.ScreenToWorldPoint (mousePosition);
			transform.position = Vector2.Lerp(transform.position, mousePosition, movespeed);

		
	}
}

