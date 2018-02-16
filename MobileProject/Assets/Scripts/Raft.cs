using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Raft : MonoBehaviour {
    bool on = false;
    public float speed = 1;
    float timer = 0;
    public float resetTimer = 15;
    Vector3 pos;
    bool reset = false;
	// Use this for initialization
	void Start () {
       pos = new Vector3 (GetComponent<Transform>().position.x, GetComponent<Rigidbody2D>().position.y);
	}
	
	// Update is called once per frame
	void Update () {
		if (on == true)
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(speed, 0);
        }
        if(reset == true)
        {
            timer += Time.deltaTime;
        }
        if (timer >= resetTimer)
        {
            timer = 0;
            GetComponent<Transform>().position = pos;
            reset = false;
        }
	}
    private void OnCollisionEnter2D(Collision2D col)
    {
        if(col.gameObject.tag == "Player")
        {
            on = true;
        }
        if(col.gameObject.layer == 8 && on == true)
        {
            reset = true;
        }
    }
}
