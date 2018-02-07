using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SunEnemy : MonoBehaviour {
    private bool attack = false;
	// Use this for initialization
	void Start () {
        GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezeAll;
    }
	
	// Update is called once per frame
	void Update () {
       
		if(attack == true)
        {
            GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.None;
        }
	}
    private void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.tag == "Player")
        {
            attack = true;
        }
    }
}