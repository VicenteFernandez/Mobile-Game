using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppleMove : MonoBehaviour {
    public float moveSpeed = 3;
    float timer = 0;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Vector2 velocity = GetComponent<Rigidbody2D>().velocity;
        velocity = new Vector2(-1 * moveSpeed, 0);
        GetComponent<Rigidbody2D>().velocity = velocity;
        timer += Time.deltaTime;
        if (timer >= 4)
        {
            Destroy(gameObject);
        }
    }
}
