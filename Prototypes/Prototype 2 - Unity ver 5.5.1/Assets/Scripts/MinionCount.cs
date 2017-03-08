using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MinionCount : MonoBehaviour {

	
    

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnDestroy()
	{
		if (gameObject.tag == "Good")
		{
			updateGMinion();
		}
        else
        {
            updateBMinion();
        }
	}

	void updateGMinion ()
		{
			GameObject g = GameObject.Find("5 Aliave G");
		EnemyCounter gScript = g.GetComponent<EnemyCounter>();
		gScript.updateGoodUI();
	}

    void updateBMinion()
    {
        GameObject b = GameObject.Find("5 Aliave B");
        EnemyCounter bScript = b.GetComponent<EnemyCounter>();
        bScript.updateBadUI();
    }
}
