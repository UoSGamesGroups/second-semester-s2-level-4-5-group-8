using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Despawner : MonoBehaviour {

	public float timer;


	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		
		timer += 1.0F * Time.deltaTime;
		if (timer >= 4)
		{
			GameObject.Destroy(gameObject);
		}


}
}
