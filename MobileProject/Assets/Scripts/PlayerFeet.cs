﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFeet : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.layer == 8)
        {
            GetComponentInParent<PlayerControler>().Grounded();
        }
        if (col.gameObject.tag == "Ice")
        {
            GetComponentInParent<PlayerControler>().OnIce();

        }
    }
    private void OnTriggerExit2D(Collider2D col)
    {
        if (col.gameObject.layer == 8)
        {
            GetComponentInParent<PlayerControler>().NotGrounded();
        }
        if (col.gameObject.tag == "Ice")
        {
            GetComponentInParent<PlayerControler>().OffIce();
        }
    }

}
