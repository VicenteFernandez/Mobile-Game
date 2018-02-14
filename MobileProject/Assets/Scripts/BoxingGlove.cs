﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxingGlove : MonoBehaviour {
    bool on = false;
    float timer = 0;
    public float timeLimit = 1;
    Vector3 pos;
	// Use this for initialization
	void Start () {
        pos = GetComponent<Transform>().position;
	}
	
	// Update is called once per frame
	void Update () {
        if(on == true)
        {
            timer += Time.deltaTime;
            GetComponent<Rigidbody2D>().AddForce(GetComponent<Rigidbody2D>().velocity = new Vector2(-25, 0));
            if(timer >= timeLimit)
            {
                GetComponent<Transform>().position = pos;
            }
        }
	}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            on = true;
        }
    }
}
