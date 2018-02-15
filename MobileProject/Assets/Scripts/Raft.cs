using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Raft : MonoBehaviour {
    bool on = false;
    public float speed = 1;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (on == true)
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(speed, 0);
        }
	}
    private void OnCollisionEnter2D(Collision2D col)
    {
        if(col.gameObject.tag == "Player")
        {
            on = true;
        }
    }
}
