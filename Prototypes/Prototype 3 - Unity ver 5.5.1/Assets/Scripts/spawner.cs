using UnityEngine;
using System.Collections;

public class spawner : MonoBehaviour {

	public GameObject enemyPrefab;
	public int timer = 0;
	public int spawnRate = 30;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void FixedUpdate () {

		timer = timer + 1;
		if (timer > spawnRate) {
			spawnRate = Random.Range (1, 2);

			Instantiate (enemyPrefab, new Vector3 (transform.position.x, transform.position.y, 0), Quaternion.identity);
			timer = 0;
		}
	
	}
}
