using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControler : MonoBehaviour {
    public float moveSpeed = 1, jumpSpeed = 1, bounceSpeed = 1, moveX;
    public bool grounded = false, canBounce = false, JumpButton = false;
    private bool onIce = false, canMove = true;

    Animator anim;
	// Use this for initialization
	void Start () {
        anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
        //Player movement left and right
        //moveX = Input.GetAxis("Horizontal");
        Vector2 velocity = GetComponent<Rigidbody2D>().velocity;
        if (onIce == false && canMove == true)
        {
            velocity.x = moveX * moveSpeed;
            GetComponent<Rigidbody2D>().velocity = velocity;
        }
        if(onIce == true && canMove == true)
        {
            GetComponent<Rigidbody2D>().AddForce(new Vector2(moveX * moveSpeed, velocity.y));
        }
        
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
        if (Input.GetButtonDown("Jump") && grounded == true || JumpButton == true && grounded == true)
        {
            float Xvel = GetComponent<Rigidbody2D>().velocity.x;
            GetComponent<Rigidbody2D>().AddForce(new Vector2(Xvel, 100 * jumpSpeed));
            JumpButton = false;
        }

    }

    public void Grounded()
    {
        grounded = true;
        anim.SetBool("isJumping", false);
        canMove = true;
    }
    public void NotGrounded()
    {
        grounded = false;
        anim.SetBool("isJumping", true);
    }
    public void OnIce()
    {
        onIce = true;
    }
    public void OffIce()
    {
        onIce = false;
    }
    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "PlayerLauncher")
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(-100, 25);
            canMove = false;
        }
    }
}
