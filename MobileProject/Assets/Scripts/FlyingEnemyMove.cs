using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyingEnemyMove : MonoBehaviour {
    public float moveSpeed = 1, triggerDistance = 10, turnAround = 10;
    private float timer = 0;
    GameObject player;
    private bool on = false;
    //if changesDirection is true, the enemy will move in the opposite direction after the timer > turnAround
    public bool changesDirection = false;
    //directions are left, right, up, down, upleft, downleft, upright, downright
    public string direction = "left";
    Animator anim;
    // Use this for initialization
    void Start () {
        anim = GetComponent<Animator>();
    }
	
	// Update is called once per frame
	void Update () {
        player = GameObject.FindGameObjectWithTag("Player");
        //finds the player pos and compares it to trigger distance
        Vector3 playerPos = player.transform.position;
        Vector2 Distance = new Vector2(playerPos.x - transform.position.x,
                                                playerPos.y - transform.position.y);
        if (Distance.magnitude < triggerDistance)
        {
            on = true;

        }
        //movement based on the string direction
        Vector2 velocity = GetComponent<Rigidbody2D>().velocity;
        if (on == true && direction == "left")
        {
            velocity.x = moveSpeed * -1;
            GetComponent<Rigidbody2D>().velocity = velocity;
            timer += Time.deltaTime;
            if(timer > turnAround && changesDirection == true)
            {
                direction = "right";
                timer = 0;
            }

        }
        if (on == true && direction == "right")
        {
            velocity.x = moveSpeed * 1;
            GetComponent<Rigidbody2D>().velocity = velocity;
            timer += Time.deltaTime;
            if (timer > turnAround && changesDirection == true)
            {
                direction = "left";
                timer = 0;
            }
        }
        if (on == true && direction == "up")
        {
            velocity.y = moveSpeed * 1;
            GetComponent<Rigidbody2D>().velocity = velocity;
            timer += Time.deltaTime;
            if (timer > turnAround && changesDirection == true)
            {
                direction = "down";
                timer = 0;
            }
        }
        if (on == true && direction == "down")
        {
            velocity.y = moveSpeed * -1;
            GetComponent<Rigidbody2D>().velocity = velocity;
            timer += Time.deltaTime;
            if (timer > turnAround && changesDirection == true)
            {
                direction = "up";
                timer = 0;
            }
        }
        //diagonal directions
        if (on == true && direction == "upleft")
        {
            velocity = new Vector2(moveSpeed * -1, moveSpeed * 1);
            GetComponent<Rigidbody2D>().velocity = velocity;
            timer += Time.deltaTime;
            if (timer > turnAround && changesDirection == true)
            {
                direction = "downright";
                timer = 0;
            }

        }
        if (on == true && direction == "downleft")
        {
            velocity = new Vector2(moveSpeed * -1, moveSpeed * -1);
            GetComponent<Rigidbody2D>().velocity = velocity;
            timer += Time.deltaTime;
            if (timer > turnAround && changesDirection == true)
            {
                direction = "upright";
                timer = 0;
            }

        }
        if (on == true && direction == "upright")
        {
            velocity = new Vector2(moveSpeed * 1, moveSpeed * 1);
            GetComponent<Rigidbody2D>().velocity = velocity;
            timer += Time.deltaTime;
            if (timer > turnAround && changesDirection == true)
            {
                direction = "downleft";
                timer = 0;
            }

        }
        if (on == true && direction == "downright")
        {
            velocity = new Vector2(moveSpeed * 1, moveSpeed * -1);
            GetComponent<Rigidbody2D>().velocity = velocity;
            timer += Time.deltaTime;
            if (timer > turnAround && changesDirection == true)
            {
                direction = "upleft";
                timer = 0;
            }

        }
        //animation controls
        anim.SetFloat("moveX", GetComponent<Rigidbody2D>().velocity.x);
        anim.SetFloat("moveY", GetComponent<Rigidbody2D>().velocity.y);
    }
}
