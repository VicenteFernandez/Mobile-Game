using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour {
    public float moveSpeed = 1, triggerDistance = 10;
    public GameObject player;
    bool on = false, moveRight = false, moveLeft = false;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 playerPos = player.transform.position;
        Vector2 Distance = new Vector2(playerPos.x - transform.position.x,
                                                playerPos.y - transform.position.y);
        if (Distance.magnitude < triggerDistance)
        {
            on = true;

        }
        Vector2 velocity = GetComponent<Rigidbody2D>().velocity;
        if (on == true && moveRight == false)
        {
            velocity.x = moveSpeed * -1;
            GetComponent<Rigidbody2D>().velocity = velocity;
            moveLeft = true;

        }
        if (on == true && moveRight == true)
        {
            velocity.x = moveSpeed * 1;
            GetComponent<Rigidbody2D>().velocity = velocity;

        }
    }
    public void HitWall()
    {
        Debug.Log("HitWall");
        if (moveRight == false && moveLeft == true)
        {
            moveRight = true;
            moveLeft = false;
            Debug.Log("R");
            return;
        }
        if (moveLeft == false && moveRight == true)
        {
            moveLeft = true;
            moveRight = false;
            Debug.Log("L");
            return;
        }
    }
}
