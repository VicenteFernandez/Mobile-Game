using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControler : MonoBehaviour {
    public float moveSpeed = 1, jumpSpeed = 1, bounceSpeed = 1;
    public bool grounded = false, canBounce = false;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        //Player movement left and right
        float moveX = Input.GetAxis("Horizontal");
        Vector2 velocity = GetComponent<Rigidbody2D>().velocity;
        velocity.x = moveX * moveSpeed;
        GetComponent<Rigidbody2D>().velocity = velocity;

        //jump
        if(Input.GetButtonDown("Jump") && grounded == true)
        {
            GetComponent<Rigidbody2D>().AddForce(new Vector2(0, 100 * jumpSpeed));
           
        }

    }

    public void Grounded()
    {
        grounded = true;
    }
    public void NotGrounded()
    {
        grounded = false;
    }
}
