using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCounter : MonoBehaviour {

    public int GMinionCount = 6;
    public int BMinionCount = 6;

    SpriteRenderer sr;
	//Sprites for good minions left
	public Sprite[] GMinion;

	//Sprites for bad minions left
	public Sprite[] BMinion;
	// Use this for initialization

	public void updateGoodUI()
	{
        GMinionCount--;
        sr = GetComponent<SpriteRenderer>();
        sr.sprite = GMinion[GMinionCount];
    }

	public void updateBadUI()
	{
        BMinionCount--;
        sr = GetComponent<SpriteRenderer> ();
		sr.sprite = BMinion[BMinionCount];
	}
}
