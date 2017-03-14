using UnityEngine;
using System.Collections;

public class BulletController : MonoBehaviour {

	public float bulletSpeed = 10;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		var moveBullet = new Vector3 (2, 0, 0);
		transform.position +=moveBullet * bulletSpeed * Time.deltaTime;
	}
		
	
	
}
