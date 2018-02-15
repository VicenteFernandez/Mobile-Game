using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CaveBat : MonoBehaviour {
    public string LeftorRight = "left";
    public float triggerDistance = 10, moveSpeedX = 1, moveSpeedY = 1;
    bool down = true, on = false;
    GameObject player;
    Animator anim;
	// Use this for initialization
	void Start () {
		player = GameObject.FindGameObjectWithTag("Player");
        anim = GetComponent<Animator>();
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
        if (on == true && down == true && LeftorRight == "left")
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(moveSpeedX * -1, moveSpeedY * -1);
            anim.SetBool("right", false);
        }
        if (on == true && down == false && LeftorRight == "left")
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(moveSpeedX * -1, moveSpeedY * 1);
            anim.SetBool("right", false);
        }
        if (on == true && down == true && LeftorRight == "right")
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(moveSpeedX * 1, moveSpeedY * -1);
            anim.SetBool("right", true);
        }
        if (on == true && down == false && LeftorRight == "right")
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(moveSpeedX * 1, moveSpeedY * 1);
            anim.SetBool("right", true);
        }
    }
    private void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.layer == 8)
        {
            if(down == true)
            {
                down = false;
            }
            else
            {
                down = true;
            }
        }
    }
}
