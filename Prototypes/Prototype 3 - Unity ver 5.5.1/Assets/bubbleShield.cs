using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bubbleShield : MonoBehaviour {

    public EnemyCounter objectWithMinionCount;
    SpriteRenderer SR;
    Color color;
    public bool good;
    public Sprite[] damageSprites;

	// Use this for initialization
	void Start () {
        SR = this.GetComponent<SpriteRenderer>();
        color = SR.color;
	}
	
	// Update is called once per frame
	void Update () {
        if (good) {
            SR.sprite = damageSprites[objectWithMinionCount.GMinionCount];
            //Debug.Log((objectWithMinionCount.BMinionCount * 40).ToString());
        }
        else
        {
            SR.sprite = damageSprites[objectWithMinionCount.BMinionCount];
            //Debug.Log((objectWithMinionCount.BMinionCount * 40).ToString());
        }
	}
}
