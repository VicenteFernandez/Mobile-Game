using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoconutMove : MonoBehaviour {
    public float moveSpeed = 1, triggerDistance = 10;
    private GameObject Player;
    private bool on = false, grounded = false;
    public string moveDirection = "left";
	// Use this for initialization
	void Start () {
        Player = GameObject.FindGameObjectWithTag("Player");
	}
	
	// Update is called once per frame
	void Update () {
        Vector2 playerPos = (Player.transform.position);
        Vector2 distance = new Vector2 (playerPos.x - transform.position.x, playerPos.y - transform.position.y);
        if(distance.magnitude <= triggerDistance)
        {
            on = true;
        }
        Vector2 velocity = GetComponent<Rigidbody2D>().velocity;
        if ( on == true && grounded == true && moveDirection == "left")
        {
            velocity.x = -1 * moveSpeed;
            GetComponent<Rigidbody2D>().velocity = velocity;

        }
        if (on == true && grounded == true && moveDirection == "right")
        {
            velocity.x = 1 * moveSpeed;
            GetComponent<Rigidbody2D>().velocity = velocity;

        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.layer == 8)
        {
            grounded = true;
        }
        else
        {
            grounded = false;
        }
    }
}
