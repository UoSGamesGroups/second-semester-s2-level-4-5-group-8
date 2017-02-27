using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class MouseFire : MonoBehaviour {

	public GameManager gameManager;
	public GameObject bullet;
	public float speed = 1.0f;
	public float increase = 1.0f;
	public bool player1;
	public bool player2;
	public Slider powerSlider;

	// Use this for initialization
	void Start () {
		powerSlider.maxValue = increase;
	}



	// Update is called once per frame
	void Update () {

		if (player1) {
			if (gameManager.player1Turn) {
				Shoot ();
				powerSlider.gameObject.SetActive (true);
			} else {
				powerSlider.gameObject.SetActive (false);
			}
		} 

		if(player2){
			if (gameManager.player2Turn) {
				Shoot ();
				powerSlider.gameObject.SetActive (true);
			}else {
				powerSlider.gameObject.SetActive (false);
			}
		}


			
	}

	void Shoot(){
		if (Input.GetMouseButton (0) && speed < 20) {
			speed += increase*Time.deltaTime;
			powerSlider.value = speed;
		}

		if (Input.GetMouseButtonUp (0)) {
			Vector2 target = Camera.main.ScreenToWorldPoint( new Vector2(Input.mousePosition.x,  Input.mousePosition.y) );
			Vector2 myPos = new Vector2(transform.position.x,transform.position.y + 0);
			Vector2 direction = target - myPos;
			direction.Normalize();
			Quaternion rotation = Quaternion.Euler( 0, 0, Mathf.Atan2 ( direction.y, direction.x ) * Mathf.Rad2Deg );
			GameObject projectile = (GameObject) Instantiate( bullet, myPos, rotation);
			projectile.GetComponent<Rigidbody2D>().velocity = direction * speed;
			speed = 0; //Resets the force
			powerSlider.value = speed;
		}
	}



}
