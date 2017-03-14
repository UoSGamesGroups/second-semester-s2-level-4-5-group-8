using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyCounter : MonoBehaviour {

    public int GMinionCount = 6;
    public int BMinionCount = 6;

    Image image;
	//Sprites for good minions left
	public Sprite[] GMinion;

	//Sprites for bad minions left
	public Sprite[] BMinion;
	// Use this for initialization

	public void updateGoodUI()
	{
        GMinionCount--;
        image = GetComponent<Image>();
        image.sprite = GMinion[GMinionCount];
    }

	public void updateBadUI()
	{
        BMinionCount--;
        image = GetComponent<Image> ();
		image.sprite = BMinion[BMinionCount];
	}
}
