using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControler : MonoBehaviour {
    public float moveSpeed = 1, jumpSpeed = 1, bounceSpeed = 1;
    public bool grounded = false, canBounce = false;
    Animator anim;
	// Use this for initialization
	void Start () {
        anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
        //Player movement left and right
        float moveX = Input.GetAxis("Horizontal");
        Vector2 velocity = GetComponent<Rigidbody2D>().velocity;
        velocity.x = moveX * moveSpeed;
        GetComponent<Rigidbody2D>().velocity = velocity;
        //change an int in the anim controller to match the float moveX
        if(moveX == 0)
        {
            anim.SetInteger("moveX", 0);
        }
        if(moveX > 0)
        {
            anim.SetInteger("moveX", 1);
        }
        if (moveX < 0)
        {
            anim.SetInteger("moveX", -1);
        }


        //jump
        if (Input.GetButtonDown("Jump") && grounded == true)
        {
            GetComponent<Rigidbody2D>().AddForce(new Vector2(0, 100 * jumpSpeed));
           
        }

    }

    public void Grounded()
    {
        grounded = true;
        anim.SetBool("isJumping", false);
    }
    public void NotGrounded()
    {
        grounded = false;
        anim.SetBool("isJumping", true);
    }
}
