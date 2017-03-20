using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour {

    public bool following;

	// Use this for initialization
	void Start () {
        following = false;

    }
	
	// Update is called once per frame
	void Update () {
        if (following == false)
        {
            transform.position = Vector3.Lerp(transform.position, new Vector3(0, 0, -10), 0.5f);
            GetComponent<Camera>().orthographicSize = Mathf.Lerp(GetComponent<Camera>().orthographicSize, 7.2f, 0.05f);
        }
	}
}
