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
	private const float fireGunCooldown = 10.0f; //A constant that can be changed to chang the cooldown
	private float fireGunTimer; //timer to figure out when you can fire

	void Awake ()
	{
		//Sets the timer to 0 on awake so the player can fire right away
		fireGunTimer = 0;
	}

	// Use this for initialization
	void Start () {
	}



	// Update is called once per frame
	void Update () {
		//Decrease the timer by the time that has elapsed per frame
		fireGunTimer -= Time.deltaTime;
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
		if (Input.GetMouseButton (0) && speed < 30) {
			speed += increase*Time.deltaTime;
			powerSlider.value = speed;
		}

		// if timer is below '0', player is allowed to fire
		if (Input.GetMouseButtonUp (0) && fireGunTimer <= 0) {
			Vector2 target = Camera.main.ScreenToWorldPoint( new Vector2(Input.mousePosition.x,  Input.mousePosition.y) );
			Vector2 myPos = new Vector2(transform.position.x,transform.position.y + 0);
			Vector2 direction = target - myPos;
			direction.Normalize();
			Quaternion rotation = Quaternion.Euler( 0, 0, Mathf.Atan2 ( direction.y, direction.x ) * Mathf.Rad2Deg );
			GameObject projectile = (GameObject) Instantiate( bullet, myPos, rotation);
			projectile.GetComponent<Rigidbody2D>().velocity = direction * speed;
			speed = 0; //Resets the force
			fireGunTimer = fireGunCooldown; // reset timer to fireGunCooldown after firing (10 seconds)
			powerSlider.value = speed;
		}
	}



}
