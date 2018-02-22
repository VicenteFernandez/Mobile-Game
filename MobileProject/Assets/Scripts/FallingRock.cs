using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingRock : MonoBehaviour {
    bool fall = false;
	// Use this for initialization
	void Start () {
        GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezeAll;
    }
	
	// Update is called once per frame
	void Update () {
		if (fall == true)
        {
            GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.None;
        }
	}
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.layer == 8)
        {
            Destroy(gameObject);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            fall = true;
        }
    }
}
