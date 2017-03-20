using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deathBox : MonoBehaviour {

    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log ("Triggered");
        if (other.tag == "Good" || other.tag == "Bad") {
            Destroy(other.gameObject);
        }
    }
}
