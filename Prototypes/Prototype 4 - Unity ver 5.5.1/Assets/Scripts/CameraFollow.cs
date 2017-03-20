using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {

    // The main cameras Transform
    Transform mainCamera;
    
    // Use this for initialization
	void Start () {
        mainCamera = Camera.main.transform;
	}
	
	// Update is called once per frame
	void Update () {
        //sets the cameras y position as the same as the bullet;
        mainCamera.GetComponent<CameraScript>().following = true;
        mainCamera.GetComponent<Camera>().orthographicSize = Mathf.Lerp(mainCamera.GetComponent<Camera>().orthographicSize, 5, 0.05f);
        mainCamera.position = Vector3.Lerp(mainCamera.transform.position, new Vector3(this.transform.position.x, this.transform.position.y,-10), 0.5f);

    }

    private void OnDestroy()
    {
        mainCamera.GetComponent<CameraScript>().following = false;
    }
}
