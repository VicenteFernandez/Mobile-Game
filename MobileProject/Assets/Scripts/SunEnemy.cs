using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SunEnemy : MonoBehaviour {
    private bool attack = false;
    public GameObject player;
    public float PosX = 0, PosY = 0;
	// Use this for initialization
	void Start () {
        GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezeAll;
    }
	
	// Update is called once per frame
	void Update () {
       
		if(attack == true)
        {
            GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.None;
            GetComponent<Rigidbody2D>().AddForce(new Vector2(GetComponent<Rigidbody2D>().velocity.x + -10, GetComponent<Rigidbody2D>().velocity.y));
        }
        if(attack == false)
        {
            transform.position = new Vector3(player.transform.position.x + PosX, player.transform.position.y + PosY, transform.position.z);
        }
	}
    public void Attack()
    {
        attack = true;
    }
}