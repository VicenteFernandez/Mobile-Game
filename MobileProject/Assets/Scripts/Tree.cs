﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tree : MonoBehaviour {
    public GameObject prefab;
    private bool done = false;
    // Use this for initialization
    void Start () {
        
    }
	
	// Update is called once per frame
	void Update () {
        
    }
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (done == false)
        {
            done = true;
            Vector3 spawnPos = gameObject.transform.position;
            GameObject Coconut = (GameObject)Instantiate(prefab, spawnPos, Quaternion.identity);
           
        }
       
    }
}
